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

namespace DoorScanner
{
	[Serializable]
	public class ListeInterfaces
	{
		private List<Interface> InterListe;
		public List<Interface> interListe
		{
			get{return InterListe;}
		}
		public ListeInterfaces()
		{
		}
		
		
		public void XmltoList(){
			InterListe = new List<Interface>();
			XmlDocument xnl = new XmlDocument();
				xnl.Load("ipDispo.xml");
				XmlNodeList host = xnl.SelectNodes("/nmaprun/host");
				foreach (XmlNode n in host)
				{
					Interface ipUp = new Interface();
					ipUp.hostName = n.SelectSingleNode("hostname").InnerText;
					ipUp.ipAddress = n.SelectSingleNode("//address[@addrtype='ipv4']/@addr").InnerText;
					ipUp.os = n.SelectSingleNode("//osmatch[@accuracy = max(/osmatch/accuracy)]@name").InnerText;
					InterListe.Add(ipUp);
				}
		}
	}
}
