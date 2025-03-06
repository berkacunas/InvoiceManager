using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private List<UserControl> _userControls = new List<UserControl>();
        private int _panelIndex;

        private static TactionForm _tactionForm;
        private static ItemForm _itemForm;
        private static ShopForm _shopForm;
        private static PaymentMethodForm _paymentMethodForm;
        private static UserForm _userForm;
        private static SellerForm _sellerForm;
        private static SettingsForm _settingsForm;

        public MainForm()
        {
            InitializeComponent();

            this._createToolStripButtons();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.AppIcon.GetHicon());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this._timer = new System.Threading.Timer(timer_callback, null, 0, 1000);

            string[] listViewLogColumns = new string[] { "Message", "Action Type", "Action Time" };
            int[] listViewLogColumnWidths = new int[] { 400, 300, 250 };
            HorizontalAlignment[] listViewLogColumnAlignments = { HorizontalAlignment.Left, HorizontalAlignment.Left, HorizontalAlignment.Left };

            _setListViewRowStyles(this.listViewLog, View.Details, true, true, false);
            _setListViewColumnStyles(this.listViewLog, listViewLogColumns, listViewLogColumnWidths, listViewLogColumnAlignments);
            this._loadToolStripMenuItemIcons();
        }


        private void timer_callback(object state)
        {
            this.InvokeEx(f => f.toolStripStatusLabelLiveDateTime.Text = DateTime.Now.ToString("d MMMM yyyy dddd HH:mm:ss"));
        }

        #region ToolStripMenuItem Events
        private void toolStripMenuItemSyncSqlite_Click(object sender, EventArgs e)
        {
            SyncSqliteForm syncSqliteForm = new SyncSqliteForm();

            if (syncSqliteForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void toolStripMenuItemBatchItemSubTypes_Click(object sender, EventArgs e)
        {
            ItemSubTypeBatcherForm itemSubTypeBatcherForm = new ItemSubTypeBatcherForm();

            if (itemSubTypeBatcherForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void toolStripMenuItemTransactions_Click(object sender, EventArgs e)
        {
            this._initializeTactionForm();
            _tactionForm.Show();
        }

        private void toolStripMenuItemItems_Click(object sender, EventArgs e)
        {
            this._initializeItemForm();
            _itemForm.Show();
        }

        private void toolStripMenuItemShops_Click(object sender, EventArgs e)
        {
            this._initializeShopForm();
            _shopForm.Show();
        }

        private void toolStripMenuItemPaymentMethods_Click(object sender, EventArgs e)
        {
            this._initializePaymentMethodForm();
            _paymentMethodForm.Show();
        }

        private void toolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            this._initializeUserForm();
            _userForm.Show();
        }

        private void toolStripMenuItemSellers_Click(object sender, EventArgs e)
        {
            this._initializeSellerForm();
            _sellerForm.Show();
        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            this._initializeSettingsForm();
            _settingsForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
                System.Windows.Forms.Application.Exit();    // WinForms app
            else
                System.Environment.Exit(1);     // Console app
        }

        #endregion

        #region ToolStripButton Events

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
            this._initializeSellerForm();
        }

        private void ToolStripButtonSettings_Click(object sender, EventArgs e)
        {
            this._initializeSettingsForm();
        }

        #endregion

        #region User-Defined Form Events
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

        #endregion

        #region Private Functions
        private void _loadToolStripMenuItemIcons()
        {
            this.toolStripMenuItemSync.Image = BitmapResourceLoader.Loop;
            this.toolStripMenuItemExit.Image = BitmapResourceLoader.Exit;

            this.toolStripMenuItemSyncSqlite.Image = BitmapResourceLoader.Sqlite;

            this.toolStripMenuItemTransactions.Image = BitmapResourceLoader.Transaction;
            this.toolStripMenuItemItems.Image = BitmapResourceLoader.Item;
            this.toolStripMenuItemShops.Image = BitmapResourceLoader.Shop;
            this.toolStripMenuItemPaymentMethods.Image = BitmapResourceLoader.PaymentMethod;
            this.toolStripMenuItemUsers.Image = BitmapResourceLoader.User;
            this.toolStripMenuItemSellers.Image = BitmapResourceLoader.Seller;
            this.toolStripMenuItemSettings.Image = BitmapResourceLoader.Settings;
        }

        private void _createToolStripButtons()
        {

            ToolStripButton toolStripButtonSyncSqlite = new ToolStripButton();
            ToolStripSeparator separator1 = new ToolStripSeparator();
            ToolStripButton toolStripButtonTactions = new ToolStripButton();
            ToolStripButton toolStripButtonItems = new ToolStripButton();
            ToolStripButton toolStripButtonShops = new ToolStripButton();
            ToolStripButton toolStripButtonPaymentMethods = new ToolStripButton();
            ToolStripButton toolStripButtonUsers = new ToolStripButton();
            ToolStripButton toolStripButtonSellers = new ToolStripButton();
            ToolStripSeparator separator2 = new ToolStripSeparator();
            ToolStripButton toolStripButtonSettings = new ToolStripButton();

            Padding padding = new Padding(4, 0, 4, 0);
            separator1.Margin = padding;
            separator2.Margin = padding;

            toolStripButtonSyncSqlite.Image = BitmapResourceLoader.Sqlite;
            toolStripButtonTactions.Image = BitmapResourceLoader.Transaction;
            toolStripButtonItems.Image = BitmapResourceLoader.Item;
            toolStripButtonShops.Image = BitmapResourceLoader.Shop;
            toolStripButtonPaymentMethods.Image = BitmapResourceLoader.PaymentMethod;
            toolStripButtonUsers.Image = BitmapResourceLoader.User;
            toolStripButtonSellers.Image = BitmapResourceLoader.Seller;
            toolStripButtonSettings.Image = BitmapResourceLoader.Settings;

            toolStripMain.Items.AddRange(new ToolStripItem[] {
                toolStripButtonSyncSqlite, separator1,
                toolStripButtonTactions, toolStripButtonItems,
                toolStripButtonShops, toolStripButtonPaymentMethods,
                toolStripButtonUsers, toolStripButtonSellers,
                separator2, toolStripButtonSettings
            });


            toolStripButtonTactions.Click += ToolStripButtonTactions_Click;
            toolStripButtonItems.Click += ToolStripButtonItems_Click;
            toolStripButtonShops.Click += ToolStripButtonShops_Click;
            toolStripButtonPaymentMethods.Click += ToolStripButtonPaymentMethods_Click;
            toolStripButtonUsers.Click += ToolStripButtonUsers_Click;
            toolStripButtonSellers.Click += ToolStripButtonSellers_Click;
            toolStripButtonSettings.Click += ToolStripButtonSettings_Click;
        }

        private void _addDataToListViewLog(string actionType, string message, DateTime eventTime)
        {
            this.listViewLog.Items.Add(new ListViewItem(new string[] { message, actionType, eventTime.ToString(_eventTimeFormat) }));
        }

        private static void _setListViewRowStyles(ListView listView, View view, bool gridLines, bool fullRowSelect, bool multiSelect)
        {
            listView.View = view;
            listView.GridLines = gridLines;
            listView.FullRowSelect = fullRowSelect;
            listView.MultiSelect = multiSelect;
        }
        private static void _setListViewColumnStyles(ListView listView, string[] columnNames, int[] columnWidths, HorizontalAlignment[] alignments)
        {
            for (int i = 0; i < columnNames.Length; ++i)
                listView.Columns.Add(columnNames[i], columnWidths[i], alignments[i]);
        }

        #endregion


        #region Initialize Forms
        private void _initializeTactionForm()
        {
            if (_tactionForm != null)
                return;

            _tactionForm = new TactionForm();
            _tactionForm.TransactionFormOpened += TactionForm_TransactionFormOpened;
            _tactionForm.TransactionChanged += TactionForm_TransactionChanged;
            _tactionForm.TransactionFormClosed += TactionForm_TransactionFormClosed;
            //_tactionForm.Show();
        }

        private void _initializeItemForm()
        {
            if (_itemForm != null)
                return;

            _itemForm = new ItemForm();
            _itemForm.ItemFormOpened += ItemForm_ItemFormOpened;
            _itemForm.ItemChanged += ItemForm_ItemChanged;
            _itemForm.ItemFormClosed += ItemForm_ItemFormClosed;
            _itemForm.Show();
        }

        private void _initializeShopForm()
        {
            if (_shopForm != null)
                return;

            _shopForm = new ShopForm();
            _shopForm.ShopFormOpened += ShopForm_ShopFormOpened;
            _shopForm.ShopChanged += ShopForm_ShopChanged;
            _shopForm.ShopFormClosed += ShopForm_ShopFormClosed;
            _shopForm.Show();
        }

        private void _initializePaymentMethodForm()
        {
            if (_paymentMethodForm != null)
                return;

            _paymentMethodForm = new PaymentMethodForm();
            _paymentMethodForm.Show();
        }

        private void _initializeUserForm()
        {
            if (_userForm != null)
                return;

            _userForm = new UserForm();
            _userForm.Show();
        }

        private void _initializeSellerForm()
        {
            if (_sellerForm != null)
                return;

            _sellerForm = new SellerForm();
            _sellerForm.Show();
        }

        private void _initializeSettingsForm()
        {
            if (_settingsForm != null)
                return;

            _settingsForm = new SettingsForm();
            _settingsForm.ShowDialog();
        }


        #endregion

        private void toolStripMenuItemShowTactions_Click(object sender, EventArgs e)
        {
            TactionUserControl _tactionUserControl = new TactionUserControl();

            _tactionForm.FormBorderStyle = FormBorderStyle.None;
            _tactionForm.TopLevel = false;
            _tactionForm.AutoScroll = true;
            _tactionForm.Dock = DockStyle.Fill;

            this.groupBoxWithListView.Visible = false;

            this.splitContainerMain.Panel2.Controls.Add(_tactionUserControl);
            this._userControls.Add(_tactionUserControl);
            this._userControls[_panelIndex].Visible = true;
            this._userControls[_panelIndex].Show(); // Not necessary
        }
    }
}
