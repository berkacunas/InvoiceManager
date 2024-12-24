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
    
    public partial class Taction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Taction()
        {
            this.TactionDetails = new HashSet<TactionDetails>();
        }
    
        public int id { get; set; }
        public System.DateTime Dt { get; set; }
        public int ShopId { get; set; }
        public decimal TotalPrice { get; set; }
        public int PaymentMethodId { get; set; }
        public string No { get; set; }
        public Nullable<int> SellerId { get; set; }
        public Nullable<int> WhoDidIt { get; set; }
    
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Person Person { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual Shop Shop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TactionDetails> TactionDetails { get; set; }
    }
}
