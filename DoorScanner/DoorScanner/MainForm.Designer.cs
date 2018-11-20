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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.ListView lviewCarteReseau;
		private System.Windows.Forms.ColumnHeader columnIp;
		private System.Windows.Forms.ColumnHeader columnNetwork;
		private System.Windows.Forms.ColumnHeader columnMask;
		private System.Windows.Forms.Panel scanPortPanel;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label ipAddLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnPort;
		private System.Windows.Forms.ColumnHeader columnState;
		private System.Windows.Forms.ColumnHeader columnService;
		private System.Windows.Forms.ColumnHeader columnProtocole;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnValider = new System.Windows.Forms.Button();
			this.lviewCarteReseau = new System.Windows.Forms.ListView();
			this.columnIp = new System.Windows.Forms.ColumnHeader();
			this.columnNetwork = new System.Windows.Forms.ColumnHeader();
			this.columnMask = new System.Windows.Forms.ColumnHeader();
			this.scanPortPanel = new System.Windows.Forms.Panel();
			this.ipAddLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnPort = new System.Windows.Forms.ColumnHeader();
			this.columnProtocole = new System.Windows.Forms.ColumnHeader();
			this.columnState = new System.Windows.Forms.ColumnHeader();
			this.columnService = new System.Windows.Forms.ColumnHeader();
			this.scanPortPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(144, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(263, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "Choisissez à partir de quelle carte réseau voulez-vous lancer un scan, puis Valid" +
	"ez :";
			// 
			// btnValider
			// 
			this.btnValider.Location = new System.Drawing.Point(25, 134);
			this.btnValider.Margin = new System.Windows.Forms.Padding(2);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(95, 34);
			this.btnValider.TabIndex = 2;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.BtnValiderClick);
			// 
			// lviewCarteReseau
			// 
			this.lviewCarteReseau.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnIp,
			this.columnNetwork,
			this.columnMask});
			this.lviewCarteReseau.FullRowSelect = true;
			this.lviewCarteReseau.GridLines = true;
			this.lviewCarteReseau.Location = new System.Drawing.Point(139, 58);
			this.lviewCarteReseau.Margin = new System.Windows.Forms.Padding(2);
			this.lviewCarteReseau.MultiSelect = false;
			this.lviewCarteReseau.Name = "lviewCarteReseau";
			this.lviewCarteReseau.Size = new System.Drawing.Size(289, 212);
			this.lviewCarteReseau.TabIndex = 3;
			this.lviewCarteReseau.UseCompatibleStateImageBehavior = false;
			this.lviewCarteReseau.View = System.Windows.Forms.View.Details;
			// 
			// columnIp
			// 
			this.columnIp.Text = "IP";
			this.columnIp.Width = 100;
			// 
			// columnNetwork
			// 
			this.columnNetwork.Text = "Réseau";
			this.columnNetwork.Width = 100;
			// 
			// columnMask
			// 
			this.columnMask.Text = "Masque";
			this.columnMask.Width = 100;
			// 
			// scanPortPanel
			// 
			this.scanPortPanel.Controls.Add(this.ipAddLabel);
			this.scanPortPanel.Controls.Add(this.label2);
			this.scanPortPanel.Controls.Add(this.listView1);
			this.scanPortPanel.Location = new System.Drawing.Point(48, 331);
			this.scanPortPanel.Name = "scanPortPanel";
			this.scanPortPanel.Size = new System.Drawing.Size(529, 376);
			this.scanPortPanel.TabIndex = 4;
			this.scanPortPanel.Visible = false;
			// 
			// ipAddLabel
			// 
			this.ipAddLabel.Location = new System.Drawing.Point(91, 22);
			this.ipAddLabel.Name = "ipAddLabel";
			this.ipAddLabel.Size = new System.Drawing.Size(100, 23);
			this.ipAddLabel.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Adresse IP : ";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnPort,
			this.columnProtocole,
			this.columnState,
			this.columnService});
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(96, 65);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(284, 287);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnPort
			// 
			this.columnPort.Text = "Port";
			// 
			// columnProtocole
			// 
			this.columnProtocole.DisplayIndex = 3;
			this.columnProtocole.Text = "Protocole";
			// 
			// columnState
			// 
			this.columnState.DisplayIndex = 1;
			this.columnState.Text = "Etat";
			// 
			// columnService
			// 
			this.columnService.DisplayIndex = 2;
			this.columnService.Text = "Service";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 735);
			this.Controls.Add(this.scanPortPanel);
			this.Controls.Add(this.lviewCarteReseau);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "DoorScanner";
			this.scanPortPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
