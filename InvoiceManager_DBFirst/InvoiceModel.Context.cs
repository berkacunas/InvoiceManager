﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InvoicesEntities : DbContext
    {
        public InvoicesEntities()
            : base("name=InvoicesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BankCard> BankCard { get; set; }
        public virtual DbSet<CashTransfer> CashTransfer { get; set; }
        public virtual DbSet<CurrencyMovement> CurrencyMovement { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemGroup> ItemGroup { get; set; }
        public virtual DbSet<ItemSubType> ItemSubType { get; set; }
        public virtual DbSet<ItemTopGroup> ItemTopGroup { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<ShopGroup> ShopGroup { get; set; }
        public virtual DbSet<ShopType> ShopType { get; set; }
        public virtual DbSet<Taction> Taction { get; set; }
        public virtual DbSet<TactionDetails> TactionDetails { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserImage> UserImage { get; set; }
        public virtual DbSet<ItemSubTypeDetails> ItemSubTypeDetails { get; set; }
        public virtual DbSet<AppLog> AppLog { get; set; }
        public virtual DbSet<AppLogActionType> AppLogActionType { get; set; }
    }
}
