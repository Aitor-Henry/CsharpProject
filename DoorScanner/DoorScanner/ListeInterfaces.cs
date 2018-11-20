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
using System.Xml.XPath;
using System.Xml.Linq;
using System.Linq;
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
		public void ajout(Interface i)
		{
			InterListe.Add(i);
		}
		
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
		{				
			IList<Interface> lHost = null;//liste intermediare
			
			XDocument doc = XDocument.Load("ipDispo.xml");
			
			//chaque resultat de cette requete linq en loop est stocké dans lHost
			lHost = (from host in doc.Root.Elements("host")//element sur lequel on va iterer
			         select new Interface 
			         {
			         	ipAddress = host.Elements("address")
			         		.Where(h=>h.Attribute("addrtype").Value == "ipv4")
			         		.Select(h=>h.Attribute("addr").Value)
			         		.FirstOrDefault(),
			         	macAddress = host.Elements("address")
			         		.Where(h=>h.Attribute("addrtype").Value == "mac")
			         		.Select(h=>h.Attribute("addr").Value)
			         		.FirstOrDefault(),
			         	osCarte = host.Elements("address")
			         		.Where(h=>h.Attribute("addrtype").Value == "mac")
			         		.Select(h=>h.Attribute("vendor").Value)
			         		.FirstOrDefault(),
			         	hostName = host.Elements("hostnames")
			         		.Elements("hostname")
			         		.Select(h=>h.Attribute("name").Value)
			         		.FirstOrDefault(),
			         	status = host.Elements("status")
			         		.Elements("reason")
			         		.Select(h=>h.Attribute("reason").Value)
			         		.FirstOrDefault(),
			         }
			        ).ToList<Interface>();
			
			//MessageBox.Show(lHost.Count.ToString());
			
			InterListe = new List<Interface>();
			
			//Transfere des donnees de lHost vers la liste d'interface 
			foreach(Interface i in lHost)
			{	
				if (i.hostName == null) i.hostName = "not found";
				if (i.ipAddress == null) i.ipAddress = "not found";
				if (i.macAddress == null) i.macAddress = "not found";
				if (i.osCarte == null) i.osCarte = "not found";
				if (i.status == null) i.status = "not found";
				InterListe.Add(i);
			}

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
				}
			}*/
		}
	}
}
