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

namespace DoorScanner
{
	/// <summary>
	/// Description of portScan.
	/// </summary>
	public class portScan
	{
		string ipToScan;
		List<Port> listPort;
				
		public portScan(string ipScan)
		{
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
			//reader, incrémentation de la liste listPort
		}
	}
}
