﻿using System;
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
using InvoiceManager_DBFirst.UserControls;
using Maya.DatabaseSynchronization;
using Maya.Redirection;

namespace InvoiceManager_DBFirst
{
    public partial class MainForm : Form
    {
        private InvoicesEntities dbContext;
        private System.Threading.Timer _timer;

        private List<AppLog> _appLogs;
        

        public MainForm()
        {
            InitializeComponent();

            this.dbContext = new InvoicesEntities();

            this._appLogs = new List<AppLog>();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.AppIcon.GetHicon());
            this._createToolStripButtons();

            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this._timer = new System.Threading.Timer(timer_callback, null, 0, 1000);

            this._loadToolStripMenuItemIcons();
            this.initializeTactionUserControl();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext.AppLog.AddRange(this._appLogs);

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot save application logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            this.initializeTactionUserControl();
        }

        private void toolStripMenuItemItems_Click(object sender, EventArgs e)
        {
            this.initializeItemUserControl();
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
            this._initializeSellerForm();
        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            this._initializeSettingsForm();
        }

        private void toolStripMenuItemApplicationLog_Click(object sender, EventArgs e)
        {
            this.initializeApplicationLogUserControl();
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
            this.initializeTactionUserControl();
        }

        private void ToolStripButtonItems_Click(object sender, EventArgs e)
        {
            this.initializeItemUserControl();
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
            this.addLog(actionType, message, eventTime);
        }

        private void TactionForm_TransactionChanged(string actionType, string message, DateTime eventTime)
        {
            this.addLog(actionType, message, eventTime);
        }

        private void TactionForm_TransactionFormClosed(string actionType, string message, DateTime eventTime)
        {
            this.addLog(actionType, message, eventTime);
        }

        private void itemUserControl_ItemFormOpened(string actionType, string message, DateTime eventTime)
        {
            this.addLog(actionType, message, eventTime);
        }

        private void itemUserControl_ItemChanged(string actionType, string message, DateTime eventTime)
        {
            this.addLog(actionType, message, eventTime);
        }

        private void itemForm_ItemFormClosed(string actionType, string message, DateTime eventTime)
        {
            this.addLog(actionType, message, eventTime);
        }

        private void ShopForm_ShopFormOpened(string actionType, string message, DateTime eventTime)
        {
            this.addLog(actionType, message, eventTime);
        }

        private void ShopForm_ShopChanged(string actionType, string message, DateTime eventTime)
        {
            this.addLog(actionType, message, eventTime);
        }

        private void ShopForm_ShopFormClosed(string actionType, string message, DateTime eventTime)
        {
            this.addLog(actionType, message, eventTime);
        }

        #endregion

        #region Private Functions

        private void addLog(string actionType, string message, DateTime eventTime)
        {
            AppLog appLog = new AppLog();
            AppLogActionType appLogActionType = this.dbContext.AppLogActionType.Where(r => r.Name == actionType).FirstOrDefault();

            if (appLogActionType == null)
            {
                appLogActionType = new AppLogActionType();
                appLogActionType.Name = actionType;

                this.dbContext.AppLogActionType.Add(appLogActionType);
                this.dbContext.SaveChanges();
            }

            appLog.AppLogActionType = appLogActionType;
            appLog.ActionTypeId = appLogActionType.id;
            appLog.Message = message;
            appLog.EventTime = eventTime;

            this._appLogs.Add(appLog);
        }

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


        #endregion

        #region Initialize Forms
        private void initializeTactionUserControl()
        {
            TactionUserControl tactionUserControl = new TactionUserControl();
            tactionUserControl.TransactionFormOpened += TactionForm_TransactionFormOpened;
            tactionUserControl.TransactionChanged += TactionForm_TransactionChanged;
            tactionUserControl.TransactionFormClosed += TactionForm_TransactionFormClosed;

            this.placeHolder.Controls.Clear();
            this.placeHolder.Controls.Add(tactionUserControl);
        }

        private void initializeItemUserControl()
        {
            ItemUserControl itemUserControl = new ItemUserControl();
            itemUserControl.ItemFormOpened += itemUserControl_ItemFormOpened;
            itemUserControl.ItemChanged += itemUserControl_ItemChanged;
            itemUserControl.ItemFormClosed += itemForm_ItemFormClosed;

            this.placeHolder.Controls.Clear();
            this.placeHolder.Controls.Add(itemUserControl);
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

        private void _initializeSellerForm()
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
        }

        private void _initializeSettingsForm()
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void initializeApplicationLogUserControl()
        {
            ApplicationLogUserControl applicationLogUserControl = new ApplicationLogUserControl(this._appLogs);
            
            this.placeHolder.Controls.Clear();
            this.placeHolder.Controls.Add(applicationLogUserControl);
        }


        #endregion

        
    }
}
