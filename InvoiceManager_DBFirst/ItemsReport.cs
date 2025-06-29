using System.Collections.Generic;

using mayacs;


namespace InvoiceManager_DBFirst
{
    internal class ItemsReport
    {
        //private Item _item;
        //private int _itemCount;
        //private decimal _totalPricePerItem;
        //private Shop[] _shops;

        public int ItemId { get; set; }

        public int? ItemSubTypeId { get; set; }

        public int ItemGroupId { get; set; }

        public string ItemGroupName { get; set; }

        public string ItemName { get; set; }

        public string ItemSubTypeName { get; set; }

        public decimal? ItemUnit { get; set; }

        public decimal TotalPricePerItem { get; set; }

        public List<Shop> Shops { get; set; }

        public ItemsReport(TactionDetails detail)
        {
            this.ItemId = detail.ItemId;
            this.ItemGroupId = detail.Item.GroupId;
            this.ItemSubTypeId = detail.ItemSubTypeId;
            this.ItemGroupName = detail.Item.ItemGroup.Name;
            this.ItemName = detail.Item.Name;

            if (detail.ItemSubType != null)
                this.ItemSubTypeName = detail.ItemSubType.Name;

            this.ItemUnit = detail.Unit;
            this.TotalPricePerItem = (detail.DiscountedPrice != null) ? detail.DiscountedPrice.Value : detail.Unit * detail.UnitPrice;
        }

        public void IncreaseItemUnit(decimal unit)
        {
            this.ItemUnit += unit;
        }

        public void IncreaseTotalPricePerItem(decimal price)
        {
            this.TotalPricePerItem += price;
        }

        public void FormatItemUnit()
        {
            this.ItemUnit = (MayaMath.isInteger(this.ItemUnit.Value)) ? System.Math.Round(this.ItemUnit.Value) : this.ItemUnit;
        }

        public void FormatTotalPricePerItem()
        {
            this.TotalPricePerItem = this.formatPrice(this.TotalPricePerItem);
        }

        private decimal formatPrice(decimal price)
        {
            return System.Math.Round(price, 2);
        }
    }
}
