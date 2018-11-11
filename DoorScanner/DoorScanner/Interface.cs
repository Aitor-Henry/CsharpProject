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
		private string Os;
		private string Mask;
		private string IpAddress;
		
		
		//-----GETTER AND SETTER-----
		public string hostName
		{
			get{return HostName;}
			set{HostName=value;}
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
		public string os
		{
			get{return Os;}
			set{Os=value;}
		}
		public List<Port> infosports
		{
			get{return InfosPorts;}
			set{InfosPorts=value;}
		}
		
		
		//-----Constructeurs-----
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
		
		
		//-----function-----
		public string showInterface()
		{
			return "Host: "+hostName+" IP: "+ipAddress+" OS: "+os;
		}
		
	}
}
