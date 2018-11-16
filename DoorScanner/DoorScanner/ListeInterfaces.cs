/*
 * Created by SharpDevelop.
 * User: Amaury
 * Date: 04/11/2018
 * Time: 22:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Windows.Forms;
namespace DoorScanner
{
	[Serializable]
	public class ListeInterfaces //les interfaces tiers sur le réseau
	{
		private List<Interface> InterListe;
		
		//-----GETTER AND SETTER-----
		public List<Interface> interListe
		{
			get{return InterListe;}
		}
		
		
		//-----Constructeur-----
		public ListeInterfaces()
		{
		}
		
		
		//-----Functions-----
		public string showIpList()
		{
			string resultat="";
			foreach(Interface i in InterListe)
			{
				resultat=resultat+" \n"+i.showInterfaceT();
				
			}
			return resultat;
		}
		
		public void XmltoList()
		{	//y a une couille la dedans mais je sais pas encore ou...
			//les valeur de n.ip et n.os ne change pas, host OK et nb d'ip up OK 
			InterListe = new List<Interface>();
		 	
			XmlDocument xnl = new XmlDocument();
			xnl.Load("ipDispo.xml");
			XmlNodeList host = xnl.SelectNodes("/nmaprun/host");
			
			foreach (XmlNode n in host)
			{
				Interface ipUp = new Interface();

				//marche presque.
				/*XmlNode ports = n.SelectSingleNode("ports");
				List<int> port = new List<int>();
				List<string> prot = new List<string>();
				List<string> state = new List<string>();
				List<string> service = new List<string>();

				foreach (XmlNode p2 in ports.SelectNodes("//port[@portid]")) {
					port.Add(Int32.Parse(p2.Attributes["portid"].Value));
					prot.Add(p2.Attributes["protocol"].Value);
				}
				foreach (XmlNode s in ports.SelectNodes("//state[@state]")) {
					state.Add(s.Attributes["state"].Value);
				}
				foreach (XmlNode serv in ports.SelectNodes("//service[@name]")) {
					service.Add(serv.Attributes["name"].Value);
				}
				MessageBox.Show(port.Count.ToString());
				for (int i = 0; i < port.Count; i++) {
					Port P = new Port();
					P.numport=port[i];
					P.protocole=prot[i];
					P.service=service[i];
					P.state=state[i];
					ipUp.infosports.Add(P);
				}*/
				
				ipUp.ipAddress = n.SelectSingleNode("//address[@addrtype='ipv4']/@addr").InnerText;
				ipUp.macAddress = n.SelectSingleNode("//address[@addrtype='mac']/@addr").InnerText;
				ipUp.hostName = n.SelectSingleNode("//hostname/@name").InnerText;
				ipUp.osCarte = n.SelectSingleNode("//address[@addrtype='mac']/@vendor").InnerText;
				InterListe.Add(ipUp);

			}
		}
	}
}
