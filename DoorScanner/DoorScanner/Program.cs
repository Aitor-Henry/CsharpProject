﻿/*
 * Created by SharpDevelop.
 * User: aihenry
 * Date: 22/10/2018
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace DoorScanner
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			
			
			//MsgBox pour afficher les résultats, c'est de la merde
<<<<<<< Updated upstream
			networkScan NS = new networkScan();
			MessageBoxButtons MB = MessageBoxButtons.YesNo;
			
			MessageBox.Show(NS.interfaceGS.showIP()+", "+NS.interfaceGS.showMask()+", "+NS.shownetworkID()+", "+NS.showBroadcast(), "Votre adresse IPv4", MB);
			
			//NS.getIpAvailable(NS.interfaceGS.ipAddress);
			
			ListeInterfaces LI = new ListeInterfaces();
			LI.XmltoList();
			MessageBox.Show(LI.showIpList());
=======
>>>>>>> Stashed changes
			
			//MessageBoxButtons MB = MessageBoxButtons.YesNo;
			//MessageBox.Show(NS.showIP()+", "+NS.showMask()+", "+NS.shownetworkID()+", "+NS.showBroadcast(), "Votre adresse IPv4", MB);

	
		}
		
		
	}
}
