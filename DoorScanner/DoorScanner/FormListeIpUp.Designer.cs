/*
 * Created by SharpDevelop.
 * User: Amaury
 * Date: 20/11/2018
 * Time: 09:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DoorScanner
{
	partial class FormListeIpUp
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.ColumnHeader columnIp;
		private System.Windows.Forms.ColumnHeader columnMac;
		private System.Windows.Forms.ColumnHeader columnVendor;
		private System.Windows.Forms.ColumnHeader columnStatus;
		public System.Windows.Forms.ListView lviewIpUp;
		private System.Windows.Forms.Button validateIpButton;
		private System.Windows.Forms.Button cancelIpButton;
		
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
			this.lviewIpUp = new System.Windows.Forms.ListView();
			this.columnName = new System.Windows.Forms.ColumnHeader();
			this.columnIp = new System.Windows.Forms.ColumnHeader();
			this.columnMac = new System.Windows.Forms.ColumnHeader();
			this.columnVendor = new System.Windows.Forms.ColumnHeader();
			this.columnStatus = new System.Windows.Forms.ColumnHeader();
			this.validateIpButton = new System.Windows.Forms.Button();
			this.cancelIpButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lviewIpUp
			// 
			this.lviewIpUp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnName,
			this.columnIp,
			this.columnMac,
			this.columnVendor,
			this.columnStatus});
			this.lviewIpUp.FullRowSelect = true;
			this.lviewIpUp.GridLines = true;
			this.lviewIpUp.Location = new System.Drawing.Point(82, 66);
			this.lviewIpUp.Margin = new System.Windows.Forms.Padding(2);
			this.lviewIpUp.Name = "lviewIpUp";
			this.lviewIpUp.Size = new System.Drawing.Size(417, 244);
			this.lviewIpUp.TabIndex = 0;
			this.lviewIpUp.UseCompatibleStateImageBehavior = false;
			this.lviewIpUp.View = System.Windows.Forms.View.Details;
			// 
			// columnName
			// 
			this.columnName.Text = "Nom d\'hôte";
			this.columnName.Width = 80;
			// 
			// columnIp
			// 
			this.columnIp.Text = "Ip";
			this.columnIp.Width = 80;
			// 
			// columnMac
			// 
			this.columnMac.Text = "Adresse Mac";
			this.columnMac.Width = 80;
			// 
			// columnVendor
			// 
			this.columnVendor.Text = "Constructeur carte";
			this.columnVendor.Width = 120;
			// 
			// columnStatus
			// 
			this.columnStatus.Text = "Statut";
			this.columnStatus.Width = 90;
			// 
			// validateIpButton
			// 
			this.validateIpButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.validateIpButton.Location = new System.Drawing.Point(82, 12);
			this.validateIpButton.Name = "validateIpButton";
			this.validateIpButton.Size = new System.Drawing.Size(84, 33);
			this.validateIpButton.TabIndex = 1;
			this.validateIpButton.Text = "Valider";
			this.validateIpButton.UseVisualStyleBackColor = true;
			this.validateIpButton.Click += new System.EventHandler(this.ValidateIpButtonClick);
			// 
			// cancelIpButton
			// 
			this.cancelIpButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelIpButton.Location = new System.Drawing.Point(192, 12);
			this.cancelIpButton.Name = "cancelIpButton";
			this.cancelIpButton.Size = new System.Drawing.Size(83, 33);
			this.cancelIpButton.TabIndex = 2;
			this.cancelIpButton.TabStop = false;
			this.cancelIpButton.Text = "Annuler";
			this.cancelIpButton.UseVisualStyleBackColor = true;
			// 
			// FormListeIpUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 369);
			this.Controls.Add(this.cancelIpButton);
			this.Controls.Add(this.validateIpButton);
			this.Controls.Add(this.lviewIpUp);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormListeIpUp";
			this.Text = "FormListeIpUp";
			this.ResumeLayout(false);

		}
	}
}
