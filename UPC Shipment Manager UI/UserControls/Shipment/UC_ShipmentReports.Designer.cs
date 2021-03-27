
namespace UPC_Shipment_Manager_UI.UserControls.Shipment
{
	partial class UC_ShipmentReports
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
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Canva = new System.Windows.Forms.Panel();
			this.Report = new System.Windows.Forms.ToolStripButton();
			this.Search = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report,
            this.toolStripSeparator1,
            this.Search});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(801, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// Canva
			// 
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(0, 25);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 473);
			this.Canva.TabIndex = 2;
			// 
			// Report
			// 
			this.Report.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_report_file_24px_2;
			this.Report.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Report.Name = "Report";
			this.Report.Size = new System.Drawing.Size(121, 22);
			this.Report.Text = "Shipment Reports";
			this.Report.Click += new System.EventHandler(this.Report_Click);
			// 
			// Search
			// 
			this.Search.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_search_property_26px;
			this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(122, 22);
			this.Search.Text = "Search Tracking Id";
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// UC_ShipmentReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.toolStrip1);
			this.Name = "UC_ShipmentReports";
			this.Size = new System.Drawing.Size(801, 498);
			this.Load += new System.EventHandler(this.UC_ShipmentReports_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton Report;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton Search;
		private System.Windows.Forms.Panel Canva;
	}
}
