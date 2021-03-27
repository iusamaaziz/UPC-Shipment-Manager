
namespace UPC_Shipment_Manager_UI.UserControls.ShipmentManager
{
	partial class UC_ShipmentManager
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
			this.Navbar = new System.Windows.Forms.Panel();
			this.Back = new System.Windows.Forms.PictureBox();
			this.NavTitle = new System.Windows.Forms.Label();
			this.Canva = new System.Windows.Forms.Panel();
			this.MenuBar = new System.Windows.Forms.Panel();
			this.Reports = new FontAwesome.Sharp.IconButton();
			this.Outward = new FontAwesome.Sharp.IconButton();
			this.Inward = new FontAwesome.Sharp.IconButton();
			this.Navbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
			this.MenuBar.SuspendLayout();
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
			this.Navbar.TabIndex = 10;
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
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// NavTitle
			// 
			this.NavTitle.AutoSize = true;
			this.NavTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.NavTitle.ForeColor = System.Drawing.Color.Black;
			this.NavTitle.Location = new System.Drawing.Point(34, 6);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(126, 19);
			this.NavTitle.TabIndex = 7;
			this.NavTitle.Text = "Shipment Manager";
			// 
			// Canva
			// 
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(157, 30);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 498);
			this.Canva.TabIndex = 12;
			// 
			// MenuBar
			// 
			this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.MenuBar.Controls.Add(this.Reports);
			this.MenuBar.Controls.Add(this.Outward);
			this.MenuBar.Controls.Add(this.Inward);
			this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuBar.Location = new System.Drawing.Point(0, 30);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(157, 498);
			this.MenuBar.TabIndex = 11;
			// 
			// Reports
			// 
			this.Reports.Dock = System.Windows.Forms.DockStyle.Top;
			this.Reports.FlatAppearance.BorderSize = 0;
			this.Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Reports.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Reports.ForeColor = System.Drawing.Color.White;
			this.Reports.IconChar = FontAwesome.Sharp.IconChar.None;
			this.Reports.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Reports.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.Reports.IconSize = 30;
			this.Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Reports.Location = new System.Drawing.Point(0, 74);
			this.Reports.Name = "Reports";
			this.Reports.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.Reports.Size = new System.Drawing.Size(157, 37);
			this.Reports.TabIndex = 21;
			this.Reports.Text = "Reports";
			this.Reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Reports.UseVisualStyleBackColor = true;
			this.Reports.Click += new System.EventHandler(this.Reports_Click);
			// 
			// Outward
			// 
			this.Outward.Dock = System.Windows.Forms.DockStyle.Top;
			this.Outward.FlatAppearance.BorderSize = 0;
			this.Outward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Outward.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Outward.ForeColor = System.Drawing.Color.White;
			this.Outward.IconChar = FontAwesome.Sharp.IconChar.None;
			this.Outward.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Outward.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.Outward.IconSize = 30;
			this.Outward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Outward.Location = new System.Drawing.Point(0, 37);
			this.Outward.Name = "Outward";
			this.Outward.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.Outward.Size = new System.Drawing.Size(157, 37);
			this.Outward.TabIndex = 20;
			this.Outward.Text = "Outward";
			this.Outward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Outward.UseVisualStyleBackColor = true;
			this.Outward.Click += new System.EventHandler(this.Outward_Click);
			// 
			// Inward
			// 
			this.Inward.Dock = System.Windows.Forms.DockStyle.Top;
			this.Inward.FlatAppearance.BorderSize = 0;
			this.Inward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Inward.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Inward.ForeColor = System.Drawing.Color.White;
			this.Inward.IconChar = FontAwesome.Sharp.IconChar.None;
			this.Inward.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Inward.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.Inward.IconSize = 30;
			this.Inward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Inward.Location = new System.Drawing.Point(0, 0);
			this.Inward.Name = "Inward";
			this.Inward.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.Inward.Size = new System.Drawing.Size(157, 37);
			this.Inward.TabIndex = 19;
			this.Inward.Text = "Inward";
			this.Inward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Inward.UseVisualStyleBackColor = true;
			this.Inward.Click += new System.EventHandler(this.Inward_Click);
			// 
			// UC_ShipmentManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.MenuBar);
			this.Controls.Add(this.Navbar);
			this.Name = "UC_ShipmentManager";
			this.Size = new System.Drawing.Size(958, 528);
			this.Load += new System.EventHandler(this.UC_ShipmentManager_Load);
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			this.MenuBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Back;
		private System.Windows.Forms.Panel Canva;
		private System.Windows.Forms.Panel MenuBar;
		private FontAwesome.Sharp.IconButton Reports;
		private FontAwesome.Sharp.IconButton Outward;
		private FontAwesome.Sharp.IconButton Inward;
		public System.Windows.Forms.Label NavTitle;
	}
}
