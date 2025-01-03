using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.DatabaseSynchronization
{
    internal static class Config
    {
        private static string _sqlProvider = @"Data Source=.;Initial Catalog=Invoices;Integrated Security=True;Trust Server Certificate=True;";
        private static string _mysqlProvider = "";
        private static string _sqliteProvider = @"C:\berk\Documents\Databases\Invoices\Invoices2.db";
        private static string[] _syncSetupTables = new string[] {
            "CashTransfer",
            "CurrencyMovement",
            "Item",
            "ItemGroup",
            "ItemTopGroup",
            "ItemSubType",
            "PaymentMethod",
            "Person",
            "Seller",
            "Shop",
            "ShopGroup",
            "ShopType",
            "Taction",
            "TactionDetails"
        };

        public static string SqliteProvider
        {
            get { return _sqliteProvider; }
        }

        public static string SqlProvider
        {
            get { return _sqlProvider; }
        }

        public static string MySQLProvider
        {
            get { return _mysqlProvider; }
        }

        public static string[] SyncSetupTables
        { 
            get { return _syncSetupTables; } 
        }
    }
}
