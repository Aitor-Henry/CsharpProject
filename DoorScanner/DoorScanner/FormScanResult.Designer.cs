/*
 * Created by SharpDevelop.
 * User: Amaury
 * Date: 26/11/2018
 * Time: 11:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DoorScanner
{
	partial class FormScanResult
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label lbIpScan;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.lbIpScan = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(38, 109);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(689, 398);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// lbIpScan
			// 
			this.lbIpScan.Location = new System.Drawing.Point(53, 70);
			this.lbIpScan.Name = "lbIpScan";
			this.lbIpScan.Size = new System.Drawing.Size(100, 23);
			this.lbIpScan.TabIndex = 1;
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(460, 33);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(243, 60);
			this.btnExport.TabIndex = 2;
			this.btnExport.Text = "Exporter le Scan";
			this.btnExport.UseVisualStyleBackColor = true;
			// 
			// FormScanResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 519);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.lbIpScan);
			this.Controls.Add(this.listView1);
			this.Name = "FormScanResult";
			this.Text = "FormScanResult";
			this.ResumeLayout(false);

		}
	}
}
