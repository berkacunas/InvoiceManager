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
    
    public partial class ShopGroup_tracking
    {
        public int id { get; set; }
        public Nullable<System.Guid> update_scope_id { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<long> timestamp_bigint { get; set; }
        public bool sync_row_is_tombstone { get; set; }
        public Nullable<System.DateTime> last_change_datetime { get; set; }
    }
}
