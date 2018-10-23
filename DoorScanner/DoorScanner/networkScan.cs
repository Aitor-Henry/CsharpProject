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
			IPAddress[] ipv4Addresses = Array.FindAll(
	    	Dns.GetHostEntry(string.Empty).AddressList,
	    	a => a.AddressFamily == AddressFamily.InterNetwork);
			
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
			
		}
		


		public string showIP(){
			return currentIP.ToString();
		}
		
		public string showMask(){
			return currentMask.ToString();
		}
		
		/*
		public IPAddress getNetworkAddress(IPAddress IP, IPAddress mask){
			//calcul pour IDR
		}
		
		public IPAddress getBroadcastAddress(IPAddress IP, IPAddress mask){
			//calcul pour broadcast
		}
		
		public List<IPAddress> getListIpAvailable(IPAddress IDR, IPAddress Broadcast){
			
			//Boucle effectuant des Pings avec un bool pour la validation, si il y a un retour on incrémente l'adresse dans la liste
			
		}
		*/
	}
}