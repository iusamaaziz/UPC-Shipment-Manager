
namespace UPC_Shipment_Manager_UI.Forms.Login
{
	partial class FormNewUser
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewUser));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.TitleBar = new System.Windows.Forms.Panel();
			this.Exit = new System.Windows.Forms.PictureBox();
			this.SoftwareName = new System.Windows.Forms.Label();
			this.Username = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Role = new System.Windows.Forms.ComboBox();
			this.Register = new FontAwesome.Sharp.IconButton();
			this.Cancel = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.TitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.Maroon;
			this.TitleBar.Controls.Add(this.Exit);
			this.TitleBar.Controls.Add(this.SoftwareName);
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(292, 31);
			this.TitleBar.TabIndex = 1;
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.Maroon;
			this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
			this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
			this.Exit.Location = new System.Drawing.Point(262, 0);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(30, 31);
			this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Exit.TabIndex = 1;
			this.Exit.TabStop = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// SoftwareName
			// 
			this.SoftwareName.AutoSize = true;
			this.SoftwareName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.SoftwareName.ForeColor = System.Drawing.Color.White;
			this.SoftwareName.Location = new System.Drawing.Point(6, 8);
			this.SoftwareName.Name = "SoftwareName";
			this.SoftwareName.Size = new System.Drawing.Size(195, 15);
			this.SoftwareName.TabIndex = 1;
			this.SoftwareName.Text = "New User - UPC Shipment Manager";
			// 
			// Username
			// 
			this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Username.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Username.Location = new System.Drawing.Point(38, 105);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(219, 25);
			this.Username.TabIndex = 0;
			this.Username.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(35, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 15);
			this.label4.TabIndex = 26;
			this.label4.Text = "Username";
			// 
			// Password
			// 
			this.Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Password.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Password.Location = new System.Drawing.Point(38, 155);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(219, 25);
			this.Password.TabIndex = 1;
			this.Password.UseSystemPasswordChar = true;
			this.Password.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(35, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 15);
			this.label1.TabIndex = 28;
			this.label1.Text = "Password";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(35, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 15);
			this.label2.TabIndex = 30;
			this.label2.Text = "Role";
			// 
			// Role
			// 
			this.Role.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Role.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Role.FormattingEnabled = true;
			this.Role.Items.AddRange(new object[] {
            "Admin",
            "Operator"});
			this.Role.Location = new System.Drawing.Point(38, 203);
			this.Role.Name = "Role";
			this.Role.Size = new System.Drawing.Size(219, 25);
			this.Role.TabIndex = 2;
			this.Role.SelectedIndexChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// Register
			// 
			this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.Register.Enabled = false;
			this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Register.Font = new System.Drawing.Font("Sitka Small", 8.25F);
			this.Register.ForeColor = System.Drawing.Color.White;
			this.Register.IconChar = FontAwesome.Sharp.IconChar.None;
			this.Register.IconColor = System.Drawing.Color.Black;
			this.Register.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.Register.Location = new System.Drawing.Point(38, 236);
			this.Register.Name = "Register";
			this.Register.Size = new System.Drawing.Size(219, 29);
			this.Register.TabIndex = 3;
			this.Register.Text = "Register";
			this.Register.UseVisualStyleBackColor = false;
			this.Register.Click += new System.EventHandler(this.Register_Click);
			// 
			// Cancel
			// 
			this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancel.Font = new System.Drawing.Font("Sitka Small", 8.25F);
			this.Cancel.ForeColor = System.Drawing.Color.White;
			this.Cancel.IconChar = FontAwesome.Sharp.IconChar.None;
			this.Cancel.IconColor = System.Drawing.Color.Black;
			this.Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.Cancel.Location = new System.Drawing.Point(38, 271);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(219, 29);
			this.Cancel.TabIndex = 4;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = false;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(91, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 24);
			this.label3.TabIndex = 31;
			this.label3.Text = "New User";
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.TitleBar;
			this.bunifuDragControl1.Vertical = true;
			// 
			// FormNewUser
			// 
			this.AcceptButton = this.Register;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(292, 352);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Register);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Role);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormNewUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New User";
			this.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			this.TitleBar.ResumeLayout(false);
			this.TitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel TitleBar;
		private System.Windows.Forms.PictureBox Exit;
		private System.Windows.Forms.Label SoftwareName;
		private System.Windows.Forms.TextBox Username;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Role;
		private FontAwesome.Sharp.IconButton Register;
		private FontAwesome.Sharp.IconButton Cancel;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
	}
}