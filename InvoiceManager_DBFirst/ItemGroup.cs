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
    
    public partial class ItemGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemGroup()
        {
            this.Item = new HashSet<Item>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public int TopGroupId { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Item { get; set; }
        public virtual ItemTopGroup ItemTopGroup { get; set; }
    }
}
