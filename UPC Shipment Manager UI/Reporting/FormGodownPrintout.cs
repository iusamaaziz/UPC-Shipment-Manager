using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;

using UPC.Library.InventoryModels;

namespace UPC_Shipment_Manager_UI.Reporting
{
	public partial class FormGodownPrintout : Form
	{
		public InventoryItem[] Items { get; set; }
		public string Godown { get; set; }

		public FormGodownPrintout(InventoryItem[] items, string godown)
		{
			InitializeComponent();
			Items = items;
			Godown = godown;
		}

		private void FormGodownPrintout_Load(object sender, EventArgs e)
		{
			List<ReportParameter> parameters = new List<ReportParameter>();
			parameters.Add(new ReportParameter("GodownName", Godown));
			reportViewer1.LocalReport.SetParameters(parameters);
			InventoryItemBindingSource.DataSource = Items;
			ReportDataSource ds2 = new ReportDataSource("GodownStockDataset", InventoryItemBindingSource);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(ds2);
			this.reportViewer1.RefreshReport();
		}
	}
}
