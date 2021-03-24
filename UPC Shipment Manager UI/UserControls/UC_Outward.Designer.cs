
namespace UPC_Shipment_Manager_UI.UserControls
{
	partial class UC_Outward
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
			this.Minimize = new System.Windows.Forms.PictureBox();
			this.NavTitle = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Canva = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.Bulk = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.Single = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.elInward = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.elOutward = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.Navbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
			this.Canva.SuspendLayout();
			this.Bulk.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.Single.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Navbar
			// 
			this.Navbar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Navbar.Controls.Add(this.Minimize);
			this.Navbar.Controls.Add(this.NavTitle);
			this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.Navbar.Location = new System.Drawing.Point(0, 0);
			this.Navbar.Name = "Navbar";
			this.Navbar.Size = new System.Drawing.Size(958, 30);
			this.Navbar.TabIndex = 11;
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Minimize.Dock = System.Windows.Forms.DockStyle.Left;
			this.Minimize.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.back;
			this.Minimize.Location = new System.Drawing.Point(0, 0);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(30, 30);
			this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Minimize.TabIndex = 8;
			this.Minimize.TabStop = false;
			this.toolTip1.SetToolTip(this.Minimize, "Back");
			this.Minimize.Click += new System.EventHandler(this.Back_Click);
			// 
			// NavTitle
			// 
			this.NavTitle.AutoSize = true;
			this.NavTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.NavTitle.ForeColor = System.Drawing.Color.Black;
			this.NavTitle.Location = new System.Drawing.Point(34, 6);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(131, 19);
			this.NavTitle.TabIndex = 7;
			this.NavTitle.Text = "Outward Shipments";
			// 
			// Canva
			// 
			this.Canva.BackColor = System.Drawing.SystemColors.Control;
			this.Canva.Controls.Add(this.label1);
			this.Canva.Controls.Add(this.Bulk);
			this.Canva.Controls.Add(this.Single);
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(0, 0);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(958, 528);
			this.Canva.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(425, 185);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 19);
			this.label1.TabIndex = 12;
			this.label1.Text = "Shipment type:";
			// 
			// Bulk
			// 
			this.Bulk.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Bulk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.Bulk.Controls.Add(this.label3);
			this.Bulk.Controls.Add(this.pictureBox2);
			this.Bulk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Bulk.Location = new System.Drawing.Point(489, 224);
			this.Bulk.Name = "Bulk";
			this.Bulk.Size = new System.Drawing.Size(148, 120);
			this.Bulk.TabIndex = 11;
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
			// 
			// Single
			// 
			this.Single.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Single.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.Single.Controls.Add(this.pictureBox1);
			this.Single.Controls.Add(this.label2);
			this.Single.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Single.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.Single.Location = new System.Drawing.Point(322, 224);
			this.Single.Name = "Single";
			this.Single.Size = new System.Drawing.Size(148, 120);
			this.Single.TabIndex = 10;
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
			// UC_Outward
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Navbar);
			this.Controls.Add(this.Canva);
			this.Name = "UC_Outward";
			this.Size = new System.Drawing.Size(958, 528);
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
			this.Canva.ResumeLayout(false);
			this.Canva.PerformLayout();
			this.Bulk.ResumeLayout(false);
			this.Bulk.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.Single.ResumeLayout(false);
			this.Single.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Minimize;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label NavTitle;
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
	}
}
