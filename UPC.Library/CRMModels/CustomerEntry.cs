using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Library.CRMModels
{
	public class CustomerEntry
	{
		public int Id { get; set; }

		public string CustomerName { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }

		public string MarketPlace { get; set; } = "";

		public string OrderNumber { get; set; } = "";

		public string OrderDate { get; set; } = "";

		public string Product { get; set; } = "";

		public string Query { get; set; }

		public string Action { get; set; }

		public string WhatsappMessage { get; set; }

		/// <summary>
		/// Open/Closed
		/// </summary>
		public string Status { get; set; } = "Open";

		/// <summary>
		/// New/Existing
		/// </summary>
		public string Type { get; set; } = "New";
	}
}
