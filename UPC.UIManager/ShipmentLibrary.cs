using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.Library.Models;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

using UPCData.Library;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace UPC.UIManager
{
	public class ShipmentLibrary
	{
		public static void InsertInwardSingleShipment(InwardSingleShipment si)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@date     ", si.Date),
				new SqlParameter("@tracking ", si.TrackingId),
				new SqlParameter("@courier  ", si.CourierName),
				new SqlParameter("@item     ", si.ItemName),
				new SqlParameter("@condition", si.ItemCondition),
				new SqlParameter("@remarks  ", si.Remarks),
				new SqlParameter("@type     ", si.ShipmentType),
				new SqlParameter("@customer ", si.CustomerName)
			};
			Access.ExecuteProcedure("[dbo].[InsertShipment]", parameters.ToArray());
		}

		public static void InsertCourierName(string name)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@name", name)
			};
			Access.ExecuteProcedure("[dbo].[InsertCourierName]", parameters.ToArray());
		}

		public static async Task<InwardSingleShipment[]> GetInwardShipmentsAsync()
		{
			return await Access.GetInwardSingleShipmentsAsync("SELECT * FROM [dbo].[GetInwardShipments]()");
		}

		public static async Task<InwardSingleShipment[]> GetOutwardShipmentsAsync()
		{
			return await Access.GetInwardSingleShipmentsAsync("SELECT * FROM [dbo].[GetOutwardShipments]()");
		}

		public static async Task<InwardSingleShipment[]> GetShipmentsByTrackingAsync(string id)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@id", id)
			};
			return await Access.GetInwardSingleShipmentsAsync("SELECT * FROM [dbo].[GetShipmentsByTracking](@id)", parameters.ToArray());
		}

		public static async Task<InwardSingleShipment[]> GetShipmentsAsync(DateTime start, DateTime end)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@start", start),
				new SqlParameter("@end", end)
			};
			return await Access.GetInwardSingleShipmentsAsync("SELECT * FROM [dbo].[GetShipmentsByDate](@start, @end)", parameters.ToArray());
		}

		public static async Task<string[]> GetCourierNamesAsync()
		{
			return await Access.GetStringArrayAsync("SELECT * FROM [dbo].[GetCourierNames]()");
		}

		public static async Task<bool> IsCourierNameExistsAsync(string godown)
		{
			SqlParameter[] parameters = { new SqlParameter("@name", godown) };
			return await Access.GetBooleanAsync("SELECT [dbo].[IsCourierNameExists](@name)", parameters);
		}

		public static async Task<AutoCompleteStringCollection> GetTrackingIdsAsync()
		{
			return await Access.GetAutoCompleteStringCollectionAsync("SELECT [TrackingId] FROM [dbo].[Shipment]");
		}

		public static async Task<bool> IsTrackingIdExistsAsync(string godown)
		{
			SqlParameter[] parameters = { new SqlParameter("@name", godown) };
			return await Access.GetBooleanAsync("SELECT [dbo].[IsTrackingExists](@name)", parameters);
		}
	}
}
