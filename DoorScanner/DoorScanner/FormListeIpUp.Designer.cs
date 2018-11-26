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
		private System.Windows.Forms.Button validateIpButton;
		private System.Windows.Forms.Button cancelIpButton;
		public System.Windows.Forms.CheckedListBox checkedListBoxSelectIp;
		private System.Windows.Forms.GroupBox groupBoxOptionScanRange;
		public System.Windows.Forms.RadioButton optionTous;
		public System.Windows.Forms.RadioButton option1023;
		public System.Windows.Forms.RadioButton optionClassique;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.CheckBox checkBoxUDP;
		public System.Windows.Forms.CheckBox checkBoxTCPConnect;
		
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
			this.validateIpButton = new System.Windows.Forms.Button();
			this.cancelIpButton = new System.Windows.Forms.Button();
			this.checkedListBoxSelectIp = new System.Windows.Forms.CheckedListBox();
			this.groupBoxOptionScanRange = new System.Windows.Forms.GroupBox();
			this.optionTous = new System.Windows.Forms.RadioButton();
			this.option1023 = new System.Windows.Forms.RadioButton();
			this.optionClassique = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxUDP = new System.Windows.Forms.CheckBox();
			this.checkBoxTCPConnect = new System.Windows.Forms.CheckBox();
			this.groupBoxOptionScanRange.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// validateIpButton
			// 
			this.validateIpButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.validateIpButton.Location = new System.Drawing.Point(472, 18);
			this.validateIpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.validateIpButton.Name = "validateIpButton";
			this.validateIpButton.Size = new System.Drawing.Size(126, 51);
			this.validateIpButton.TabIndex = 1;
			this.validateIpButton.Text = "Valider";
			this.validateIpButton.UseVisualStyleBackColor = true;
			// 
			// cancelIpButton
			// 
			this.cancelIpButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelIpButton.Location = new System.Drawing.Point(693, 18);
			this.cancelIpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cancelIpButton.Name = "cancelIpButton";
			this.cancelIpButton.Size = new System.Drawing.Size(124, 51);
			this.cancelIpButton.TabIndex = 2;
			this.cancelIpButton.TabStop = false;
			this.cancelIpButton.Text = "Annuler";
			this.cancelIpButton.UseVisualStyleBackColor = true;
			// 
			// checkedListBoxSelectIp
			// 
			this.checkedListBoxSelectIp.FormattingEnabled = true;
			this.checkedListBoxSelectIp.Location = new System.Drawing.Point(426, 137);
			this.checkedListBoxSelectIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkedListBoxSelectIp.Name = "checkedListBoxSelectIp";
			this.checkedListBoxSelectIp.Size = new System.Drawing.Size(932, 634);
			this.checkedListBoxSelectIp.TabIndex = 3;
			// 
			// groupBoxOptionScanRange
			// 
			this.groupBoxOptionScanRange.Controls.Add(this.optionTous);
			this.groupBoxOptionScanRange.Controls.Add(this.option1023);
			this.groupBoxOptionScanRange.Controls.Add(this.optionClassique);
			this.groupBoxOptionScanRange.Location = new System.Drawing.Point(44, 137);
			this.groupBoxOptionScanRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxOptionScanRange.Name = "groupBoxOptionScanRange";
			this.groupBoxOptionScanRange.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxOptionScanRange.Size = new System.Drawing.Size(327, 286);
			this.groupBoxOptionScanRange.TabIndex = 4;
			this.groupBoxOptionScanRange.TabStop = false;
			this.groupBoxOptionScanRange.Text = "Options du scan de Ports - Nombre";
			// 
			// optionTous
			// 
			this.optionTous.Location = new System.Drawing.Point(51, 197);
			this.optionTous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.optionTous.Name = "optionTous";
			this.optionTous.Size = new System.Drawing.Size(156, 37);
			this.optionTous.TabIndex = 2;
			this.optionTous.TabStop = true;
			this.optionTous.Text = "Tous les ports";
			this.optionTous.UseVisualStyleBackColor = true;
			// 
			// option1023
			// 
			this.option1023.Location = new System.Drawing.Point(51, 128);
			this.option1023.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.option1023.Name = "option1023";
			this.option1023.Size = new System.Drawing.Size(156, 37);
			this.option1023.TabIndex = 1;
			this.option1023.TabStop = true;
			this.option1023.Text = "De 1 à 1023";
			this.option1023.UseVisualStyleBackColor = true;
			// 
			// optionClassique
			// 
			this.optionClassique.Location = new System.Drawing.Point(51, 52);
			this.optionClassique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.optionClassique.Name = "optionClassique";
			this.optionClassique.Size = new System.Drawing.Size(156, 37);
			this.optionClassique.TabIndex = 0;
			this.optionClassique.TabStop = true;
			this.optionClassique.Text = "Ports classiques";
			this.optionClassique.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxUDP);
			this.groupBox1.Controls.Add(this.checkBoxTCPConnect);
			this.groupBox1.Location = new System.Drawing.Point(52, 497);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(318, 302);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// checkBoxUDP
			// 
			this.checkBoxUDP.Location = new System.Drawing.Point(42, 148);
			this.checkBoxUDP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxUDP.Name = "checkBoxUDP";
			this.checkBoxUDP.Size = new System.Drawing.Size(216, 37);
			this.checkBoxUDP.TabIndex = 2;
			this.checkBoxUDP.Text = "Scan UDP";
			this.checkBoxUDP.UseVisualStyleBackColor = true;
			// 
			// checkBoxTCPConnect
			// 
			this.checkBoxTCPConnect.Location = new System.Drawing.Point(42, 62);
			this.checkBoxTCPConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTCPConnect.Name = "checkBoxTCPConnect";
			this.checkBoxTCPConnect.Size = new System.Drawing.Size(258, 37);
			this.checkBoxTCPConnect.TabIndex = 1;
			this.checkBoxTCPConnect.Text = "Scan TCP connect";
			this.checkBoxTCPConnect.UseVisualStyleBackColor = true;
			// 
			// FormListeIpUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1375, 962);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBoxOptionScanRange);
			this.Controls.Add(this.checkedListBoxSelectIp);
			this.Controls.Add(this.cancelIpButton);
			this.Controls.Add(this.validateIpButton);
			this.Name = "FormListeIpUp";
			this.Text = "FormListeIpUp";
			this.groupBoxOptionScanRange.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
