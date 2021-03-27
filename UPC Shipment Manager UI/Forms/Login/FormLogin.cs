using System;
using System.Windows.Forms;

using UPC.UIManager.UserManager;

namespace UPC_Shipment_Manager_UI.Forms.Login
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
			if (IsValid) Login.Enabled = true;
			else Login.Enabled = false;
		}

		private async void Login_Click(object sender, EventArgs e)
		{
			var result = await UserManager.GetUser(Username.Text, Password.Text);
			if (result == null)
			{
				MessageBox.Show("Invalid Username or Password.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			UPC.Library.LoginModels.Login.Id = result.Id;
			UPC.Library.LoginModels.Login.Username = result.Username;
			UPC.Library.LoginModels.Login.Password = result.Password;
			UPC.Library.LoginModels.Login.Role = result.Role;
			Dashboard dsh = new Dashboard();
			dsh.Show();
			this.Hide();
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Print_Click(object sender, EventArgs e)
		{
			using (FormConfiguration frm = new FormConfiguration())
			{
				frm.ShowDialog();
			}
		}
	}
}
