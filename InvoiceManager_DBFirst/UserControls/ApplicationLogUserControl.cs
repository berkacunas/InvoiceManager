using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst
{
    public partial class ApplicationLogUserControl : UserControl
    {
        private string _eventTimeFormat = "dd.MM.yyyy dddd HH:mm:ss";

        public ApplicationLogUserControl()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
        }

        private void ApplicationLogUserControl_Load(object sender, EventArgs e)
        {
            string[] listViewLogColumns = new string[] { "Message", "Action Type", "Action Time" };
            int[] listViewLogColumnWidths = new int[] { 400, 300, 250 };
            HorizontalAlignment[] listViewLogColumnAlignments = { HorizontalAlignment.Left, HorizontalAlignment.Left, HorizontalAlignment.Left };

            WinFormsHelper.SetListViewRowStyles(this.listViewLog, View.Details, true, true, false);
            WinFormsHelper.SetListViewColumnStyles(this.listViewLog, listViewLogColumns, listViewLogColumnWidths, listViewLogColumnAlignments);
        }

        public void AddLog(string actionType, string message, DateTime eventTime)
        {
            this.listViewLog.Items.Add(new ListViewItem(new string[] { message, actionType, eventTime.ToString(_eventTimeFormat) }));
        }
    }
}
