/*
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
			
			if(lviewCarteReseau.SelectedItems.Count>0)
			{
				// Ligne suivant en comm. pour éviter de lancer un scan a chaque fois
				NS.getIpAvailable(lviewCarteReseau.SelectedItems[0].SubItems[1].Text, lviewCarteReseau.SelectedItems[0].SubItems[2].Text); 
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
					lIpUp.checkedListBoxSelectIp.Items.Add(i.showInterfaceT());
				}
				lIpUp.Show();
			} else {MessageBox.Show("Veuillez sélectionner une interface réseau parmis la liste.");}
		}
	}
}
