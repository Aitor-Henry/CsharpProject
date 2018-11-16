/*
 * Created by SharpDevelop.
 * User: Amaury
 * Date: 16/11/2018
 * Time: 12:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DoorScanner
{
	partial class IpDispoSurLeReseau
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox lboxIpDispo;
		private System.Windows.Forms.Button btnScan;
		
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
			this.lboxIpDispo = new System.Windows.Forms.ListBox();
			this.btnScan = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lboxIpDispo
			// 
			this.lboxIpDispo.FormattingEnabled = true;
			this.lboxIpDispo.ItemHeight = 20;
			this.lboxIpDispo.Location = new System.Drawing.Point(235, 30);
			this.lboxIpDispo.Name = "lboxIpDispo";
			this.lboxIpDispo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lboxIpDispo.Size = new System.Drawing.Size(563, 424);
			this.lboxIpDispo.TabIndex = 0;
			// 
			// btnScan
			// 
			this.btnScan.Location = new System.Drawing.Point(45, 387);
			this.btnScan.Name = "btnScan";
			this.btnScan.Size = new System.Drawing.Size(141, 67);
			this.btnScan.TabIndex = 1;
			this.btnScan.Text = "Lancer Scan";
			this.btnScan.UseVisualStyleBackColor = true;
			// 
			// IpDispoSurLeReseau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 471);
			this.Controls.Add(this.btnScan);
			this.Controls.Add(this.lboxIpDispo);
			this.Name = "IpDispoSurLeReseau";
			this.Text = "IpDispoSurLeReseau";
			this.ResumeLayout(false);

		}
	}
}
