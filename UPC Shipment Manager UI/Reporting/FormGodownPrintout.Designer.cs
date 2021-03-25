
namespace UPC_Shipment_Manager_UI.Reporting
{
	partial class FormGodownPrintout
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.InventoryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.InventoryItemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "UPC_Shipment_Manager_UI.Reporting.GodownStockPrintout.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(800, 525);
			this.reportViewer1.TabIndex = 0;
			// 
			// InventoryItemBindingSource
			// 
			this.InventoryItemBindingSource.DataSource = typeof(UPC.Library.InventoryModels.InventoryItem);
			// 
			// FormGodownPrintout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 525);
			this.Controls.Add(this.reportViewer1);
			this.Name = "FormGodownPrintout";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Godown Stock - Printout";
			this.Load += new System.EventHandler(this.FormGodownPrintout_Load);
			((System.ComponentModel.ISupportInitialize)(this.InventoryItemBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource InventoryItemBindingSource;
	}
}