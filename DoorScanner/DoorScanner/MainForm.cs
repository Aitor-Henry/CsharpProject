/*
 * Created by SharpDevelop.
 * User: aihenry
 * Date: 22/10/2018
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DoorScanner
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			networkScan NS = new networkScan();
			infoUserIP.Text = NS.showInfoIP();
		}
		void BtnScanIpUpClick(object sender, EventArgs e)
		{
			ListeInterfaces LS = new ListeInterfaces();
			
			foreach (Interface i in LS){
				lboxInterfaces.Items = i.showInterface().ToString();
			}
		}
	}
}
