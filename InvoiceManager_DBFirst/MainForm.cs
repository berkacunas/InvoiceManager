using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using InvoiceManager_DBFirst.UserControls;
using InvoiceManager_DBFirst.Globals;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlTypes;
using System.IdentityModel.Tokens;

namespace InvoiceManager_DBFirst
{
    public partial class MainForm : Form
    {
        private InvoicesEntities dbContext;
        private System.Threading.Timer _timer;

        private List<AppLog> _appLogs;
        private ImageList _activeControlsImageList;
        private UserProfile _userProfile;
        private UserLoginDetails _loginDetails;

        private ToolStripStatusLabel _toolStripStatusLabelLiveDateTime; // Have to be accessed in class scope.
        private int _lastSelectedListViewActiveControlsIndex = -1;

        private IDictionary<string, int> _profileCounts = new Dictionary<string, int>() 
        {
            { "Taction", 0 },
            { "TactionDetail", 0 },
            { "Item", 0 },
            { "ItemGroup", 0 },
            { "ItemTopGroup", 0 },
            { "Shop", 0 },
            { "ShopGroup", 0 },
            { "ShopType", 0 },
        };


        public MainForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.AppIcon.GetHicon());
            this.dbContext = new InvoicesEntities();

            this._appLogs = new List<AppLog>();
            this._userProfile = null;
            this._loginDetails = null;

            this._toolStripStatusLabelLiveDateTime = new ToolStripStatusLabel();

            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;

            this.placeHolder.ControlAdded += placeHolder_ControlAdded;
            this.placeHolder.ControlRemoved += placeHolder_ControlRemoved;

            this.listViewActiveControls.MouseClick += listViewActiveControls_MouseClick;
            this.listViewActiveControls.MouseUp += listViewActiveControls_MouseUp;
            this.listViewActiveControls.KeyUp += listViewActiveControls_KeyUp;
            this.listViewActiveControls.ClientSizeChanged += listViewActiveControls_ClientSizeChanged;
        }

        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.splitContainerMain.SplitterDistance = 225;
            this.panelProfile.Height = 250;

            this.arrangePictureBoxUserProfile();

            this.loadToolStripMenuItemIcons();
            this.createToolStripButtons();
            this.createToolStripStatusBar();
            this.createImageListActiveControlIcons();
            this.createListViewActiveControls();
            this.populateContextMenuStripTileView();

            this._timer = new System.Threading.Timer(timer_callback, null, 0, 1000);

            if (!isDbConnectionExists())
            {
                MessageBox.Show("Database connection doesn't exist.", "Database not found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.initProfileCounts();
            this.setPanelProfile();
            ((ToolStripButton)this.toolStripMain.Items[2]).Checked = true;  // Triggers a set of useful events. Replace of this.initializeTactionUserControl();
        }

        private void setPanelProfile()
        {
            this.labelProfileTransactionsVal.Text = $"{this._profileCounts["Taction"].ToString()} / {this._profileCounts["TactionDetail"].ToString()}";
            this.labelProfileItemsVal.Text = $"{this._profileCounts["Item"].ToString()} / {this._profileCounts["ItemGroup"].ToString()} / {this._profileCounts["ItemTopGroup"].ToString()}";
            this.labelProfileShopsVal.Text = $"{this._profileCounts["Shop"].ToString()} / {this._profileCounts["ShopGroup"].ToString()} / {this._profileCounts["ShopType"].ToString()}";
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
            this.statusStripMain.Items[0].Text = DateTime.Now.ToString("d MMMM yyyy dddd HH:mm:ss");
        }

        private void placeHolder_ControlAdded(object sender, ControlEventArgs e)
        {
            Control control = e.Control;
            string tileMessage = $"Add, Edit, Remove {control.Tag.ToString()}";
            this.addActiveControlToListView(control.Tag.ToString(), tileMessage, control.Tag.ToString());
        }

        private void placeHolder_ControlRemoved(object sender, ControlEventArgs e)
        {
            removeActiveControlFromListView(e.Control.Tag.ToString());
        }

        private void listViewActiveControls_MouseClick(object sender, MouseEventArgs e)
        {
            this.setSelectedListViewActiveControlsItem();
        }

        private void setSelectedListViewActiveControlsItem()
        {
            this.visibleUserControls(false);
            
            ListViewItem selectedItem = null;
            if (this.listViewActiveControls.SelectedItems != null)
            {
                selectedItem = this.listViewActiveControls.SelectedItems[0];
                this._lastSelectedListViewActiveControlsIndex = this.listViewActiveControls.SelectedIndices[0];
            }

            this.uncheckToolStripToggleButtonsExcept(selectedItem.Text);

            UserControl userControl = this.selectUserControl(selectedItem.Text);
            userControl.Visible = true;
        }

        private void listViewActiveControls_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Check Right-clicked on listViewActiveControls.
                var focusedItem = this.listViewActiveControls.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                    contextMenuStripTileView.Show(Cursor.Position);
            }
        }

        private void listViewActiveControls_KeyUp(object sender, KeyEventArgs e)
        {
            //string s = $"KeyUp code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}";
            //MessageBox.Show(s);

            if (e.KeyCode == Keys.Up && e.Modifiers == Keys.None)
            {
                if (this._lastSelectedListViewActiveControlsIndex > 0)
                {
                    --this._lastSelectedListViewActiveControlsIndex;
                    this.setSelectedListViewActiveControlsItem();
                }
            }
            else if (e.KeyCode == Keys.Down && e.Modifiers == Keys.None)
            {
                if (this._lastSelectedListViewActiveControlsIndex < this.listViewActiveControls.Items.Count - 1)
                {
                    ++this._lastSelectedListViewActiveControlsIndex;
                    this.setSelectedListViewActiveControlsItem();
                }
            }
        }

        private void listViewActiveControls_ClientSizeChanged(object sender, EventArgs e)
        {
            this.listViewActiveControls.TileSize = new Size(this.listViewActiveControls.Size.Width, 45);
            this.listViewActiveControls.Refresh();
        }

        private void contextMenuStripTileView_activate(object sender, EventArgs e)
        {
            this.visibleUserControls(false);

            ListViewItem selectedItem = null;
            if (this.listViewActiveControls.SelectedItems != null)
                selectedItem = this.listViewActiveControls.SelectedItems[0];

            UserControl userControl = this.selectUserControl(selectedItem.Text);
            userControl.Visible = true;
        }

        private void contextMenuStripTileView_remove(object sender, EventArgs e)
        {
            ListViewItem selectedItem = null;
            if (this.listViewActiveControls.SelectedItems != null)
                selectedItem = this.listViewActiveControls.SelectedItems[0];

            UserControl userControl = this.selectUserControl(selectedItem.Text);
            this.placeHolder.Controls.Remove(userControl);

            if (this.placeHolder.Controls.Count > 0)
                this.placeHolder.Controls[this.placeHolder.Controls.Count - 1].Visible = true;
        }

        #endregion

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
            this.initializeShopUserControl();
        }

        private void toolStripMenuItemPaymentMethods_Click(object sender, EventArgs e)
        {
            this.initializePaymentMethodUserControl();
        }

        private void toolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            this.initializeUserUserControl();
        }

        private void toolStripMenuItemSellers_Click(object sender, EventArgs e)
        {
            this.initializeSellerUserControl();
        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            this.initializeSettingsUserControl();
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

        private void toolStripButtonTactions_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            if (button.Checked)
            {
                this.initializeTactionUserControl();
                this.uncheckToolStripToggleButtonsExcept(button.Tag.ToString());
            }
        }

        private void toolStripButtonItems_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            if (button.Checked)
            {
                this.initializeItemUserControl();
                this.uncheckToolStripToggleButtonsExcept(button.Tag.ToString());
            }
        }

        private void toolStripButtonShops_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            if (button.Checked)
            {
                this.initializeShopUserControl();
                this.uncheckToolStripToggleButtonsExcept(button.Tag.ToString());
            }
        }

        private void toolStripButtonPaymentMethods_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            if (button.Checked)
            {
                this.initializePaymentMethodUserControl();
                this.uncheckToolStripToggleButtonsExcept(button.Tag.ToString());
            }
        }

        private void toolStripButtonUsers_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            if (button.Checked)
            {
                this.initializeUserUserControl();
                this.uncheckToolStripToggleButtonsExcept(button.Tag.ToString());
            }
        }

        private void toolStripButtonSellers_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            if (button.Checked)
            {
                this.initializeSellerUserControl();
                this.uncheckToolStripToggleButtonsExcept(button.Tag.ToString());
            }
        }

        private void toolStripButtonApplicationLog_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            if (button.Checked)
            {
                this.initializeApplicationLogUserControl();
                this.uncheckToolStripToggleButtonsExcept(button.Tag.ToString());
            }
        }

        private void toolStripButtonSettings_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            if (button.Checked)
            {
                this.initializeSettingsUserControl();
                this.uncheckToolStripToggleButtonsExcept(button.Tag.ToString());
            }
        }

        private void toolStripButtonLogin_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            if (button.Checked)
                this.initializeLoginForm();
            else
            {
                button.CheckedChanged -= toolStripButtonLogin_CheckedChanged;
                button.Checked = true;

                DialogResult dr = MessageBox.Show("Do you want to logout ?.", "You are exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    button.CheckedChanged += toolStripButtonLogin_CheckedChanged;
                    return;
                }

                button.Checked = false;
                button.CheckedChanged += toolStripButtonLogin_CheckedChanged;

                UserLoginDetails logoutDetails = new UserLoginDetails();
                logoutDetails.UserProfileId = this._userProfile.id;
                logoutDetails.IsSuccess = true;
                logoutDetails.LoginDate = DateTime.Now;
                logoutDetails.LoginType = LoginType.Logout.ToString();

                this.dbContext.UserLoginDetails.Add(logoutDetails);
                this.clearStatusBarLoginDetails();
                this.clearPanelProfile();

                try
                {
                    this.dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cannot save user logout details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this._userProfile = null;
                this._loginDetails = null;
                MessageBox.Show("You are logged out.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Helper Functions

        private UserControl selectUserControl(string tag)
        {
            UserControl userControl = (from UserControl control in this.placeHolder.Controls
                                       where control.Tag.ToString() == tag
                                       select control).FirstOrDefault();

            return userControl;
        }

        private ToolStripButton selectToolStripButton(string tag)
        {
            ToolStripButton button = null;

            foreach (ToolStripItem item in this.toolStripMain.Items)
            {
                if (item.GetType() != typeof(ToolStripButton))
                    continue;

                if (((ToolStripButton)item).Tag.ToString() == tag)
                {
                    button = (ToolStripButton)item;
                    break;
                }
            }

            return button;
        }

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

        private void addActiveControlToListView(string controlName, string tileMessage, string imageListKey)
        {
            ListViewItem activeItem = new ListViewItem(new string[] { controlName, tileMessage }, imageListKey);
            this.listViewActiveControls.Items.Add(activeItem);
            activeItem.Selected = true;
        }

        private void removeActiveControlFromListView(string itemKey)
        {
            ListViewItem removedItem = listViewActiveControls.FindItemWithText(itemKey);
            this.listViewActiveControls.Items.Remove(removedItem);
        }

        private void visibleUserControls(bool visible)
        {
            foreach (Control c in this.placeHolder.Controls)
                c.Visible = false;
        }

        private void arrangePictureBoxUserProfile()
        {
            this.pictureBoxUserProfile.Size = new Size(110, 115);
            this.pictureBoxUserProfile.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxUserProfile.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxUserProfile.Image = BitmapResourceLoader.DefaultUser;
        }

        private void createImageListActiveControlIcons()
        {
            this._activeControlsImageList = new ImageList();
            this._activeControlsImageList.ImageSize = new Size(32, 32);

            this._activeControlsImageList.Images.Add("Transactions", BitmapResourceLoader.Transaction);
            this._activeControlsImageList.Images.Add("Items", BitmapResourceLoader.Item);
            this._activeControlsImageList.Images.Add("Shops", BitmapResourceLoader.Shop);
            this._activeControlsImageList.Images.Add("PaymentMethods", BitmapResourceLoader.PaymentMethod);
            this._activeControlsImageList.Images.Add("Users", BitmapResourceLoader.User);
            this._activeControlsImageList.Images.Add("Sellers", BitmapResourceLoader.Seller);
            this._activeControlsImageList.Images.Add("Settings", BitmapResourceLoader.Settings);
        }

        private void createListViewActiveControls()
        {
            this.listViewActiveControls.View = View.Tile;
            this.listViewActiveControls.LargeImageList = this._activeControlsImageList;
            this.listViewActiveControls.MultiSelect = false;
            this.listViewActiveControls.FullRowSelect = true;
            this.listViewActiveControls.HideSelection = false;

            /* Add column headers so the subitems will appear. */
            this.listViewActiveControls.Columns.AddRange(new ColumnHeader[]
            {
                new ColumnHeader(), new ColumnHeader(), new ColumnHeader()
            });
        }

        private void loadToolStripMenuItemIcons()
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

        private void createToolStripButtons()
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
            ToolStripButton toolStripButtonApplicationLog = new ToolStripButton();
            ToolStripButton toolStripButtonSettings = new ToolStripButton();
            ToolStripSeparator separator3 = new ToolStripSeparator();
            ToolStripButton toolStripButtonLogin = new ToolStripButton();

            Padding padding = new Padding(4, 0, 4, 0);
            separator1.Margin = padding;
            separator2.Margin = padding;
            separator3.Margin = padding;

            toolStripButtonSyncSqlite.Image = BitmapResourceLoader.Sqlite;
            toolStripButtonTactions.Image = BitmapResourceLoader.Transaction;
            toolStripButtonItems.Image = BitmapResourceLoader.Item;
            toolStripButtonShops.Image = BitmapResourceLoader.Shop;
            toolStripButtonPaymentMethods.Image = BitmapResourceLoader.PaymentMethod;
            toolStripButtonUsers.Image = BitmapResourceLoader.User;
            toolStripButtonSellers.Image = BitmapResourceLoader.Seller;
            toolStripButtonApplicationLog.Image = BitmapResourceLoader.LogBook2;
            toolStripButtonSettings.Image = BitmapResourceLoader.Settings;
            toolStripButtonLogin.Image = BitmapResourceLoader.Login;

            toolStripButtonSyncSqlite.Tag = "SyncSqlite";
            toolStripButtonTactions.Tag = "Transactions";
            toolStripButtonItems.Tag = "Items";
            toolStripButtonShops.Tag = "Shops";
            toolStripButtonPaymentMethods.Tag = "PaymentMethods";
            toolStripButtonUsers.Tag = "Users";
            toolStripButtonSellers.Tag = "Sellers";
            toolStripButtonApplicationLog.Tag = "ApplicationLog";
            toolStripButtonSettings.Tag = "Settings";
            toolStripButtonLogin.Tag = "Login";

            this.toolStripMain.Items.AddRange(new ToolStripItem[] {
                toolStripButtonSyncSqlite, separator1,
                toolStripButtonTactions, toolStripButtonItems,
                toolStripButtonShops, toolStripButtonPaymentMethods,
                toolStripButtonUsers, toolStripButtonSellers,
                separator2, toolStripButtonApplicationLog, toolStripButtonSettings,
                separator3, toolStripButtonLogin
            });

            foreach (ToolStripItem item in toolStripMain.Items)
            {
                if (item.GetType() == typeof(ToolStripSeparator))
                    continue;

                ((ToolStripButton)item).CheckOnClick = true;
            }

            toolStripButtonTactions.CheckedChanged += toolStripButtonTactions_CheckedChanged; ;
            toolStripButtonItems.CheckedChanged += toolStripButtonItems_CheckedChanged;
            toolStripButtonShops.CheckedChanged += toolStripButtonShops_CheckedChanged;
            toolStripButtonPaymentMethods.CheckedChanged += toolStripButtonPaymentMethods_CheckedChanged;
            toolStripButtonUsers.CheckedChanged += toolStripButtonUsers_CheckedChanged;
            toolStripButtonSellers.CheckedChanged += toolStripButtonSellers_CheckedChanged;

            toolStripButtonApplicationLog.CheckedChanged += toolStripButtonApplicationLog_CheckedChanged;
            toolStripButtonSettings.CheckedChanged += toolStripButtonSettings_CheckedChanged;
            toolStripButtonLogin.CheckedChanged += toolStripButtonLogin_CheckedChanged;
        }

        private void createToolStripStatusBar()
        {
            ToolStripSeparator separator1 = new ToolStripSeparator();
            ToolStripStatusLabel toolStripStatusLabelLoginDetails = new ToolStripStatusLabel();

            this.statusStripMain.Items.AddRange(new ToolStripItem[] {
                this._toolStripStatusLabelLiveDateTime, separator1,
                toolStripStatusLabelLoginDetails
            });

        }

        private void populateContextMenuStripTileView()
        {
            this.contextMenuStripTileView.Items.Add("Activate", BitmapResourceLoader.PowerButton, contextMenuStripTileView_activate);
            this.contextMenuStripTileView.Items.Add("Remove", BitmapResourceLoader.Remove, contextMenuStripTileView_remove);
        }

        private void uncheckToolStripToggleButtonsExcept(string buttonText)
        {
            string[] buttonsIgnored = { "Login" };
            foreach (ToolStripItem item in this.toolStripMain.Items)
            {
                if (item.GetType() == typeof(ToolStripSeparator))
                    continue;

                string itemText = item.Tag.ToString();
                if (!buttonsIgnored.Contains(itemText))
                    ((ToolStripButton)item).Checked = (itemText == buttonText);
            }
        }

        private void updateStatusBarLoginDetails(string fullname, DateTime loginDate)
        {
            ToolStripStatusLabel toolStripStatusLabelLoginDetails = this.statusStripMain.Items[2] as ToolStripStatusLabel;
            string text = $"User {fullname} logged in at {loginDate.ToString()}";
            toolStripStatusLabelLoginDetails.Text = text;
        }

        private void clearStatusBarLoginDetails()
        {
            ToolStripStatusLabel toolStripStatusLabelLoginDetails = this.statusStripMain.Items[2] as ToolStripStatusLabel;
            toolStripStatusLabelLoginDetails.Text = string.Empty;
        }

        private void clearPanelProfile()
        {
            this.pictureBoxUserProfile.Image = BitmapResourceLoader.DefaultUser;
            this.labelActiveProfileText.Text = string.Empty;
        }

        private string createFullname(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        private bool isDbConnectionExists()
        {
            return this.dbContext.Database.Exists();
        }

        private void initProfileCounts()
        {
            _profileCounts["Taction"] = dbContext.Taction.Count(r => r.id > 0);
            _profileCounts["TactionDetail"] = dbContext.TactionDetails.Count(r => r.id > 0);
            _profileCounts["Item"] = dbContext.Item.Count(r => r.id > 0);
            _profileCounts["ItemGroup"] = dbContext.ItemGroup.Count(r => r.id > 0);
            _profileCounts["ItemTopGroup"] = dbContext.ItemTopGroup.Count(r => r.id > 0);
            _profileCounts["Shop"] = dbContext.Shop.Count(r => r.id > 0);
            _profileCounts["ShopGroup"] = dbContext.ShopGroup.Count(r => r.id > 0);
            _profileCounts["ShopType"] = dbContext.ShopType.Count(r => r.id > 0);
        }

        private void updateTactionProfileCounts(int val)
        {
            _profileCounts["Taction"] += val;
        }

        private void updateTactionDetailsProfileCounts(int val)
        {
            _profileCounts["TactionDetail"] += val;
        }

        private void updateItemProfileCounts(int val)
        {
            _profileCounts["Item"] += val;
        }

        private void updateItemGroupProfileCounts(int val)
        {
            _profileCounts["ItemGroup"] += val;
        }

        private void updateItemTopGroupProfileCounts(int val)
        {
            _profileCounts["ItemTopGroup"] += val;
        }

        private void updateShopProfileCounts(int val)
        {
            _profileCounts["Shop"] += val;
        }

        private void updateShopGroupProfileCounts(int val)
        {
            _profileCounts["ShopGroup"] += val;
        }

        private void updateShopTypeProfileCounts(int val)
        {
            _profileCounts["ShopType"] += val;
        }

        #endregion

        #region Initialize User Controls

        private void initializeTactionUserControl()
        {
            this.visibleUserControls(false);
            UserControl userControl = this.selectUserControl("Transactions");

            if (userControl == null)
            {
                TactionUserControl tactionUserControl = new TactionUserControl();
                tactionUserControl.Tag = "Transactions";
                tactionUserControl.TransactionFormOpened += UserControl_ActionHandler;
                tactionUserControl.TransactionChanged += UserControl_ActionHandler;
                tactionUserControl.TransactionFormClosed += UserControl_ActionHandler;
                
                tactionUserControl.TransactionSaved += tactionUserControl_TransactionSaved;
                this.placeHolder.Controls.Add(tactionUserControl);
            }
            else
                userControl.Visible = true;
        }

        private void initializeItemUserControl()
        {
            this.visibleUserControls(false);

            UserControl userControl = this.selectUserControl("Items");
            if (userControl == null)
            {

                ItemUserControl itemUserControl = new ItemUserControl();
                itemUserControl.Tag = "Items";

                itemUserControl.ItemFormOpened += UserControl_ActionHandler;
                itemUserControl.ItemChanged += UserControl_ActionHandler;
                itemUserControl.ItemFormClosed += UserControl_ActionHandler;

                this.placeHolder.Controls.Add(itemUserControl);

            }
            else
                userControl.Visible = true;
        }

        private void initializeShopUserControl()
        {
            this.visibleUserControls(false);
            UserControl userControl = this.selectUserControl("Shops");

            if (userControl == null)
            {
                ShopUserControl shopUserControl = new ShopUserControl();
                shopUserControl.Tag = "Shops";

                shopUserControl.ShopFormOpened += UserControl_ActionHandler;
                shopUserControl.ShopChanged += UserControl_ActionHandler;
                shopUserControl.ShopFormClosed += UserControl_ActionHandler;

                this.placeHolder.Controls.Add(shopUserControl);

            }
            else
                userControl.Visible = true;
        }

        private void initializePaymentMethodUserControl()
        {
            this.visibleUserControls(false);
            UserControl userControl = this.selectUserControl("PaymentMethods");

            if (userControl == null)
            {
                PaymentMethodUserControl paymentMethodUserControl = new PaymentMethodUserControl();
                paymentMethodUserControl.Tag = "PaymentMethods";

                paymentMethodUserControl.PaymentMethodFormOpened += UserControl_ActionHandler;
                paymentMethodUserControl.DataChanged += UserControl_ActionHandler;
                paymentMethodUserControl.PaymentMethodFormClosed += UserControl_ActionHandler;

                this.placeHolder.Controls.Add(paymentMethodUserControl);

            }
            else
                userControl.Visible = true;
        }

        private void initializeUserUserControl()
        {
            this.visibleUserControls(false);
            UserControl userControl = this.selectUserControl("Users");

            if (userControl == null)
            {
                UserUserControl userUserControl = new UserUserControl();
                userUserControl.Tag = "Users";

                userUserControl.UserFormOpened += UserControl_ActionHandler;
                userUserControl.UserChanged += UserControl_ActionHandler;
                userUserControl.UserFormClosed += UserControl_ActionHandler;

                this.placeHolder.Controls.Add(userUserControl);

            }
            else
                userControl.Visible = true;
        }

        private void initializeSellerUserControl()
        {
            this.visibleUserControls(false);
            UserControl userControl = this.selectUserControl("Sellers");

            if (userControl == null)
            {
                SellerUserControl sellerUserControl = new SellerUserControl();
                sellerUserControl.Tag = "Sellers";

                sellerUserControl.SellerFormOpened += UserControl_ActionHandler;
                sellerUserControl.SellerChanged += UserControl_ActionHandler;
                sellerUserControl.SellerFormClosed += UserControl_ActionHandler;

                this.placeHolder.Controls.Add(sellerUserControl);

            }
            else
                userControl.Visible = true;
        }

        private void initializeSettingsUserControl()
        {
            this.visibleUserControls(false);
            UserControl userControl = this.selectUserControl("Settings");

            if (userControl == null)
            {
                SettingsUserControl settingsUserControl = new SettingsUserControl();
                settingsUserControl.Tag = "Settings";

                this.placeHolder.Controls.Add(settingsUserControl);

            }
            else
                userControl.Visible = true;
        }

        private void initializeApplicationLogUserControl()
        {
            this.visibleUserControls(false);
            UserControl userControl = this.selectUserControl("ApplicationLog");

            if (userControl == null)
            {
                ApplicationLogUserControl applicationLogUserControl = new ApplicationLogUserControl(this._appLogs);
                applicationLogUserControl.Tag = "ApplicationLog";

                this.placeHolder.Controls.Add(applicationLogUserControl);

            }
            else
                userControl.Visible = true;
        }

        private void initializeLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                this._userProfile = loginForm.UserProfile;
                this._loginDetails = loginForm.LoginDetails;

                string fullname = this.createFullname(this._userProfile.FirstName, this._userProfile.LastName);
                string loginStatus = $"User {fullname} logged in at {_loginDetails.LoginDate.ToString()}";

                //MessageBox.Show($"{fullname} logged in successfully at {this._userProfile.LoginDate.ToString()}", "Welcome !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.updateStatusBarLoginDetails(fullname, this._loginDetails.LoginDate);

                User user = this.dbContext.User.Where(r => r.Fullname == fullname).FirstOrDefault();
                if (user != null)
                {
                    try
                    {
                        labelActiveProfileText.Text = user.Fullname;
                        byte[] imageData = this.dbContext.UserImage.Where(r => r.userId == user.id && r.isDefault).FirstOrDefault().imageData;
                        this.pictureBoxUserProfile.Image = ImageHelper.GetImageFromBytes(imageData);
                    }
                    catch
                    {
                        this.pictureBoxUserProfile.Image = BitmapResourceLoader.DefaultUser;
                        MessageBox.Show($"No default image for this user has found.\nPlease upload a default image for {user.Fullname}", "No image!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    labelActiveProfileText.Text = "Please create a user from User window.";
                }
            }   
            else
            {
                ToolStripButton button = this.selectToolStripButton("toolStripButtonLogin");
                button.CheckedChanged -= toolStripButtonLogin_CheckedChanged;
                button.Checked = false;
                button.CheckedChanged += toolStripButtonLogin_CheckedChanged;
            }
        }

        #endregion

        #region User-Defined Form Events

        private void UserControl_ActionHandler(string actionType, string message, DateTime eventTime)
        {
            this.addLog(actionType, message, eventTime);
        }

        private void tactionUserControl_TransactionSaved(string actionType, string message, DateTime eventTime)
        {
            this.updateTactionProfileCounts(1);
        }


        #endregion

    }
}
