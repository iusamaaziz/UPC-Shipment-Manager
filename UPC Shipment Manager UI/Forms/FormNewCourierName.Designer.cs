
namespace UPC_Shipment_Manager_UI.Forms
{
	partial class FormNewCourierName
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
			this.Cancel = new System.Windows.Forms.Button();
			this.Register = new System.Windows.Forms.Button();
			this.Godown = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Cancel
			// 
			this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(198, 70);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(112, 29);
			this.Cancel.TabIndex = 10;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// Register
			// 
			this.Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Register.Location = new System.Drawing.Point(74, 70);
			this.Register.Name = "Register";
			this.Register.Size = new System.Drawing.Size(118, 29);
			this.Register.TabIndex = 9;
			this.Register.Text = "Register";
			this.Register.UseVisualStyleBackColor = true;
			this.Register.Click += new System.EventHandler(this.Register_Click);
			// 
			// Godown
			// 
			this.Godown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Godown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Godown.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Godown.Location = new System.Drawing.Point(74, 39);
			this.Godown.Name = "Godown";
			this.Godown.Size = new System.Drawing.Size(236, 25);
			this.Godown.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(76, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 19);
			this.label1.TabIndex = 11;
			this.label1.Text = "Please enter a unique Courier name:";
			// 
			// FormNewCourierName
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
			this.Name = "FormNewCourierName";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Courier Name";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Register;
		private System.Windows.Forms.TextBox Godown;
		private System.Windows.Forms.Label label1;
	}
}