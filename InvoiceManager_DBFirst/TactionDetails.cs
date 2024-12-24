//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvoiceManager_DBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class TactionDetails
    {
        public int id { get; set; }
        public int TransactionId { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> ItemSubTypeId { get; set; }
        public decimal Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public int Vat { get; set; }
        public Nullable<decimal> DiscountRate { get; set; }
        public Nullable<decimal> DiscountedPrice { get; set; }
        public string Note { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual ItemSubType ItemSubType { get; set; }
        public virtual Taction Taction { get; set; }
    }
}
