using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
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

            this._createToolStripMenuItems();

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

        private void toolStripMenuItemSyncSqlite_Click(object sender, EventArgs e)
        {
            SyncSqliteForm syncSqliteForm = new SyncSqliteForm();

            if (syncSqliteForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void toolStripMenuItemTransactions_Click(object sender, EventArgs e)
        {
            this._initializeTactionForm();
        }

        private void toolStripMenuItemItems_Click(object sender, EventArgs e)
        {
            this._initializeItemForm();
        }

        private void toolStripMenuItemShops_Click(object sender, EventArgs e)
        {
            this._initializeShopForm();
        }

        private void toolStripMenuItemPaymentMethods_Click(object sender, EventArgs e)
        {
            this._initializePaymentMethodForm();
        }

        private void toolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            this._initializeUserForm();
        }

        private void toolStripMenuItemSellers_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonTactions_Click(object sender, EventArgs e)
        {
            this._initializeTactionForm();
        }

        private void ToolStripButtonItems_Click(object sender, EventArgs e)
        {
            this._initializeItemForm();
        }

        private void ToolStripButtonShops_Click(object sender, EventArgs e)
        {
            this._initializeShopForm();
        }

        private void ToolStripButtonPaymentMethods_Click(object sender, EventArgs e)
        {
            this._initializePaymentMethodForm();
        }

        private void ToolStripButtonUsers_Click(object sender, EventArgs e)
        {
            this._initializeUserForm();
        }

        private void ToolStripButtonSellers_Click(object sender, EventArgs e)
        {
            
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

        private void ItemForm_ItemFormOpened(string actionType, string message, DateTime eventTime)
        {
            this._addDataToListViewLog(actionType, message, eventTime);
        }

        private void ItemForm_ItemFormClosed(string actionType, string message, DateTime eventTime)
        {
            this._addDataToListViewLog(actionType, message, eventTime);
        }

        private void ItemForm_ItemChanged(string actionType, string message, DateTime eventTime)
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
            this.toolStripMenuItemSync.Image = BitmapResourceLoader.Loop;
            this.exitToolStripMenuItem.Image = BitmapResourceLoader.Exit;

            this.toolStripMenuItemSyncSqlite.Image = BitmapResourceLoader.Sqlite;

            this.toolStripMenuItemTransactions.Image = BitmapResourceLoader.Transaction;
            this.toolStripMenuItemItems.Image = BitmapResourceLoader.Item;
            this.toolStripMenuItemShops.Image = BitmapResourceLoader.Shop;
            this.toolStripMenuItemPaymentMethods.Image = BitmapResourceLoader.PaymentMethod;
            this.toolStripMenuItemUsers.Image = BitmapResourceLoader.User;
            this.toolStripMenuItemSellers.Image = BitmapResourceLoader.Seller;
        }

        private void _createToolStripMenuItems()
        {
            ToolStripButton toolStripButtonSyncSqlite = new ToolStripButton();
            ToolStripSeparator separator1 = new ToolStripSeparator();
            ToolStripButton toolStripButtonTactions = new ToolStripButton();
            ToolStripButton toolStripButtonItems = new ToolStripButton();
            ToolStripButton toolStripButtonShops = new ToolStripButton();
            ToolStripButton toolStripButtonPaymentMethods = new ToolStripButton();
            ToolStripButton toolStripButtonUsers = new ToolStripButton();
            ToolStripButton toolStripButtonSellers = new ToolStripButton();

            separator1.Margin = new Padding(4, 0, 4, 0);

            toolStripButtonSyncSqlite.Image = BitmapResourceLoader.Sqlite;
            toolStripButtonTactions.Image = BitmapResourceLoader.Transaction;
            toolStripButtonItems.Image = BitmapResourceLoader.Item;
            toolStripButtonShops.Image = BitmapResourceLoader.Shop;
            toolStripButtonPaymentMethods.Image = BitmapResourceLoader.PaymentMethod;
            toolStripButtonUsers.Image = BitmapResourceLoader.User;
            toolStripButtonSellers.Image = BitmapResourceLoader.Seller;

            toolStripMain.Items.AddRange(new ToolStripItem[] { 
                toolStripButtonSyncSqlite, separator1,
                toolStripButtonTactions, toolStripButtonItems, 
                toolStripButtonShops, toolStripButtonPaymentMethods, 
                toolStripButtonUsers, toolStripButtonSellers
            });


            toolStripButtonTactions.Click += ToolStripButtonTactions_Click;
            toolStripButtonItems.Click += ToolStripButtonItems_Click;
            toolStripButtonShops.Click += ToolStripButtonShops_Click;
            toolStripButtonPaymentMethods.Click += ToolStripButtonPaymentMethods_Click;
            toolStripButtonUsers.Click += ToolStripButtonUsers_Click;
            toolStripButtonSellers.Click += ToolStripButtonSellers_Click;

        }

        private void _addDataToListViewLog(string actionType, string message, DateTime eventTime)
        {
            this.listViewLog.Items.Add(new ListViewItem(new string[] { message, actionType, eventTime.ToString(_eventTimeFormat) }));
        }

        private static void _setListViewColumnStyles(ListView listView, string[] columnNames, int[] columnWidths, HorizontalAlignment[] alignments)
        {
            for (int i = 0; i < columnNames.Length; ++i)
                listView.Columns.Add(columnNames[i], columnWidths[i], alignments[i]);
        }

        private void _initializeTactionForm()
        {
            TactionForm tactionForm = new TactionForm();
            tactionForm.TransactionFormOpened += TactionForm_TransactionFormOpened;
            tactionForm.TransactionChanged += TactionForm_TransactionChanged;
            tactionForm.TransactionFormClosed += TactionForm_TransactionFormClosed;
            tactionForm.Show();
        }

        private void _initializeItemForm()
        {
            ItemForm itemForm = new ItemForm();
            itemForm.ItemFormOpened += ItemForm_ItemFormOpened;
            itemForm.ItemChanged += ItemForm_ItemChanged;
            itemForm.ItemFormClosed += ItemForm_ItemFormClosed;
            itemForm.Show();
        }

        private void _initializeShopForm()
        {
            ShopForm shopForm = new ShopForm();
            shopForm.ShopFormOpened += ShopForm_ShopFormOpened;
            shopForm.ShopChanged += ShopForm_ShopChanged;
            shopForm.ShopFormClosed += ShopForm_ShopFormClosed;
            shopForm.Show();
        }

        private void _initializePaymentMethodForm()
        {
            PaymentMethodForm paymentMethodForm = new PaymentMethodForm();
            paymentMethodForm.Show();
        }

        private void _initializeUserForm()
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

    }
}
