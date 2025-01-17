﻿using System;
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

namespace InvoiceManager_DBFirst
{
    internal static class BitmapResourceLoader
    {
        private static Assembly _assembly;
        private static string _resourceStreamPrefix = "InvoiceManager_DBFirst.assets";

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

        public static Bitmap Person
        {
            get { return _getBitmap("person.png"); }
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
