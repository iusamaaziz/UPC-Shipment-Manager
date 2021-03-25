using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.UIManager.InventoryManager;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_PastPicklists : UserControl
	{
		public UC_PastPicklists()
		{
			InitializeComponent();
		}

		private async void UC_PastPicklists_Load(object sender, EventArgs e)
		{
			inventoryItemBindingSource.DataSource = await InventoryManager.GetPastPicklistsAsync();
		}
	}
}
