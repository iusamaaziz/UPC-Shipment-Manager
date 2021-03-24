
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
			this.components = new System.ComponentModel.Container();
			this.label = new System.Windows.Forms.Label();
			this.Outward = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.Inward = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.elInward = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.elOutward = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.Navbar = new System.Windows.Forms.Panel();
			this.Back = new System.Windows.Forms.PictureBox();
			this.NavTitle = new System.Windows.Forms.Label();
			this.Outward.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.Inward.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Navbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label.ForeColor = System.Drawing.Color.Black;
			this.label.Location = new System.Drawing.Point(367, 185);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(221, 19);
			this.label.TabIndex = 9;
			this.label.Text = "Please select an option to proceed:";
			// 
			// Outward
			// 
			this.Outward.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Outward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.Outward.Controls.Add(this.label3);
			this.Outward.Controls.Add(this.pictureBox2);
			this.Outward.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Outward.Location = new System.Drawing.Point(489, 223);
			this.Outward.Name = "Outward";
			this.Outward.Size = new System.Drawing.Size(148, 120);
			this.Outward.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(44, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "Outward";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_external_60px;
			this.pictureBox2.Location = new System.Drawing.Point(35, 20);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(74, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// Inward
			// 
			this.Inward.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Inward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.Inward.Controls.Add(this.pictureBox1);
			this.Inward.Controls.Add(this.label2);
			this.Inward.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Inward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.Inward.Location = new System.Drawing.Point(322, 223);
			this.Inward.Name = "Inward";
			this.Inward.Size = new System.Drawing.Size(148, 120);
			this.Inward.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_internal_60px;
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
			this.label2.Location = new System.Drawing.Point(49, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Inward";
			// 
			// elInward
			// 
			this.elInward.ElipseRadius = 10;
			this.elInward.TargetControl = this.Inward;
			// 
			// elOutward
			// 
			this.elOutward.ElipseRadius = 10;
			this.elOutward.TargetControl = this.Outward;
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
			// UC_ShipmentManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Navbar);
			this.Controls.Add(this.label);
			this.Controls.Add(this.Outward);
			this.Controls.Add(this.Inward);
			this.Name = "UC_ShipmentManager";
			this.Size = new System.Drawing.Size(958, 528);
			this.Outward.ResumeLayout(false);
			this.Outward.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.Inward.ResumeLayout(false);
			this.Inward.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel Outward;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel Inward;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuElipse elInward;
		private Bunifu.Framework.UI.BunifuElipse elOutward;
		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Back;
		private System.Windows.Forms.Label NavTitle;
	}
}
