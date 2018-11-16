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
			
			// Configuration de l'affichage des cartes réseau dispo
			
				//ajout des headers
			lviewCarteReseau.Columns.Add("IP", 100, HorizontalAlignment.Left);
			lviewCarteReseau.Columns.Add("Reseau", 100, HorizontalAlignment.Left);
			lviewCarteReseau.View = View.Details;
			
				//Remplissage du tableau 
			foreach(Interface i in NS.cartesListe)
			{	
				ListViewItem carte = new ListViewItem(i.ipAddress);
				carte.SubItems.Add (i.netAdd);
				lviewCarteReseau.Items.Add(carte);
			}
		}
		
		//Declenche le scan, genere le xml et extrait les infos du xml 
		void BtnValiderClick(object sender, EventArgs e)
		{
			//A FAIRE: ajout d'un controle de selection (si null >> msg="ERROOOOR! GROS CONARD!")
			//NS.getIpAvailable(lviewCarteReseau.SelectedItems[0].SubItems[1].Text);
			LI = new ListeInterfaces();
			LI.XmltoList();
			MessageBox.Show(LI.showIpList());
		}
	}
}
