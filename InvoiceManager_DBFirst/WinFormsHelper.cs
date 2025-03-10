using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    internal class WinFormsHelper
    {
        public static void SetListViewRowStyles(ListView listView, View view, bool gridLines, bool fullRowSelect, bool multiSelect)
        {
            listView.View = view;
            listView.GridLines = gridLines;
            listView.FullRowSelect = fullRowSelect;
            listView.MultiSelect = multiSelect;
        }
        public static void SetListViewColumnStyles(ListView listView, string[] columnNames, int[] columnWidths, HorizontalAlignment[] alignments)
        {
            for (int i = 0; i < columnNames.Length; ++i)
                listView.Columns.Add(columnNames[i], columnWidths[i], alignments[i]);
        }

    }
}
