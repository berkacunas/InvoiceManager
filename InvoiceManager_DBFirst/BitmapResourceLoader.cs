using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    internal static class BitmapResourceLoader
    {
        private static Assembly _assembly;
        private static string _resourceStreamPrefix = "InvoiceManager_DBFirst.assets";

        public static Bitmap AppIcon
        {
            get { return _getBitmap("appicon.png"); }
        }

        public static Bitmap Transaction
        {
            get { return _getBitmap("transaction.png"); }
        }

        public static Bitmap PaymentMethod
        {
            get { return _getBitmap("payment-method.png"); }
        }

        public static Bitmap Item
        {
            get { return _getBitmap("item.png"); }
        }

        public static Bitmap Seller
        {
            get { return _getBitmap("seller.png"); }
        }

        public static Bitmap Shop
        {
            get { return _getBitmap("shop.png"); }
        }

        public static Bitmap User
        {
            get { return _getBitmap("user.png"); }
        }

        public static Bitmap Sqlite
        {
            get { return _getBitmap("sqlite.png"); }
        }

        public static Bitmap Sync
        {
            get { return _getBitmap("sync.png"); }
        }

        public static Bitmap Loop
        {
            get { return _getBitmap("loop.png"); }
        }

        public static Bitmap Exit
        {
            get { return _getBitmap("exit.png"); }
        }

        public static Bitmap PowerOff
        {
            get { return _getBitmap("power-off.png"); }
        }

        public static Bitmap ShoppingBag
        {
            get { return _getBitmap("shopping-bag.png"); }
        }

        public static Bitmap Groceries
        {
            get { return _getBitmap("groceries.png"); }
        }

        public static Bitmap DefaultUser
        {
            get { return _getBitmap("empty-image.png"); }
        }

        static BitmapResourceLoader() 
        {
            _assembly = Assembly.GetExecutingAssembly();
        }

        private static Bitmap _getBitmap(string resource)
        {
            Stream stream = _assembly.GetManifestResourceStream($"{_resourceStreamPrefix}.{resource}");
            return new Bitmap(stream);
        }
    }
}
