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

namespace InvoiceManager_DBFirst
{
    internal static class BitmapResourceLoader
    {
        private static Assembly _assembly;
        private static string _resourceStreamPrefix = "InvoiceManager_DBFirst.assets";

        public static Bitmap PaymentMethod
        {
            get 
            {
                Stream stream = _assembly.GetManifestResourceStream($"{_resourceStreamPrefix}.payment-method.png");
                return new Bitmap(stream);
            }
        }

        public static Bitmap Item
        {
            get
            {
                string path = $"{_resourceStreamPrefix}.item.png";
                Stream stream = _assembly.GetManifestResourceStream(path);
                return new Bitmap(stream);
            }
        }

        public static Bitmap Seller
        {
            get
            {
                Stream stream = _assembly.GetManifestResourceStream($"{_resourceStreamPrefix}.seller.png");
                return new Bitmap(stream);
            }
        }

        public static Bitmap Shop
        {
            get
            {
                Stream stream = _assembly.GetManifestResourceStream($"{_resourceStreamPrefix}.shop.png");
                return new Bitmap(stream);
            }
        }

        static BitmapResourceLoader() 
        {
            _assembly = Assembly.GetExecutingAssembly();
        }
    }
}
