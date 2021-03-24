using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPCData.Library
{
	public static class DB
	{
		public static async Task<SqlConnection> GetSqlConnectionAsync()
		{
			SqlConnection cnn = new SqlConnection(ConnectionString);
			await cnn.OpenAsync();
			return cnn;
		}

		public static SqlConnection SqlConnection
		{
			get
			{
				SqlConnection cnn = new SqlConnection(ConnectionString);
				cnn.Open();
				return cnn;
			}
		}

		public static string ConnectionString
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
			}
		}

	}
}
