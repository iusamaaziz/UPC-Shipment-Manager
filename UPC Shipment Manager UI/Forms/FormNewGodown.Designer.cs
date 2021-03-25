﻿
namespace UPC_Shipment_Manager_UI.Forms
{
	partial class FormNewGodown
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.Godown = new System.Windows.Forms.TextBox();
			this.Register = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(69, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 19);
			this.label1.TabIndex = 7;
			this.label1.Text = "Please enter a unique godown number:";
			// 
			// Godown
			// 
			this.Godown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Godown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Godown.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Godown.Location = new System.Drawing.Point(75, 41);
			this.Godown.Name = "Godown";
			this.Godown.Size = new System.Drawing.Size(236, 25);
			this.Godown.TabIndex = 0;
			// 
			// Register
			// 
			this.Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Register.Location = new System.Drawing.Point(75, 72);
			this.Register.Name = "Register";
			this.Register.Size = new System.Drawing.Size(118, 29);
			this.Register.TabIndex = 1;
			this.Register.Text = "Register";
			this.Register.UseVisualStyleBackColor = true;
			this.Register.Click += new System.EventHandler(this.Register_Click);
			// 
			// Cancel
			// 
			this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(199, 72);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(112, 29);
			this.Cancel.TabIndex = 2;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// FormNewGodown
			// 
			this.AcceptButton = this.Register;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(385, 106);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Register);
			this.Controls.Add(this.Godown);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormNewGodown";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register New Godown";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Godown;
		private System.Windows.Forms.Button Register;
		private System.Windows.Forms.Button Cancel;
	}
}