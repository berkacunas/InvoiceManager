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
    
    public partial class CardTactionDetails
    {
        public int id { get; set; }
        public int CardTactionId { get; set; }
        public int OperationTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
    
        public virtual CardTactionOperationType CardTactionOperationType { get; set; }
    }
}
