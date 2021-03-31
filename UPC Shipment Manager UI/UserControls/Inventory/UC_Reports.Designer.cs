
namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	partial class UC_Reports
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ItemReports = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.GodownStock = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.PastPicklists = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.Canva = new System.Windows.Forms.Panel();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemReports,
            this.toolStripSeparator1,
            this.GodownStock,
            this.toolStripSeparator2,
            this.PastPicklists,
            this.toolStripSeparator3});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(801, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// ItemReports
			// 
			this.ItemReports.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_report_file_24px_2;
			this.ItemReports.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ItemReports.Name = "ItemReports";
			this.ItemReports.Size = new System.Drawing.Size(94, 22);
			this.ItemReports.Text = "Item Reports";
			this.ItemReports.Click += new System.EventHandler(this.ItemReports_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// GodownStock
			// 
			this.GodownStock.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_warehouse_24px;
			this.GodownStock.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.GodownStock.Name = "GodownStock";
			this.GodownStock.Size = new System.Drawing.Size(104, 22);
			this.GodownStock.Text = "Godown Stock";
			this.GodownStock.Click += new System.EventHandler(this.GodownStock_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// PastPicklists
			// 
			this.PastPicklists.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_list_16px;
			this.PastPicklists.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PastPicklists.Name = "PastPicklists";
			this.PastPicklists.Size = new System.Drawing.Size(94, 22);
			this.PastPicklists.Text = "Past Picklists";
			this.PastPicklists.Click += new System.EventHandler(this.PastPicklists_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// Canva
			// 
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(0, 25);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 473);
			this.Canva.TabIndex = 1;
			// 
			// UC_Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.toolStrip1);
			this.Name = "UC_Reports";
			this.Size = new System.Drawing.Size(801, 498);
			this.Load += new System.EventHandler(this.UC_Reports_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton ItemReports;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton GodownStock;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton PastPicklists;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.Panel Canva;
	}
}
