/*
 * Created by SharpDevelop.
 * User: Amaury
 * Date: 04/11/2018
 * Time: 21:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Collections.Generic;

namespace DoorScanner
{
	[Serializable]
	public class Interface
	{
		private string HostName;
		private List<Port> InfosPorts;
		private string OsCarte;
		private string MacAddress;
		private string Mask;
		private string IpAddress;
		private string NetAdd;
		private string BroadAdd;
		
		
		//-----GETTER AND SETTER-----
		public string hostName
		{
			get{return HostName;}
			set{HostName=value;}
		}
		public string osCarte
		{
			get{return OsCarte;}
			set{OsCarte=value;}
		}
		public string macAddress
		{
			get{return MacAddress;}
			set{MacAddress=value;}
		}
		public string ipAddress
		{
			get{return IpAddress;}
			set{IpAddress=value;}
		}
		public string mask
		{
			get{return Mask;}
			set{Mask=value;}
		}
		public string netAdd
		{
			get{return NetAdd;}
			set{NetAdd=value;}
		}
		public string broadAdd
		{
			get{return BroadAdd;}
			set{BroadAdd=value;}
		}
		public List<Port> infosports
		{
			get{return InfosPorts;}
			set{InfosPorts=value;}
		}
		
		
		//-----Constructeurs-----
		public Interface()
		{
			infosports= new List<Port>();
		}

		public Interface(string cIp, string cMask, string cNet, string cBroad)
		{
			ipAddress=cIp;
			mask=cMask;
			netAdd=cNet;
			broadAdd=cBroad;
		}
		public Interface(string chostname, string cIP, string cMask, string cOsCarte, string cMac){
			ipAddress=cIP;
			mask=cMask;
			hostName=chostname;
			osCarte=cOsCarte;
			macAddress=cMac;
			
		}
		
		
		//-----function-----
		public string showInterfaceT()
		{
			// le temps de voir si l'implémentation de l'ip marche
			/*string retour = "Host: "+hostName+" IP: "+ipAddress+" OS: "+osCarte+"\r\n";
			foreach (Port e in infosports) {
				retour = retour+e.showip()+"\r\n";
			}
			return retour;*/
			return hostName+" "+ipAddress+" "+macAddress+" "+osCarte;
		}
		public string showCarte()
		{
			return "IP: "+ipAddress+"  Reseau: "+netAdd;
		}
		
	}
}
