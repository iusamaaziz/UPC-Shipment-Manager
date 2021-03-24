
namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	partial class UC_InventoryManager
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
			this.MenuBar = new System.Windows.Forms.Panel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Canva = new System.Windows.Forms.Panel();
			this.Reports = new FontAwesome.Sharp.IconButton();
			this.InventoryOut = new FontAwesome.Sharp.IconButton();
			this.InventoryIn = new FontAwesome.Sharp.IconButton();
			this.Back = new System.Windows.Forms.PictureBox();
			this.Navbar.SuspendLayout();
			this.MenuBar.SuspendLayout();
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
			this.Navbar.TabIndex = 1;
			// 
			// NavTitle
			// 
			this.NavTitle.AutoSize = true;
			this.NavTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.NavTitle.ForeColor = System.Drawing.Color.Black;
			this.NavTitle.Location = new System.Drawing.Point(35, 6);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(158, 19);
			this.NavTitle.TabIndex = 7;
			this.NavTitle.Text = "UPC Inventory Manager";
			// 
			// MenuBar
			// 
			this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.MenuBar.Controls.Add(this.Reports);
			this.MenuBar.Controls.Add(this.InventoryOut);
			this.MenuBar.Controls.Add(this.InventoryIn);
			this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuBar.Location = new System.Drawing.Point(0, 30);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(157, 498);
			this.MenuBar.TabIndex = 2;
			// 
			// Canva
			// 
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(157, 30);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 498);
			this.Canva.TabIndex = 3;
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
			// InventoryOut
			// 
			this.InventoryOut.Dock = System.Windows.Forms.DockStyle.Top;
			this.InventoryOut.FlatAppearance.BorderSize = 0;
			this.InventoryOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.InventoryOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InventoryOut.ForeColor = System.Drawing.Color.White;
			this.InventoryOut.IconChar = FontAwesome.Sharp.IconChar.None;
			this.InventoryOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.InventoryOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.InventoryOut.IconSize = 30;
			this.InventoryOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.InventoryOut.Location = new System.Drawing.Point(0, 37);
			this.InventoryOut.Name = "InventoryOut";
			this.InventoryOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.InventoryOut.Size = new System.Drawing.Size(157, 37);
			this.InventoryOut.TabIndex = 20;
			this.InventoryOut.Text = "Inventory Out";
			this.InventoryOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.InventoryOut.UseVisualStyleBackColor = true;
			this.InventoryOut.Click += new System.EventHandler(this.InventoryOut_Click);
			// 
			// InventoryIn
			// 
			this.InventoryIn.Dock = System.Windows.Forms.DockStyle.Top;
			this.InventoryIn.FlatAppearance.BorderSize = 0;
			this.InventoryIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.InventoryIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InventoryIn.ForeColor = System.Drawing.Color.White;
			this.InventoryIn.IconChar = FontAwesome.Sharp.IconChar.None;
			this.InventoryIn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.InventoryIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.InventoryIn.IconSize = 30;
			this.InventoryIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.InventoryIn.Location = new System.Drawing.Point(0, 0);
			this.InventoryIn.Name = "InventoryIn";
			this.InventoryIn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.InventoryIn.Size = new System.Drawing.Size(157, 37);
			this.InventoryIn.TabIndex = 19;
			this.InventoryIn.Text = "Inventory In";
			this.InventoryIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.InventoryIn.UseVisualStyleBackColor = true;
			this.InventoryIn.Click += new System.EventHandler(this.InventoryIn_Click);
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
			// UC_InventoryManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.MenuBar);
			this.Controls.Add(this.Navbar);
			this.Name = "UC_InventoryManager";
			this.Size = new System.Drawing.Size(958, 528);
			this.Load += new System.EventHandler(this.UC_InventoryManager_Load);
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			this.MenuBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Back;
		private System.Windows.Forms.Label NavTitle;
		private System.Windows.Forms.Panel MenuBar;
		private FontAwesome.Sharp.IconButton InventoryIn;
		private FontAwesome.Sharp.IconButton Reports;
		private FontAwesome.Sharp.IconButton InventoryOut;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel Canva;
	}
}
