/*
 * Created by SharpDevelop.
 * User: Amaury
 * Date: 20/11/2018
 * Time: 09:51
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
	/// Description of FormListeIpUp.
	/// </summary>
	public partial class FormListeIpUp : Form
	{
		public FormListeIpUp()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		void ValidateIpButtonClick(object sender, EventArgs e)
		{
			if(this.checkedListBoxSelectIp.CheckedItems.Count>0)
			{	
				FormScanResult scanRes = new FormScanResult();
				List<string> IpSelected = new List<string>();
				foreach (string ipSelected in this.checkedListBoxSelectIp.CheckedItems) {
					IpSelected.Add(ipSelected.Split(new[] {"; "},StringSplitOptions.None)[1]);
				}
				portScan PS = new portScan(IpSelected);
				string optionNB="";
				string optionScan="";
				if(this.optionClassique.Checked){
					optionNB = "-p20,21,22,23,25,53,68,80,110,119,135,139,143,443,445,465,548,587,993,995,1025,3680,8080";
				}
				if(this.option1023.Checked){
					optionNB = "-p1-1023";
				}
				if(this.optionTous.Checked){
					optionNB = "-p-";
				}
				if(this.checkBoxTCPConnect.Checked){
					optionScan += " -sT";
				}
				if(this.checkBoxUDP.Checked){
					optionScan += " -sU";
				}
				if(this.checkBoxVuln.Checked){
						optionScan += " -p389,631,1433,1521,3389,3680,5353,5432,5900,6667,8080";//a compléter
				}
				PS.startMultipleScanPorts(optionNB, optionScan);
				PS.readScanToListMultiple();
				foreach (KeyValuePair<string,List<Port>> ip in PS.ResultatScans) {
					ListViewItem ipPorts = new ListViewItem(ip.Key);
					List<Port> Ports = ip.Value;
					ipPorts.SubItems.Add(Ports[0].numport.ToString());
					ipPorts.SubItems.Add(Ports[0].protocole);
					ipPorts.SubItems.Add(Ports[0].state);
					ipPorts.SubItems.Add(Ports[0].service);
					scanRes.listPortView.Items.Add(ipPorts);
					for (int i = 1; i < Ports.Count; i++) {
						ListViewItem PortsVI = new ListViewItem("");
						PortsVI.SubItems.Add(Ports[i].numport.ToString());
						PortsVI.SubItems.Add(Ports[i].protocole);
						PortsVI.SubItems.Add(Ports[i].state);
						PortsVI.SubItems.Add(Ports[i].service);
						scanRes.listPortView.Items.Add(PortsVI);
					}
				}
				scanRes.ipAddLabel.Text = PS.diplayLipToScan();

				if (scanRes.ShowDialog() == DialogResult.OK){
					if(scanRes.saveFileDialog1.ShowDialog() == DialogResult.OK){
						PS.listToTxt(scanRes.saveFileDialog1.FileName);
					}
				}
			} else { MessageBox.Show("Vous n'avez pas seléctionné d'ip à scanner");}
			
		}
		void CancelIpButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
