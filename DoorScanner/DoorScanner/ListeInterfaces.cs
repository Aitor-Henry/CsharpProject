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
				resultat=resultat+" \n"+i.showInterface();
				
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
					// AJOUT D'UNE LIGNE POUR METTRE TOUTES LES IP DANS INTERFACE.InfosPorts, les ajouter toutes en remplissant Port, state, protocole et service (name dans le xml)
					
					ipUp.ipAddress = n.SelectSingleNode("address[@addrtype='ipv4']/@addr").InnerText;
					ipUp.hostName = n.SelectSingleNode("hostnames").InnerText;
					ipUp.os = n.SelectSingleNode(
						"//osmatch[not(@accuracy < preceding::osmatch/@accuracy)and not(@accuracy < following::osmatch/@accuracy)]/@name").InnerText;
					InterListe.Add(ipUp);
				}
		}
	}
}
