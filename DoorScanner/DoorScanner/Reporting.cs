/*
 * Created by SharpDevelop.
 * User: Aitor
 * Date: 28/11/2018
 * Time: 18:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace DoorScanner
{
	/// <summary>
	/// Description of Reporting.
	/// </summary>
	public class Reporting
	{
		
		//-----Variables-----
		string nomF;
		string path;
		string header = "Rapport du "+DateTime.Now.ToString("d/M/yyyy")+". \r\n" +
			"Ce rapport vous présente en fonction des adresses IP choisies les vulnérabilités potentielles détéctées.\r\n" +
			"Tous les ports et services présents dans ce rapport devront faire l'état d'une recherche sur internet ou être analysé par un expert afin de se renseigner sur leur dangerosité. \r\n";
		string corpsRapport = "";
		string footer = "\r\nFin du scan pour les adresses demandées.\r\n";
		
		
		//-----Constructeur-----
		public Reporting(string fichierscan)
		{
			nomF = fichierscan;
			string[] temp = fichierscan.Split('\\');
			string temp2 = temp[temp.Length-1];
			path = fichierscan.Replace(temp2,"");
		}
		
		//-----Fonctions-----
		public void createReport(){
			StreamReader scanres = File.OpenText(nomF);
			IDictionary<string,List<string[]>> listPort = new Dictionary<string,List<string[]>> ();
			List<string[]> listStr = new List<string[]>();
			string scanReader;
			string listReader;
			
			//Il doit exister plus simple mais j'ai un problème sinon
			List<string[]> tempLP = new List<string[]>();
			string tempStr = null;
			int c = 0;
			while ((scanReader = scanres.ReadLine()) != null) {
				if(scanReader.Contains(";")){
					tempLP.Add(scanReader.Split(';'));
				} else {
					//pour la premiere ip
					if(c==0){
						tempStr = scanReader;
						c=1;
					} else {
						listPort.Add(tempStr, new List<string[]>(tempLP));
						tempStr = scanReader;
						tempLP.Clear();
					}
				}
				
			}
			listPort.Add(tempStr, new List<string[]>(tempLP));
			tempLP.Clear();

			scanres.Close();
			foreach (KeyValuePair<string,List<string[]>> ip in listPort) {
				corpsRapport += " \r\n Ports pouvant représenter une vulnérabilité pour l'adresse IP : "+ip.Key+". \r\n \r\n";
				foreach (string[] ls in ip.Value) {
					StreamReader fichierPorts = File.OpenText("PortService0-65535.txt");
					while ((listReader= fichierPorts.ReadLine())!=null) {
						string[] tempLecture = listReader.Split(';');
						//si port et protocole correspondent
						if(ls[0]==tempLecture[1] && ls[2]==tempLecture[2]){
							//si les services sont différents
							if(ls[3]!=tempLecture[0] && tempLecture[0]!="Unassigned" && (ls[1]=="open" || ls[1]=="filtered")){
								corpsRapport += "Attention au port "+ls[0]+", utilisant le service "+ls[3]+" et dans l'état "+ls[1]+". \r\n";
							}
							break;
						}
					}
					fichierPorts.Close();
				}
				corpsRapport += "\r\n";
			}
			
			//ajoute à la suite si le fichier existe déjà
			using (StreamWriter swRapport = File.AppendText(path+"Rapports_"+DateTime.Now.ToString("d-M-yyyy")+".txt")){
				swRapport.WriteLine(header+corpsRapport+footer);
			}


		}
		
	}
}
