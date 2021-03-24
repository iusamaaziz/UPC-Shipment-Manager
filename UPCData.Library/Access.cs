using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UPCData.Library
{
	public static class Access
	{
		public static void ExecuteProcedure(string storedProcedure, SqlParameter[] parameters = null)
		{
			using (SqlConnection cnn = DB.SqlConnection)
			{
				SqlTransaction transaction = cnn.BeginTransaction("ExecuteProcedure");
				SqlCommand cmd = new SqlCommand(storedProcedure, cnn) { Transaction = transaction };
				cmd.Parameters.AddRange(parameters);
				try
				{
					cmd.ExecuteNonQuery();
					transaction.Commit();
				}
				catch (Exception ex)
				{
					try
					{
						Console.WriteLine($"Commit Exception Type {ex.GetType()}");
						Console.WriteLine($"Commit Exception Message {ex.Message}");
						transaction.Rollback();
					}
					catch (Exception ex1)
					{
						Console.WriteLine($"Rollback Exception Type {ex1.GetType()}");
						Console.WriteLine($"Rollback Exception Message {ex1.Message}");
						throw ex1;
					}
				}
			}
		}

		public static async Task<AutoCompleteStringCollection> GetAutoCompleteStringCollectionAsync(string command, SqlParameter[] parameters)
		{
			AutoCompleteStringCollection col = new AutoCompleteStringCollection();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						col.Add(reader[0].ToString());
					}
				}
			}
			return col;
		}

	}
}
