using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UPC.Library.LoginModels;

using UPCData.Library;

namespace UPC.UIManager.UserManager
{
	public class UserManager
	{
		public static async Task<User> GetUser(string username, string password)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@name", username),
				new SqlParameter("@pass", password)
			};
			return await Access.GetUserAsync("SELECT * FROM [dbo].[GetUserForLogin](@name, @pass)", parameters.ToArray());
		}

		public static void InsertUser(string username, string password, string role)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@name", username),
				new SqlParameter("@pass", password),
				new SqlParameter("@role", role)
			};
			Access.ExecuteProcedure("[dbo].[InsertUser]", parameters.ToArray());
		}

		public static int GetUserCount()
		{
			return Access.GetInt("SELECT [dbo].[GetUserCount]()");
		}
	}
}
