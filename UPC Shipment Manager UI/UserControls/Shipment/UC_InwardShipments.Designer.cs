
namespace UPC_Shipment_Manager_UI.UserControls.ShipmentManager
{
	partial class UC_InwardShipments
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
			this.Canva = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.SingleShipments = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.GodownStock = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Canva
			// 
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(0, 25);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 473);
			this.Canva.TabIndex = 3;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SingleShipments,
            this.toolStripSeparator1,
            this.GodownStock,
            this.toolStripSeparator2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(801, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// SingleShipments
			// 
			this.SingleShipments.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.single;
			this.SingleShipments.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SingleShipments.Name = "SingleShipments";
			this.SingleShipments.Size = new System.Drawing.Size(118, 22);
			this.SingleShipments.Text = "Single Shipments";
			this.SingleShipments.Click += new System.EventHandler(this.SingleShipments_Click);
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
			this.GodownStock.Size = new System.Drawing.Size(109, 22);
			this.GodownStock.Text = "Bulk Shipments";
			this.GodownStock.Click += new System.EventHandler(this.GodownStock_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// UC_InwardShipments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.toolStrip1);
			this.Name = "UC_InwardShipments";
			this.Size = new System.Drawing.Size(801, 498);
			this.Load += new System.EventHandler(this.UC_InwardShipments_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel Canva;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton SingleShipments;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton GodownStock;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}
