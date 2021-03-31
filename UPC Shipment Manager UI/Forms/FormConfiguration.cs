using System;
using System.Configuration;
using System.Windows.Forms;

using UPC.UIManager;

namespace UPC_Shipment_Manager_UI.Forms
{
	public partial class FormConfiguration : Form
	{
		public FormConfiguration()
		{
			InitializeComponent();
		}

		private bool IsValid
		{
			get
			{
				if (!LocalHost.Checked)
					return (tbServer.TextLength > 0 && tbUser.TextLength > 0 && tbPassword.TextLength > 0);
				return (tbServer.TextLength > 0);
			}
		}

		private void Tb_TextChanged(object sender, EventArgs e)
		{
			if (IsValid) Connect.Enabled = true;
			else Connect.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Connect_Click(object sender, EventArgs e)
		{
			Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			if (!LocalHost.Checked)
			{
				configuration.ConnectionStrings.ConnectionStrings["Database"].ConnectionString = $"Data Source={tbServer.Text};Network Library=DBMSSOCN;Initial Catalog=UPCShipmentManager;Integrated Security=false;User ID={tbUser.Text};Password={tbPassword.Text};";
			}
			else
			{
				configuration.ConnectionStrings.ConnectionStrings["Database"].ConnectionString = $"Server={tbServer.Text};Database=UPCShipmentManager;Trusted_Connection=True;";
			}
			if (GeneralManager.IsConnected)
			{
				configuration.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection("connectionStrings");
				MessageBox.Show("You were successfully connected to SQL server.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}

		private void LocalHost_CheckedChanged(object sender, EventArgs e)
		{
			if (LocalHost.Checked)
			{
				tbUser.Enabled = false;
				tbPassword.Enabled = false;
				tbUser.Clear();
				tbPassword.Clear();
			}
			else
			{
				tbUser.Enabled = true;
				tbPassword.Enabled = true;
			}
		}
	}
}
