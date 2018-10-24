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
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace DoorScanner
{
	/// <summary>
	/// Class to scan network, write it in a xml file, and read it to stock it in a 2 dimension List.
	/// </summary>
	public class networkScan
	{
		
		IPAddress currentIP;
		IPAddress currentMask;
		IPAddress networkAdd;
		IPAddress broadcastAdd;
		
		List<IPAddress> listIpNetwork;

		
		public networkScan()
		{
			//récupere l'adresse IP de la machine et le masque du réseau.
			IPAddress[] ipv4Addresses = Array.FindAll(Dns.GetHostEntry(string.Empty).AddressList,a => a.AddressFamily == AddressFamily.InterNetwork);
			
			foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
	        {
	        	foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
	            {
	            	if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
	                {
	                   	if (ipv4Addresses[0].Equals(unicastIPAddressInformation.Address))
	                    {
	                   		currentMask = unicastIPAddressInformation.IPv4Mask;
	                   		currentIP = ipv4Addresses[ipv4Addresses.Length-1];
	                   	}
	               	}
	            }
	        }
			
			networkAdd = getNetworkAddress(currentIP, currentMask);
			broadcastAdd = getBroadcastAddress(networkAdd, currentMask);
			listIpNetwork = getListIpAvailable();
		}
		


		public string showIP(){
			return currentIP.ToString();
		}
		
		public string showMask(){
			return currentMask.ToString();
		}
		
		public string shownetworkID(){
			return networkAdd.ToString();
		}
		
		public string showBroadcast(){
			return broadcastAdd.ToString();
		}
		
		/*
		public string lengthNet(){
			return listIpNetwork.Count.ToString();
		}
		
		public string showListIP(){
			List<string> listIPstring= new List<string>();
			string concatIPs;
			for(int i=0; i<listIpNetwork.Count; i++){
				listIPstring.Add(listIpNetwork[i].ToString());
			}
			concatIPs = string.Join(",", listIPstring.ToArray());
			return concatIPs;
		}
		*/
		
		public IPAddress getNetworkAddress(IPAddress IP, IPAddress mask){
			//calcul pour IDR
			byte[] IPadd = IP.GetAddressBytes();
			byte[] MaskBytes = mask.GetAddressBytes();
			byte[] Broadcast = new byte[MaskBytes.Length];

			for(int i=0; i<IPadd.Length; i++){
				Broadcast[i] = (byte) (IPadd[i] & MaskBytes[i]);
			}
			return new IPAddress(Broadcast);
		}
		
		
		public IPAddress getBroadcastAddress(IPAddress IDR, IPAddress mask){
			//calcul pour broadcast
			byte[] IPadd = IDR.GetAddressBytes();
			byte[] maskBytes = mask.GetAddressBytes();
			byte[] broadcastbytes = new byte[maskBytes.Length];
			for (int i = 0; i < broadcastbytes.Length; i++){
				broadcastbytes[i] = (byte)(IPadd[i] | (maskBytes[i] ^ 255));
			}
			return new IPAddress(broadcastbytes);
		}
		
		/* NOT WORKING 
		public List<IPAddress> getListIpAvailable(){
			//liste des addresses dans le réseau
			List<IPAddress> listAddress = new List<IPAddress>();
			foreach(NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces()){
				
			    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses){
					
			        if(!ip.IsDnsEligible){
						
			            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork){
							
			                // All IP Address in the LAN
			                if(!(currentIP.Equals(ip.Address) || networkAdd.Equals(ip.Address) || broadcastAdd.Equals(ip.Address))){
			                	listAddress.Add(ip.Address);
			                }
			                
			            }
			        }
			    }
			}
			return listAddress;
		}
		*/

	}
}