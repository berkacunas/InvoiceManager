using System;
using System.ComponentModel;

namespace InvoiceManager_DBFirst
{
    public static class ISynchronizeInvokeExtensions
    {
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            if (@this.InvokeRequired)
                @this.Invoke(action, new object[] { @this });
            else
                action(@this);
        }
    }
}
