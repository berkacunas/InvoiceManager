using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManager_DBFirst
{
    internal class ItemsReport
    {
        //private Item _item;
        //private int _itemCount;
        //private decimal _totalPricePerItem;
        //private Shop[] _shops;

        public int ItemId { get; set; }

        public string ItemGroupName { get; set; }

        public string ItemName { get; set; }

        public decimal ItemCount { get; set; }

        public decimal TotalPricePerItem { get; set; }

        public List<Shop> Shops { get; set; }
    }
}
