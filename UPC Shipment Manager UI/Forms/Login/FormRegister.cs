using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UPC.UIManager.UserManager;

namespace UPC_Shipment_Manager_UI.Forms.Login
{
	public partial class FormRegister : Form
	{
		public FormRegister()
		{
			InitializeComponent();
		}

		private bool IsValid
		{
			get
			{
				return (Username.TextLength > 0 && Password.TextLength > 0);
			}
		}

		private void Tb_TextChanged(object sender, EventArgs e)
		{
			if (IsValid) Register.Enabled = true;
			else Register.Enabled = false;
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Register_Click(object sender, EventArgs e)
		{
			try
			{
				UserManager.InsertUser(Username.Text, Password.Text, "Admin");
				MessageBox.Show($"Administrator was successfully registered.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				FormLogin login = new FormLogin();
				login.Show();
				this.Hide();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Could not register user due to:\nException type: {ex.GetType()}\nMessage: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
