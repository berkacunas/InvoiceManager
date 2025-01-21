using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Dotmim.Sync;
using Maya.DatabaseSynchronization;
using Maya.Redirection;

namespace InvoiceManager_DBFirst
{
    public partial class MainForm : Form
    {
        private System.Threading.Timer _timer;
        private string _eventTimeFormat = "dd.MM.yyyy dddd HH:mm:ss";

        public MainForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.AppIcon.GetHicon());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this._timer = new System.Threading.Timer(timer_callback, null, 0, 1000);

            this.listViewLog.View = View.Details;

            string[] listViewLogColumns = new string[] { "Message", "Action Type", "Action Time" };
            int[] listViewLogColumnWidths = new int[] { 400, 300, 250 };
            HorizontalAlignment[] listViewLogColumnAlignments = { HorizontalAlignment.Left, HorizontalAlignment.Left, HorizontalAlignment.Left };

            _setListViewColumnStyles(this.listViewLog, listViewLogColumns, listViewLogColumnWidths, listViewLogColumnAlignments);
            this._loadToolStripMenuItemIcons();
        }

        private static void _setListViewColumnStyles(ListView listView, string[] columnNames, int[]columnWidths, HorizontalAlignment[] alignments)
        {
            for (int i = 0; i < columnNames.Length; ++i)
                listView.Columns.Add(columnNames[i], columnWidths[i], alignments[i]);
        }

        private void toolStripMenuItemSyncWithSQLiteDatabase_Click(object sender, EventArgs e)
        {
            SyncWithSQLiteDatabaseForm form = new SyncWithSQLiteDatabaseForm();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void toolStripMenuItemTransactions_Click(object sender, EventArgs e)
        {
            TactionForm tactionForm = new TactionForm();
            tactionForm.TransactionFormOpened += TactionForm_TransactionFormOpened;
            tactionForm.TransactionChanged += TactionForm_TransactionChanged;
            tactionForm.TransactionFormClosed += TactionForm_TransactionFormClosed;
            tactionForm.Show();
        }

        private void toolStripMenuItem_Items_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.ItemFormOpened += İtemForm_ItemFormOpened;
            itemForm.ItemChanged += İtemForm_ItemChanged;
            itemForm.ItemFormClosed += İtemForm_ItemFormClosed;
            itemForm.Show();
        }

        private void toolStripMenuItemShops_Click(object sender, EventArgs e)
        {
            ShopForm shopForm = new ShopForm();
            shopForm.ShopFormOpened += ShopForm_ShopFormOpened;
            shopForm.ShopChanged += ShopForm_ShopChanged;
            shopForm.ShopFormClosed += ShopForm_ShopFormClosed;
            shopForm.Show();
        }

        private void toolStripMenuItemPaymentMethods_Click(object sender, EventArgs e)
        {
            PaymentMethodForm paymentMethodForm = new PaymentMethodForm();
            paymentMethodForm.Show();
        }

        private void toolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void timer_callback(object state)
        {
            this.InvokeEx(f => f.toolStripStatusLabelLiveDateTime.Text = DateTime.Now.ToString("d MMMM yyyy dddd HH:mm:ss"));
        }

        private void TactionForm_TransactionFormOpened(string actionType, string message, DateTime eventTime)
        {
            this._addDataToListViewLog(actionType, message, eventTime);
        }

        private void TactionForm_TransactionChanged(string actionType, string message, DateTime eventTime)
        {
            this._addDataToListViewLog(actionType, message, eventTime);
        }

        private void TactionForm_TransactionFormClosed(string actionType, string message, DateTime eventTime)
        {
            this._addDataToListViewLog(actionType, message, eventTime);
        }

        private void İtemForm_ItemFormOpened(string actionType, string message, DateTime eventTime)
        {
            this._addDataToListViewLog(actionType, message, eventTime);
        }

        private void İtemForm_ItemFormClosed(string actionType, string message, DateTime eventTime)
        {
            this._addDataToListViewLog(actionType, message, eventTime);
        }

        private void İtemForm_ItemChanged(string actionType, string message, DateTime eventTime)
        {
            this._addDataToListViewLog(actionType, message, eventTime);
        }

        private void ShopForm_ShopFormOpened(string actionType, string message, DateTime eventTime)
        {
            this.listViewLog.Items.Add(new ListViewItem(new string[] { message, actionType, eventTime.ToString(_eventTimeFormat) }));
        }

        private void ShopForm_ShopChanged(string actionType, string message, DateTime eventTime)
        {
            this.listViewLog.Items.Add(new ListViewItem(new string[] { message, actionType, eventTime.ToString(_eventTimeFormat) }));
        }

        private void ShopForm_ShopFormClosed(string actionType, string message, DateTime eventTime)
        {
            this.listViewLog.Items.Add(new ListViewItem(new string[] { message, actionType, eventTime.ToString(_eventTimeFormat) }));
        }

        private void _loadToolStripMenuItemIcons()
        {
            this.toolStripMenuItemTransactions.Image = BitmapResourceLoader.Transaction;
            this.toolStripMenuItemItems.Image = BitmapResourceLoader.Item;
            this.toolStripMenuItemShops.Image = BitmapResourceLoader.Shop;
            this.toolStripMenuItemPaymentMethods.Image = BitmapResourceLoader.PaymentMethod;
            this.toolStripMenuItemUsers.Image = BitmapResourceLoader.User;
            this.toolStripMenuItemSellers.Image = BitmapResourceLoader.Seller;
        }

        private void _addDataToListViewLog(string actionType, string message, DateTime eventTime)
        {
            this.listViewLog.Items.Add(new ListViewItem(new string[] { message, actionType, eventTime.ToString(_eventTimeFormat) }));
        }
    }
}
