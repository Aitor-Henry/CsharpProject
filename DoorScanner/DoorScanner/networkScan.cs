/*
 * Created by SharpDevelop.
 * User: Aitor
 * Date: 22/10/2018
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;


namespace DoorScanner
{
	/// <summary>
	/// Class to collect info, scan network and write it in a xml file
	/// </summary>
	public class networkScan
	{
		
		//-----Variables-----
		IPAddress networkAdd;
		IPAddress broadcastAdd;
		IPAddress currentIP;
		IPAddress currentMask;
		Interface currentInterface;
		public List<Interface> cartesListe;
		
		//-----Constructeur-----
		public networkScan()
		{
			//récupere l'adresse IP de la machine et le masque du réseau.
			if (NetworkInterface.GetIsNetworkAvailable())
            {
                //appell de toutes les cartes reseau local
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                //Instensiation de la liste des cartes 
                cartesListe = new List<Interface>();
                //affichage de toutes les informations des cartes reseau
                foreach (NetworkInterface ni in interfaces)
                {
                    if (ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    {

                        IPInterfaceProperties adapterProperties = ni.GetIPProperties();
                        IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                        GatewayIPAddressInformationCollection gateway = adapterProperties.GatewayAddresses;
                        IPAddressCollection dhcpserver = adapterProperties.DhcpServerAddresses;
                        UnicastIPAddressInformationCollection unicastadress = adapterProperties.UnicastAddresses;
                        string InfoInterface;

                        // renvoie les informations de la carte reseau physique
                        InfoInterface = " Nom de l'interface: 			"+ni.Name+Environment.NewLine;
                        InfoInterface += " Description de l'interface: 		"+ni.Description+Environment.NewLine;
                        InfoInterface += " ID de l'interface: 			"+ni.Id+Environment.NewLine;
                        InfoInterface += " Type de l'interface: 			"+ni.NetworkInterfaceType+Environment.NewLine;
                        InfoInterface += " Vitesse de l'interface: 		"+(((ni.Speed) / 1024) / 1024).ToString()+".Mbits/s"+Environment.NewLine;
                        InfoInterface += " Status de l'interface: 		"+ni.OperationalStatus.ToString()+Environment.NewLine;

                            foreach (UnicastIPAddressInformation uni in unicastadress)
                            {
                                // seulement IPV4
                                if (uni.Address.AddressFamily == AddressFamily.InterNetwork)
                                {

                                	InfoInterface += "  Address IP ....................... : "+uni.Address+Environment.NewLine;
                                    currentIP = uni.Address;

                                    InfoInterface += "  MASK ............................. : "+uni.IPv4Mask+Environment.NewLine;
                                    currentMask = uni.IPv4Mask;

	                                foreach (GatewayIPAddressInformation gate in gateway)
	                                {
	                                    InfoInterface += "  gateway .......................... : "+ gate.Address+Environment.NewLine;
	                                }
	
	
	                                foreach (IPAddress dns in dnsServers)
	                                {
	                                    InfoInterface +="  DNS Servers ...................... : "+dns.ToString()+Environment.NewLine;
	                                }
	
	                                InfoInterface += "  Bail dhcp ........................ : "+(((uni.DhcpLeaseLifetime) / 3600) / 24)+" Jours "+Environment.NewLine;
	
	                                foreach (IPAddress dhcp in dhcpserver)
	                                {
	                                    InfoInterface += "Serveur dhcp ....................... : "+dhcp.ToString()+Environment.NewLine;
	                                }
                                }
                            }
                        //On sauvegarde les infos des interfaces dans un fichier txt
                    	File.WriteAllText("InterfaceInfos.txt", InfoInterface);
                    	networkAdd = getNetworkAddress(currentIP, currentMask);
                    	broadcastAdd = getBroadcastAddress(networkAdd, currentMask);
                    	currentInterface = new Interface(currentIP.ToString(), currentMask.ToString(), networkAdd.ToString(), broadcastAdd.ToString());
                    	cartesListe.Add(currentInterface);
                    }
                    
                }
            }
		}
		
	
		//-----Fonctions-----
		public static IPAddress getNetworkAddress(IPAddress IP, IPAddress mask){
			//calcul pour IDR
			byte[] IPadd = IP.GetAddressBytes();
			byte[] MaskBytes = mask.GetAddressBytes();
			byte[] Broadcast = new byte[MaskBytes.Length];

			for(int i=0; i<IPadd.Length; i++){
				Broadcast[i] = (byte) (IPadd[i] & MaskBytes[i]);
			}
			return new IPAddress(Broadcast);
		}
		
		public static IPAddress getBroadcastAddress(IPAddress IDR, IPAddress mask){
			//calcul pour broadcast
			byte[] IPadd = IDR.GetAddressBytes();
			byte[] maskBytes = mask.GetAddressBytes();
			byte[] broadcastbytes = new byte[maskBytes.Length];
			for (int i = 0; i < broadcastbytes.Length; i++){
				broadcastbytes[i] = (byte)(IPadd[i] | (maskBytes[i] ^ 255));
			}
			return new IPAddress(broadcastbytes);
		}
		
		public void getIpAvailable(string IDR, string mask)
		{	//liste des ip dispo sur le reseau avec commande nmap
			string commande = ("nmap -sn -T5 "+IDR+convertMask(mask)+" -oX ipDispo.xml");
				/* -sn pour recueillir nom d'hote, ip, mac, modele de la carte mac
				  + le fichier xml est enregistrer dans le dossier courant /bin/debug */
			Process cmd = new Process();
				cmd.StartInfo.FileName = "cmd.exe";
				cmd.StartInfo.Arguments = "/c"+commande;
				cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				cmd.Start();
				cmd.WaitForExit();
		}
		
		public string convertMask(string mask)
		{//fait correspondre une notation CIDR à un masque, notation necessaire pour nmap
			string result = "";
			Dictionary<string, string> convertToCIDR = new Dictionary<string, string>() {
				// Les masques classiques
				{ "255.255.255.0","/24" },
				{ "255.255.0.0","/16" },
				{ "255.0.0.0","/8" },
				//les moins classiques, on prends en compte toutes les possibilitées
				{ "255.255.255.255","/32" },
				{ "255.255.255.254","/31" },
				{ "255.255.255.252","/30" },
				{ "255.255.255.248","/29" },
				{ "255.255.255.240","/28" },
				{ "255.255.255.224","/27" },
				{ "255.255.255.192","/26" },
				{ "255.255.255.128","/25" },
				
				{ "255.255.254.0","/23" },
				{ "255.255.252.0","/22" },
				{ "255.255.248.0","/21" },
				{ "255.255.240.0","/20" },
				{ "255.255.224.0","/19" },
				{ "255.255.192.0","/18" },
				{ "255.255.128.0","/17" },
				
				{ "255.254.0.0","/15" },
				{ "255.252.0.0","/14" },
				{ "255.248.0.0","/13" },
				{ "255.240.0.0","/12" },
				{ "255.224.0.0","/11" },
				{ "255.192.0.0","/10" },
				{ "255.128.0.0","/9" },
				
				{ "254.0.0.0","/7" },
				{ "252.0.0.0","/6" },
				{ "248.0.0.0","/5" },
				{ "240.0.0.0","/4" },
				{ "224.0.0.0","/3" },
				{ "192.0.0.0","/2" },
				{ "128.0.0.0","/1" }
			};
			if (convertToCIDR.TryGetValue(mask, out result)) {
				return result;
			}
			//Ne devrait pas arriver
			return "error";
		}

	}
}