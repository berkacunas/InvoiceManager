using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InvoiceManager_DBFirst.Globals
{
    internal class WinFormsHelper
    {
        public static void SetDefaultGridViewStyles(DataGridView gridview)
        {
            gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridview.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);

            gridview.DefaultCellStyle.Font = new Font("Calibri", 10);
            gridview.DefaultCellStyle.ForeColor = Color.FromArgb(7, 7, 7); //  152, g: 255, b: 152
            gridview.DefaultCellStyle.BackColor = Color.White;

            gridview.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(7, 7, 7);
            gridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            gridview.DefaultCellStyle.SelectionForeColor = Color.FromArgb(7, 7, 7);
            gridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(163, 255, 179);

            gridview.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.5f, FontStyle.Bold);
            gridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public static void SetDefaultGridViewHeaderStyles(DataGridView gridview, string[] headerTexts, int[] columnWidths, DataGridViewContentAlignment[] columnAlignments)
        {
            for (int i = 0; i < gridview.Columns.Count; ++i)
            {
                gridview.Columns[i].HeaderCell.Value = headerTexts[i];
                gridview.Columns[i].Width = columnWidths[i];
                gridview.Columns[i].DefaultCellStyle.Alignment = columnAlignments[i];
            }
        }

        public static void EnableDataGridViewMultiSelect(DataGridView gridview, bool enable)
        {
            gridview.MultiSelect = enable;
        }

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

        public static void SetButtonImages(Button button, ImageList imageList, string imageIndexOfKey, Color foreColor, Color backColor, FlatStyle flatStyle, int borderWidth)
        {
            button.ImageList = imageList;
            button.ImageIndex = imageList.Images.IndexOfKey(imageIndexOfKey);
            button.ForeColor = foreColor;
            //button.BackColor = backColor;
            button.FlatStyle = flatStyle;
            button.FlatAppearance.BorderSize = borderWidth;
        }
    }
}
