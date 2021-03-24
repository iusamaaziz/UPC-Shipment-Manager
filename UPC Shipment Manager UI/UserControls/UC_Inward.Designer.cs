
namespace UPC_Shipment_Manager_UI.UserControls
{
	partial class UC_Inward
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Navbar = new System.Windows.Forms.Panel();
			this.NavTitle = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Canva = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.Bulk = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.Single = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.elInward = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.elOutward = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.Search = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Back = new System.Windows.Forms.PictureBox();
			this.Navbar.SuspendLayout();
			this.Canva.SuspendLayout();
			this.Bulk.SuspendLayout();
			this.Single.SuspendLayout();
			this.Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
			this.SuspendLayout();
			// 
			// Navbar
			// 
			this.Navbar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Navbar.Controls.Add(this.Back);
			this.Navbar.Controls.Add(this.NavTitle);
			this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.Navbar.Location = new System.Drawing.Point(0, 0);
			this.Navbar.Name = "Navbar";
			this.Navbar.Size = new System.Drawing.Size(958, 30);
			this.Navbar.TabIndex = 0;
			// 
			// NavTitle
			// 
			this.NavTitle.AutoSize = true;
			this.NavTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.NavTitle.ForeColor = System.Drawing.Color.Black;
			this.NavTitle.Location = new System.Drawing.Point(34, 6);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(119, 19);
			this.NavTitle.TabIndex = 7;
			this.NavTitle.Text = "Inward Shipments";
			// 
			// Canva
			// 
			this.Canva.BackColor = System.Drawing.SystemColors.Control;
			this.Canva.Controls.Add(this.Search);
			this.Canva.Controls.Add(this.label1);
			this.Canva.Controls.Add(this.Bulk);
			this.Canva.Controls.Add(this.Single);
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(0, 30);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(958, 498);
			this.Canva.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(387, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 19);
			this.label1.TabIndex = 12;
			this.label1.Text = "Select an appropriate option:";
			// 
			// Bulk
			// 
			this.Bulk.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Bulk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.Bulk.Controls.Add(this.label3);
			this.Bulk.Controls.Add(this.pictureBox2);
			this.Bulk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Bulk.Location = new System.Drawing.Point(407, 211);
			this.Bulk.Name = "Bulk";
			this.Bulk.Size = new System.Drawing.Size(148, 120);
			this.Bulk.TabIndex = 11;
			this.Bulk.Click += new System.EventHandler(this.Bulk_Clicked);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(26, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "Bulk Shipment";
			this.label3.Click += new System.EventHandler(this.Bulk_Clicked);
			// 
			// Single
			// 
			this.Single.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Single.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.Single.Controls.Add(this.pictureBox1);
			this.Single.Controls.Add(this.label2);
			this.Single.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Single.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.Single.Location = new System.Drawing.Point(240, 211);
			this.Single.Name = "Single";
			this.Single.Size = new System.Drawing.Size(148, 120);
			this.Single.TabIndex = 10;
			this.Single.Click += new System.EventHandler(this.Single_Clicked);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(24, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Single Shipment";
			this.label2.Click += new System.EventHandler(this.Single_Clicked);
			// 
			// elInward
			// 
			this.elInward.ElipseRadius = 10;
			this.elInward.TargetControl = this.Single;
			// 
			// elOutward
			// 
			this.elOutward.ElipseRadius = 10;
			this.elOutward.TargetControl = this.Bulk;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 10;
			this.bunifuElipse1.TargetControl = this.Search;
			// 
			// Search
			// 
			this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.Search.Controls.Add(this.label4);
			this.Search.Controls.Add(this.pictureBox3);
			this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Search.Location = new System.Drawing.Point(573, 211);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(148, 120);
			this.Search.TabIndex = 12;
			this.Search.Click += new System.EventHandler(this.SearchDownload_Clicked);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(8, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "Search && Download";
			this.label4.Click += new System.EventHandler(this.SearchDownload_Clicked);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_download_52px;
			this.pictureBox3.Location = new System.Drawing.Point(35, 20);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(74, 64);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.SearchDownload_Clicked);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.bulk;
			this.pictureBox2.Location = new System.Drawing.Point(35, 20);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(74, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.Bulk_Clicked);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.single;
			this.pictureBox1.Location = new System.Drawing.Point(37, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(74, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.Single_Clicked);
			// 
			// Back
			// 
			this.Back.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Back.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.back;
			this.Back.Location = new System.Drawing.Point(0, 0);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(30, 30);
			this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Back.TabIndex = 8;
			this.Back.TabStop = false;
			this.toolTip1.SetToolTip(this.Back, "Back to Main Page");
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// UC_Inward
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.Navbar);
			this.Name = "UC_Inward";
			this.Size = new System.Drawing.Size(958, 528);
			this.Load += new System.EventHandler(this.UC_Inward_Load);
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			this.Canva.ResumeLayout(false);
			this.Canva.PerformLayout();
			this.Bulk.ResumeLayout(false);
			this.Bulk.PerformLayout();
			this.Single.ResumeLayout(false);
			this.Single.PerformLayout();
			this.Search.ResumeLayout(false);
			this.Search.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.Label NavTitle;
		private System.Windows.Forms.PictureBox Back;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel Canva;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel Bulk;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel Single;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuElipse elInward;
		private Bunifu.Framework.UI.BunifuElipse elOutward;
		private System.Windows.Forms.Panel Search;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}
