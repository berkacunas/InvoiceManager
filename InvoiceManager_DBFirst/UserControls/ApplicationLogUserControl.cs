using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst
{
    public partial class ApplicationLogUserControl : UserControl
    {
        private InvoicesEntities dbContext;

        private List<AppLog> _appLogs;
        private string _eventTimeFormat = "dd.MM.yyyy dddd HH:mm:ss";

        public ApplicationLogUserControl(List<AppLog> appLogs)
        {
            InitializeComponent();
            
            this.dbContext = new InvoicesEntities();
            this._appLogs = appLogs;

            this.Dock = DockStyle.Fill;
        }

        private void ApplicationLogUserControl_Load(object sender, EventArgs e)
        {
            string[] listViewLogColumns = new string[] { "Message", "Action Type", "Action Time" };
            int[] listViewLogColumnWidths = new int[] { 400, 300, 250 };
            HorizontalAlignment[] listViewLogColumnAlignments = { HorizontalAlignment.Left, HorizontalAlignment.Left, HorizontalAlignment.Left };

            WinFormsHelper.SetListViewRowStyles(this.listViewLog, View.Details, true, true, false);
            WinFormsHelper.SetListViewColumnStyles(this.listViewLog, listViewLogColumns, listViewLogColumnWidths, listViewLogColumnAlignments);

            this.setDataToListViewLog();
        }

        private void setDataToListViewLog()
        {
            foreach (AppLog appLog in this._appLogs)
                this.addLogToListViewLog(appLog.AppLogActionType.Name, appLog.Message, appLog.EventTime);
        }

        private void addLogToListViewLog(string actionType, string message, DateTime eventTime)
        {
            this.listViewLog.Items.Add(new ListViewItem(new string[] { message, actionType, eventTime.ToString(_eventTimeFormat) }));
        }
    }
}
