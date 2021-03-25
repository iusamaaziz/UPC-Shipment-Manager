using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace UPCData.Library
{
	public static class Access
	{
		public static void ExecuteProcedure(string storedProcedure, SqlParameter[] parameters = null)
		{
			using (SqlConnection cnn = DB.SqlConnection)
			{
				SqlTransaction transaction = cnn.BeginTransaction("ExecuteProcedure");
				SqlCommand cmd = new SqlCommand(storedProcedure, cnn) { Transaction = transaction, CommandType = CommandType.StoredProcedure };
				if (parameters != null)
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

		/// <summary>
		/// Get a boolean value according to executed command
		/// </summary>
		/// <param name="command"></param>
		/// <param name=""></param>
		/// <param name="parameters"></param>
		/// <returns>returns false is result has now rows</returns>
		public static async Task<bool> GetBooleanAsync(string command, SqlParameter[] parameters = null)
		{
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						return reader.GetBoolean(0);
					}
				}
				else return false;
			}
			return false;
		}

		public static async Task<int> GetIntAsync(string command, SqlParameter[] parameters = null)
		{
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						return reader.GetInt32(0);
					}
				}
			}
			return -1;
		}

		public static async Task<AutoCompleteStringCollection> GetAutoCompleteStringCollectionAsync(string command, SqlParameter[] parameters = null)
		{
			AutoCompleteStringCollection col = new AutoCompleteStringCollection();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
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

		public static async Task<string[]> GetStringArrayAsync(string command, SqlParameter[] parameters = null)
		{
			List<string> col = new List<string>();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						col.Add(reader[0].ToString());
					}
				}
			}
			return col.ToArray();
		}

		public static async Task<DataTable> GetDataTableAsync(string command, SqlParameter[] parameters = null)
		{
			DataTable dt = new DataTable();
			using (SqlConnection cnn = await DB.GetSqlConnectionAsync())
			{
				SqlCommand cmd = new SqlCommand(command, cnn);
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dt);
			}
			return dt;
		}
	}
}
