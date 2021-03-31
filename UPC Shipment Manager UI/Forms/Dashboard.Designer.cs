
namespace UPC_Shipment_Manager_UI.Forms
{
	partial class Dashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.TitleBar = new System.Windows.Forms.Panel();
			this.Logout = new System.Windows.Forms.PictureBox();
			this.UserSettings = new System.Windows.Forms.PictureBox();
			this.Minimize = new System.Windows.Forms.PictureBox();
			this.Maximize = new System.Windows.Forms.PictureBox();
			this.Exit = new System.Windows.Forms.PictureBox();
			this.SoftwareName = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.elInward = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.ShipmentManager = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.elOutward = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.CRM = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.Canva = new System.Windows.Forms.Panel();
			this.InventoryManager = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label = new System.Windows.Forms.Label();
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.TitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UserSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
			this.ShipmentManager.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.CRM.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.Canva.SuspendLayout();
			this.InventoryManager.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.Maroon;
			this.TitleBar.Controls.Add(this.Logout);
			this.TitleBar.Controls.Add(this.UserSettings);
			this.TitleBar.Controls.Add(this.Minimize);
			this.TitleBar.Controls.Add(this.Maximize);
			this.TitleBar.Controls.Add(this.Exit);
			this.TitleBar.Controls.Add(this.SoftwareName);
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(958, 31);
			this.TitleBar.TabIndex = 0;
			// 
			// Logout
			// 
			this.Logout.BackColor = System.Drawing.Color.Maroon;
			this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Logout.Dock = System.Windows.Forms.DockStyle.Right;
			this.Logout.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_logout_rounded_up_24px;
			this.Logout.Location = new System.Drawing.Point(808, 0);
			this.Logout.Name = "Logout";
			this.Logout.Size = new System.Drawing.Size(30, 31);
			this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Logout.TabIndex = 6;
			this.Logout.TabStop = false;
			this.toolTip1.SetToolTip(this.Logout, "Logout");
			this.Logout.Click += new System.EventHandler(this.Logout_Click);
			// 
			// UserSettings
			// 
			this.UserSettings.BackColor = System.Drawing.Color.Maroon;
			this.UserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UserSettings.Dock = System.Windows.Forms.DockStyle.Right;
			this.UserSettings.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_users_settings_24px;
			this.UserSettings.Location = new System.Drawing.Point(838, 0);
			this.UserSettings.Name = "UserSettings";
			this.UserSettings.Size = new System.Drawing.Size(30, 31);
			this.UserSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.UserSettings.TabIndex = 5;
			this.UserSettings.TabStop = false;
			this.toolTip1.SetToolTip(this.UserSettings, "Manage Users - Admin only");
			this.UserSettings.Click += new System.EventHandler(this.UserSettings_Click);
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.Color.Maroon;
			this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
			this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
			this.Minimize.Location = new System.Drawing.Point(868, 0);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(30, 31);
			this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Minimize.TabIndex = 3;
			this.Minimize.TabStop = false;
			this.toolTip1.SetToolTip(this.Minimize, "Minimize");
			this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
			// 
			// Maximize
			// 
			this.Maximize.BackColor = System.Drawing.Color.Maroon;
			this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Maximize.Dock = System.Windows.Forms.DockStyle.Right;
			this.Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Maximize.Image")));
			this.Maximize.Location = new System.Drawing.Point(898, 0);
			this.Maximize.Name = "Maximize";
			this.Maximize.Size = new System.Drawing.Size(30, 31);
			this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Maximize.TabIndex = 2;
			this.Maximize.TabStop = false;
			this.toolTip1.SetToolTip(this.Maximize, "Maximize");
			this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.Maroon;
			this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
			this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
			this.Exit.Location = new System.Drawing.Point(928, 0);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(30, 31);
			this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Exit.TabIndex = 1;
			this.Exit.TabStop = false;
			this.toolTip1.SetToolTip(this.Exit, "Close");
			this.Exit.Click += new System.EventHandler(this.Close_Click);
			// 
			// SoftwareName
			// 
			this.SoftwareName.AutoSize = true;
			this.SoftwareName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.SoftwareName.ForeColor = System.Drawing.Color.White;
			this.SoftwareName.Location = new System.Drawing.Point(6, 8);
			this.SoftwareName.Name = "SoftwareName";
			this.SoftwareName.Size = new System.Drawing.Size(134, 15);
			this.SoftwareName.TabIndex = 1;
			this.SoftwareName.Text = "UPC Shipment Manager";
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.TitleBar;
			this.bunifuDragControl1.Vertical = true;
			// 
			// elInward
			// 
			this.elInward.ElipseRadius = 9;
			this.elInward.TargetControl = this.ShipmentManager;
			// 
			// ShipmentManager
			// 
			this.ShipmentManager.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ShipmentManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.ShipmentManager.Controls.Add(this.pictureBox1);
			this.ShipmentManager.Controls.Add(this.label2);
			this.ShipmentManager.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ShipmentManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ShipmentManager.Location = new System.Drawing.Point(246, 211);
			this.ShipmentManager.Name = "ShipmentManager";
			this.ShipmentManager.Size = new System.Drawing.Size(148, 120);
			this.ShipmentManager.TabIndex = 4;
			this.ShipmentManager.Click += new System.EventHandler(this.ShipmentManager_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_shipment_logistic_48px;
			this.pictureBox1.Location = new System.Drawing.Point(37, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(74, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.ShipmentManager_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(13, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Shipment Manager";
			this.label2.Click += new System.EventHandler(this.ShipmentManager_Click);
			// 
			// elOutward
			// 
			this.elOutward.ElipseRadius = 9;
			this.elOutward.TargetControl = this.CRM;
			// 
			// CRM
			// 
			this.CRM.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.CRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.CRM.Controls.Add(this.label3);
			this.CRM.Controls.Add(this.pictureBox2);
			this.CRM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CRM.Location = new System.Drawing.Point(418, 211);
			this.CRM.Name = "CRM";
			this.CRM.Size = new System.Drawing.Size(148, 120);
			this.CRM.TabIndex = 5;
			this.CRM.Click += new System.EventHandler(this.CRM_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(56, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "CRM";
			this.label3.Click += new System.EventHandler(this.CRM_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_people_64px;
			this.pictureBox2.Location = new System.Drawing.Point(35, 20);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(74, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.CRM_Click);
			// 
			// Canva
			// 
			this.Canva.BackColor = System.Drawing.Color.White;
			this.Canva.Controls.Add(this.InventoryManager);
			this.Canva.Controls.Add(this.label);
			this.Canva.Controls.Add(this.CRM);
			this.Canva.Controls.Add(this.ShipmentManager);
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(0, 31);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(958, 528);
			this.Canva.TabIndex = 5;
			// 
			// InventoryManager
			// 
			this.InventoryManager.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.InventoryManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.InventoryManager.Controls.Add(this.label1);
			this.InventoryManager.Controls.Add(this.pictureBox4);
			this.InventoryManager.Cursor = System.Windows.Forms.Cursors.Hand;
			this.InventoryManager.Location = new System.Drawing.Point(586, 211);
			this.InventoryManager.Name = "InventoryManager";
			this.InventoryManager.Size = new System.Drawing.Size(148, 120);
			this.InventoryManager.TabIndex = 7;
			this.InventoryManager.Click += new System.EventHandler(this.InventoryManager_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 19);
			this.label1.TabIndex = 6;
			this.label1.Text = "Inventory Manager";
			this.label1.Click += new System.EventHandler(this.InventoryManager_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox4.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_toolbox_52px;
			this.pictureBox4.Location = new System.Drawing.Point(35, 20);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(74, 64);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.InventoryManager_Click);
			// 
			// label
			// 
			this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label.ForeColor = System.Drawing.Color.Black;
			this.label.Location = new System.Drawing.Point(367, 173);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(221, 19);
			this.label.TabIndex = 6;
			this.label.Text = "Please select an option to proceed:";
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 9;
			this.bunifuElipse2.TargetControl = this.InventoryManager;
			// 
			// Dashboard
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(958, 559);
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.TitleBar);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Dashboard";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.TitleBar.ResumeLayout(false);
			this.TitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UserSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
			this.ShipmentManager.ResumeLayout(false);
			this.ShipmentManager.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.CRM.ResumeLayout(false);
			this.CRM.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.Canva.ResumeLayout(false);
			this.Canva.PerformLayout();
			this.InventoryManager.ResumeLayout(false);
			this.InventoryManager.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TitleBar;
		private System.Windows.Forms.Label SoftwareName;
		private System.Windows.Forms.PictureBox Exit;
		private System.Windows.Forms.PictureBox Minimize;
		private System.Windows.Forms.PictureBox Maximize;
		private System.Windows.Forms.ToolTip toolTip1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.Framework.UI.BunifuElipse elInward;
		private Bunifu.Framework.UI.BunifuElipse elOutward;
		private System.Windows.Forms.Panel Canva;
		private System.Windows.Forms.PictureBox UserSettings;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel CRM;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel ShipmentManager;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel InventoryManager;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private System.Windows.Forms.PictureBox Logout;
	}
}