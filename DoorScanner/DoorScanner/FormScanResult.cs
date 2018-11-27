/*
 * Created by SharpDevelop.
 * User: Amaury
 * Date: 26/11/2018
 * Time: 11:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoorScanner
{
	/// <summary>
	/// Description of FormScanResult.
	/// </summary>
	public partial class FormScanResult : Form
	{
		public FormScanResult()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnNewScanClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
