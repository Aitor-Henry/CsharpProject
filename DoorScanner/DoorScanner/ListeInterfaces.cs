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
		 	Port P = new Port();
			XmlDocument xnl = new XmlDocument();
			xnl.Load("ipDispo.xml");
			XmlNodeList host = xnl.SelectNodes("/nmaprun/host");
			
			foreach (XmlNode n in host)
			{
				Interface ipUp = new Interface();
				// AJOUT D'UNE LIGNE POUR METTRE TOUTES LES IP DANS INTERFACE.InfosPorts, les ajouter toutes en remplissant Port, state, protocole et service (name dans le xml)
				if(n.HasChildNodes){
					foreach (XmlNode n2 in n) {
						//liste sur les nodes hostnames, ports, etc, il faut ensuite faire une boucle sur node:ports pour récupérer les infos de chaque port
						if(n2.Name=="ports"){
								foreach(XmlNode p in n2)
								{
									
									/*P.numport=Int32.Parse(p.SelectSingleNode("port/@portid").InnerText);
									P.protocole=p.SelectSingleNode("port/@protocol").InnerText;
									P.service=p.SelectSingleNode("port/@name").InnerText;
									P.state=p.SelectSingleNode("port/@state").InnerText;
									MessageBox.Show(P.showip());
									ipUp.infosports.Add(P);*/
								}
							}
					}
					/*if(cn=="ports"){
						
						
					   }*/
				}
				ipUp.ipAddress = n.SelectSingleNode("address[@addrtype='ipv4']/@addr").InnerText;
				ipUp.hostName = n.SelectSingleNode("hostnames").InnerText;
				ipUp.os = n.SelectSingleNode("//osmatch[not(@accuracy < preceding::osmatch/@accuracy)and not(@accuracy < following::osmatch/@accuracy)]/@name").InnerText;
				
				InterListe.Add(ipUp);
			}
		}
	}
}
