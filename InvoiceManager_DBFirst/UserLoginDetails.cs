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
    
    public partial class UserLoginDetails
    {
        public int id { get; set; }
        public int UserLoginId { get; set; }
        public System.DateTime LoginDate { get; set; }
        public bool IsSuccess { get; set; }
        public int PasswordErrorCount { get; set; }
        public string LoginType { get; set; }
    
        public virtual UserLogin UserLogin { get; set; }
    }
}
