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
		public System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.ListView lviewCarteReseau;
		private System.Windows.Forms.ColumnHeader columnIp;
		private System.Windows.Forms.ColumnHeader columnNetwork;
		private System.Windows.Forms.ColumnHeader columnMask;
		
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
			this.columnIp = new System.Windows.Forms.ColumnHeader();
			this.columnNetwork = new System.Windows.Forms.ColumnHeader();
			this.columnMask = new System.Windows.Forms.ColumnHeader();
			this.lviewCarteReseau = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(208, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "Choisissez à partir de quelle carte réseau voulez-vous lancer un scan, puis Valid" +
	"ez :";
			// 
			// btnValider
			// 
			this.btnValider.Location = new System.Drawing.Point(38, 206);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(142, 52);
			this.btnValider.TabIndex = 2;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.BtnValiderClick);
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
			// lviewCarteReseau
			// 
			this.lviewCarteReseau.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnIp,
			this.columnNetwork,
			this.columnMask});
			this.lviewCarteReseau.FullRowSelect = true;
			this.lviewCarteReseau.GridLines = true;
			this.lviewCarteReseau.Location = new System.Drawing.Point(208, 89);
			this.lviewCarteReseau.MultiSelect = false;
			this.lviewCarteReseau.Name = "lviewCarteReseau";
			this.lviewCarteReseau.Size = new System.Drawing.Size(432, 324);
			this.lviewCarteReseau.TabIndex = 3;
			this.lviewCarteReseau.UseCompatibleStateImageBehavior = false;
			this.lviewCarteReseau.View = System.Windows.Forms.View.Details;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 435);
			this.Controls.Add(this.lviewCarteReseau);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "DoorScanner";
			this.ResumeLayout(false);

		}
	}
}
