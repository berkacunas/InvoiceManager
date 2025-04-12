using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManager_DBFirst.Globals
{
    public static class Func
    {
        public static object Clone(object obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (obj.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, obj);
                    stream.Position = 0;
                    return formatter.Deserialize(stream);
                }

                return null;
            }
        }
    }
}
