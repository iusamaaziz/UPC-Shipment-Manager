
namespace UPC_Shipment_Manager_UI.UserControls.CRM
{
	partial class UC_CRM
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
			this.MenuBar = new System.Windows.Forms.Panel();
			this.SearchEntry = new FontAwesome.Sharp.IconButton();
			this.NewEntry = new FontAwesome.Sharp.IconButton();
			this.Canva = new System.Windows.Forms.Panel();
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
			this.Navbar.TabIndex = 2;
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
			this.NavTitle.Location = new System.Drawing.Point(35, 6);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(70, 19);
			this.NavTitle.TabIndex = 7;
			this.NavTitle.Text = "UPC CRM";
			// 
			// MenuBar
			// 
			this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.MenuBar.Controls.Add(this.SearchEntry);
			this.MenuBar.Controls.Add(this.NewEntry);
			this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuBar.Location = new System.Drawing.Point(0, 30);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(157, 498);
			this.MenuBar.TabIndex = 3;
			// 
			// SearchEntry
			// 
			this.SearchEntry.Dock = System.Windows.Forms.DockStyle.Top;
			this.SearchEntry.FlatAppearance.BorderSize = 0;
			this.SearchEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SearchEntry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchEntry.ForeColor = System.Drawing.Color.White;
			this.SearchEntry.IconChar = FontAwesome.Sharp.IconChar.None;
			this.SearchEntry.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.SearchEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.SearchEntry.IconSize = 30;
			this.SearchEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SearchEntry.Location = new System.Drawing.Point(0, 37);
			this.SearchEntry.Name = "SearchEntry";
			this.SearchEntry.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.SearchEntry.Size = new System.Drawing.Size(157, 37);
			this.SearchEntry.TabIndex = 20;
			this.SearchEntry.Text = "Search Entry";
			this.SearchEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SearchEntry.UseVisualStyleBackColor = true;
			this.SearchEntry.Click += new System.EventHandler(this.SearchEntry_Click);
			// 
			// NewEntry
			// 
			this.NewEntry.Dock = System.Windows.Forms.DockStyle.Top;
			this.NewEntry.FlatAppearance.BorderSize = 0;
			this.NewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NewEntry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewEntry.ForeColor = System.Drawing.Color.White;
			this.NewEntry.IconChar = FontAwesome.Sharp.IconChar.None;
			this.NewEntry.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NewEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.NewEntry.IconSize = 30;
			this.NewEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.NewEntry.Location = new System.Drawing.Point(0, 0);
			this.NewEntry.Name = "NewEntry";
			this.NewEntry.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.NewEntry.Size = new System.Drawing.Size(157, 37);
			this.NewEntry.TabIndex = 19;
			this.NewEntry.Text = "New Entry";
			this.NewEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.NewEntry.UseVisualStyleBackColor = true;
			this.NewEntry.Click += new System.EventHandler(this.NewEntry_Click);
			// 
			// Canva
			// 
			this.Canva.BackColor = System.Drawing.Color.White;
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(157, 30);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 498);
			this.Canva.TabIndex = 4;
			// 
			// UC_CRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.MenuBar);
			this.Controls.Add(this.Navbar);
			this.Name = "UC_CRM";
			this.Size = new System.Drawing.Size(958, 528);
			this.Load += new System.EventHandler(this.UC_CRM_Load);
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			this.MenuBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Back;
		public System.Windows.Forms.Label NavTitle;
		private System.Windows.Forms.Panel MenuBar;
		private FontAwesome.Sharp.IconButton SearchEntry;
		private FontAwesome.Sharp.IconButton NewEntry;
		private System.Windows.Forms.Panel Canva;
	}
}
