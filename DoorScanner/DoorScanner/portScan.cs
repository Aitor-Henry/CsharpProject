/*
 * Created by SharpDevelop.
 * User: Aitor
 * Date: 20/11/2018
 * Time: 13:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
using System.Linq;
using System.Xml.XPath;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace DoorScanner
{
	/// <summary>
	/// Description of portScan.
	/// </summary>
	public class portScan
	{
		string ipToScan;
		public List<Port> listPort {get; set;}
				
		public portScan(string ipScan)
		{
			listPort = new List<Port>();
			ipToScan = ipScan;
		}
		
		public void startScanPorts(){
			string commande = ("nmap -sS -sU "+ipToScan+" -oX scanPort.xml");
			Process cmd = new Process();
			cmd.StartInfo.FileName = "cmd.exe";
			cmd.StartInfo.Arguments = "/c"+commande;
			cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			cmd.Start();
			cmd.WaitForExit();
		}
		
		public void readScanToList(){
			
			XmlDocument docXml = new XmlDocument();
			docXml.Load("scanPort.xml");
			XmlNodeList host = docXml.SelectNodes("/nmaprun/host");
			
			foreach (XmlNode n in host){
				XmlNode ports = n.SelectSingleNode("ports");
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

				for(int i=0; i<port.Count; i++){
					Port P = new Port();
					P.numport=port[i];
					P.protocole=prot[i];
					P.service=service[i];
					P.state=state[i];
					//si l'état et le service sont unknown, on n'ajoute pas ? (seulement un numéro ip)
					if(!(P.state=="unknown" && P.service=="unknown")){
						listPort.Add(P);
					}
					
				}
			}

		}
	}
}
