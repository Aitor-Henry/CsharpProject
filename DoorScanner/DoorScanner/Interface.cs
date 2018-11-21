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
		private string OsCarte;
		private string MacAddress;
		private string Mask;
		private string IpAddress;
		private string NetAdd;
		private string BroadAdd;
		private string Status;
		
		
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
		public string status
		{
			get{return Status;}
			set{Status=value;}
		}
		
		
		//-----Constructeurs-----
		public Interface()
		{
		}

		public Interface(string cIp, string cMask, string cNet, string cBroad)
		{
			ipAddress=cIp;
			mask=cMask;
			netAdd=cNet;
			broadAdd=cBroad;
		}
		public Interface(string chostname, string cIP, string cstatus, string cOsCarte, string cMac)
		{
			ipAddress=cIP;
			hostName=chostname;
			status=cstatus;
			osCarte=cOsCarte;
			macAddress=cMac;
		}
		
		
		//-----function----- Inutile, à supprimer par la suite
		public string showInterfaceT()
		{
			return hostName+"; "+ipAddress+"; "+macAddress+"; "+osCarte+"; "+ status;
		}
		public string showCarte()
		{
			return "IP: "+ipAddress+"  Reseau: "+netAdd;
		}
		
	}
}
