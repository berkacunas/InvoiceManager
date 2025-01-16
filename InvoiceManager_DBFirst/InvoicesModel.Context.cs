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
        public virtual DbSet<CashTransfer_tracking> CashTransfer_tracking { get; set; }
        public virtual DbSet<CurrencyMovement> CurrencyMovement { get; set; }
        public virtual DbSet<CurrencyMovement_tracking> CurrencyMovement_tracking { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Item_tracking> Item_tracking { get; set; }
        public virtual DbSet<ItemGroup> ItemGroup { get; set; }
        public virtual DbSet<ItemGroup_tracking> ItemGroup_tracking { get; set; }
        public virtual DbSet<ItemSubType> ItemSubType { get; set; }
        public virtual DbSet<ItemSubType_tracking> ItemSubType_tracking { get; set; }
        public virtual DbSet<ItemTopGroup> ItemTopGroup { get; set; }
        public virtual DbSet<ItemTopGroup_tracking> ItemTopGroup_tracking { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<PaymentMethod_tracking> PaymentMethod_tracking { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Person_tracking> Person_tracking { get; set; }
        public virtual DbSet<scope_info> scope_info { get; set; }
        public virtual DbSet<scope_info_client> scope_info_client { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<Seller_tracking> Seller_tracking { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Shop_tracking> Shop_tracking { get; set; }
        public virtual DbSet<ShopGroup> ShopGroup { get; set; }
        public virtual DbSet<ShopGroup_tracking> ShopGroup_tracking { get; set; }
        public virtual DbSet<ShopType> ShopType { get; set; }
        public virtual DbSet<ShopType_tracking> ShopType_tracking { get; set; }
        public virtual DbSet<Taction> Taction { get; set; }
        public virtual DbSet<Taction_tracking> Taction_tracking { get; set; }
        public virtual DbSet<TactionDetails> TactionDetails { get; set; }
        public virtual DbSet<TactionDetails_tracking> TactionDetails_tracking { get; set; }
    }
}