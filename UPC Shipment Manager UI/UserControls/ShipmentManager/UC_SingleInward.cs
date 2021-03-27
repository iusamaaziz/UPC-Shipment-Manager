using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.UIManager;

namespace UPC_Shipment_Manager_UI.UserControls
{
	public partial class UC_SingleInward : UserControl
	{
		public UC_SingleInward()
		{
			InitializeComponent();
		}

		private bool IsValid
		{
			get
			{
				return (TrackingId.TextLength > 0 && ItemName.TextLength > 0 && CourierName.Text.Length > 0 && ItemCondition.Text.Length > 0);
			}
		}

		private void Tb_TextChanged(object sender, EventArgs e)
		{
			if (IsValid) Register.Enabled = true;
			else Register.Enabled = false;
		}

		private void UC_SingleInward_Load(object sender, EventArgs e)
		{
			//Date.Text = DateTime.Now.ToString();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			GeneralManager.ExportDataGrid(dg);
		}

		private void Register_Click(object sender, EventArgs e)
		{
			//Ship
		}
	}
}
