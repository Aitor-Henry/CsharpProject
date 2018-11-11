/*
 * Created by SharpDevelop.
 * User: aihenry
 * Date: 22/10/2018
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DoorScanner
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label infoUserIP;
		private System.Windows.Forms.Button btnScanIpUp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lboxInterfaces;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.infoUserIP = new System.Windows.Forms.Label();
			this.btnScanIpUp = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lboxInterfaces = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// infoUserIP
			// 
			this.infoUserIP.Location = new System.Drawing.Point(53, 38);
			this.infoUserIP.Name = "infoUserIP";
			this.infoUserIP.Size = new System.Drawing.Size(624, 41);
			this.infoUserIP.TabIndex = 0;
			this.infoUserIP.Text = " -";
			// 
			// btnScanIpUp
			// 
			this.btnScanIpUp.Location = new System.Drawing.Point(276, 106);
			this.btnScanIpUp.Name = "btnScanIpUp";
			this.btnScanIpUp.Size = new System.Drawing.Size(148, 35);
			this.btnScanIpUp.TabIndex = 1;
			this.btnScanIpUp.Text = "Lancer le Scan";
			this.btnScanIpUp.UseVisualStyleBackColor = true;
			this.btnScanIpUp.Click += new System.EventHandler(this.BtnScanIpUpClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Trouver les interfaces dispo :";
			// 
			// lboxInterfaces
			// 
			this.lboxInterfaces.FormattingEnabled = true;
			this.lboxInterfaces.ItemHeight = 20;
			this.lboxInterfaces.Location = new System.Drawing.Point(37, 206);
			this.lboxInterfaces.Name = "lboxInterfaces";
			this.lboxInterfaces.Size = new System.Drawing.Size(601, 284);
			this.lboxInterfaces.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 658);
			this.Controls.Add(this.lboxInterfaces);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnScanIpUp);
			this.Controls.Add(this.infoUserIP);
			this.Name = "MainForm";
			this.Text = "DoorScanner";
			this.ResumeLayout(false);

		}
	}
}
