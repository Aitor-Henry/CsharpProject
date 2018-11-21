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
		networkScan NS = new networkScan();
		ListeInterfaces LI;
		public MainForm()
		{
			InitializeComponent();
			
			//remplissage du tableau à l'ouverture de la fenetre
			foreach(Interface i in NS.cartesListe)
			{	
				ListViewItem carte = new ListViewItem(i.ipAddress);
				carte.SubItems.Add(i.netAdd);
				carte.SubItems.Add(i.mask);
				lviewCarteReseau.Items.Add(carte);
			}
		}
		
		//Declenche le scan, genere le xml et extrait les infos du xml 
		void BtnValiderClick(object sender, EventArgs e)
		{
			
			if(lviewCarteReseau.SelectedItems.Count>0){
				// Ligne suivant en comm. pour éviter de lancer un scan a chaque fois
				//NS.getIpAvailable(lviewCarteReseau.SelectedItems[0].SubItems[1].Text, lviewCarteReseau.SelectedItems[0].SubItems[2].Text); 
				LI = new ListeInterfaces();
				LI.XmltoList();
				
				FormListeIpUp lIpUp = new FormListeIpUp();
				
				foreach(Interface i in LI.interListe)
				{
					ListViewItem ipup = new ListViewItem(i.hostName);
					ipup.SubItems.Add(i.ipAddress);
					ipup.SubItems.Add(i.macAddress);
					ipup.SubItems.Add(i.osCarte);
					ipup.SubItems.Add(i.status);
					lIpUp.lviewIpUp.Items.Add(ipup);
					lIpUp.checkedListBoxSelectIp.Items.Add(i.showInterfaceT());
				}
				
				if(lIpUp.ShowDialog()==DialogResult.OK){
					/*if(lIpUp.ipChoisie!=null){
						portScan PS = new portScan(lIpUp.ipChoisie);
						// Ligne suivant en comm. pour éviter de lancer un scan a chaque fois
						PS.startScanPorts();
						PS.readScanToList();

						foreach (Port p in PS.listPort) {
							ListViewItem carte = new ListViewItem(p.numport.ToString());
							carte.SubItems.Add(p.protocole);
							carte.SubItems.Add(p.state);
							carte.SubItems.Add(p.service);
							listPortView.Items.Add(carte);
						}
						ipAddLabel.Text = lIpUp.ipChoisie;
						scanPortPanel.Visible = true;
					} else {
						MessageBox.Show("Vous n'avez pas seléctionné d'ip à scanner");
					}*/
					
					
					// Nouvelle solution en dév #########################################################################
					MessageBox.Show(lIpUp.checkedListBoxSelectIp.CheckedItems.Count.ToString());
					
					if(lIpUp.checkedListBoxSelectIp.CheckedItems.Count>0){
						
						List<string> IpSelected = new List<string>();
						foreach (string ipSelected in lIpUp.checkedListBoxSelectIp.CheckedItems) {
							IpSelected.Add(ipSelected.Split(new[] {"; "},StringSplitOptions.None)[1]);
							MessageBox.Show(ipSelected.Split(new[] {"; "},StringSplitOptions.None)[1]);
							
						}
						portScan PS = new portScan(IpSelected);
						string optionNB="";
						string optionScan="";
						if(lIpUp.optionClassique.Checked){
							optionNB = "-F";
						}
						if(lIpUp.option1023.Checked){
							optionNB = "-p1-1023";
						}
						if(lIpUp.optionTous.Checked){
							optionNB = "-p-";
						}
						if(lIpUp.checkBoxTCPConnect.Checked){
							if(lIpUp.checkBoxUDP.Checked){
								optionScan = "-sT -sU";
							} else {
								optionScan = "-sT";
							}
						} else {
							if(lIpUp.checkBoxUDP.Checked){
								optionScan = "-sU";
							} else {
								optionScan = "-sS"; // option par défaut si aucune checkbox n'est cochée
							}
						}
						PS.startMultipleScanPorts(optionNB, optionScan);
					} else {
						MessageBox.Show("Vous n'avez pas seléctionné d'ip à scanner");
					}
					// ##################################################################################################
				}
			} else {
				MessageBox.Show("Veuillez sélectionner une interface réseau parmis la liste.");
			}
			
		}

	}
}
