using System;
using System.Windows.Forms;

using UPC.Library.InventoryModels;

namespace UPC_Shipment_Manager_UI.Reporting
{
	public partial class FormPicklistPrintout : Form
	{
		InventoryItem[] Items;
		public FormPicklistPrintout(InventoryItem[] items)
		{
			InitializeComponent();
			Items = items;
		}

		private void FormPicklistPrintout_Load(object sender, EventArgs e)
		{
			InventoryItemBindingSource.DataSource = Items;
			this.reportViewer1.RefreshReport();
		}
	}
}
