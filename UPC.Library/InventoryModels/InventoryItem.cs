using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Library.InventoryModels
{
	public class InventoryItem
	{
		public int Id { get; set; }

		public string ItemName { get; set; }

		public string Godown { get; set; }

		public string Quantity { get; set; }

		public string Remarks { get; set; }

		public DateTime TransactionDate { get; set; }

	}
}
