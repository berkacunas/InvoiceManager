using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManager_DBFirst.Globals
{
    internal static class ImageHelper
    {
        public static Image ResizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            double nPercent = 0;
            double nPercentW = 0;
            double nPercentH = 0;

            // Calculate width and height with new desired size
            nPercentW = ((double)size.Width / (double)sourceWidth);
            nPercentH = ((double)size.Height / (double)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);

            // New Width and Height
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);

            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        public static byte[] GetBytesOfImage(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static Image GetImageFromBytes(byte[] imageData)
        {
            MemoryStream ms = new MemoryStream(imageData);
            return new Bitmap(ms);
        }
    }
}
