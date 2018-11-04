/*
 * Created by SharpDevelop.
 * User: Amaury
 * Date: 04/11/2018
 * Time: 21:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

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
		private string Os;
		public string os
		{
			get{return Os;}
			set{Os=value;}
		}
		
		public Interface()
		{
		}
		
		public Interface(string cHostName, string cIp, string cOs)
		{
			hostName=cHostName;
			ipAddress=cIp;
			os=cOs;
		}
		
	}
}
