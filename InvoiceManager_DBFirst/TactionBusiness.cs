using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    internal class TactionBusiness
    {
        enum Mode
        {
            Display,
            Add,
            Edit,
            Search
        }

        enum BindType
        {
            Select,
            Where,
            Setnull
        }

        public event Notify TransactionsLoaded;
        public event Notify TransactionSaved;
        public event Notify TransactionUpdated;
        public event Notify TransactionRemoved;

        public event Notify TransactionChanged;
        public event Notify TransactionFormOpened;
        public event Notify TransactionFormClosed;

        private ImageList _imageList;

        private InvoicesEntities dbContext;
        private Taction _newTaction;
        private Mode _mode;

        private Panel _tactionPanel;

        public TactionBusiness() 
        {
            
        }

        public ImageList CreateImageList()
        {
            ImageList imageList = new ImageList
            {
                ImageSize = new Size(19, 19),
                ColorDepth = ColorDepth.Depth32Bit
            };
            imageList.Images.Add("Thinker", BitmapResourceLoader.Thinker);
            imageList.Images.Add("FAQ", BitmapResourceLoader.FAQ);
            imageList.Images.Add("QuestionMark", BitmapResourceLoader.QuestionMark);
            imageList.Images.Add("Question1", BitmapResourceLoader.Question1);
            imageList.Images.Add("Question2", BitmapResourceLoader.Question2);

            return imageList;
        }

        public ContextMenuStrip CreateReportContextMenu()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();

            ToolStripMenuItem contextMenuItemReportSelection = new ToolStripMenuItem("Report selection...", BitmapResourceLoader.Sqlite, new EventHandler(contextMenuItemReportSelection_Click), Keys.None);
            ToolStripMenuItem contextMenuItemReportDaily = new ToolStripMenuItem("Report daily...", BitmapResourceLoader.Sqlite, new EventHandler(contextMenuItemReportDaily_Click), Keys.None);
            ToolStripMenuItem contextMenuItemReportWeekly = new ToolStripMenuItem("Report weekly...", BitmapResourceLoader.Sqlite, new EventHandler(contextMenuItemReportWeekly_Click), Keys.None);
            ToolStripMenuItem contextMenuItemReportYearly = new ToolStripMenuItem("Report monthly...", BitmapResourceLoader.Sqlite, new EventHandler(contextMenuItemReportMonthly_Click), Keys.None);
            ToolStripMenuItem contextMenuItemExit = new ToolStripMenuItem("Exit");

            menuStrip.Items.AddRange(new ToolStripItem[] { contextMenuItemReportSelection,
                                                           contextMenuItemReportDaily,
                                                           contextMenuItemReportWeekly,
                                                           contextMenuItemReportYearly,
                                                           contextMenuItemExit });

            return menuStrip;
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

    }
}
