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
			InitializeComponent();

			networkScan NS = new networkScan();
			
			
			lviewCarteReseau.Columns.Add("IP", 100, HorizontalAlignment.Left);
			lviewCarteReseau.Columns.Add("Reseau", 100, HorizontalAlignment.Left);
			lviewCarteReseau.View = View.Details;
			
			foreach(Interface i in NS.cartesListe)
			{	
				
				ListViewItem carte = new ListViewItem(i.ipAddress);
				carte.SubItems.Add (i.netAdd);
				lviewCarteReseau.Items.Add(carte);
			}
		}
		void BtnValiderClick(object sender, EventArgs e)
		{
			
		}
	}
}
