﻿/*
 * Created by SharpDevelop.
 * User: Amaury
 * Date: 20/11/2018
 * Time: 09:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace DoorScanner
{
	/// <summary>
	/// Description of FormListeIpUp.
	/// </summary>
	public partial class FormListeIpUp : Form
	{
		public string ipChoisie {get;set;}
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
			if(lviewIpUp.SelectedItems.Count>0){
				ipChoisie = lviewIpUp.SelectedItems[0].SubItems[1].Text;
			}
		}
		

	}
}
