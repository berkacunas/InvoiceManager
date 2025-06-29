using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayacs
{
    internal static class MayaMath
    {
        public static bool isInteger(decimal val)
        {
            return (decimal)((int)val) == val;
        }
    }
}
