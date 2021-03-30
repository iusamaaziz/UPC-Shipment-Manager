
namespace UPC_Shipment_Manager_UI.Forms
{
	partial class FormConfiguration
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
			this.label4 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancel = new FontAwesome.Sharp.IconButton();
			this.Connect = new FontAwesome.Sharp.IconButton();
			this.label1 = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.LocalHost = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Sitka Small", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(89, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 18);
			this.label4.TabIndex = 39;
			this.label4.Text = "Password:";
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPassword.Location = new System.Drawing.Point(92, 168);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(226, 23);
			this.tbPassword.TabIndex = 2;
			this.tbPassword.UseSystemPasswordChar = true;
			this.tbPassword.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Sitka Small", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(89, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 18);
			this.label3.TabIndex = 38;
			this.label3.Text = "User:";
			// 
			// tbUser
			// 
			this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbUser.Location = new System.Drawing.Point(92, 117);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(226, 23);
			this.tbUser.TabIndex = 1;
			this.tbUser.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Sitka Small", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(88, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 18);
			this.label2.TabIndex = 37;
			this.label2.Text = "Server Name:";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Sitka Small", 8.25F);
			this.btnCancel.ForeColor = System.Drawing.Color.Black;
			this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCancel.IconColor = System.Drawing.Color.Black;
			this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancel.IconSize = 16;
			this.btnCancel.Location = new System.Drawing.Point(93, 253);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(225, 25);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// Connect
			// 
			this.Connect.Enabled = false;
			this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Connect.Font = new System.Drawing.Font("Sitka Small", 8.25F);
			this.Connect.ForeColor = System.Drawing.Color.Black;
			this.Connect.IconChar = FontAwesome.Sharp.IconChar.None;
			this.Connect.IconColor = System.Drawing.Color.Black;
			this.Connect.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.Connect.IconSize = 16;
			this.Connect.Location = new System.Drawing.Point(93, 222);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(225, 25);
			this.Connect.TabIndex = 3;
			this.Connect.Text = "Connect";
			this.Connect.UseVisualStyleBackColor = true;
			this.Connect.Click += new System.EventHandler(this.Connect_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 18);
			this.label1.TabIndex = 36;
			this.label1.Text = "Please fill in the following information to connect to the server";
			// 
			// tbServer
			// 
			this.tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbServer.Location = new System.Drawing.Point(91, 65);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(226, 23);
			this.tbServer.TabIndex = 0;
			this.tbServer.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// LocalHost
			// 
			this.LocalHost.AutoSize = true;
			this.LocalHost.Location = new System.Drawing.Point(91, 199);
			this.LocalHost.Name = "LocalHost";
			this.LocalHost.Size = new System.Drawing.Size(136, 17);
			this.LocalHost.TabIndex = 40;
			this.LocalHost.Text = "Connect as local host";
			this.LocalHost.UseVisualStyleBackColor = true;
			this.LocalHost.CheckedChanged += new System.EventHandler(this.LocalHost_CheckedChanged);
			// 
			// FormConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(419, 290);
			this.Controls.Add(this.LocalHost);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.Connect);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbServer);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.Name = "FormConfiguration";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Server Configuration";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton btnCancel;
		private FontAwesome.Sharp.IconButton Connect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.CheckBox LocalHost;
	}
}