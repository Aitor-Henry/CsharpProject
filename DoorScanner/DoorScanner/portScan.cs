/*
 * Created by SharpDevelop.
 * User: Aitor
 * Date: 20/11/2018
 * Time: 13:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace DoorScanner
{
	/// <summary>
	/// Description of portScan.
	/// </summary>
	[Serializable]
	public class portScan
	{

		
		List<string> LipToScan;
		public Dictionary<string, List<Port>> ResultatScans {get; set;} 
		
		
		
		public portScan(List<string> LipTS){
			
			LipToScan = LipTS;
			ResultatScans = new Dictionary<string, List<Port>>();
		}
		
		public void startMultipleScanPorts(string optNB, string optScan){
			
			/*if(optScan==""){
				optScan="-sS";
			}*/
			foreach(string ip in LipToScan){
				string commande = ("nmap "+optNB+" "+optScan+" -T4 "+ip+" -oX scanPort"+ip+".xml");
				Process cmd = new Process();
				cmd.StartInfo.FileName = "cmd.exe";
				cmd.StartInfo.Arguments = "/c"+commande;
				cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				cmd.Start();
				cmd.WaitForExit();
			}
		}
		
		
		public void readScanToListMultiple(){
			foreach (string ipS in LipToScan) {
				//réutilisation de la fonction
				ResultatScans.Add(ipS, readScanToList(ipS));
			}
		}
		
		
		public List<Port> readScanToList(string ip){
			List<Port> listPort = new List<Port>();
			XmlDocument docXml = new XmlDocument();
			docXml.Load("scanPort"+ip+".xml");
			XmlNodeList host = docXml.SelectNodes("/nmaprun/host");
			

			foreach (XmlNode n in host){
				XmlNode ports = n.SelectSingleNode("ports");
				List<int> port = new List<int>();
				List<string> prot = new List<string>();
				List<string> state = new List<string>();
				List<string> service = new List<string>();
				
				foreach (XmlNode Node in ports) {
					if(Node.Name=="port"){
						port.Add(Int32.Parse(Node.Attributes["portid"].Value));
						prot.Add(Node.Attributes["protocol"].Value);
						
						foreach (XmlNode test in Node) { //c'est pas beau mais j'ai pas trouvé d'autres moyens
							if(test.Name=="state"){
								state.Add(test.Attributes["state"].Value);
							}
							if(Node.ChildNodes.Count==1){
								service.Add("unknown");
							} else {
								if(test.Name=="service"){
									service.Add(test.Attributes["name"].Value);
								}
							}
						}
					}
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
			return listPort;

		}
		
		public string diplayLipToScan(){
			string display="";
			foreach (string ip in LipToScan) {
				display = display+ip+"; ";
			}
			return display;
		}
		
		//export format txt
		public void listToTxt(string nomFichier)
		{
			StreamWriter sw = new StreamWriter(nomFichier);
			foreach(KeyValuePair<string, List<Port>> p in ResultatScans)
			{
				List<Port> port = p.Value;
				sw.WriteLine(p.Key+Environment.NewLine+ port[0].showForSave());
				for(int i=1; i<port.Count; i++){
					sw.WriteLine(port[i].showForSave());
				}
			}
				
			sw.Close();			
		}
	}
}
