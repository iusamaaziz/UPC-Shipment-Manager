using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
