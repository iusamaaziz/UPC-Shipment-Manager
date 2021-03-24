using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC_Shipment_Manager_UI.Forms;

namespace UPC_Shipment_Manager_UI.UserControls
{
	public partial class UC_Inward : UserControl
	{
		// TODO -- make instances of shipment controls
		//UC_SingleInward single;

		public UC_Inward()
		{
			InitializeComponent();
		}

		private void ActivateControl(UserControl c)
		{
			Canva.Controls.Clear();
			c.Dock = DockStyle.Fill;
			Canva.Controls.Add(c);
		}

		public void ActivateInitials()
		{
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(425, 170);
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
			this.Bulk.Location = new System.Drawing.Point(489, 209);
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
			this.Single.Location = new System.Drawing.Point(322, 209);
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

			this.ParentForm.WindowState = FormWindowState.Normal;
		}

		private void Single_Clicked(object sender, EventArgs e)
		{
			NavTitle.Text = "Inward Shipments → Single shipment";
			ActivateControl(new UC_SingleInward());
		}

		private void Bulk_Clicked(object sender, EventArgs e)
		{
			NavTitle.Text = "Inward Shipments → Bulk shipment";
			ActivateControl(new UC_BulkInward());
		}

		private void SearchDownload_Clicked(object sender, EventArgs e)
		{
			NavTitle.Text = "Inward Shipments → Search and Export Inward Shipments";
			ActivateControl(new UC_SearchInward());
		}

		private void Back_Click(object sender, EventArgs e)
		{
			(this.ParentForm as Dashboard).ActivateInitials();
		}

		private void UC_Inward_Load(object sender, EventArgs e)
		{

		}
	}
}
