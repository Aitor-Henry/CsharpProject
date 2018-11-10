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

namespace DoorScanner
{
	[Serializable]
	public class Interface
	{
		private string HostName;
		public string hostName
		{
			get{return HostName;}
			set{HostName=value;}
		}
		
		private string IpAddress;
		public string ipAddress
		{
			get{return IpAddress;}
			set{IpAddress=value;}
		}
		
		private string Mask;
		public string mask
		{
			get{return Mask;}
			set{Mask=value;}
		}
		
		private string Os;
		public string os
		{
			get{return Os;}
			set{Os=value;}
		}
		
		public Interface()
		{
		}
		
		public Interface(string cIp, string cMask)
		{
			ipAddress=cIp;
			Mask=cMask;
		}
		public Interface(string chostname, string cIP, string cMask, string cOs){
			ipAddress=cIP;
			Mask=cMask;
			HostName=chostname;
			Os=cOs;
		}
		
		public string showIP(){
			return ipAddress.ToString();
		}
		
		public string showMask(){
			return Mask.ToString();
		}
		
		public string showInterface()
		{
			return "Host: "+hostName+" IP: "+ipAddress+" OS: "+os;
		}
		
	}
}
