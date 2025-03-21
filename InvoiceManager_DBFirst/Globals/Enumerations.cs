using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManager_DBFirst.Globals
{
    public enum Mode
    {
        Display,
        Add,
        Edit,
        Search
    }

    public enum BindType
    {
        Select,
        Where,
        Setnull
    }

    public enum ColumnSortOrder
    {
        ASC,
        DESC,
        UNORDERED
    }

    public enum LoginType
    {
        Login,
        Logout
    }
}
