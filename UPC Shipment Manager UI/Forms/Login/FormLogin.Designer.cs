
namespace UPC_Shipment_Manager_UI.Forms.Login
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.label3 = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Username = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SoftwareName = new System.Windows.Forms.Label();
			this.TitleBar = new System.Windows.Forms.Panel();
			this.Exit = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Print = new System.Windows.Forms.PictureBox();
			this.Login = new FontAwesome.Sharp.IconButton();
			this.TitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Print)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(38, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 15);
			this.label3.TabIndex = 15;
			this.label3.Text = "Password";
			// 
			// Password
			// 
			this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Password.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Password.Location = new System.Drawing.Point(41, 201);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(209, 25);
			this.Password.TabIndex = 1;
			this.Password.UseSystemPasswordChar = true;
			this.Password.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(38, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 15);
			this.label2.TabIndex = 14;
			this.label2.Text = "Username";
			// 
			// Username
			// 
			this.Username.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Username.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Username.Location = new System.Drawing.Point(41, 154);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(209, 25);
			this.Username.TabIndex = 0;
			this.Username.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(110, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 24);
			this.label1.TabIndex = 13;
			this.label1.Text = "Login";
			// 
			// SoftwareName
			// 
			this.SoftwareName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.SoftwareName.AutoSize = true;
			this.SoftwareName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
			this.SoftwareName.ForeColor = System.Drawing.Color.Black;
			this.SoftwareName.Location = new System.Drawing.Point(35, 63);
			this.SoftwareName.Name = "SoftwareName";
			this.SoftwareName.Size = new System.Drawing.Size(210, 24);
			this.SoftwareName.TabIndex = 11;
			this.SoftwareName.Text = "UPC Shipment Manager";
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.Maroon;
			this.TitleBar.Controls.Add(this.Exit);
			this.TitleBar.Controls.Add(this.label4);
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(286, 31);
			this.TitleBar.TabIndex = 16;
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.Maroon;
			this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
			this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
			this.Exit.Location = new System.Drawing.Point(256, 0);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(30, 31);
			this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Exit.TabIndex = 1;
			this.Exit.TabStop = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(6, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "Login - UPC Shipment Manager";
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 7;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.TitleBar;
			this.bunifuDragControl1.Vertical = true;
			// 
			// bunifuDragControl2
			// 
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this;
			this.bunifuDragControl2.Vertical = true;
			// 
			// Print
			// 
			this.Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Print.BackColor = System.Drawing.Color.White;
			this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Print.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_server_24px;
			this.Print.Location = new System.Drawing.Point(261, 278);
			this.Print.Name = "Print";
			this.Print.Size = new System.Drawing.Size(24, 24);
			this.Print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Print.TabIndex = 59;
			this.Print.TabStop = false;
			this.toolTip1.SetToolTip(this.Print, "Server Configuration");
			this.Print.Click += new System.EventHandler(this.Print_Click);
			// 
			// Login
			// 
			this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Login.Enabled = false;
			this.Login.Font = new System.Drawing.Font("Sitka Small", 8.25F);
			this.Login.IconChar = FontAwesome.Sharp.IconChar.None;
			this.Login.IconColor = System.Drawing.Color.Black;
			this.Login.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.Login.Location = new System.Drawing.Point(41, 234);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(209, 30);
			this.Login.TabIndex = 2;
			this.Login.Text = "Login";
			this.Login.UseVisualStyleBackColor = true;
			this.Login.Click += new System.EventHandler(this.Login_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(286, 304);
			this.Controls.Add(this.Print);
			this.Controls.Add(this.TitleBar);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SoftwareName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLogin";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login - UPC Shipment Manager";
			this.TitleBar.ResumeLayout(false);
			this.TitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Print)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton Login;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label SoftwareName;
		private System.Windows.Forms.Panel TitleBar;
		private System.Windows.Forms.PictureBox Exit;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
		private System.Windows.Forms.PictureBox Print;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}