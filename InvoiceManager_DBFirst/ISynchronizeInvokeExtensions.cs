using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    public static class ISynchronizeInvokeExtensions
    {
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            try
            {
                if (@this.InvokeRequired)
                    @this.Invoke(action, new object[] { @this });
                else
                    action(@this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
