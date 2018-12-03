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
		public System.Windows.Forms.Label ipAddLabel;
		public System.Windows.Forms.Button btnExport;
		public System.Windows.Forms.SaveFileDialog saveFileDialog1;
		public System.Windows.Forms.ListView listPortView;
		private System.Windows.Forms.ColumnHeader columnIPshow;
		private System.Windows.Forms.ColumnHeader columnPort;
		private System.Windows.Forms.ColumnHeader columnProtocole;
		private System.Windows.Forms.ColumnHeader columnState;
		private System.Windows.Forms.ColumnHeader columnService;
		private System.Windows.Forms.Button btnNewScan;
		private System.Windows.Forms.Label label1;
		
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
			this.ipAddLabel = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.listPortView = new System.Windows.Forms.ListView();
			this.columnIPshow = new System.Windows.Forms.ColumnHeader();
			this.columnPort = new System.Windows.Forms.ColumnHeader();
			this.columnProtocole = new System.Windows.Forms.ColumnHeader();
			this.columnState = new System.Windows.Forms.ColumnHeader();
			this.columnService = new System.Windows.Forms.ColumnHeader();
			this.btnNewScan = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ipAddLabel
			// 
			this.ipAddLabel.Location = new System.Drawing.Point(8, 34);
			this.ipAddLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ipAddLabel.Name = "ipAddLabel";
			this.ipAddLabel.Size = new System.Drawing.Size(207, 34);
			this.ipAddLabel.TabIndex = 1;
			// 
			// btnExport
			// 
			this.btnExport.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnExport.Location = new System.Drawing.Point(274, 382);
			this.btnExport.Margin = new System.Windows.Forms.Padding(2);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(208, 39);
			this.btnExport.TabIndex = 2;
			this.btnExport.Text = "Exporter le Scan + Rapport";
			this.btnExport.UseVisualStyleBackColor = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Fichier Texte|*.txt";
			// 
			// listPortView
			// 
			this.listPortView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnIPshow,
			this.columnPort,
			this.columnProtocole,
			this.columnState,
			this.columnService});
			this.listPortView.FullRowSelect = true;
			this.listPortView.GridLines = true;
			this.listPortView.Location = new System.Drawing.Point(71, 72);
			this.listPortView.Name = "listPortView";
			this.listPortView.Size = new System.Drawing.Size(411, 287);
			this.listPortView.TabIndex = 3;
			this.listPortView.UseCompatibleStateImageBehavior = false;
			this.listPortView.View = System.Windows.Forms.View.Details;
			// 
			// columnIPshow
			// 
			this.columnIPshow.Text = "Adresse IP";
			// 
			// columnPort
			// 
			this.columnPort.Text = "Port";
			// 
			// columnProtocole
			// 
			this.columnProtocole.DisplayIndex = 4;
			this.columnProtocole.Text = "Protocole";
			// 
			// columnState
			// 
			this.columnState.DisplayIndex = 2;
			this.columnState.Text = "Etat";
			// 
			// columnService
			// 
			this.columnService.DisplayIndex = 3;
			this.columnService.Text = "Service";
			// 
			// btnNewScan
			// 
			this.btnNewScan.Location = new System.Drawing.Point(71, 382);
			this.btnNewScan.Margin = new System.Windows.Forms.Padding(2);
			this.btnNewScan.Name = "btnNewScan";
			this.btnNewScan.Size = new System.Drawing.Size(109, 39);
			this.btnNewScan.TabIndex = 4;
			this.btnNewScan.Text = "Nouveau scan";
			this.btnNewScan.UseVisualStyleBackColor = true;
			this.btnNewScan.Click += new System.EventHandler(this.BtnNewScanClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Addresse(s) Ip scannée(s) :";
			// 
			// FormScanResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(615, 503);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnNewScan);
			this.Controls.Add(this.listPortView);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.ipAddLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormScanResult";
			this.Text = "FormScanResult";
			this.ResumeLayout(false);

		}
	}
}
