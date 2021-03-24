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
using UPC.UIManager.InventoryManager;

namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	public partial class UC_InventoryIn : UserControl
	{
		public UC_InventoryIn()
		{
			InitializeComponent();
		}

		private void Godown_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void UC_InventoryIn_Load(object sender, EventArgs e)
		{

		}

		private async void Register_Click(object sender, EventArgs e)
		{
			try
			{
				await InventoryManager.InsertInventoryIn(new InventoryItem());
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
