namespace InvoiceManager_DBFirst
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSync = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSyncSqlite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBatchItemSubTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShops = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPaymentMethods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSellers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemApplicationLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowSidePanel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKeyboardShortcuts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReportABug = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLiveDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelBottomSide = new System.Windows.Forms.Panel();
            this.listBoxSidePanel = new System.Windows.Forms.ListBox();
            this.panelTopSide = new System.Windows.Forms.Panel();
            this.treeViewSidePanel = new System.Windows.Forms.TreeView();
            this.panelSellers = new System.Windows.Forms.Panel();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.dataGridViewSellers = new System.Windows.Forms.DataGridView();
            this.groupBoxSellerOptions = new System.Windows.Forms.GroupBox();
            this.buttonNewSeller = new System.Windows.Forms.Button();
            this.textBoxSellerOptionsWeb = new System.Windows.Forms.TextBox();
            this.labelSellerOptionsWeb = new System.Windows.Forms.Label();
            this.textBoxSellerOptionsEmail = new System.Windows.Forms.TextBox();
            this.labelSellerOptionsEmail = new System.Windows.Forms.Label();
            this.textBoxSellerOptionsTel = new System.Windows.Forms.TextBox();
            this.labelSellerOptionsTel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSellerOptionsSeller = new System.Windows.Forms.TextBox();
            this.labelSellerOptionsAddress = new System.Windows.Forms.Label();
            this.textBoxSellerOptionsAddress = new System.Windows.Forms.TextBox();
            this.buttonDeleteSeller = new System.Windows.Forms.Button();
            this.buttonUpdateSeller = new System.Windows.Forms.Button();
            this.buttonSaveSeller = new System.Windows.Forms.Button();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.groupBoxUserOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxDefaultUserImage = new System.Windows.Forms.CheckBox();
            this.textBoxUserOptionsName = new System.Windows.Forms.TextBox();
            this.textBoxUserOptionsSurname = new System.Windows.Forms.TextBox();
            this.buttonPreviousImage = new System.Windows.Forms.Button();
            this.buttonNextImage = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelUserOptionsName = new System.Windows.Forms.Label();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.textBoxUserOptionsFullname = new System.Windows.Forms.TextBox();
            this.labelUserOptionsFullname = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.labelUserOptionsSurname = new System.Windows.Forms.Label();
            this.panelPaymentMethods = new System.Windows.Forms.Panel();
            this.groupBoxBankCardOptions = new System.Windows.Forms.GroupBox();
            this.textBoxCardOptionsCard = new System.Windows.Forms.TextBox();
            this.comboBoxCardOptionsCardType = new System.Windows.Forms.ComboBox();
            this.checkBoxCardOptionsEdit = new System.Windows.Forms.CheckBox();
            this.buttonNewCard = new System.Windows.Forms.Button();
            this.labelCardOptionsCardType = new System.Windows.Forms.Label();
            this.buttonDeleteCard = new System.Windows.Forms.Button();
            this.buttonUpdateCard = new System.Windows.Forms.Button();
            this.buttonSaveCard = new System.Windows.Forms.Button();
            this.labelCardOptionsCard = new System.Windows.Forms.Label();
            this.groupBoxPaymentMethodOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxPaymentMethodOptionsCardOwner = new System.Windows.Forms.ComboBox();
            this.labelPaymentMethodOptionsCardOwner = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethodOptionsCardType = new System.Windows.Forms.ComboBox();
            this.labelPaymentMethodOptionsCardType = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethodOptionsCard = new System.Windows.Forms.ComboBox();
            this.checkBoxPaymentOptionsEdit = new System.Windows.Forms.CheckBox();
            this.buttonNewPaymentMethod = new System.Windows.Forms.Button();
            this.buttonDeletePaymentMethod = new System.Windows.Forms.Button();
            this.buttonUpdatePaymentMethod = new System.Windows.Forms.Button();
            this.buttonSavePaymentMethod = new System.Windows.Forms.Button();
            this.labelPaymentMethodOptionsPaymentMethod = new System.Windows.Forms.Label();
            this.textBoxPaymentMethodOptionsPaymentMethod = new System.Windows.Forms.TextBox();
            this.labelPaymentMethodOptionsCard = new System.Windows.Forms.Label();
            this.groupBoxPaymentMethods = new System.Windows.Forms.GroupBox();
            this.dataGridViewPaymentMethods = new System.Windows.Forms.DataGridView();
            this.groupBoxBankCards = new System.Windows.Forms.GroupBox();
            this.dataGridViewBankCards = new System.Windows.Forms.DataGridView();
            this.panelShops = new System.Windows.Forms.Panel();
            this.groupBoxShopGroupOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxShopGroupOptionsEdit = new System.Windows.Forms.CheckBox();
            this.buttonNewShopGroup = new System.Windows.Forms.Button();
            this.buttonSaveShopGroup = new System.Windows.Forms.Button();
            this.buttonUpdateShopGroup = new System.Windows.Forms.Button();
            this.buttonDeleteShopGroup = new System.Windows.Forms.Button();
            this.labelShopGroupOptionsOwner = new System.Windows.Forms.Label();
            this.textBoxShopGroupOptionsGroupName = new System.Windows.Forms.TextBox();
            this.labelShopGroupOptionsGroupName = new System.Windows.Forms.Label();
            this.comboBoxShopGroupOptionsShopType = new System.Windows.Forms.ComboBox();
            this.textBoxShopGroupOptionsOwner = new System.Windows.Forms.TextBox();
            this.labelShopGroupOptionsShopType = new System.Windows.Forms.Label();
            this.groupBoxShopGroups = new System.Windows.Forms.GroupBox();
            this.dataGridViewShopGroups = new System.Windows.Forms.DataGridView();
            this.groupBoxShops = new System.Windows.Forms.GroupBox();
            this.dataGridViewShops = new System.Windows.Forms.DataGridView();
            this.groupBoxShopTypes = new System.Windows.Forms.GroupBox();
            this.dataGridViewShopTypes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxShopTypeOptionsShopType = new System.Windows.Forms.ComboBox();
            this.buttonNewShopType = new System.Windows.Forms.Button();
            this.labelShopTypeOptionsShopType = new System.Windows.Forms.Label();
            this.buttonDeleteShopType = new System.Windows.Forms.Button();
            this.buttonUpdateShopType = new System.Windows.Forms.Button();
            this.checkBoxSetRelational = new System.Windows.Forms.CheckBox();
            this.buttonSaveShopType = new System.Windows.Forms.Button();
            this.groupBoxShopOptions = new System.Windows.Forms.GroupBox();
            this.labelShopOptionsShopGroup = new System.Windows.Forms.Label();
            this.comboBoxShopOptionsShopGroup = new System.Windows.Forms.ComboBox();
            this.buttonNewShop = new System.Windows.Forms.Button();
            this.textBoxShopOptionsWeb = new System.Windows.Forms.TextBox();
            this.labelShopOptionsWeb = new System.Windows.Forms.Label();
            this.textBoxShopOptionsEmail = new System.Windows.Forms.TextBox();
            this.labelShopOptionsEmail = new System.Windows.Forms.Label();
            this.textBoxShopOptionsTel = new System.Windows.Forms.TextBox();
            this.labelShopOptionsTel = new System.Windows.Forms.Label();
            this.textBoxShopOptionsNickName = new System.Windows.Forms.TextBox();
            this.labelShopOptionsShopName = new System.Windows.Forms.Label();
            this.textBoxShopOptionsShop = new System.Windows.Forms.TextBox();
            this.labelShopOptionsNickName = new System.Windows.Forms.Label();
            this.labelShopOptionsAddress = new System.Windows.Forms.Label();
            this.textBoxShopOptionsAddress = new System.Windows.Forms.TextBox();
            this.buttonDeleteShop = new System.Windows.Forms.Button();
            this.buttonUpdateShop = new System.Windows.Forms.Button();
            this.buttonSaveShop = new System.Windows.Forms.Button();
            this.panelItems = new System.Windows.Forms.Panel();
            this.groupBoxItemSubTypeOptions = new System.Windows.Forms.GroupBox();
            this.textBoxItemSubTypeOptionsItem = new System.Windows.Forms.TextBox();
            this.comboBoxItemSubTypeOptionsItemSubType = new System.Windows.Forms.ComboBox();
            this.checkBoxItemSubTypeOptionsEdit = new System.Windows.Forms.CheckBox();
            this.buttonNewItemSubType = new System.Windows.Forms.Button();
            this.buttonDeleteItemSubType = new System.Windows.Forms.Button();
            this.buttonUpdateItemSubType = new System.Windows.Forms.Button();
            this.buttonSaveItemSubType = new System.Windows.Forms.Button();
            this.labelItemSubTypeOptionsItem = new System.Windows.Forms.Label();
            this.labelItemSubTypeOptionsItemSubType = new System.Windows.Forms.Label();
            this.groupBoxItemTopGroups = new System.Windows.Forms.GroupBox();
            this.dataGridViewItemTopGroups = new System.Windows.Forms.DataGridView();
            this.groupBoxItemTopGroupOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxTopGroupOptionsTopGroup = new System.Windows.Forms.ComboBox();
            this.buttonNewTopGroup = new System.Windows.Forms.Button();
            this.labelTopGroupOptionsTopGroup = new System.Windows.Forms.Label();
            this.buttonDeleteTopGroup = new System.Windows.Forms.Button();
            this.buttonUpdateTopGroup = new System.Windows.Forms.Button();
            this.buttonSaveTopGroup = new System.Windows.Forms.Button();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.groupBoxItemOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxItemOptionsEdit = new System.Windows.Forms.CheckBox();
            this.buttonNewItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.textBoxItemOptionsNote = new System.Windows.Forms.TextBox();
            this.labelItemOptionsNote = new System.Windows.Forms.Label();
            this.comboBoxItemOptionsGroup = new System.Windows.Forms.ComboBox();
            this.labelItemOptionsGroup = new System.Windows.Forms.Label();
            this.textBoxItemOptionsItem = new System.Windows.Forms.TextBox();
            this.labelItemOptionsItem = new System.Windows.Forms.Label();
            this.groupBoxItemGroups = new System.Windows.Forms.GroupBox();
            this.dataGridViewItemGroups = new System.Windows.Forms.DataGridView();
            this.groupBoxItemGroupOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxGroupOptionsEdit = new System.Windows.Forms.CheckBox();
            this.comboBoxGroupOptionsTopGroup = new System.Windows.Forms.ComboBox();
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.textBoxGroupOptionsGroup = new System.Windows.Forms.TextBox();
            this.labelGroupOptionsGroup = new System.Windows.Forms.Label();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.buttonUpdateGroup = new System.Windows.Forms.Button();
            this.buttonSaveGroup = new System.Windows.Forms.Button();
            this.labelGroupOptionsTopGroup = new System.Windows.Forms.Label();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.groupBoxTactionOptions = new System.Windows.Forms.GroupBox();
            this.textBoxTotalVatPrice = new System.Windows.Forms.TextBox();
            this.labelTotalVatPrice = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.buttonCancelTaction = new System.Windows.Forms.Button();
            this.checkBoxTactionsEditable = new System.Windows.Forms.CheckBox();
            this.textBoxSeller = new System.Windows.Forms.TextBox();
            this.dateTimePickerTactionDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxSeller = new System.Windows.Forms.CheckBox();
            this.labelTactionDate = new System.Windows.Forms.Label();
            this.buttonNewTaction = new System.Windows.Forms.Button();
            this.labelShop = new System.Windows.Forms.Label();
            this.buttonDeleteTaction = new System.Windows.Forms.Button();
            this.textBoxShop = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.buttonSaveTaction = new System.Windows.Forms.Button();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTactionNo = new System.Windows.Forms.Label();
            this.buttonUpdateTaction = new System.Windows.Forms.Button();
            this.textBoxTactionNo = new System.Windows.Forms.TextBox();
            this.groupBoxTactionDetailsOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxItemSubType = new System.Windows.Forms.ComboBox();
            this.buttonAdviceLastUnitPrice = new System.Windows.Forms.Button();
            this.labelVatPercantage = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.labelItemGroup = new System.Windows.Forms.Label();
            this.textBoxItemGroup = new System.Windows.Forms.TextBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelItemSubType = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.labelVat = new System.Windows.Forms.Label();
            this.textBoxVat = new System.Windows.Forms.TextBox();
            this.labelDiscountRate = new System.Windows.Forms.Label();
            this.textBoxDiscountRate = new System.Windows.Forms.TextBox();
            this.labelDiscountedPrice = new System.Windows.Forms.Label();
            this.buttonRemoveDetail = new System.Windows.Forms.Button();
            this.buttonUpdateDetail = new System.Windows.Forms.Button();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.checkBoxDetailsEditable = new System.Windows.Forms.CheckBox();
            this.textBoxDiscountedPrice = new System.Windows.Forms.TextBox();
            this.labelDetailsNote = new System.Windows.Forms.Label();
            this.buttonAddDetail = new System.Windows.Forms.Button();
            this.textBoxDetailsNote = new System.Windows.Forms.TextBox();
            this.groupBoxTactionDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewTactionDetails = new System.Windows.Forms.DataGridView();
            this.groupBoxTactions = new System.Windows.Forms.GroupBox();
            this.dataGridViewTactions = new System.Windows.Forms.DataGridView();
            this.panelApplicationLog = new System.Windows.Forms.Panel();
            this.groupBoxWithListView = new System.Windows.Forms.GroupBox();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.labelHorizontalLine1 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelBottomSide.SuspendLayout();
            this.panelTopSide.SuspendLayout();
            this.panelSellers.SuspendLayout();
            this.groupBoxSeller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellers)).BeginInit();
            this.groupBoxSellerOptions.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.groupBoxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.groupBoxUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelPaymentMethods.SuspendLayout();
            this.groupBoxBankCardOptions.SuspendLayout();
            this.groupBoxPaymentMethodOptions.SuspendLayout();
            this.groupBoxPaymentMethods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentMethods)).BeginInit();
            this.groupBoxBankCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankCards)).BeginInit();
            this.panelShops.SuspendLayout();
            this.groupBoxShopGroupOptions.SuspendLayout();
            this.groupBoxShopGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopGroups)).BeginInit();
            this.groupBoxShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            this.groupBoxShopTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopTypes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxShopOptions.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.groupBoxItemSubTypeOptions.SuspendLayout();
            this.groupBoxItemTopGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemTopGroups)).BeginInit();
            this.groupBoxItemTopGroupOptions.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.groupBoxItemOptions.SuspendLayout();
            this.groupBoxItemGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemGroups)).BeginInit();
            this.groupBoxItemGroupOptions.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.groupBoxTactionOptions.SuspendLayout();
            this.groupBoxTactionDetailsOptions.SuspendLayout();
            this.groupBoxTactionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionDetails)).BeginInit();
            this.groupBoxTactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactions)).BeginInit();
            this.panelApplicationLog.SuspendLayout();
            this.groupBoxWithListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemWindows,
            this.toolsToolStripMenuItem,
            this.toolStripMenuItemView,
            this.toolStripMenuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1910, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSync,
            this.toolStripMenuItemBatch,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "&File";
            // 
            // toolStripMenuItemSync
            // 
            this.toolStripMenuItemSync.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSyncSqlite});
            this.toolStripMenuItemSync.Name = "toolStripMenuItemSync";
            this.toolStripMenuItemSync.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemSync.Text = "Sync";
            // 
            // toolStripMenuItemSyncSqlite
            // 
            this.toolStripMenuItemSyncSqlite.Name = "toolStripMenuItemSyncSqlite";
            this.toolStripMenuItemSyncSqlite.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemSyncSqlite.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemSyncSqlite.Text = "Sqlite";
            this.toolStripMenuItemSyncSqlite.Click += new System.EventHandler(this.toolStripMenuItemSyncSqlite_Click);
            // 
            // toolStripMenuItemBatch
            // 
            this.toolStripMenuItemBatch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBatchItemSubTypes});
            this.toolStripMenuItemBatch.Name = "toolStripMenuItemBatch";
            this.toolStripMenuItemBatch.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemBatch.Text = "Batch";
            // 
            // toolStripMenuItemBatchItemSubTypes
            // 
            this.toolStripMenuItemBatchItemSubTypes.Name = "toolStripMenuItemBatchItemSubTypes";
            this.toolStripMenuItemBatchItemSubTypes.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemBatchItemSubTypes.Text = "ItemSubTypes";
            this.toolStripMenuItemBatchItemSubTypes.Click += new System.EventHandler(this.toolStripMenuItemBatchItemSubTypes_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.ShortcutKeyDisplayString = "";
            this.toolStripMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItemWindows
            // 
            this.toolStripMenuItemWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTransactions,
            this.toolStripMenuItemItems,
            this.toolStripMenuItemShops,
            this.toolStripMenuItemPaymentMethods,
            this.toolStripMenuItemUsers,
            this.toolStripMenuItemSellers,
            this.toolStripMenuItemApplicationLog});
            this.toolStripMenuItemWindows.Name = "toolStripMenuItemWindows";
            this.toolStripMenuItemWindows.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItemWindows.Text = "Actions";
            // 
            // toolStripMenuItemTransactions
            // 
            this.toolStripMenuItemTransactions.Name = "toolStripMenuItemTransactions";
            this.toolStripMenuItemTransactions.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolStripMenuItemTransactions.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemTransactions.Text = "Transactions";
            this.toolStripMenuItemTransactions.Click += new System.EventHandler(this.toolStripMenuItemTransactions_Click);
            // 
            // toolStripMenuItemItems
            // 
            this.toolStripMenuItemItems.Name = "toolStripMenuItemItems";
            this.toolStripMenuItemItems.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.toolStripMenuItemItems.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemItems.Text = "Items";
            this.toolStripMenuItemItems.Click += new System.EventHandler(this.toolStripMenuItemItems_Click);
            // 
            // toolStripMenuItemShops
            // 
            this.toolStripMenuItemShops.Name = "toolStripMenuItemShops";
            this.toolStripMenuItemShops.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemShops.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemShops.Text = "Shops";
            this.toolStripMenuItemShops.Click += new System.EventHandler(this.toolStripMenuItemShops_Click);
            // 
            // toolStripMenuItemPaymentMethods
            // 
            this.toolStripMenuItemPaymentMethods.Name = "toolStripMenuItemPaymentMethods";
            this.toolStripMenuItemPaymentMethods.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItemPaymentMethods.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemPaymentMethods.Text = "Payment Methods";
            this.toolStripMenuItemPaymentMethods.Click += new System.EventHandler(this.toolStripMenuItemPaymentMethods_Click);
            // 
            // toolStripMenuItemUsers
            // 
            this.toolStripMenuItemUsers.Name = "toolStripMenuItemUsers";
            this.toolStripMenuItemUsers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.toolStripMenuItemUsers.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemUsers.Text = "Users";
            this.toolStripMenuItemUsers.Click += new System.EventHandler(this.toolStripMenuItemUsers_Click);
            // 
            // toolStripMenuItemSellers
            // 
            this.toolStripMenuItemSellers.Name = "toolStripMenuItemSellers";
            this.toolStripMenuItemSellers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemSellers.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemSellers.Text = "Sellers";
            this.toolStripMenuItemSellers.Click += new System.EventHandler(this.toolStripMenuItemSellers_Click);
            // 
            // toolStripMenuItemApplicationLog
            // 
            this.toolStripMenuItemApplicationLog.Name = "toolStripMenuItemApplicationLog";
            this.toolStripMenuItemApplicationLog.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemApplicationLog.Text = "Application Log";
            this.toolStripMenuItemApplicationLog.Click += new System.EventHandler(this.toolStripMenuItemApplicationLog_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSettings});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItemSettings.Text = "Settings";
            this.toolStripMenuItemSettings.Click += new System.EventHandler(this.toolStripMenuItemSettings_Click);
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAlwaysOnTop,
            this.toolStripMenuItemShowSidePanel,
            this.toolbarToolStripMenuItemShow});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemView.Text = "View";
            // 
            // toolStripMenuItemAlwaysOnTop
            // 
            this.toolStripMenuItemAlwaysOnTop.Name = "toolStripMenuItemAlwaysOnTop";
            this.toolStripMenuItemAlwaysOnTop.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItemAlwaysOnTop.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItemAlwaysOnTop.Text = "Always on Top";
            // 
            // toolStripMenuItemShowSidePanel
            // 
            this.toolStripMenuItemShowSidePanel.Checked = true;
            this.toolStripMenuItemShowSidePanel.CheckOnClick = true;
            this.toolStripMenuItemShowSidePanel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemShowSidePanel.Name = "toolStripMenuItemShowSidePanel";
            this.toolStripMenuItemShowSidePanel.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItemShowSidePanel.Text = "Show Side Panel";
            // 
            // toolbarToolStripMenuItemShow
            // 
            this.toolbarToolStripMenuItemShow.Checked = true;
            this.toolbarToolStripMenuItemShow.CheckOnClick = true;
            this.toolbarToolStripMenuItemShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolbarToolStripMenuItemShow.Name = "toolbarToolStripMenuItemShow";
            this.toolbarToolStripMenuItemShow.Size = new System.Drawing.Size(224, 22);
            this.toolbarToolStripMenuItemShow.Text = "Show Toolbar";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemKeyboardShortcuts,
            this.toolStripMenuItemReportABug,
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // toolStripMenuItemKeyboardShortcuts
            // 
            this.toolStripMenuItemKeyboardShortcuts.Name = "toolStripMenuItemKeyboardShortcuts";
            this.toolStripMenuItemKeyboardShortcuts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.toolStripMenuItemKeyboardShortcuts.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItemKeyboardShortcuts.Text = "Keyboard Shortcuts";
            // 
            // toolStripMenuItemReportABug
            // 
            this.toolStripMenuItemReportABug.Name = "toolStripMenuItemReportABug";
            this.toolStripMenuItemReportABug.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItemReportABug.Text = "Report a Bug";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItemAbout.Text = "About";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLiveDateTime});
            this.statusStripMain.Location = new System.Drawing.Point(0, 895);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1910, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLiveDateTime
            // 
            this.toolStripStatusLabelLiveDateTime.Name = "toolStripStatusLabelLiveDateTime";
            this.toolStripStatusLabelLiveDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.Location = new System.Drawing.Point(0, 54);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelBottomSide);
            this.splitContainerMain.Panel1.Controls.Add(this.panelTopSide);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelSellers);
            this.splitContainerMain.Panel2.Controls.Add(this.panelUsers);
            this.splitContainerMain.Panel2.Controls.Add(this.panelPaymentMethods);
            this.splitContainerMain.Panel2.Controls.Add(this.panelShops);
            this.splitContainerMain.Panel2.Controls.Add(this.panelItems);
            this.splitContainerMain.Panel2.Controls.Add(this.panelTransactions);
            this.splitContainerMain.Panel2.Controls.Add(this.panelApplicationLog);
            this.splitContainerMain.Size = new System.Drawing.Size(1909, 838);
            this.splitContainerMain.SplitterDistance = 223;
            this.splitContainerMain.TabIndex = 5;
            // 
            // panelBottomSide
            // 
            this.panelBottomSide.Controls.Add(this.listBoxSidePanel);
            this.panelBottomSide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomSide.Location = new System.Drawing.Point(0, 612);
            this.panelBottomSide.Name = "panelBottomSide";
            this.panelBottomSide.Size = new System.Drawing.Size(223, 226);
            this.panelBottomSide.TabIndex = 2;
            // 
            // listBoxSidePanel
            // 
            this.listBoxSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSidePanel.FormattingEnabled = true;
            this.listBoxSidePanel.ItemHeight = 15;
            this.listBoxSidePanel.Location = new System.Drawing.Point(0, 0);
            this.listBoxSidePanel.Name = "listBoxSidePanel";
            this.listBoxSidePanel.Size = new System.Drawing.Size(223, 226);
            this.listBoxSidePanel.TabIndex = 0;
            // 
            // panelTopSide
            // 
            this.panelTopSide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopSide.Controls.Add(this.treeViewSidePanel);
            this.panelTopSide.Location = new System.Drawing.Point(0, 0);
            this.panelTopSide.Name = "panelTopSide";
            this.panelTopSide.Size = new System.Drawing.Size(225, 606);
            this.panelTopSide.TabIndex = 1;
            // 
            // treeViewSidePanel
            // 
            this.treeViewSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSidePanel.Location = new System.Drawing.Point(0, 0);
            this.treeViewSidePanel.Name = "treeViewSidePanel";
            this.treeViewSidePanel.Size = new System.Drawing.Size(225, 606);
            this.treeViewSidePanel.TabIndex = 0;
            // 
            // panelSellers
            // 
            this.panelSellers.Controls.Add(this.groupBoxSeller);
            this.panelSellers.Controls.Add(this.groupBoxSellerOptions);
            this.panelSellers.Location = new System.Drawing.Point(1225, 9);
            this.panelSellers.Name = "panelSellers";
            this.panelSellers.Size = new System.Drawing.Size(186, 179);
            this.panelSellers.TabIndex = 11;
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSeller.Controls.Add(this.dataGridViewSellers);
            this.groupBoxSeller.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSeller.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSeller.Size = new System.Drawing.Size(561, 0);
            this.groupBoxSeller.TabIndex = 17;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Sellers";
            // 
            // dataGridViewSellers
            // 
            this.dataGridViewSellers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSellers.Location = new System.Drawing.Point(7, 19);
            this.dataGridViewSellers.Name = "dataGridViewSellers";
            this.dataGridViewSellers.Size = new System.Drawing.Size(547, 0);
            this.dataGridViewSellers.TabIndex = 0;
            // 
            // groupBoxSellerOptions
            // 
            this.groupBoxSellerOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSellerOptions.Controls.Add(this.buttonNewSeller);
            this.groupBoxSellerOptions.Controls.Add(this.textBoxSellerOptionsWeb);
            this.groupBoxSellerOptions.Controls.Add(this.labelSellerOptionsWeb);
            this.groupBoxSellerOptions.Controls.Add(this.textBoxSellerOptionsEmail);
            this.groupBoxSellerOptions.Controls.Add(this.labelSellerOptionsEmail);
            this.groupBoxSellerOptions.Controls.Add(this.textBoxSellerOptionsTel);
            this.groupBoxSellerOptions.Controls.Add(this.labelSellerOptionsTel);
            this.groupBoxSellerOptions.Controls.Add(this.label1);
            this.groupBoxSellerOptions.Controls.Add(this.textBoxSellerOptionsSeller);
            this.groupBoxSellerOptions.Controls.Add(this.labelSellerOptionsAddress);
            this.groupBoxSellerOptions.Controls.Add(this.textBoxSellerOptionsAddress);
            this.groupBoxSellerOptions.Controls.Add(this.buttonDeleteSeller);
            this.groupBoxSellerOptions.Controls.Add(this.buttonUpdateSeller);
            this.groupBoxSellerOptions.Controls.Add(this.buttonSaveSeller);
            this.groupBoxSellerOptions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSellerOptions.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSellerOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSellerOptions.Name = "groupBoxSellerOptions";
            this.groupBoxSellerOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSellerOptions.Size = new System.Drawing.Size(561, 166);
            this.groupBoxSellerOptions.TabIndex = 18;
            this.groupBoxSellerOptions.TabStop = false;
            this.groupBoxSellerOptions.Text = "Seller Options";
            // 
            // buttonNewSeller
            // 
            this.buttonNewSeller.Location = new System.Drawing.Point(188, 128);
            this.buttonNewSeller.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewSeller.Name = "buttonNewSeller";
            this.buttonNewSeller.Size = new System.Drawing.Size(78, 27);
            this.buttonNewSeller.TabIndex = 34;
            this.buttonNewSeller.Text = "New";
            this.buttonNewSeller.UseVisualStyleBackColor = true;
            // 
            // textBoxSellerOptionsWeb
            // 
            this.textBoxSellerOptionsWeb.Location = new System.Drawing.Point(366, 93);
            this.textBoxSellerOptionsWeb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSellerOptionsWeb.Name = "textBoxSellerOptionsWeb";
            this.textBoxSellerOptionsWeb.Size = new System.Drawing.Size(164, 23);
            this.textBoxSellerOptionsWeb.TabIndex = 33;
            // 
            // labelSellerOptionsWeb
            // 
            this.labelSellerOptionsWeb.AutoSize = true;
            this.labelSellerOptionsWeb.Location = new System.Drawing.Point(321, 97);
            this.labelSellerOptionsWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSellerOptionsWeb.Name = "labelSellerOptionsWeb";
            this.labelSellerOptionsWeb.Size = new System.Drawing.Size(32, 15);
            this.labelSellerOptionsWeb.TabIndex = 32;
            this.labelSellerOptionsWeb.Text = "Web";
            // 
            // textBoxSellerOptionsEmail
            // 
            this.textBoxSellerOptionsEmail.Location = new System.Drawing.Point(366, 60);
            this.textBoxSellerOptionsEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSellerOptionsEmail.Name = "textBoxSellerOptionsEmail";
            this.textBoxSellerOptionsEmail.Size = new System.Drawing.Size(164, 23);
            this.textBoxSellerOptionsEmail.TabIndex = 31;
            // 
            // labelSellerOptionsEmail
            // 
            this.labelSellerOptionsEmail.AutoSize = true;
            this.labelSellerOptionsEmail.Location = new System.Drawing.Point(311, 65);
            this.labelSellerOptionsEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSellerOptionsEmail.Name = "labelSellerOptionsEmail";
            this.labelSellerOptionsEmail.Size = new System.Drawing.Size(42, 15);
            this.labelSellerOptionsEmail.TabIndex = 30;
            this.labelSellerOptionsEmail.Text = "E-mail";
            // 
            // textBoxSellerOptionsTel
            // 
            this.textBoxSellerOptionsTel.Location = new System.Drawing.Point(366, 27);
            this.textBoxSellerOptionsTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSellerOptionsTel.Name = "textBoxSellerOptionsTel";
            this.textBoxSellerOptionsTel.Size = new System.Drawing.Size(164, 23);
            this.textBoxSellerOptionsTel.TabIndex = 29;
            // 
            // labelSellerOptionsTel
            // 
            this.labelSellerOptionsTel.AutoSize = true;
            this.labelSellerOptionsTel.Location = new System.Drawing.Point(331, 31);
            this.labelSellerOptionsTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSellerOptionsTel.Name = "labelSellerOptionsTel";
            this.labelSellerOptionsTel.Size = new System.Drawing.Size(22, 15);
            this.labelSellerOptionsTel.TabIndex = 28;
            this.labelSellerOptionsTel.Text = "Tel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seller";
            // 
            // textBoxSellerOptionsSeller
            // 
            this.textBoxSellerOptionsSeller.Location = new System.Drawing.Point(81, 27);
            this.textBoxSellerOptionsSeller.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSellerOptionsSeller.Name = "textBoxSellerOptionsSeller";
            this.textBoxSellerOptionsSeller.Size = new System.Drawing.Size(200, 23);
            this.textBoxSellerOptionsSeller.TabIndex = 4;
            // 
            // labelSellerOptionsAddress
            // 
            this.labelSellerOptionsAddress.AutoSize = true;
            this.labelSellerOptionsAddress.Location = new System.Drawing.Point(13, 63);
            this.labelSellerOptionsAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSellerOptionsAddress.Name = "labelSellerOptionsAddress";
            this.labelSellerOptionsAddress.Size = new System.Drawing.Size(51, 15);
            this.labelSellerOptionsAddress.TabIndex = 7;
            this.labelSellerOptionsAddress.Text = "Address";
            // 
            // textBoxSellerOptionsAddress
            // 
            this.textBoxSellerOptionsAddress.Location = new System.Drawing.Point(81, 60);
            this.textBoxSellerOptionsAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSellerOptionsAddress.Multiline = true;
            this.textBoxSellerOptionsAddress.Name = "textBoxSellerOptionsAddress";
            this.textBoxSellerOptionsAddress.Size = new System.Drawing.Size(200, 56);
            this.textBoxSellerOptionsAddress.TabIndex = 8;
            // 
            // buttonDeleteSeller
            // 
            this.buttonDeleteSeller.Location = new System.Drawing.Point(452, 128);
            this.buttonDeleteSeller.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteSeller.Name = "buttonDeleteSeller";
            this.buttonDeleteSeller.Size = new System.Drawing.Size(78, 27);
            this.buttonDeleteSeller.TabIndex = 27;
            this.buttonDeleteSeller.Text = "Delete";
            this.buttonDeleteSeller.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateSeller
            // 
            this.buttonUpdateSeller.Location = new System.Drawing.Point(364, 128);
            this.buttonUpdateSeller.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateSeller.Name = "buttonUpdateSeller";
            this.buttonUpdateSeller.Size = new System.Drawing.Size(78, 27);
            this.buttonUpdateSeller.TabIndex = 26;
            this.buttonUpdateSeller.Text = "Update";
            this.buttonUpdateSeller.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSeller
            // 
            this.buttonSaveSeller.Location = new System.Drawing.Point(276, 128);
            this.buttonSaveSeller.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveSeller.Name = "buttonSaveSeller";
            this.buttonSaveSeller.Size = new System.Drawing.Size(78, 27);
            this.buttonSaveSeller.TabIndex = 25;
            this.buttonSaveSeller.Text = "Save";
            this.buttonSaveSeller.UseVisualStyleBackColor = true;
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.groupBoxUsers);
            this.panelUsers.Controls.Add(this.groupBoxUserOptions);
            this.panelUsers.Location = new System.Drawing.Point(1027, 9);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(187, 179);
            this.panelUsers.TabIndex = 10;
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxUsers.Controls.Add(this.dataGridViewUsers);
            this.groupBoxUsers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsers.Location = new System.Drawing.Point(8, 6);
            this.groupBoxUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxUsers.Size = new System.Drawing.Size(609, 171);
            this.groupBoxUsers.TabIndex = 13;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Users";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(595, 143);
            this.dataGridViewUsers.TabIndex = 13;
            this.dataGridViewUsers.TabStop = false;
            // 
            // groupBoxUserOptions
            // 
            this.groupBoxUserOptions.Controls.Add(this.checkBoxDefaultUserImage);
            this.groupBoxUserOptions.Controls.Add(this.textBoxUserOptionsName);
            this.groupBoxUserOptions.Controls.Add(this.textBoxUserOptionsSurname);
            this.groupBoxUserOptions.Controls.Add(this.buttonPreviousImage);
            this.groupBoxUserOptions.Controls.Add(this.buttonNextImage);
            this.groupBoxUserOptions.Controls.Add(this.buttonAddImage);
            this.groupBoxUserOptions.Controls.Add(this.buttonDeleteImage);
            this.groupBoxUserOptions.Controls.Add(this.pictureBoxUser);
            this.groupBoxUserOptions.Controls.Add(this.labelUserOptionsName);
            this.groupBoxUserOptions.Controls.Add(this.buttonNewUser);
            this.groupBoxUserOptions.Controls.Add(this.textBoxUserOptionsFullname);
            this.groupBoxUserOptions.Controls.Add(this.labelUserOptionsFullname);
            this.groupBoxUserOptions.Controls.Add(this.buttonDeleteUser);
            this.groupBoxUserOptions.Controls.Add(this.buttonUpdateUser);
            this.groupBoxUserOptions.Controls.Add(this.buttonSaveUser);
            this.groupBoxUserOptions.Controls.Add(this.labelUserOptionsSurname);
            this.groupBoxUserOptions.Location = new System.Drawing.Point(624, 6);
            this.groupBoxUserOptions.Name = "groupBoxUserOptions";
            this.groupBoxUserOptions.Size = new System.Drawing.Size(553, 226);
            this.groupBoxUserOptions.TabIndex = 14;
            this.groupBoxUserOptions.TabStop = false;
            this.groupBoxUserOptions.Text = "User Options";
            // 
            // checkBoxDefaultUserImage
            // 
            this.checkBoxDefaultUserImage.AutoSize = true;
            this.checkBoxDefaultUserImage.Location = new System.Drawing.Point(160, 167);
            this.checkBoxDefaultUserImage.Name = "checkBoxDefaultUserImage";
            this.checkBoxDefaultUserImage.Size = new System.Drawing.Size(66, 19);
            this.checkBoxDefaultUserImage.TabIndex = 16;
            this.checkBoxDefaultUserImage.Text = "Default";
            this.checkBoxDefaultUserImage.UseVisualStyleBackColor = true;
            // 
            // textBoxUserOptionsName
            // 
            this.textBoxUserOptionsName.Location = new System.Drawing.Point(296, 24);
            this.textBoxUserOptionsName.Name = "textBoxUserOptionsName";
            this.textBoxUserOptionsName.Size = new System.Drawing.Size(240, 23);
            this.textBoxUserOptionsName.TabIndex = 1;
            // 
            // textBoxUserOptionsSurname
            // 
            this.textBoxUserOptionsSurname.Location = new System.Drawing.Point(296, 52);
            this.textBoxUserOptionsSurname.Name = "textBoxUserOptionsSurname";
            this.textBoxUserOptionsSurname.Size = new System.Drawing.Size(240, 23);
            this.textBoxUserOptionsSurname.TabIndex = 2;
            // 
            // buttonPreviousImage
            // 
            this.buttonPreviousImage.Location = new System.Drawing.Point(13, 188);
            this.buttonPreviousImage.Name = "buttonPreviousImage";
            this.buttonPreviousImage.Size = new System.Drawing.Size(23, 23);
            this.buttonPreviousImage.TabIndex = 10;
            this.buttonPreviousImage.Text = "<";
            this.buttonPreviousImage.UseVisualStyleBackColor = true;
            // 
            // buttonNextImage
            // 
            this.buttonNextImage.Location = new System.Drawing.Point(131, 188);
            this.buttonNextImage.Name = "buttonNextImage";
            this.buttonNextImage.Size = new System.Drawing.Size(23, 23);
            this.buttonNextImage.TabIndex = 11;
            this.buttonNextImage.Text = ">";
            this.buttonNextImage.UseVisualStyleBackColor = true;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(160, 24);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(50, 23);
            this.buttonAddImage.TabIndex = 8;
            this.buttonAddImage.Text = "Add";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.Location = new System.Drawing.Point(160, 53);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(50, 23);
            this.buttonDeleteImage.TabIndex = 9;
            this.buttonDeleteImage.Text = "Delete";
            this.buttonDeleteImage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Location = new System.Drawing.Point(13, 24);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(141, 160);
            this.pictureBoxUser.TabIndex = 15;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelUserOptionsName
            // 
            this.labelUserOptionsName.AutoSize = true;
            this.labelUserOptionsName.Location = new System.Drawing.Point(251, 28);
            this.labelUserOptionsName.Name = "labelUserOptionsName";
            this.labelUserOptionsName.Size = new System.Drawing.Size(38, 15);
            this.labelUserOptionsName.TabIndex = 13;
            this.labelUserOptionsName.Text = "Name";
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(296, 114);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(55, 23);
            this.buttonNewUser.TabIndex = 4;
            this.buttonNewUser.Text = "New";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            // 
            // textBoxUserOptionsFullname
            // 
            this.textBoxUserOptionsFullname.Location = new System.Drawing.Point(296, 80);
            this.textBoxUserOptionsFullname.Name = "textBoxUserOptionsFullname";
            this.textBoxUserOptionsFullname.Size = new System.Drawing.Size(240, 23);
            this.textBoxUserOptionsFullname.TabIndex = 3;
            // 
            // labelUserOptionsFullname
            // 
            this.labelUserOptionsFullname.AutoSize = true;
            this.labelUserOptionsFullname.Location = new System.Drawing.Point(237, 84);
            this.labelUserOptionsFullname.Name = "labelUserOptionsFullname";
            this.labelUserOptionsFullname.Size = new System.Drawing.Size(58, 15);
            this.labelUserOptionsFullname.TabIndex = 9;
            this.labelUserOptionsFullname.Text = "Fullname";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(481, 114);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(55, 23);
            this.buttonDeleteUser.TabIndex = 7;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Location = new System.Drawing.Point(419, 114);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(55, 23);
            this.buttonUpdateUser.TabIndex = 6;
            this.buttonUpdateUser.Text = "Update";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Location = new System.Drawing.Point(358, 114);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(55, 23);
            this.buttonSaveUser.TabIndex = 5;
            this.buttonSaveUser.Text = "Save";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            // 
            // labelUserOptionsSurname
            // 
            this.labelUserOptionsSurname.AutoSize = true;
            this.labelUserOptionsSurname.Location = new System.Drawing.Point(237, 55);
            this.labelUserOptionsSurname.Name = "labelUserOptionsSurname";
            this.labelUserOptionsSurname.Size = new System.Drawing.Size(55, 15);
            this.labelUserOptionsSurname.TabIndex = 0;
            this.labelUserOptionsSurname.Text = "Surname";
            // 
            // panelPaymentMethods
            // 
            this.panelPaymentMethods.Controls.Add(this.groupBoxBankCardOptions);
            this.panelPaymentMethods.Controls.Add(this.groupBoxPaymentMethodOptions);
            this.panelPaymentMethods.Controls.Add(this.groupBoxPaymentMethods);
            this.panelPaymentMethods.Controls.Add(this.groupBoxBankCards);
            this.panelPaymentMethods.Location = new System.Drawing.Point(823, 3);
            this.panelPaymentMethods.Name = "panelPaymentMethods";
            this.panelPaymentMethods.Size = new System.Drawing.Size(197, 185);
            this.panelPaymentMethods.TabIndex = 9;
            // 
            // groupBoxBankCardOptions
            // 
            this.groupBoxBankCardOptions.Controls.Add(this.textBoxCardOptionsCard);
            this.groupBoxBankCardOptions.Controls.Add(this.comboBoxCardOptionsCardType);
            this.groupBoxBankCardOptions.Controls.Add(this.checkBoxCardOptionsEdit);
            this.groupBoxBankCardOptions.Controls.Add(this.buttonNewCard);
            this.groupBoxBankCardOptions.Controls.Add(this.labelCardOptionsCardType);
            this.groupBoxBankCardOptions.Controls.Add(this.buttonDeleteCard);
            this.groupBoxBankCardOptions.Controls.Add(this.buttonUpdateCard);
            this.groupBoxBankCardOptions.Controls.Add(this.buttonSaveCard);
            this.groupBoxBankCardOptions.Controls.Add(this.labelCardOptionsCard);
            this.groupBoxBankCardOptions.Location = new System.Drawing.Point(1036, 6);
            this.groupBoxBankCardOptions.Name = "groupBoxBankCardOptions";
            this.groupBoxBankCardOptions.Size = new System.Drawing.Size(392, 125);
            this.groupBoxBankCardOptions.TabIndex = 16;
            this.groupBoxBankCardOptions.TabStop = false;
            this.groupBoxBankCardOptions.Text = "Card Options";
            // 
            // textBoxCardOptionsCard
            // 
            this.textBoxCardOptionsCard.Location = new System.Drawing.Point(94, 31);
            this.textBoxCardOptionsCard.Name = "textBoxCardOptionsCard";
            this.textBoxCardOptionsCard.Size = new System.Drawing.Size(284, 23);
            this.textBoxCardOptionsCard.TabIndex = 11;
            // 
            // comboBoxCardOptionsCardType
            // 
            this.comboBoxCardOptionsCardType.FormattingEnabled = true;
            this.comboBoxCardOptionsCardType.Location = new System.Drawing.Point(94, 61);
            this.comboBoxCardOptionsCardType.Name = "comboBoxCardOptionsCardType";
            this.comboBoxCardOptionsCardType.Size = new System.Drawing.Size(284, 23);
            this.comboBoxCardOptionsCardType.TabIndex = 13;
            // 
            // checkBoxCardOptionsEdit
            // 
            this.checkBoxCardOptionsEdit.AutoSize = true;
            this.checkBoxCardOptionsEdit.Location = new System.Drawing.Point(7, 96);
            this.checkBoxCardOptionsEdit.Name = "checkBoxCardOptionsEdit";
            this.checkBoxCardOptionsEdit.Size = new System.Drawing.Size(47, 19);
            this.checkBoxCardOptionsEdit.TabIndex = 11;
            this.checkBoxCardOptionsEdit.Text = "Edit";
            this.checkBoxCardOptionsEdit.UseVisualStyleBackColor = true;
            // 
            // buttonNewCard
            // 
            this.buttonNewCard.Location = new System.Drawing.Point(94, 92);
            this.buttonNewCard.Name = "buttonNewCard";
            this.buttonNewCard.Size = new System.Drawing.Size(65, 23);
            this.buttonNewCard.TabIndex = 11;
            this.buttonNewCard.Text = "New";
            this.buttonNewCard.UseVisualStyleBackColor = true;
            // 
            // labelCardOptionsCardType
            // 
            this.labelCardOptionsCardType.AutoSize = true;
            this.labelCardOptionsCardType.Location = new System.Drawing.Point(40, 66);
            this.labelCardOptionsCardType.Name = "labelCardOptionsCardType";
            this.labelCardOptionsCardType.Size = new System.Drawing.Size(31, 15);
            this.labelCardOptionsCardType.TabIndex = 9;
            this.labelCardOptionsCardType.Text = "Type";
            // 
            // buttonDeleteCard
            // 
            this.buttonDeleteCard.Location = new System.Drawing.Point(313, 92);
            this.buttonDeleteCard.Name = "buttonDeleteCard";
            this.buttonDeleteCard.Size = new System.Drawing.Size(65, 23);
            this.buttonDeleteCard.TabIndex = 8;
            this.buttonDeleteCard.Text = "Delete";
            this.buttonDeleteCard.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCard
            // 
            this.buttonUpdateCard.Location = new System.Drawing.Point(240, 92);
            this.buttonUpdateCard.Name = "buttonUpdateCard";
            this.buttonUpdateCard.Size = new System.Drawing.Size(65, 23);
            this.buttonUpdateCard.TabIndex = 7;
            this.buttonUpdateCard.Text = "Update";
            this.buttonUpdateCard.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCard
            // 
            this.buttonSaveCard.Location = new System.Drawing.Point(167, 92);
            this.buttonSaveCard.Name = "buttonSaveCard";
            this.buttonSaveCard.Size = new System.Drawing.Size(65, 23);
            this.buttonSaveCard.TabIndex = 6;
            this.buttonSaveCard.Text = "Save";
            this.buttonSaveCard.UseVisualStyleBackColor = true;
            // 
            // labelCardOptionsCard
            // 
            this.labelCardOptionsCard.AutoSize = true;
            this.labelCardOptionsCard.Location = new System.Drawing.Point(38, 36);
            this.labelCardOptionsCard.Name = "labelCardOptionsCard";
            this.labelCardOptionsCard.Size = new System.Drawing.Size(33, 15);
            this.labelCardOptionsCard.TabIndex = 0;
            this.labelCardOptionsCard.Text = "Card";
            // 
            // groupBoxPaymentMethodOptions
            // 
            this.groupBoxPaymentMethodOptions.Controls.Add(this.comboBoxPaymentMethodOptionsCardOwner);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.labelPaymentMethodOptionsCardOwner);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.comboBoxPaymentMethodOptionsCardType);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.labelPaymentMethodOptionsCardType);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.comboBoxPaymentMethodOptionsCard);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.checkBoxPaymentOptionsEdit);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.buttonNewPaymentMethod);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.buttonDeletePaymentMethod);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.buttonUpdatePaymentMethod);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.buttonSavePaymentMethod);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.labelPaymentMethodOptionsPaymentMethod);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.textBoxPaymentMethodOptionsPaymentMethod);
            this.groupBoxPaymentMethodOptions.Controls.Add(this.labelPaymentMethodOptionsCard);
            this.groupBoxPaymentMethodOptions.Location = new System.Drawing.Point(1036, 137);
            this.groupBoxPaymentMethodOptions.Name = "groupBoxPaymentMethodOptions";
            this.groupBoxPaymentMethodOptions.Size = new System.Drawing.Size(392, 191);
            this.groupBoxPaymentMethodOptions.TabIndex = 15;
            this.groupBoxPaymentMethodOptions.TabStop = false;
            this.groupBoxPaymentMethodOptions.Text = "Payment Method Options";
            // 
            // comboBoxPaymentMethodOptionsCardOwner
            // 
            this.comboBoxPaymentMethodOptionsCardOwner.FormattingEnabled = true;
            this.comboBoxPaymentMethodOptionsCardOwner.Location = new System.Drawing.Point(94, 125);
            this.comboBoxPaymentMethodOptionsCardOwner.Name = "comboBoxPaymentMethodOptionsCardOwner";
            this.comboBoxPaymentMethodOptionsCardOwner.Size = new System.Drawing.Size(284, 23);
            this.comboBoxPaymentMethodOptionsCardOwner.TabIndex = 18;
            // 
            // labelPaymentMethodOptionsCardOwner
            // 
            this.labelPaymentMethodOptionsCardOwner.AutoSize = true;
            this.labelPaymentMethodOptionsCardOwner.Location = new System.Drawing.Point(4, 129);
            this.labelPaymentMethodOptionsCardOwner.Name = "labelPaymentMethodOptionsCardOwner";
            this.labelPaymentMethodOptionsCardOwner.Size = new System.Drawing.Size(72, 15);
            this.labelPaymentMethodOptionsCardOwner.TabIndex = 17;
            this.labelPaymentMethodOptionsCardOwner.Text = "Card Owner";
            // 
            // comboBoxPaymentMethodOptionsCardType
            // 
            this.comboBoxPaymentMethodOptionsCardType.FormattingEnabled = true;
            this.comboBoxPaymentMethodOptionsCardType.Location = new System.Drawing.Point(94, 94);
            this.comboBoxPaymentMethodOptionsCardType.Name = "comboBoxPaymentMethodOptionsCardType";
            this.comboBoxPaymentMethodOptionsCardType.Size = new System.Drawing.Size(284, 23);
            this.comboBoxPaymentMethodOptionsCardType.TabIndex = 16;
            // 
            // labelPaymentMethodOptionsCardType
            // 
            this.labelPaymentMethodOptionsCardType.AutoSize = true;
            this.labelPaymentMethodOptionsCardType.Location = new System.Drawing.Point(16, 98);
            this.labelPaymentMethodOptionsCardType.Name = "labelPaymentMethodOptionsCardType";
            this.labelPaymentMethodOptionsCardType.Size = new System.Drawing.Size(60, 15);
            this.labelPaymentMethodOptionsCardType.TabIndex = 15;
            this.labelPaymentMethodOptionsCardType.Text = "Card Type";
            // 
            // comboBoxPaymentMethodOptionsCard
            // 
            this.comboBoxPaymentMethodOptionsCard.FormattingEnabled = true;
            this.comboBoxPaymentMethodOptionsCard.Location = new System.Drawing.Point(94, 63);
            this.comboBoxPaymentMethodOptionsCard.Name = "comboBoxPaymentMethodOptionsCard";
            this.comboBoxPaymentMethodOptionsCard.Size = new System.Drawing.Size(284, 23);
            this.comboBoxPaymentMethodOptionsCard.TabIndex = 14;
            // 
            // checkBoxPaymentOptionsEdit
            // 
            this.checkBoxPaymentOptionsEdit.AutoSize = true;
            this.checkBoxPaymentOptionsEdit.Location = new System.Drawing.Point(6, 163);
            this.checkBoxPaymentOptionsEdit.Name = "checkBoxPaymentOptionsEdit";
            this.checkBoxPaymentOptionsEdit.Size = new System.Drawing.Size(47, 19);
            this.checkBoxPaymentOptionsEdit.TabIndex = 10;
            this.checkBoxPaymentOptionsEdit.Text = "Edit";
            this.checkBoxPaymentOptionsEdit.UseVisualStyleBackColor = true;
            // 
            // buttonNewPaymentMethod
            // 
            this.buttonNewPaymentMethod.Location = new System.Drawing.Point(94, 157);
            this.buttonNewPaymentMethod.Name = "buttonNewPaymentMethod";
            this.buttonNewPaymentMethod.Size = new System.Drawing.Size(65, 23);
            this.buttonNewPaymentMethod.TabIndex = 9;
            this.buttonNewPaymentMethod.Text = "New";
            this.buttonNewPaymentMethod.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePaymentMethod
            // 
            this.buttonDeletePaymentMethod.Location = new System.Drawing.Point(313, 157);
            this.buttonDeletePaymentMethod.Name = "buttonDeletePaymentMethod";
            this.buttonDeletePaymentMethod.Size = new System.Drawing.Size(65, 23);
            this.buttonDeletePaymentMethod.TabIndex = 8;
            this.buttonDeletePaymentMethod.Text = "Delete";
            this.buttonDeletePaymentMethod.UseVisualStyleBackColor = true;
            // 
            // buttonUpdatePaymentMethod
            // 
            this.buttonUpdatePaymentMethod.Location = new System.Drawing.Point(240, 157);
            this.buttonUpdatePaymentMethod.Name = "buttonUpdatePaymentMethod";
            this.buttonUpdatePaymentMethod.Size = new System.Drawing.Size(65, 23);
            this.buttonUpdatePaymentMethod.TabIndex = 7;
            this.buttonUpdatePaymentMethod.Text = "Update";
            this.buttonUpdatePaymentMethod.UseVisualStyleBackColor = true;
            // 
            // buttonSavePaymentMethod
            // 
            this.buttonSavePaymentMethod.Location = new System.Drawing.Point(167, 157);
            this.buttonSavePaymentMethod.Name = "buttonSavePaymentMethod";
            this.buttonSavePaymentMethod.Size = new System.Drawing.Size(65, 23);
            this.buttonSavePaymentMethod.TabIndex = 6;
            this.buttonSavePaymentMethod.Text = "Save";
            this.buttonSavePaymentMethod.UseVisualStyleBackColor = true;
            // 
            // labelPaymentMethodOptionsPaymentMethod
            // 
            this.labelPaymentMethodOptionsPaymentMethod.AutoSize = true;
            this.labelPaymentMethodOptionsPaymentMethod.Location = new System.Drawing.Point(27, 36);
            this.labelPaymentMethodOptionsPaymentMethod.Name = "labelPaymentMethodOptionsPaymentMethod";
            this.labelPaymentMethodOptionsPaymentMethod.Size = new System.Drawing.Size(49, 15);
            this.labelPaymentMethodOptionsPaymentMethod.TabIndex = 2;
            this.labelPaymentMethodOptionsPaymentMethod.Text = "Method";
            // 
            // textBoxPaymentMethodOptionsPaymentMethod
            // 
            this.textBoxPaymentMethodOptionsPaymentMethod.Location = new System.Drawing.Point(94, 32);
            this.textBoxPaymentMethodOptionsPaymentMethod.Name = "textBoxPaymentMethodOptionsPaymentMethod";
            this.textBoxPaymentMethodOptionsPaymentMethod.Size = new System.Drawing.Size(284, 23);
            this.textBoxPaymentMethodOptionsPaymentMethod.TabIndex = 1;
            // 
            // labelPaymentMethodOptionsCard
            // 
            this.labelPaymentMethodOptionsCard.AutoSize = true;
            this.labelPaymentMethodOptionsCard.Location = new System.Drawing.Point(43, 67);
            this.labelPaymentMethodOptionsCard.Name = "labelPaymentMethodOptionsCard";
            this.labelPaymentMethodOptionsCard.Size = new System.Drawing.Size(33, 15);
            this.labelPaymentMethodOptionsCard.TabIndex = 0;
            this.labelPaymentMethodOptionsCard.Text = "Card";
            // 
            // groupBoxPaymentMethods
            // 
            this.groupBoxPaymentMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPaymentMethods.Controls.Add(this.dataGridViewPaymentMethods);
            this.groupBoxPaymentMethods.Location = new System.Drawing.Point(354, 6);
            this.groupBoxPaymentMethods.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPaymentMethods.Name = "groupBoxPaymentMethods";
            this.groupBoxPaymentMethods.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPaymentMethods.Size = new System.Drawing.Size(675, 174);
            this.groupBoxPaymentMethods.TabIndex = 14;
            this.groupBoxPaymentMethods.TabStop = false;
            this.groupBoxPaymentMethods.Text = "Payment Methods";
            // 
            // dataGridViewPaymentMethods
            // 
            this.dataGridViewPaymentMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewPaymentMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaymentMethods.Location = new System.Drawing.Point(4, 22);
            this.dataGridViewPaymentMethods.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewPaymentMethods.Name = "dataGridViewPaymentMethods";
            this.dataGridViewPaymentMethods.Size = new System.Drawing.Size(663, 146);
            this.dataGridViewPaymentMethods.TabIndex = 0;
            // 
            // groupBoxBankCards
            // 
            this.groupBoxBankCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxBankCards.Controls.Add(this.dataGridViewBankCards);
            this.groupBoxBankCards.Location = new System.Drawing.Point(8, 6);
            this.groupBoxBankCards.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxBankCards.Name = "groupBoxBankCards";
            this.groupBoxBankCards.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxBankCards.Size = new System.Drawing.Size(338, 174);
            this.groupBoxBankCards.TabIndex = 13;
            this.groupBoxBankCards.TabStop = false;
            this.groupBoxBankCards.Text = "Cards";
            // 
            // dataGridViewBankCards
            // 
            this.dataGridViewBankCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewBankCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBankCards.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewBankCards.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewBankCards.Name = "dataGridViewBankCards";
            this.dataGridViewBankCards.Size = new System.Drawing.Size(323, 146);
            this.dataGridViewBankCards.TabIndex = 0;
            // 
            // panelShops
            // 
            this.panelShops.Controls.Add(this.groupBoxShopGroupOptions);
            this.panelShops.Controls.Add(this.groupBoxShopGroups);
            this.panelShops.Controls.Add(this.groupBoxShops);
            this.panelShops.Controls.Add(this.groupBoxShopTypes);
            this.panelShops.Controls.Add(this.groupBox1);
            this.panelShops.Controls.Add(this.groupBoxShopOptions);
            this.panelShops.Location = new System.Drawing.Point(623, 3);
            this.panelShops.Name = "panelShops";
            this.panelShops.Size = new System.Drawing.Size(194, 185);
            this.panelShops.TabIndex = 8;
            // 
            // groupBoxShopGroupOptions
            // 
            this.groupBoxShopGroupOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxShopGroupOptions.Controls.Add(this.checkBoxShopGroupOptionsEdit);
            this.groupBoxShopGroupOptions.Controls.Add(this.buttonNewShopGroup);
            this.groupBoxShopGroupOptions.Controls.Add(this.buttonSaveShopGroup);
            this.groupBoxShopGroupOptions.Controls.Add(this.buttonUpdateShopGroup);
            this.groupBoxShopGroupOptions.Controls.Add(this.buttonDeleteShopGroup);
            this.groupBoxShopGroupOptions.Controls.Add(this.labelShopGroupOptionsOwner);
            this.groupBoxShopGroupOptions.Controls.Add(this.textBoxShopGroupOptionsGroupName);
            this.groupBoxShopGroupOptions.Controls.Add(this.labelShopGroupOptionsGroupName);
            this.groupBoxShopGroupOptions.Controls.Add(this.comboBoxShopGroupOptionsShopType);
            this.groupBoxShopGroupOptions.Controls.Add(this.textBoxShopGroupOptionsOwner);
            this.groupBoxShopGroupOptions.Controls.Add(this.labelShopGroupOptionsShopType);
            this.groupBoxShopGroupOptions.Location = new System.Drawing.Point(770, -25);
            this.groupBoxShopGroupOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroupOptions.Name = "groupBoxShopGroupOptions";
            this.groupBoxShopGroupOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroupOptions.Size = new System.Drawing.Size(330, 201);
            this.groupBoxShopGroupOptions.TabIndex = 41;
            this.groupBoxShopGroupOptions.TabStop = false;
            this.groupBoxShopGroupOptions.Text = "Shop Group Options";
            // 
            // checkBoxShopGroupOptionsEdit
            // 
            this.checkBoxShopGroupOptionsEdit.AutoSize = true;
            this.checkBoxShopGroupOptionsEdit.Location = new System.Drawing.Point(239, 169);
            this.checkBoxShopGroupOptionsEdit.Name = "checkBoxShopGroupOptionsEdit";
            this.checkBoxShopGroupOptionsEdit.Size = new System.Drawing.Size(71, 19);
            this.checkBoxShopGroupOptionsEdit.TabIndex = 36;
            this.checkBoxShopGroupOptionsEdit.Text = "Editable";
            this.checkBoxShopGroupOptionsEdit.UseVisualStyleBackColor = true;
            // 
            // buttonNewShopGroup
            // 
            this.buttonNewShopGroup.Location = new System.Drawing.Point(24, 130);
            this.buttonNewShopGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewShopGroup.Name = "buttonNewShopGroup";
            this.buttonNewShopGroup.Size = new System.Drawing.Size(64, 27);
            this.buttonNewShopGroup.TabIndex = 35;
            this.buttonNewShopGroup.Text = "New";
            this.buttonNewShopGroup.UseVisualStyleBackColor = true;
            // 
            // buttonSaveShopGroup
            // 
            this.buttonSaveShopGroup.Location = new System.Drawing.Point(98, 130);
            this.buttonSaveShopGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveShopGroup.Name = "buttonSaveShopGroup";
            this.buttonSaveShopGroup.Size = new System.Drawing.Size(64, 27);
            this.buttonSaveShopGroup.TabIndex = 32;
            this.buttonSaveShopGroup.Text = "Save";
            this.buttonSaveShopGroup.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateShopGroup
            // 
            this.buttonUpdateShopGroup.Location = new System.Drawing.Point(172, 130);
            this.buttonUpdateShopGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateShopGroup.Name = "buttonUpdateShopGroup";
            this.buttonUpdateShopGroup.Size = new System.Drawing.Size(64, 27);
            this.buttonUpdateShopGroup.TabIndex = 33;
            this.buttonUpdateShopGroup.Text = "Update";
            this.buttonUpdateShopGroup.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteShopGroup
            // 
            this.buttonDeleteShopGroup.Location = new System.Drawing.Point(246, 130);
            this.buttonDeleteShopGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteShopGroup.Name = "buttonDeleteShopGroup";
            this.buttonDeleteShopGroup.Size = new System.Drawing.Size(64, 27);
            this.buttonDeleteShopGroup.TabIndex = 34;
            this.buttonDeleteShopGroup.Text = "Delete";
            this.buttonDeleteShopGroup.UseVisualStyleBackColor = true;
            // 
            // labelShopGroupOptionsOwner
            // 
            this.labelShopGroupOptionsOwner.AutoSize = true;
            this.labelShopGroupOptionsOwner.Location = new System.Drawing.Point(5, 64);
            this.labelShopGroupOptionsOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopGroupOptionsOwner.Name = "labelShopGroupOptionsOwner";
            this.labelShopGroupOptionsOwner.Size = new System.Drawing.Size(43, 15);
            this.labelShopGroupOptionsOwner.TabIndex = 32;
            this.labelShopGroupOptionsOwner.Text = "Owner";
            // 
            // textBoxShopGroupOptionsGroupName
            // 
            this.textBoxShopGroupOptionsGroupName.Location = new System.Drawing.Point(56, 27);
            this.textBoxShopGroupOptionsGroupName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopGroupOptionsGroupName.Name = "textBoxShopGroupOptionsGroupName";
            this.textBoxShopGroupOptionsGroupName.Size = new System.Drawing.Size(254, 23);
            this.textBoxShopGroupOptionsGroupName.TabIndex = 33;
            // 
            // labelShopGroupOptionsGroupName
            // 
            this.labelShopGroupOptionsGroupName.AutoSize = true;
            this.labelShopGroupOptionsGroupName.Location = new System.Drawing.Point(7, 31);
            this.labelShopGroupOptionsGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopGroupOptionsGroupName.Name = "labelShopGroupOptionsGroupName";
            this.labelShopGroupOptionsGroupName.Size = new System.Drawing.Size(41, 15);
            this.labelShopGroupOptionsGroupName.TabIndex = 32;
            this.labelShopGroupOptionsGroupName.Text = "Group";
            // 
            // comboBoxShopGroupOptionsShopType
            // 
            this.comboBoxShopGroupOptionsShopType.FormattingEnabled = true;
            this.comboBoxShopGroupOptionsShopType.Location = new System.Drawing.Point(56, 93);
            this.comboBoxShopGroupOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxShopGroupOptionsShopType.Name = "comboBoxShopGroupOptionsShopType";
            this.comboBoxShopGroupOptionsShopType.Size = new System.Drawing.Size(254, 23);
            this.comboBoxShopGroupOptionsShopType.TabIndex = 13;
            // 
            // textBoxShopGroupOptionsOwner
            // 
            this.textBoxShopGroupOptionsOwner.Location = new System.Drawing.Point(56, 60);
            this.textBoxShopGroupOptionsOwner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopGroupOptionsOwner.Name = "textBoxShopGroupOptionsOwner";
            this.textBoxShopGroupOptionsOwner.Size = new System.Drawing.Size(254, 23);
            this.textBoxShopGroupOptionsOwner.TabIndex = 33;
            // 
            // labelShopGroupOptionsShopType
            // 
            this.labelShopGroupOptionsShopType.AutoSize = true;
            this.labelShopGroupOptionsShopType.Location = new System.Drawing.Point(17, 98);
            this.labelShopGroupOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopGroupOptionsShopType.Name = "labelShopGroupOptionsShopType";
            this.labelShopGroupOptionsShopType.Size = new System.Drawing.Size(31, 15);
            this.labelShopGroupOptionsShopType.TabIndex = 34;
            this.labelShopGroupOptionsShopType.Text = "Type";
            // 
            // groupBoxShopGroups
            // 
            this.groupBoxShopGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxShopGroups.Controls.Add(this.dataGridViewShopGroups);
            this.groupBoxShopGroups.Location = new System.Drawing.Point(1053, 6);
            this.groupBoxShopGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroups.Name = "groupBoxShopGroups";
            this.groupBoxShopGroups.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroups.Size = new System.Drawing.Size(617, 0);
            this.groupBoxShopGroups.TabIndex = 37;
            this.groupBoxShopGroups.TabStop = false;
            this.groupBoxShopGroups.Text = "Shop Groups";
            // 
            // dataGridViewShopGroups
            // 
            this.dataGridViewShopGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewShopGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShopGroups.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewShopGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewShopGroups.Name = "dataGridViewShopGroups";
            this.dataGridViewShopGroups.Size = new System.Drawing.Size(602, 0);
            this.dataGridViewShopGroups.TabIndex = 0;
            // 
            // groupBoxShops
            // 
            this.groupBoxShops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxShops.Controls.Add(this.dataGridViewShops);
            this.groupBoxShops.Location = new System.Drawing.Point(240, 6);
            this.groupBoxShops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShops.Name = "groupBoxShops";
            this.groupBoxShops.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShops.Size = new System.Drawing.Size(805, 0);
            this.groupBoxShops.TabIndex = 36;
            this.groupBoxShops.TabStop = false;
            this.groupBoxShops.Text = "Shops";
            // 
            // dataGridViewShops
            // 
            this.dataGridViewShops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShops.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewShops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewShops.Name = "dataGridViewShops";
            this.dataGridViewShops.Size = new System.Drawing.Size(790, 0);
            this.dataGridViewShops.TabIndex = 0;
            // 
            // groupBoxShopTypes
            // 
            this.groupBoxShopTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxShopTypes.Controls.Add(this.dataGridViewShopTypes);
            this.groupBoxShopTypes.Location = new System.Drawing.Point(8, 6);
            this.groupBoxShopTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopTypes.Name = "groupBoxShopTypes";
            this.groupBoxShopTypes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopTypes.Size = new System.Drawing.Size(224, 170);
            this.groupBoxShopTypes.TabIndex = 38;
            this.groupBoxShopTypes.TabStop = false;
            this.groupBoxShopTypes.Text = "Shop types";
            // 
            // dataGridViewShopTypes
            // 
            this.dataGridViewShopTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewShopTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShopTypes.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewShopTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewShopTypes.Name = "dataGridViewShopTypes";
            this.dataGridViewShopTypes.Size = new System.Drawing.Size(209, 142);
            this.dataGridViewShopTypes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.comboBoxShopTypeOptionsShopType);
            this.groupBox1.Controls.Add(this.buttonNewShopType);
            this.groupBox1.Controls.Add(this.labelShopTypeOptionsShopType);
            this.groupBox1.Controls.Add(this.buttonDeleteShopType);
            this.groupBox1.Controls.Add(this.buttonUpdateShopType);
            this.groupBox1.Controls.Add(this.checkBoxSetRelational);
            this.groupBox1.Controls.Add(this.buttonSaveShopType);
            this.groupBox1.Location = new System.Drawing.Point(1108, -25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(318, 124);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop Type Options";
            // 
            // comboBoxShopTypeOptionsShopType
            // 
            this.comboBoxShopTypeOptionsShopType.FormattingEnabled = true;
            this.comboBoxShopTypeOptionsShopType.Location = new System.Drawing.Point(93, 25);
            this.comboBoxShopTypeOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxShopTypeOptionsShopType.Name = "comboBoxShopTypeOptionsShopType";
            this.comboBoxShopTypeOptionsShopType.Size = new System.Drawing.Size(207, 23);
            this.comboBoxShopTypeOptionsShopType.TabIndex = 12;
            // 
            // buttonNewShopType
            // 
            this.buttonNewShopType.Location = new System.Drawing.Point(22, 58);
            this.buttonNewShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewShopType.Name = "buttonNewShopType";
            this.buttonNewShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonNewShopType.TabIndex = 11;
            this.buttonNewShopType.Text = "New";
            this.buttonNewShopType.UseVisualStyleBackColor = true;
            // 
            // labelShopTypeOptionsShopType
            // 
            this.labelShopTypeOptionsShopType.AutoSize = true;
            this.labelShopTypeOptionsShopType.Location = new System.Drawing.Point(13, 29);
            this.labelShopTypeOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopTypeOptionsShopType.Name = "labelShopTypeOptionsShopType";
            this.labelShopTypeOptionsShopType.Size = new System.Drawing.Size(61, 15);
            this.labelShopTypeOptionsShopType.TabIndex = 9;
            this.labelShopTypeOptionsShopType.Text = "Shop Type";
            // 
            // buttonDeleteShopType
            // 
            this.buttonDeleteShopType.Location = new System.Drawing.Point(236, 58);
            this.buttonDeleteShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteShopType.Name = "buttonDeleteShopType";
            this.buttonDeleteShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonDeleteShopType.TabIndex = 8;
            this.buttonDeleteShopType.Text = "Delete";
            this.buttonDeleteShopType.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateShopType
            // 
            this.buttonUpdateShopType.Location = new System.Drawing.Point(165, 58);
            this.buttonUpdateShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateShopType.Name = "buttonUpdateShopType";
            this.buttonUpdateShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonUpdateShopType.TabIndex = 7;
            this.buttonUpdateShopType.Text = "Update";
            this.buttonUpdateShopType.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetRelational
            // 
            this.checkBoxSetRelational.AutoSize = true;
            this.checkBoxSetRelational.Location = new System.Drawing.Point(199, 96);
            this.checkBoxSetRelational.Name = "checkBoxSetRelational";
            this.checkBoxSetRelational.Size = new System.Drawing.Size(101, 19);
            this.checkBoxSetRelational.TabIndex = 42;
            this.checkBoxSetRelational.Text = "Set Relational";
            this.checkBoxSetRelational.UseVisualStyleBackColor = true;
            // 
            // buttonSaveShopType
            // 
            this.buttonSaveShopType.Location = new System.Drawing.Point(93, 58);
            this.buttonSaveShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveShopType.Name = "buttonSaveShopType";
            this.buttonSaveShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonSaveShopType.TabIndex = 6;
            this.buttonSaveShopType.Text = "Save";
            this.buttonSaveShopType.UseVisualStyleBackColor = true;
            // 
            // groupBoxShopOptions
            // 
            this.groupBoxShopOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsShopGroup);
            this.groupBoxShopOptions.Controls.Add(this.comboBoxShopOptionsShopGroup);
            this.groupBoxShopOptions.Controls.Add(this.buttonNewShop);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsWeb);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsWeb);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsEmail);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsEmail);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsTel);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsTel);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsNickName);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsShopName);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsShop);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsNickName);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsAddress);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsAddress);
            this.groupBoxShopOptions.Controls.Add(this.buttonDeleteShop);
            this.groupBoxShopOptions.Controls.Add(this.buttonUpdateShop);
            this.groupBoxShopOptions.Controls.Add(this.buttonSaveShop);
            this.groupBoxShopOptions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxShopOptions.Location = new System.Drawing.Point(240, -25);
            this.groupBoxShopOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopOptions.Name = "groupBoxShopOptions";
            this.groupBoxShopOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopOptions.Size = new System.Drawing.Size(522, 201);
            this.groupBoxShopOptions.TabIndex = 40;
            this.groupBoxShopOptions.TabStop = false;
            this.groupBoxShopOptions.Text = "Shop Options";
            // 
            // labelShopOptionsShopGroup
            // 
            this.labelShopOptionsShopGroup.AutoSize = true;
            this.labelShopOptionsShopGroup.Location = new System.Drawing.Point(23, 31);
            this.labelShopOptionsShopGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsShopGroup.Name = "labelShopOptionsShopGroup";
            this.labelShopOptionsShopGroup.Size = new System.Drawing.Size(41, 15);
            this.labelShopOptionsShopGroup.TabIndex = 36;
            this.labelShopOptionsShopGroup.Text = "Group";
            // 
            // comboBoxShopOptionsShopGroup
            // 
            this.comboBoxShopOptionsShopGroup.FormattingEnabled = true;
            this.comboBoxShopOptionsShopGroup.Location = new System.Drawing.Point(81, 27);
            this.comboBoxShopOptionsShopGroup.Name = "comboBoxShopOptionsShopGroup";
            this.comboBoxShopOptionsShopGroup.Size = new System.Drawing.Size(194, 23);
            this.comboBoxShopOptionsShopGroup.TabIndex = 35;
            // 
            // buttonNewShop
            // 
            this.buttonNewShop.Location = new System.Drawing.Point(164, 163);
            this.buttonNewShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewShop.Name = "buttonNewShop";
            this.buttonNewShop.Size = new System.Drawing.Size(78, 27);
            this.buttonNewShop.TabIndex = 34;
            this.buttonNewShop.Text = "New";
            this.buttonNewShop.UseVisualStyleBackColor = true;
            // 
            // textBoxShopOptionsWeb
            // 
            this.textBoxShopOptionsWeb.Location = new System.Drawing.Point(348, 126);
            this.textBoxShopOptionsWeb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsWeb.Name = "textBoxShopOptionsWeb";
            this.textBoxShopOptionsWeb.Size = new System.Drawing.Size(158, 23);
            this.textBoxShopOptionsWeb.TabIndex = 33;
            // 
            // labelShopOptionsWeb
            // 
            this.labelShopOptionsWeb.AutoSize = true;
            this.labelShopOptionsWeb.Location = new System.Drawing.Point(303, 130);
            this.labelShopOptionsWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsWeb.Name = "labelShopOptionsWeb";
            this.labelShopOptionsWeb.Size = new System.Drawing.Size(32, 15);
            this.labelShopOptionsWeb.TabIndex = 32;
            this.labelShopOptionsWeb.Text = "Web";
            // 
            // textBoxShopOptionsEmail
            // 
            this.textBoxShopOptionsEmail.Location = new System.Drawing.Point(348, 93);
            this.textBoxShopOptionsEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsEmail.Name = "textBoxShopOptionsEmail";
            this.textBoxShopOptionsEmail.Size = new System.Drawing.Size(158, 23);
            this.textBoxShopOptionsEmail.TabIndex = 31;
            // 
            // labelShopOptionsEmail
            // 
            this.labelShopOptionsEmail.AutoSize = true;
            this.labelShopOptionsEmail.Location = new System.Drawing.Point(293, 98);
            this.labelShopOptionsEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsEmail.Name = "labelShopOptionsEmail";
            this.labelShopOptionsEmail.Size = new System.Drawing.Size(42, 15);
            this.labelShopOptionsEmail.TabIndex = 30;
            this.labelShopOptionsEmail.Text = "E-mail";
            // 
            // textBoxShopOptionsTel
            // 
            this.textBoxShopOptionsTel.Location = new System.Drawing.Point(348, 60);
            this.textBoxShopOptionsTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsTel.Name = "textBoxShopOptionsTel";
            this.textBoxShopOptionsTel.Size = new System.Drawing.Size(158, 23);
            this.textBoxShopOptionsTel.TabIndex = 29;
            // 
            // labelShopOptionsTel
            // 
            this.labelShopOptionsTel.AutoSize = true;
            this.labelShopOptionsTel.Location = new System.Drawing.Point(313, 64);
            this.labelShopOptionsTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsTel.Name = "labelShopOptionsTel";
            this.labelShopOptionsTel.Size = new System.Drawing.Size(22, 15);
            this.labelShopOptionsTel.TabIndex = 28;
            this.labelShopOptionsTel.Text = "Tel";
            // 
            // textBoxShopOptionsNickName
            // 
            this.textBoxShopOptionsNickName.Location = new System.Drawing.Point(348, 27);
            this.textBoxShopOptionsNickName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsNickName.Name = "textBoxShopOptionsNickName";
            this.textBoxShopOptionsNickName.Size = new System.Drawing.Size(158, 23);
            this.textBoxShopOptionsNickName.TabIndex = 6;
            // 
            // labelShopOptionsShopName
            // 
            this.labelShopOptionsShopName.AutoSize = true;
            this.labelShopOptionsShopName.Location = new System.Drawing.Point(30, 64);
            this.labelShopOptionsShopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsShopName.Name = "labelShopOptionsShopName";
            this.labelShopOptionsShopName.Size = new System.Drawing.Size(34, 15);
            this.labelShopOptionsShopName.TabIndex = 3;
            this.labelShopOptionsShopName.Text = "Shop";
            // 
            // textBoxShopOptionsShop
            // 
            this.textBoxShopOptionsShop.Location = new System.Drawing.Point(81, 60);
            this.textBoxShopOptionsShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsShop.Name = "textBoxShopOptionsShop";
            this.textBoxShopOptionsShop.Size = new System.Drawing.Size(194, 23);
            this.textBoxShopOptionsShop.TabIndex = 4;
            // 
            // labelShopOptionsNickName
            // 
            this.labelShopOptionsNickName.AutoSize = true;
            this.labelShopOptionsNickName.Location = new System.Drawing.Point(304, 31);
            this.labelShopOptionsNickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsNickName.Name = "labelShopOptionsNickName";
            this.labelShopOptionsNickName.Size = new System.Drawing.Size(31, 15);
            this.labelShopOptionsNickName.TabIndex = 5;
            this.labelShopOptionsNickName.Text = "Nick";
            // 
            // labelShopOptionsAddress
            // 
            this.labelShopOptionsAddress.AutoSize = true;
            this.labelShopOptionsAddress.Location = new System.Drawing.Point(13, 96);
            this.labelShopOptionsAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsAddress.Name = "labelShopOptionsAddress";
            this.labelShopOptionsAddress.Size = new System.Drawing.Size(51, 15);
            this.labelShopOptionsAddress.TabIndex = 7;
            this.labelShopOptionsAddress.Text = "Address";
            // 
            // textBoxShopOptionsAddress
            // 
            this.textBoxShopOptionsAddress.Location = new System.Drawing.Point(81, 93);
            this.textBoxShopOptionsAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsAddress.Multiline = true;
            this.textBoxShopOptionsAddress.Name = "textBoxShopOptionsAddress";
            this.textBoxShopOptionsAddress.Size = new System.Drawing.Size(194, 56);
            this.textBoxShopOptionsAddress.TabIndex = 8;
            // 
            // buttonDeleteShop
            // 
            this.buttonDeleteShop.Location = new System.Drawing.Point(428, 163);
            this.buttonDeleteShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteShop.Name = "buttonDeleteShop";
            this.buttonDeleteShop.Size = new System.Drawing.Size(78, 27);
            this.buttonDeleteShop.TabIndex = 27;
            this.buttonDeleteShop.Text = "Delete";
            this.buttonDeleteShop.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateShop
            // 
            this.buttonUpdateShop.Location = new System.Drawing.Point(340, 163);
            this.buttonUpdateShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateShop.Name = "buttonUpdateShop";
            this.buttonUpdateShop.Size = new System.Drawing.Size(78, 27);
            this.buttonUpdateShop.TabIndex = 26;
            this.buttonUpdateShop.Text = "Update";
            this.buttonUpdateShop.UseVisualStyleBackColor = true;
            // 
            // buttonSaveShop
            // 
            this.buttonSaveShop.Location = new System.Drawing.Point(252, 163);
            this.buttonSaveShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveShop.Name = "buttonSaveShop";
            this.buttonSaveShop.Size = new System.Drawing.Size(78, 27);
            this.buttonSaveShop.TabIndex = 25;
            this.buttonSaveShop.Text = "Save";
            this.buttonSaveShop.UseVisualStyleBackColor = true;
            // 
            // panelItems
            // 
            this.panelItems.Controls.Add(this.groupBoxItemSubTypeOptions);
            this.panelItems.Controls.Add(this.groupBoxItemTopGroups);
            this.panelItems.Controls.Add(this.groupBoxItemTopGroupOptions);
            this.panelItems.Controls.Add(this.groupBoxItems);
            this.panelItems.Controls.Add(this.groupBoxItemOptions);
            this.panelItems.Controls.Add(this.groupBoxItemGroups);
            this.panelItems.Controls.Add(this.groupBoxItemGroupOptions);
            this.panelItems.Location = new System.Drawing.Point(413, 3);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(200, 185);
            this.panelItems.TabIndex = 7;
            // 
            // groupBoxItemSubTypeOptions
            // 
            this.groupBoxItemSubTypeOptions.Controls.Add(this.textBoxItemSubTypeOptionsItem);
            this.groupBoxItemSubTypeOptions.Controls.Add(this.comboBoxItemSubTypeOptionsItemSubType);
            this.groupBoxItemSubTypeOptions.Controls.Add(this.checkBoxItemSubTypeOptionsEdit);
            this.groupBoxItemSubTypeOptions.Controls.Add(this.buttonNewItemSubType);
            this.groupBoxItemSubTypeOptions.Controls.Add(this.buttonDeleteItemSubType);
            this.groupBoxItemSubTypeOptions.Controls.Add(this.buttonUpdateItemSubType);
            this.groupBoxItemSubTypeOptions.Controls.Add(this.buttonSaveItemSubType);
            this.groupBoxItemSubTypeOptions.Controls.Add(this.labelItemSubTypeOptionsItem);
            this.groupBoxItemSubTypeOptions.Controls.Add(this.labelItemSubTypeOptionsItemSubType);
            this.groupBoxItemSubTypeOptions.Location = new System.Drawing.Point(1235, 449);
            this.groupBoxItemSubTypeOptions.Name = "groupBoxItemSubTypeOptions";
            this.groupBoxItemSubTypeOptions.Size = new System.Drawing.Size(433, 123);
            this.groupBoxItemSubTypeOptions.TabIndex = 19;
            this.groupBoxItemSubTypeOptions.TabStop = false;
            this.groupBoxItemSubTypeOptions.Text = "Subitem Options";
            // 
            // textBoxItemSubTypeOptionsItem
            // 
            this.textBoxItemSubTypeOptionsItem.Location = new System.Drawing.Point(86, 31);
            this.textBoxItemSubTypeOptionsItem.Name = "textBoxItemSubTypeOptionsItem";
            this.textBoxItemSubTypeOptionsItem.Size = new System.Drawing.Size(330, 23);
            this.textBoxItemSubTypeOptionsItem.TabIndex = 12;
            // 
            // comboBoxItemSubTypeOptionsItemSubType
            // 
            this.comboBoxItemSubTypeOptionsItemSubType.FormattingEnabled = true;
            this.comboBoxItemSubTypeOptionsItemSubType.Location = new System.Drawing.Point(86, 60);
            this.comboBoxItemSubTypeOptionsItemSubType.Name = "comboBoxItemSubTypeOptionsItemSubType";
            this.comboBoxItemSubTypeOptionsItemSubType.Size = new System.Drawing.Size(330, 23);
            this.comboBoxItemSubTypeOptionsItemSubType.TabIndex = 11;
            // 
            // checkBoxItemSubTypeOptionsEdit
            // 
            this.checkBoxItemSubTypeOptionsEdit.AutoSize = true;
            this.checkBoxItemSubTypeOptionsEdit.Location = new System.Drawing.Point(6, 98);
            this.checkBoxItemSubTypeOptionsEdit.Name = "checkBoxItemSubTypeOptionsEdit";
            this.checkBoxItemSubTypeOptionsEdit.Size = new System.Drawing.Size(47, 19);
            this.checkBoxItemSubTypeOptionsEdit.TabIndex = 10;
            this.checkBoxItemSubTypeOptionsEdit.Text = "Edit";
            this.checkBoxItemSubTypeOptionsEdit.UseVisualStyleBackColor = true;
            // 
            // buttonNewItemSubType
            // 
            this.buttonNewItemSubType.Location = new System.Drawing.Point(86, 92);
            this.buttonNewItemSubType.Name = "buttonNewItemSubType";
            this.buttonNewItemSubType.Size = new System.Drawing.Size(75, 23);
            this.buttonNewItemSubType.TabIndex = 9;
            this.buttonNewItemSubType.Text = "New";
            this.buttonNewItemSubType.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteItemSubType
            // 
            this.buttonDeleteItemSubType.Location = new System.Drawing.Point(339, 92);
            this.buttonDeleteItemSubType.Name = "buttonDeleteItemSubType";
            this.buttonDeleteItemSubType.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteItemSubType.TabIndex = 8;
            this.buttonDeleteItemSubType.Text = "Delete";
            this.buttonDeleteItemSubType.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateItemSubType
            // 
            this.buttonUpdateItemSubType.Location = new System.Drawing.Point(254, 92);
            this.buttonUpdateItemSubType.Name = "buttonUpdateItemSubType";
            this.buttonUpdateItemSubType.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateItemSubType.TabIndex = 7;
            this.buttonUpdateItemSubType.Text = "Update";
            this.buttonUpdateItemSubType.UseVisualStyleBackColor = true;
            // 
            // buttonSaveItemSubType
            // 
            this.buttonSaveItemSubType.Location = new System.Drawing.Point(169, 92);
            this.buttonSaveItemSubType.Name = "buttonSaveItemSubType";
            this.buttonSaveItemSubType.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveItemSubType.TabIndex = 6;
            this.buttonSaveItemSubType.Text = "Save";
            this.buttonSaveItemSubType.UseVisualStyleBackColor = true;
            // 
            // labelItemSubTypeOptionsItem
            // 
            this.labelItemSubTypeOptionsItem.AutoSize = true;
            this.labelItemSubTypeOptionsItem.Location = new System.Drawing.Point(40, 37);
            this.labelItemSubTypeOptionsItem.Name = "labelItemSubTypeOptionsItem";
            this.labelItemSubTypeOptionsItem.Size = new System.Drawing.Size(31, 15);
            this.labelItemSubTypeOptionsItem.TabIndex = 2;
            this.labelItemSubTypeOptionsItem.Text = "Item";
            // 
            // labelItemSubTypeOptionsItemSubType
            // 
            this.labelItemSubTypeOptionsItemSubType.AutoSize = true;
            this.labelItemSubTypeOptionsItemSubType.Location = new System.Drawing.Point(20, 66);
            this.labelItemSubTypeOptionsItemSubType.Name = "labelItemSubTypeOptionsItemSubType";
            this.labelItemSubTypeOptionsItemSubType.Size = new System.Drawing.Size(51, 15);
            this.labelItemSubTypeOptionsItemSubType.TabIndex = 0;
            this.labelItemSubTypeOptionsItemSubType.Text = "Subitem";
            // 
            // groupBoxItemTopGroups
            // 
            this.groupBoxItemTopGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxItemTopGroups.Controls.Add(this.dataGridViewItemTopGroups);
            this.groupBoxItemTopGroups.Location = new System.Drawing.Point(7, 6);
            this.groupBoxItemTopGroups.Name = "groupBoxItemTopGroups";
            this.groupBoxItemTopGroups.Size = new System.Drawing.Size(208, 171);
            this.groupBoxItemTopGroups.TabIndex = 21;
            this.groupBoxItemTopGroups.TabStop = false;
            this.groupBoxItemTopGroups.Text = "Top Groups";
            // 
            // dataGridViewItemTopGroups
            // 
            this.dataGridViewItemTopGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewItemTopGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemTopGroups.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewItemTopGroups.Name = "dataGridViewItemTopGroups";
            this.dataGridViewItemTopGroups.Size = new System.Drawing.Size(191, 143);
            this.dataGridViewItemTopGroups.TabIndex = 0;
            // 
            // groupBoxItemTopGroupOptions
            // 
            this.groupBoxItemTopGroupOptions.Controls.Add(this.comboBoxTopGroupOptionsTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonNewTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.labelTopGroupOptionsTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonDeleteTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonUpdateTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonSaveTopGroup);
            this.groupBoxItemTopGroupOptions.Location = new System.Drawing.Point(1235, 6);
            this.groupBoxItemTopGroupOptions.Name = "groupBoxItemTopGroupOptions";
            this.groupBoxItemTopGroupOptions.Size = new System.Drawing.Size(433, 96);
            this.groupBoxItemTopGroupOptions.TabIndex = 20;
            this.groupBoxItemTopGroupOptions.TabStop = false;
            this.groupBoxItemTopGroupOptions.Text = "Top Group Options";
            // 
            // comboBoxTopGroupOptionsTopGroup
            // 
            this.comboBoxTopGroupOptionsTopGroup.FormattingEnabled = true;
            this.comboBoxTopGroupOptionsTopGroup.Location = new System.Drawing.Point(86, 33);
            this.comboBoxTopGroupOptionsTopGroup.Name = "comboBoxTopGroupOptionsTopGroup";
            this.comboBoxTopGroupOptionsTopGroup.Size = new System.Drawing.Size(328, 23);
            this.comboBoxTopGroupOptionsTopGroup.TabIndex = 12;
            // 
            // buttonNewTopGroup
            // 
            this.buttonNewTopGroup.Location = new System.Drawing.Point(86, 62);
            this.buttonNewTopGroup.Name = "buttonNewTopGroup";
            this.buttonNewTopGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonNewTopGroup.TabIndex = 11;
            this.buttonNewTopGroup.Text = "New";
            this.buttonNewTopGroup.UseVisualStyleBackColor = true;
            // 
            // labelTopGroupOptionsTopGroup
            // 
            this.labelTopGroupOptionsTopGroup.AutoSize = true;
            this.labelTopGroupOptionsTopGroup.Location = new System.Drawing.Point(5, 36);
            this.labelTopGroupOptionsTopGroup.Name = "labelTopGroupOptionsTopGroup";
            this.labelTopGroupOptionsTopGroup.Size = new System.Drawing.Size(63, 15);
            this.labelTopGroupOptionsTopGroup.TabIndex = 9;
            this.labelTopGroupOptionsTopGroup.Text = "Top Group";
            // 
            // buttonDeleteTopGroup
            // 
            this.buttonDeleteTopGroup.Location = new System.Drawing.Point(339, 62);
            this.buttonDeleteTopGroup.Name = "buttonDeleteTopGroup";
            this.buttonDeleteTopGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTopGroup.TabIndex = 8;
            this.buttonDeleteTopGroup.Text = "Delete";
            this.buttonDeleteTopGroup.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateTopGroup
            // 
            this.buttonUpdateTopGroup.Location = new System.Drawing.Point(254, 62);
            this.buttonUpdateTopGroup.Name = "buttonUpdateTopGroup";
            this.buttonUpdateTopGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateTopGroup.TabIndex = 7;
            this.buttonUpdateTopGroup.Text = "Update";
            this.buttonUpdateTopGroup.UseVisualStyleBackColor = true;
            // 
            // buttonSaveTopGroup
            // 
            this.buttonSaveTopGroup.Location = new System.Drawing.Point(169, 62);
            this.buttonSaveTopGroup.Name = "buttonSaveTopGroup";
            this.buttonSaveTopGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveTopGroup.TabIndex = 6;
            this.buttonSaveTopGroup.Text = "Save";
            this.buttonSaveTopGroup.UseVisualStyleBackColor = true;
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxItems.Controls.Add(this.dataGridViewItems);
            this.groupBoxItems.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItems.Location = new System.Drawing.Point(600, 6);
            this.groupBoxItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItems.Size = new System.Drawing.Size(628, 171);
            this.groupBoxItems.TabIndex = 14;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(8, 22);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(612, 143);
            this.dataGridViewItems.TabIndex = 0;
            // 
            // groupBoxItemOptions
            // 
            this.groupBoxItemOptions.Controls.Add(this.checkBoxItemOptionsEdit);
            this.groupBoxItemOptions.Controls.Add(this.buttonNewItem);
            this.groupBoxItemOptions.Controls.Add(this.buttonDeleteItem);
            this.groupBoxItemOptions.Controls.Add(this.buttonUpdateItem);
            this.groupBoxItemOptions.Controls.Add(this.buttonSaveItem);
            this.groupBoxItemOptions.Controls.Add(this.textBoxItemOptionsNote);
            this.groupBoxItemOptions.Controls.Add(this.labelItemOptionsNote);
            this.groupBoxItemOptions.Controls.Add(this.comboBoxItemOptionsGroup);
            this.groupBoxItemOptions.Controls.Add(this.labelItemOptionsGroup);
            this.groupBoxItemOptions.Controls.Add(this.textBoxItemOptionsItem);
            this.groupBoxItemOptions.Controls.Add(this.labelItemOptionsItem);
            this.groupBoxItemOptions.Location = new System.Drawing.Point(1235, 242);
            this.groupBoxItemOptions.Name = "groupBoxItemOptions";
            this.groupBoxItemOptions.Size = new System.Drawing.Size(433, 201);
            this.groupBoxItemOptions.TabIndex = 15;
            this.groupBoxItemOptions.TabStop = false;
            this.groupBoxItemOptions.Text = "Item Options";
            // 
            // checkBoxItemOptionsEdit
            // 
            this.checkBoxItemOptionsEdit.AutoSize = true;
            this.checkBoxItemOptionsEdit.Location = new System.Drawing.Point(6, 176);
            this.checkBoxItemOptionsEdit.Name = "checkBoxItemOptionsEdit";
            this.checkBoxItemOptionsEdit.Size = new System.Drawing.Size(47, 19);
            this.checkBoxItemOptionsEdit.TabIndex = 10;
            this.checkBoxItemOptionsEdit.Text = "Edit";
            this.checkBoxItemOptionsEdit.UseVisualStyleBackColor = true;
            // 
            // buttonNewItem
            // 
            this.buttonNewItem.Location = new System.Drawing.Point(86, 170);
            this.buttonNewItem.Name = "buttonNewItem";
            this.buttonNewItem.Size = new System.Drawing.Size(75, 23);
            this.buttonNewItem.TabIndex = 9;
            this.buttonNewItem.Text = "New";
            this.buttonNewItem.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(339, 170);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteItem.TabIndex = 8;
            this.buttonDeleteItem.Text = "Delete";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Location = new System.Drawing.Point(254, 170);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateItem.TabIndex = 7;
            this.buttonUpdateItem.Text = "Update";
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.Location = new System.Drawing.Point(169, 170);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveItem.TabIndex = 6;
            this.buttonSaveItem.Text = "Save";
            this.buttonSaveItem.UseVisualStyleBackColor = true;
            // 
            // textBoxItemOptionsNote
            // 
            this.textBoxItemOptionsNote.Location = new System.Drawing.Point(86, 89);
            this.textBoxItemOptionsNote.Multiline = true;
            this.textBoxItemOptionsNote.Name = "textBoxItemOptionsNote";
            this.textBoxItemOptionsNote.Size = new System.Drawing.Size(330, 73);
            this.textBoxItemOptionsNote.TabIndex = 5;
            // 
            // labelItemOptionsNote
            // 
            this.labelItemOptionsNote.AutoSize = true;
            this.labelItemOptionsNote.Location = new System.Drawing.Point(37, 95);
            this.labelItemOptionsNote.Name = "labelItemOptionsNote";
            this.labelItemOptionsNote.Size = new System.Drawing.Size(32, 15);
            this.labelItemOptionsNote.TabIndex = 4;
            this.labelItemOptionsNote.Text = "Note";
            // 
            // comboBoxItemOptionsGroup
            // 
            this.comboBoxItemOptionsGroup.FormattingEnabled = true;
            this.comboBoxItemOptionsGroup.Location = new System.Drawing.Point(86, 32);
            this.comboBoxItemOptionsGroup.Name = "comboBoxItemOptionsGroup";
            this.comboBoxItemOptionsGroup.Size = new System.Drawing.Size(330, 23);
            this.comboBoxItemOptionsGroup.TabIndex = 3;
            // 
            // labelItemOptionsGroup
            // 
            this.labelItemOptionsGroup.AutoSize = true;
            this.labelItemOptionsGroup.Location = new System.Drawing.Point(27, 37);
            this.labelItemOptionsGroup.Name = "labelItemOptionsGroup";
            this.labelItemOptionsGroup.Size = new System.Drawing.Size(41, 15);
            this.labelItemOptionsGroup.TabIndex = 2;
            this.labelItemOptionsGroup.Text = "Group";
            // 
            // textBoxItemOptionsItem
            // 
            this.textBoxItemOptionsItem.Location = new System.Drawing.Point(86, 60);
            this.textBoxItemOptionsItem.Name = "textBoxItemOptionsItem";
            this.textBoxItemOptionsItem.Size = new System.Drawing.Size(330, 23);
            this.textBoxItemOptionsItem.TabIndex = 1;
            // 
            // labelItemOptionsItem
            // 
            this.labelItemOptionsItem.AutoSize = true;
            this.labelItemOptionsItem.Location = new System.Drawing.Point(37, 66);
            this.labelItemOptionsItem.Name = "labelItemOptionsItem";
            this.labelItemOptionsItem.Size = new System.Drawing.Size(31, 15);
            this.labelItemOptionsItem.TabIndex = 0;
            this.labelItemOptionsItem.Text = "Item";
            // 
            // groupBoxItemGroups
            // 
            this.groupBoxItemGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxItemGroups.Controls.Add(this.dataGridViewItemGroups);
            this.groupBoxItemGroups.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItemGroups.Location = new System.Drawing.Point(222, 6);
            this.groupBoxItemGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItemGroups.Name = "groupBoxItemGroups";
            this.groupBoxItemGroups.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItemGroups.Size = new System.Drawing.Size(370, 171);
            this.groupBoxItemGroups.TabIndex = 16;
            this.groupBoxItemGroups.TabStop = false;
            this.groupBoxItemGroups.Text = "Groups";
            // 
            // dataGridViewItemGroups
            // 
            this.dataGridViewItemGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewItemGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewItemGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemGroups.Location = new System.Drawing.Point(8, 22);
            this.dataGridViewItemGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewItemGroups.Name = "dataGridViewItemGroups";
            this.dataGridViewItemGroups.Size = new System.Drawing.Size(354, 143);
            this.dataGridViewItemGroups.TabIndex = 0;
            // 
            // groupBoxItemGroupOptions
            // 
            this.groupBoxItemGroupOptions.Controls.Add(this.checkBoxGroupOptionsEdit);
            this.groupBoxItemGroupOptions.Controls.Add(this.comboBoxGroupOptionsTopGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonNewGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.textBoxGroupOptionsGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.labelGroupOptionsGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonDeleteGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonUpdateGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonSaveGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.labelGroupOptionsTopGroup);
            this.groupBoxItemGroupOptions.Location = new System.Drawing.Point(1235, 108);
            this.groupBoxItemGroupOptions.Name = "groupBoxItemGroupOptions";
            this.groupBoxItemGroupOptions.Size = new System.Drawing.Size(433, 126);
            this.groupBoxItemGroupOptions.TabIndex = 18;
            this.groupBoxItemGroupOptions.TabStop = false;
            this.groupBoxItemGroupOptions.Text = "Group Options";
            // 
            // checkBoxGroupOptionsEdit
            // 
            this.checkBoxGroupOptionsEdit.AutoSize = true;
            this.checkBoxGroupOptionsEdit.Location = new System.Drawing.Point(6, 96);
            this.checkBoxGroupOptionsEdit.Name = "checkBoxGroupOptionsEdit";
            this.checkBoxGroupOptionsEdit.Size = new System.Drawing.Size(47, 19);
            this.checkBoxGroupOptionsEdit.TabIndex = 11;
            this.checkBoxGroupOptionsEdit.Text = "Edit";
            this.checkBoxGroupOptionsEdit.UseVisualStyleBackColor = true;
            // 
            // comboBoxGroupOptionsTopGroup
            // 
            this.comboBoxGroupOptionsTopGroup.FormattingEnabled = true;
            this.comboBoxGroupOptionsTopGroup.Location = new System.Drawing.Point(86, 32);
            this.comboBoxGroupOptionsTopGroup.Name = "comboBoxGroupOptionsTopGroup";
            this.comboBoxGroupOptionsTopGroup.Size = new System.Drawing.Size(328, 23);
            this.comboBoxGroupOptionsTopGroup.TabIndex = 12;
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Location = new System.Drawing.Point(86, 92);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGroup.TabIndex = 11;
            this.buttonNewGroup.Text = "New";
            this.buttonNewGroup.UseVisualStyleBackColor = true;
            // 
            // textBoxGroupOptionsGroup
            // 
            this.textBoxGroupOptionsGroup.Location = new System.Drawing.Point(86, 61);
            this.textBoxGroupOptionsGroup.Name = "textBoxGroupOptionsGroup";
            this.textBoxGroupOptionsGroup.Size = new System.Drawing.Size(330, 23);
            this.textBoxGroupOptionsGroup.TabIndex = 10;
            // 
            // labelGroupOptionsGroup
            // 
            this.labelGroupOptionsGroup.AutoSize = true;
            this.labelGroupOptionsGroup.Location = new System.Drawing.Point(27, 64);
            this.labelGroupOptionsGroup.Name = "labelGroupOptionsGroup";
            this.labelGroupOptionsGroup.Size = new System.Drawing.Size(41, 15);
            this.labelGroupOptionsGroup.TabIndex = 9;
            this.labelGroupOptionsGroup.Text = "Group";
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Location = new System.Drawing.Point(339, 92);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteGroup.TabIndex = 8;
            this.buttonDeleteGroup.Text = "Delete";
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateGroup
            // 
            this.buttonUpdateGroup.Location = new System.Drawing.Point(254, 92);
            this.buttonUpdateGroup.Name = "buttonUpdateGroup";
            this.buttonUpdateGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateGroup.TabIndex = 7;
            this.buttonUpdateGroup.Text = "Update";
            this.buttonUpdateGroup.UseVisualStyleBackColor = true;
            // 
            // buttonSaveGroup
            // 
            this.buttonSaveGroup.Location = new System.Drawing.Point(169, 92);
            this.buttonSaveGroup.Name = "buttonSaveGroup";
            this.buttonSaveGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveGroup.TabIndex = 6;
            this.buttonSaveGroup.Text = "Save";
            this.buttonSaveGroup.UseVisualStyleBackColor = true;
            // 
            // labelGroupOptionsTopGroup
            // 
            this.labelGroupOptionsTopGroup.AutoSize = true;
            this.labelGroupOptionsTopGroup.Location = new System.Drawing.Point(5, 37);
            this.labelGroupOptionsTopGroup.Name = "labelGroupOptionsTopGroup";
            this.labelGroupOptionsTopGroup.Size = new System.Drawing.Size(63, 15);
            this.labelGroupOptionsTopGroup.TabIndex = 0;
            this.labelGroupOptionsTopGroup.Text = "Top Group";
            // 
            // panelTransactions
            // 
            this.panelTransactions.Controls.Add(this.groupBoxTactionOptions);
            this.panelTransactions.Controls.Add(this.groupBoxTactionDetailsOptions);
            this.panelTransactions.Controls.Add(this.groupBoxTactionDetails);
            this.panelTransactions.Controls.Add(this.groupBoxTactions);
            this.panelTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTransactions.Location = new System.Drawing.Point(0, 0);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(1682, 838);
            this.panelTransactions.TabIndex = 6;
            this.panelTransactions.Visible = false;
            // 
            // groupBoxTactionOptions
            // 
            this.groupBoxTactionOptions.Controls.Add(this.textBoxTotalVatPrice);
            this.groupBoxTactionOptions.Controls.Add(this.labelTotalVatPrice);
            this.groupBoxTactionOptions.Controls.Add(this.labelOwner);
            this.groupBoxTactionOptions.Controls.Add(this.comboBoxOwner);
            this.groupBoxTactionOptions.Controls.Add(this.buttonCancelTaction);
            this.groupBoxTactionOptions.Controls.Add(this.checkBoxTactionsEditable);
            this.groupBoxTactionOptions.Controls.Add(this.textBoxSeller);
            this.groupBoxTactionOptions.Controls.Add(this.dateTimePickerTactionDate);
            this.groupBoxTactionOptions.Controls.Add(this.checkBoxSeller);
            this.groupBoxTactionOptions.Controls.Add(this.labelTactionDate);
            this.groupBoxTactionOptions.Controls.Add(this.buttonNewTaction);
            this.groupBoxTactionOptions.Controls.Add(this.labelShop);
            this.groupBoxTactionOptions.Controls.Add(this.buttonDeleteTaction);
            this.groupBoxTactionOptions.Controls.Add(this.textBoxShop);
            this.groupBoxTactionOptions.Controls.Add(this.textBoxTotalPrice);
            this.groupBoxTactionOptions.Controls.Add(this.labelPaymentMethod);
            this.groupBoxTactionOptions.Controls.Add(this.buttonSaveTaction);
            this.groupBoxTactionOptions.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBoxTactionOptions.Controls.Add(this.labelTotalPrice);
            this.groupBoxTactionOptions.Controls.Add(this.labelTactionNo);
            this.groupBoxTactionOptions.Controls.Add(this.buttonUpdateTaction);
            this.groupBoxTactionOptions.Controls.Add(this.textBoxTactionNo);
            this.groupBoxTactionOptions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactionOptions.Location = new System.Drawing.Point(745, 490);
            this.groupBoxTactionOptions.Name = "groupBoxTactionOptions";
            this.groupBoxTactionOptions.Size = new System.Drawing.Size(927, 166);
            this.groupBoxTactionOptions.TabIndex = 10;
            this.groupBoxTactionOptions.TabStop = false;
            this.groupBoxTactionOptions.Text = "Transaction Options";
            // 
            // textBoxTotalVatPrice
            // 
            this.textBoxTotalVatPrice.Location = new System.Drawing.Point(749, 58);
            this.textBoxTotalVatPrice.Name = "textBoxTotalVatPrice";
            this.textBoxTotalVatPrice.Size = new System.Drawing.Size(118, 23);
            this.textBoxTotalVatPrice.TabIndex = 51;
            // 
            // labelTotalVatPrice
            // 
            this.labelTotalVatPrice.AutoSize = true;
            this.labelTotalVatPrice.Location = new System.Drawing.Point(678, 62);
            this.labelTotalVatPrice.Name = "labelTotalVatPrice";
            this.labelTotalVatPrice.Size = new System.Drawing.Size(54, 15);
            this.labelTotalVatPrice.TabIndex = 50;
            this.labelTotalVatPrice.Text = "Total Vat";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(336, 93);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(43, 15);
            this.labelOwner.TabIndex = 48;
            this.labelOwner.Text = "Owner";
            // 
            // comboBoxOwner
            // 
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Location = new System.Drawing.Point(413, 89);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new System.Drawing.Size(200, 23);
            this.comboBoxOwner.TabIndex = 49;
            // 
            // buttonCancelTaction
            // 
            this.buttonCancelTaction.Location = new System.Drawing.Point(364, 133);
            this.buttonCancelTaction.Name = "buttonCancelTaction";
            this.buttonCancelTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonCancelTaction.TabIndex = 47;
            this.buttonCancelTaction.Text = "Cancel";
            this.buttonCancelTaction.UseVisualStyleBackColor = true;
            // 
            // checkBoxTactionsEditable
            // 
            this.checkBoxTactionsEditable.AutoSize = true;
            this.checkBoxTactionsEditable.Location = new System.Drawing.Point(795, 135);
            this.checkBoxTactionsEditable.Name = "checkBoxTactionsEditable";
            this.checkBoxTactionsEditable.Size = new System.Drawing.Size(71, 19);
            this.checkBoxTactionsEditable.TabIndex = 46;
            this.checkBoxTactionsEditable.Text = "Editable";
            this.checkBoxTactionsEditable.UseVisualStyleBackColor = true;
            // 
            // textBoxSeller
            // 
            this.textBoxSeller.Location = new System.Drawing.Point(413, 27);
            this.textBoxSeller.Name = "textBoxSeller";
            this.textBoxSeller.Size = new System.Drawing.Size(200, 23);
            this.textBoxSeller.TabIndex = 45;
            // 
            // dateTimePickerTactionDate
            // 
            this.dateTimePickerTactionDate.Location = new System.Drawing.Point(78, 26);
            this.dateTimePickerTactionDate.Name = "dateTimePickerTactionDate";
            this.dateTimePickerTactionDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTactionDate.TabIndex = 34;
            // 
            // checkBoxSeller
            // 
            this.checkBoxSeller.AutoSize = true;
            this.checkBoxSeller.Location = new System.Drawing.Point(328, 30);
            this.checkBoxSeller.Name = "checkBoxSeller";
            this.checkBoxSeller.Size = new System.Drawing.Size(57, 19);
            this.checkBoxSeller.TabIndex = 43;
            this.checkBoxSeller.Text = "Seller";
            this.checkBoxSeller.UseVisualStyleBackColor = true;
            // 
            // labelTactionDate
            // 
            this.labelTactionDate.AutoSize = true;
            this.labelTactionDate.Location = new System.Drawing.Point(30, 30);
            this.labelTactionDate.Name = "labelTactionDate";
            this.labelTactionDate.Size = new System.Drawing.Size(32, 15);
            this.labelTactionDate.TabIndex = 33;
            this.labelTactionDate.Text = "Date";
            // 
            // buttonNewTaction
            // 
            this.buttonNewTaction.Location = new System.Drawing.Point(24, 133);
            this.buttonNewTaction.Name = "buttonNewTaction";
            this.buttonNewTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonNewTaction.TabIndex = 21;
            this.buttonNewTaction.Text = "New";
            this.buttonNewTaction.UseVisualStyleBackColor = true;
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(28, 61);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(34, 15);
            this.labelShop.TabIndex = 35;
            this.labelShop.Text = "Shop";
            // 
            // buttonDeleteTaction
            // 
            this.buttonDeleteTaction.Location = new System.Drawing.Point(279, 133);
            this.buttonDeleteTaction.Name = "buttonDeleteTaction";
            this.buttonDeleteTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonDeleteTaction.TabIndex = 24;
            this.buttonDeleteTaction.Text = "Delete";
            this.buttonDeleteTaction.UseVisualStyleBackColor = true;
            // 
            // textBoxShop
            // 
            this.textBoxShop.Location = new System.Drawing.Point(78, 57);
            this.textBoxShop.Name = "textBoxShop";
            this.textBoxShop.Size = new System.Drawing.Size(200, 23);
            this.textBoxShop.TabIndex = 36;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(749, 27);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(118, 23);
            this.textBoxTotalPrice.TabIndex = 42;
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Location = new System.Drawing.Point(8, 92);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(54, 15);
            this.labelPaymentMethod.TabIndex = 37;
            this.labelPaymentMethod.Text = "Payment";
            // 
            // buttonSaveTaction
            // 
            this.buttonSaveTaction.Location = new System.Drawing.Point(109, 133);
            this.buttonSaveTaction.Name = "buttonSaveTaction";
            this.buttonSaveTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveTaction.TabIndex = 22;
            this.buttonSaveTaction.Text = "Save";
            this.buttonSaveTaction.UseVisualStyleBackColor = true;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(78, 88);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(200, 23);
            this.comboBoxPaymentMethod.TabIndex = 38;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(667, 32);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(65, 15);
            this.labelTotalPrice.TabIndex = 41;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // labelTactionNo
            // 
            this.labelTactionNo.AutoSize = true;
            this.labelTactionNo.Location = new System.Drawing.Point(357, 62);
            this.labelTactionNo.Name = "labelTactionNo";
            this.labelTactionNo.Size = new System.Drawing.Size(22, 15);
            this.labelTactionNo.TabIndex = 39;
            this.labelTactionNo.Text = "No";
            // 
            // buttonUpdateTaction
            // 
            this.buttonUpdateTaction.Location = new System.Drawing.Point(194, 133);
            this.buttonUpdateTaction.Name = "buttonUpdateTaction";
            this.buttonUpdateTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonUpdateTaction.TabIndex = 23;
            this.buttonUpdateTaction.Text = "Update";
            this.buttonUpdateTaction.UseVisualStyleBackColor = true;
            // 
            // textBoxTactionNo
            // 
            this.textBoxTactionNo.Location = new System.Drawing.Point(413, 58);
            this.textBoxTactionNo.Name = "textBoxTactionNo";
            this.textBoxTactionNo.Size = new System.Drawing.Size(75, 23);
            this.textBoxTactionNo.TabIndex = 40;
            // 
            // groupBoxTactionDetailsOptions
            // 
            this.groupBoxTactionDetailsOptions.Controls.Add(this.comboBoxItemSubType);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.buttonAdviceLastUnitPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelVatPercantage);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxItem);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelItemGroup);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxItemGroup);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelItem);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelItemSubType);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelUnit);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxUnit);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelUnitPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxUnitPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelVat);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxVat);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelDiscountRate);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxDiscountRate);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelDiscountedPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.buttonRemoveDetail);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.buttonUpdateDetail);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.checkBoxDiscount);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.checkBoxDetailsEditable);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxDiscountedPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelDetailsNote);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.buttonAddDetail);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxDetailsNote);
            this.groupBoxTactionDetailsOptions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactionDetailsOptions.Location = new System.Drawing.Point(745, 662);
            this.groupBoxTactionDetailsOptions.Name = "groupBoxTactionDetailsOptions";
            this.groupBoxTactionDetailsOptions.Size = new System.Drawing.Size(927, 168);
            this.groupBoxTactionDetailsOptions.TabIndex = 11;
            this.groupBoxTactionDetailsOptions.TabStop = false;
            this.groupBoxTactionDetailsOptions.Text = "Detail Options";
            // 
            // comboBoxItemSubType
            // 
            this.comboBoxItemSubType.FormattingEnabled = true;
            this.comboBoxItemSubType.Location = new System.Drawing.Point(77, 86);
            this.comboBoxItemSubType.Name = "comboBoxItemSubType";
            this.comboBoxItemSubType.Size = new System.Drawing.Size(174, 23);
            this.comboBoxItemSubType.TabIndex = 34;
            // 
            // buttonAdviceLastUnitPrice
            // 
            this.buttonAdviceLastUnitPrice.Location = new System.Drawing.Point(451, 54);
            this.buttonAdviceLastUnitPrice.Name = "buttonAdviceLastUnitPrice";
            this.buttonAdviceLastUnitPrice.Size = new System.Drawing.Size(23, 23);
            this.buttonAdviceLastUnitPrice.TabIndex = 33;
            this.buttonAdviceLastUnitPrice.UseVisualStyleBackColor = true;
            // 
            // labelVatPercantage
            // 
            this.labelVatPercantage.Location = new System.Drawing.Point(355, 90);
            this.labelVatPercantage.Name = "labelVatPercantage";
            this.labelVatPercantage.Size = new System.Drawing.Size(12, 15);
            this.labelVatPercantage.TabIndex = 32;
            this.labelVatPercantage.Text = "%";
            this.labelVatPercantage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(77, 54);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(174, 23);
            this.textBoxItem.TabIndex = 6;
            // 
            // labelItemGroup
            // 
            this.labelItemGroup.AutoSize = true;
            this.labelItemGroup.Location = new System.Drawing.Point(20, 27);
            this.labelItemGroup.Name = "labelItemGroup";
            this.labelItemGroup.Size = new System.Drawing.Size(41, 15);
            this.labelItemGroup.TabIndex = 3;
            this.labelItemGroup.Text = "Group";
            // 
            // textBoxItemGroup
            // 
            this.textBoxItemGroup.Location = new System.Drawing.Point(77, 23);
            this.textBoxItemGroup.Name = "textBoxItemGroup";
            this.textBoxItemGroup.Size = new System.Drawing.Size(174, 23);
            this.textBoxItemGroup.TabIndex = 4;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(30, 60);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(31, 15);
            this.labelItem.TabIndex = 5;
            this.labelItem.Text = "Item";
            // 
            // labelItemSubType
            // 
            this.labelItemSubType.AutoSize = true;
            this.labelItemSubType.Location = new System.Drawing.Point(30, 91);
            this.labelItemSubType.Name = "labelItemSubType";
            this.labelItemSubType.Size = new System.Drawing.Size(31, 15);
            this.labelItemSubType.TabIndex = 7;
            this.labelItemSubType.Text = "Type";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(324, 27);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(30, 15);
            this.labelUnit.TabIndex = 9;
            this.labelUnit.Text = "Unit";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(370, 23);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(75, 23);
            this.textBoxUnit.TabIndex = 10;
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(293, 60);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(61, 15);
            this.labelUnitPrice.TabIndex = 11;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(370, 54);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(75, 23);
            this.textBoxUnitPrice.TabIndex = 12;
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(330, 90);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(24, 15);
            this.labelVat.TabIndex = 13;
            this.labelVat.Text = "Vat";
            // 
            // textBoxVat
            // 
            this.textBoxVat.Location = new System.Drawing.Point(370, 86);
            this.textBoxVat.Name = "textBoxVat";
            this.textBoxVat.Size = new System.Drawing.Size(75, 23);
            this.textBoxVat.TabIndex = 14;
            // 
            // labelDiscountRate
            // 
            this.labelDiscountRate.AutoSize = true;
            this.labelDiscountRate.Location = new System.Drawing.Point(498, 60);
            this.labelDiscountRate.Name = "labelDiscountRate";
            this.labelDiscountRate.Size = new System.Drawing.Size(48, 15);
            this.labelDiscountRate.TabIndex = 15;
            this.labelDiscountRate.Text = "Rate (*)";
            // 
            // textBoxDiscountRate
            // 
            this.textBoxDiscountRate.Location = new System.Drawing.Point(552, 54);
            this.textBoxDiscountRate.Name = "textBoxDiscountRate";
            this.textBoxDiscountRate.Size = new System.Drawing.Size(75, 23);
            this.textBoxDiscountRate.TabIndex = 16;
            // 
            // labelDiscountedPrice
            // 
            this.labelDiscountedPrice.AutoSize = true;
            this.labelDiscountedPrice.Location = new System.Drawing.Point(494, 91);
            this.labelDiscountedPrice.Name = "labelDiscountedPrice";
            this.labelDiscountedPrice.Size = new System.Drawing.Size(52, 15);
            this.labelDiscountedPrice.TabIndex = 17;
            this.labelDiscountedPrice.Text = "Price (*)";
            // 
            // buttonRemoveDetail
            // 
            this.buttonRemoveDetail.Location = new System.Drawing.Point(193, 133);
            this.buttonRemoveDetail.Name = "buttonRemoveDetail";
            this.buttonRemoveDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonRemoveDetail.TabIndex = 27;
            this.buttonRemoveDetail.Text = "Remove";
            this.buttonRemoveDetail.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateDetail
            // 
            this.buttonUpdateDetail.Location = new System.Drawing.Point(108, 133);
            this.buttonUpdateDetail.Name = "buttonUpdateDetail";
            this.buttonUpdateDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonUpdateDetail.TabIndex = 26;
            this.buttonUpdateDetail.Text = "Update";
            this.buttonUpdateDetail.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Location = new System.Drawing.Point(552, 26);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(75, 19);
            this.checkBoxDiscount.TabIndex = 19;
            this.checkBoxDiscount.Text = "Discount";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // checkBoxDetailsEditable
            // 
            this.checkBoxDetailsEditable.AutoSize = true;
            this.checkBoxDetailsEditable.Location = new System.Drawing.Point(794, 133);
            this.checkBoxDetailsEditable.Name = "checkBoxDetailsEditable";
            this.checkBoxDetailsEditable.Size = new System.Drawing.Size(71, 19);
            this.checkBoxDetailsEditable.TabIndex = 31;
            this.checkBoxDetailsEditable.Text = "Editable";
            this.checkBoxDetailsEditable.UseVisualStyleBackColor = true;
            // 
            // textBoxDiscountedPrice
            // 
            this.textBoxDiscountedPrice.Location = new System.Drawing.Point(552, 86);
            this.textBoxDiscountedPrice.Name = "textBoxDiscountedPrice";
            this.textBoxDiscountedPrice.Size = new System.Drawing.Size(75, 23);
            this.textBoxDiscountedPrice.TabIndex = 20;
            // 
            // labelDetailsNote
            // 
            this.labelDetailsNote.AutoSize = true;
            this.labelDetailsNote.Location = new System.Drawing.Point(701, 23);
            this.labelDetailsNote.Name = "labelDetailsNote";
            this.labelDetailsNote.Size = new System.Drawing.Size(32, 15);
            this.labelDetailsNote.TabIndex = 30;
            this.labelDetailsNote.Text = "Note";
            // 
            // buttonAddDetail
            // 
            this.buttonAddDetail.Location = new System.Drawing.Point(23, 133);
            this.buttonAddDetail.Name = "buttonAddDetail";
            this.buttonAddDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonAddDetail.TabIndex = 25;
            this.buttonAddDetail.Text = "Add";
            this.buttonAddDetail.UseVisualStyleBackColor = true;
            // 
            // textBoxDetailsNote
            // 
            this.textBoxDetailsNote.Location = new System.Drawing.Point(701, 39);
            this.textBoxDetailsNote.Multiline = true;
            this.textBoxDetailsNote.Name = "textBoxDetailsNote";
            this.textBoxDetailsNote.Size = new System.Drawing.Size(182, 71);
            this.textBoxDetailsNote.TabIndex = 29;
            // 
            // groupBoxTactionDetails
            // 
            this.groupBoxTactionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTactionDetails.Controls.Add(this.dataGridViewTactionDetails);
            this.groupBoxTactionDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactionDetails.Location = new System.Drawing.Point(745, 5);
            this.groupBoxTactionDetails.Name = "groupBoxTactionDetails";
            this.groupBoxTactionDetails.Size = new System.Drawing.Size(1476, 479);
            this.groupBoxTactionDetails.TabIndex = 9;
            this.groupBoxTactionDetails.TabStop = false;
            this.groupBoxTactionDetails.Text = "Details";
            // 
            // dataGridViewTactionDetails
            // 
            this.dataGridViewTactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTactionDetails.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewTactionDetails.Name = "dataGridViewTactionDetails";
            this.dataGridViewTactionDetails.Size = new System.Drawing.Size(915, 449);
            this.dataGridViewTactionDetails.TabIndex = 0;
            // 
            // groupBoxTactions
            // 
            this.groupBoxTactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTactions.Controls.Add(this.dataGridViewTactions);
            this.groupBoxTactions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactions.Location = new System.Drawing.Point(6, 6);
            this.groupBoxTactions.Name = "groupBoxTactions";
            this.groupBoxTactions.Size = new System.Drawing.Size(733, 832);
            this.groupBoxTactions.TabIndex = 8;
            this.groupBoxTactions.TabStop = false;
            this.groupBoxTactions.Text = "Transactions";
            // 
            // dataGridViewTactions
            // 
            this.dataGridViewTactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTactions.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewTactions.Name = "dataGridViewTactions";
            this.dataGridViewTactions.Size = new System.Drawing.Size(721, 802);
            this.dataGridViewTactions.TabIndex = 0;
            // 
            // panelApplicationLog
            // 
            this.panelApplicationLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelApplicationLog.Controls.Add(this.groupBoxWithListView);
            this.panelApplicationLog.Location = new System.Drawing.Point(0, 0);
            this.panelApplicationLog.Name = "panelApplicationLog";
            this.panelApplicationLog.Size = new System.Drawing.Size(194, 188);
            this.panelApplicationLog.TabIndex = 5;
            // 
            // groupBoxWithListView
            // 
            this.groupBoxWithListView.Controls.Add(this.listViewLog);
            this.groupBoxWithListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWithListView.Location = new System.Drawing.Point(0, 0);
            this.groupBoxWithListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxWithListView.Name = "groupBoxWithListView";
            this.groupBoxWithListView.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxWithListView.Size = new System.Drawing.Size(194, 188);
            this.groupBoxWithListView.TabIndex = 4;
            this.groupBoxWithListView.TabStop = false;
            this.groupBoxWithListView.Text = "Application Log";
            // 
            // listViewLog
            // 
            this.listViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLog.HideSelection = false;
            this.listViewLog.Location = new System.Drawing.Point(4, 19);
            this.listViewLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.Size = new System.Drawing.Size(186, 166);
            this.listViewLog.TabIndex = 0;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripMain
            // 
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1910, 25);
            this.toolStripMain.TabIndex = 6;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // labelHorizontalLine1
            // 
            this.labelHorizontalLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHorizontalLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHorizontalLine1.Location = new System.Drawing.Point(0, 49);
            this.labelHorizontalLine1.Name = "labelHorizontalLine1";
            this.labelHorizontalLine1.Size = new System.Drawing.Size(1910, 2);
            this.labelHorizontalLine1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 917);
            this.Controls.Add(this.labelHorizontalLine1);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Invoice Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelBottomSide.ResumeLayout(false);
            this.panelTopSide.ResumeLayout(false);
            this.panelSellers.ResumeLayout(false);
            this.groupBoxSeller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellers)).EndInit();
            this.groupBoxSellerOptions.ResumeLayout(false);
            this.groupBoxSellerOptions.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            this.groupBoxUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.groupBoxUserOptions.ResumeLayout(false);
            this.groupBoxUserOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelPaymentMethods.ResumeLayout(false);
            this.groupBoxBankCardOptions.ResumeLayout(false);
            this.groupBoxBankCardOptions.PerformLayout();
            this.groupBoxPaymentMethodOptions.ResumeLayout(false);
            this.groupBoxPaymentMethodOptions.PerformLayout();
            this.groupBoxPaymentMethods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentMethods)).EndInit();
            this.groupBoxBankCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankCards)).EndInit();
            this.panelShops.ResumeLayout(false);
            this.groupBoxShopGroupOptions.ResumeLayout(false);
            this.groupBoxShopGroupOptions.PerformLayout();
            this.groupBoxShopGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopGroups)).EndInit();
            this.groupBoxShops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            this.groupBoxShopTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopTypes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxShopOptions.ResumeLayout(false);
            this.groupBoxShopOptions.PerformLayout();
            this.panelItems.ResumeLayout(false);
            this.groupBoxItemSubTypeOptions.ResumeLayout(false);
            this.groupBoxItemSubTypeOptions.PerformLayout();
            this.groupBoxItemTopGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemTopGroups)).EndInit();
            this.groupBoxItemTopGroupOptions.ResumeLayout(false);
            this.groupBoxItemTopGroupOptions.PerformLayout();
            this.groupBoxItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.groupBoxItemOptions.ResumeLayout(false);
            this.groupBoxItemOptions.PerformLayout();
            this.groupBoxItemGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemGroups)).EndInit();
            this.groupBoxItemGroupOptions.ResumeLayout(false);
            this.groupBoxItemGroupOptions.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.groupBoxTactionOptions.ResumeLayout(false);
            this.groupBoxTactionOptions.PerformLayout();
            this.groupBoxTactionDetailsOptions.ResumeLayout(false);
            this.groupBoxTactionDetailsOptions.PerformLayout();
            this.groupBoxTactionDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionDetails)).EndInit();
            this.groupBoxTactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactions)).EndInit();
            this.panelApplicationLog.ResumeLayout(false);
            this.groupBoxWithListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWindows;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransactions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemItems;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSync;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSyncSqlite;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShops;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaymentMethods;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSellers;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLiveDateTime;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKeyboardShortcuts;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowSidePanel;
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReportABug;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.TreeView treeViewSidePanel;
        private System.Windows.Forms.Label labelHorizontalLine1;
        private System.Windows.Forms.Panel panelTopSide;
        private System.Windows.Forms.ListBox listBoxSidePanel;
        private System.Windows.Forms.Panel panelBottomSide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBatch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBatchItemSubTypes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemApplicationLog;
        private System.Windows.Forms.Panel panelApplicationLog;
        private System.Windows.Forms.GroupBox groupBoxWithListView;
        private System.Windows.Forms.ListView listViewLog;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.GroupBox groupBoxTactionOptions;
        private System.Windows.Forms.TextBox textBoxTotalVatPrice;
        private System.Windows.Forms.Label labelTotalVatPrice;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.Button buttonCancelTaction;
        private System.Windows.Forms.CheckBox checkBoxTactionsEditable;
        private System.Windows.Forms.TextBox textBoxSeller;
        private System.Windows.Forms.DateTimePicker dateTimePickerTactionDate;
        private System.Windows.Forms.CheckBox checkBoxSeller;
        private System.Windows.Forms.Label labelTactionDate;
        private System.Windows.Forms.Button buttonNewTaction;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.Button buttonDeleteTaction;
        private System.Windows.Forms.TextBox textBoxShop;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Button buttonSaveTaction;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTactionNo;
        private System.Windows.Forms.Button buttonUpdateTaction;
        private System.Windows.Forms.TextBox textBoxTactionNo;
        private System.Windows.Forms.GroupBox groupBoxTactionDetailsOptions;
        private System.Windows.Forms.ComboBox comboBoxItemSubType;
        private System.Windows.Forms.Button buttonAdviceLastUnitPrice;
        private System.Windows.Forms.Label labelVatPercantage;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Label labelItemGroup;
        private System.Windows.Forms.TextBox textBoxItemGroup;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelItemSubType;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.TextBox textBoxVat;
        private System.Windows.Forms.Label labelDiscountRate;
        private System.Windows.Forms.TextBox textBoxDiscountRate;
        private System.Windows.Forms.Label labelDiscountedPrice;
        private System.Windows.Forms.Button buttonRemoveDetail;
        private System.Windows.Forms.Button buttonUpdateDetail;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.CheckBox checkBoxDetailsEditable;
        private System.Windows.Forms.TextBox textBoxDiscountedPrice;
        private System.Windows.Forms.Label labelDetailsNote;
        private System.Windows.Forms.Button buttonAddDetail;
        private System.Windows.Forms.TextBox textBoxDetailsNote;
        private System.Windows.Forms.GroupBox groupBoxTactionDetails;
        private System.Windows.Forms.DataGridView dataGridViewTactionDetails;
        private System.Windows.Forms.GroupBox groupBoxTactions;
        private System.Windows.Forms.DataGridView dataGridViewTactions;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.GroupBox groupBoxItemSubTypeOptions;
        private System.Windows.Forms.TextBox textBoxItemSubTypeOptionsItem;
        private System.Windows.Forms.ComboBox comboBoxItemSubTypeOptionsItemSubType;
        private System.Windows.Forms.CheckBox checkBoxItemSubTypeOptionsEdit;
        private System.Windows.Forms.Button buttonNewItemSubType;
        private System.Windows.Forms.Button buttonDeleteItemSubType;
        private System.Windows.Forms.Button buttonUpdateItemSubType;
        private System.Windows.Forms.Button buttonSaveItemSubType;
        private System.Windows.Forms.Label labelItemSubTypeOptionsItem;
        private System.Windows.Forms.Label labelItemSubTypeOptionsItemSubType;
        private System.Windows.Forms.GroupBox groupBoxItemTopGroups;
        private System.Windows.Forms.DataGridView dataGridViewItemTopGroups;
        private System.Windows.Forms.GroupBox groupBoxItemTopGroupOptions;
        private System.Windows.Forms.ComboBox comboBoxTopGroupOptionsTopGroup;
        private System.Windows.Forms.Button buttonNewTopGroup;
        private System.Windows.Forms.Label labelTopGroupOptionsTopGroup;
        private System.Windows.Forms.Button buttonDeleteTopGroup;
        private System.Windows.Forms.Button buttonUpdateTopGroup;
        private System.Windows.Forms.Button buttonSaveTopGroup;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.GroupBox groupBoxItemOptions;
        private System.Windows.Forms.CheckBox checkBoxItemOptionsEdit;
        private System.Windows.Forms.Button buttonNewItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.TextBox textBoxItemOptionsNote;
        private System.Windows.Forms.Label labelItemOptionsNote;
        private System.Windows.Forms.ComboBox comboBoxItemOptionsGroup;
        private System.Windows.Forms.Label labelItemOptionsGroup;
        private System.Windows.Forms.TextBox textBoxItemOptionsItem;
        private System.Windows.Forms.Label labelItemOptionsItem;
        private System.Windows.Forms.GroupBox groupBoxItemGroups;
        private System.Windows.Forms.DataGridView dataGridViewItemGroups;
        private System.Windows.Forms.GroupBox groupBoxItemGroupOptions;
        private System.Windows.Forms.CheckBox checkBoxGroupOptionsEdit;
        private System.Windows.Forms.ComboBox comboBoxGroupOptionsTopGroup;
        private System.Windows.Forms.Button buttonNewGroup;
        private System.Windows.Forms.TextBox textBoxGroupOptionsGroup;
        private System.Windows.Forms.Label labelGroupOptionsGroup;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.Button buttonUpdateGroup;
        private System.Windows.Forms.Button buttonSaveGroup;
        private System.Windows.Forms.Label labelGroupOptionsTopGroup;
        private System.Windows.Forms.Panel panelShops;
        private System.Windows.Forms.GroupBox groupBoxShopGroupOptions;
        private System.Windows.Forms.CheckBox checkBoxShopGroupOptionsEdit;
        private System.Windows.Forms.Button buttonNewShopGroup;
        private System.Windows.Forms.Button buttonSaveShopGroup;
        private System.Windows.Forms.Button buttonUpdateShopGroup;
        private System.Windows.Forms.Button buttonDeleteShopGroup;
        private System.Windows.Forms.Label labelShopGroupOptionsOwner;
        private System.Windows.Forms.TextBox textBoxShopGroupOptionsGroupName;
        private System.Windows.Forms.Label labelShopGroupOptionsGroupName;
        private System.Windows.Forms.ComboBox comboBoxShopGroupOptionsShopType;
        private System.Windows.Forms.TextBox textBoxShopGroupOptionsOwner;
        private System.Windows.Forms.Label labelShopGroupOptionsShopType;
        private System.Windows.Forms.GroupBox groupBoxShopGroups;
        private System.Windows.Forms.DataGridView dataGridViewShopGroups;
        private System.Windows.Forms.GroupBox groupBoxShops;
        private System.Windows.Forms.DataGridView dataGridViewShops;
        private System.Windows.Forms.GroupBox groupBoxShopTypes;
        private System.Windows.Forms.DataGridView dataGridViewShopTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxShopTypeOptionsShopType;
        private System.Windows.Forms.Button buttonNewShopType;
        private System.Windows.Forms.Label labelShopTypeOptionsShopType;
        private System.Windows.Forms.Button buttonDeleteShopType;
        private System.Windows.Forms.Button buttonUpdateShopType;
        private System.Windows.Forms.Button buttonSaveShopType;
        private System.Windows.Forms.CheckBox checkBoxSetRelational;
        private System.Windows.Forms.GroupBox groupBoxShopOptions;
        private System.Windows.Forms.Label labelShopOptionsShopGroup;
        private System.Windows.Forms.ComboBox comboBoxShopOptionsShopGroup;
        private System.Windows.Forms.Button buttonNewShop;
        private System.Windows.Forms.TextBox textBoxShopOptionsWeb;
        private System.Windows.Forms.Label labelShopOptionsWeb;
        private System.Windows.Forms.TextBox textBoxShopOptionsEmail;
        private System.Windows.Forms.Label labelShopOptionsEmail;
        private System.Windows.Forms.TextBox textBoxShopOptionsTel;
        private System.Windows.Forms.Label labelShopOptionsTel;
        private System.Windows.Forms.TextBox textBoxShopOptionsNickName;
        private System.Windows.Forms.Label labelShopOptionsShopName;
        private System.Windows.Forms.TextBox textBoxShopOptionsShop;
        private System.Windows.Forms.Label labelShopOptionsNickName;
        private System.Windows.Forms.Label labelShopOptionsAddress;
        private System.Windows.Forms.TextBox textBoxShopOptionsAddress;
        private System.Windows.Forms.Button buttonDeleteShop;
        private System.Windows.Forms.Button buttonUpdateShop;
        private System.Windows.Forms.Button buttonSaveShop;
        private System.Windows.Forms.Panel panelPaymentMethods;
        private System.Windows.Forms.GroupBox groupBoxBankCardOptions;
        private System.Windows.Forms.TextBox textBoxCardOptionsCard;
        private System.Windows.Forms.ComboBox comboBoxCardOptionsCardType;
        private System.Windows.Forms.CheckBox checkBoxCardOptionsEdit;
        private System.Windows.Forms.Button buttonNewCard;
        private System.Windows.Forms.Label labelCardOptionsCardType;
        private System.Windows.Forms.Button buttonDeleteCard;
        private System.Windows.Forms.Button buttonUpdateCard;
        private System.Windows.Forms.Button buttonSaveCard;
        private System.Windows.Forms.Label labelCardOptionsCard;
        private System.Windows.Forms.GroupBox groupBoxPaymentMethodOptions;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethodOptionsCardOwner;
        private System.Windows.Forms.Label labelPaymentMethodOptionsCardOwner;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethodOptionsCardType;
        private System.Windows.Forms.Label labelPaymentMethodOptionsCardType;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethodOptionsCard;
        private System.Windows.Forms.CheckBox checkBoxPaymentOptionsEdit;
        private System.Windows.Forms.Button buttonNewPaymentMethod;
        private System.Windows.Forms.Button buttonDeletePaymentMethod;
        private System.Windows.Forms.Button buttonUpdatePaymentMethod;
        private System.Windows.Forms.Button buttonSavePaymentMethod;
        private System.Windows.Forms.Label labelPaymentMethodOptionsPaymentMethod;
        private System.Windows.Forms.TextBox textBoxPaymentMethodOptionsPaymentMethod;
        private System.Windows.Forms.Label labelPaymentMethodOptionsCard;
        private System.Windows.Forms.GroupBox groupBoxPaymentMethods;
        private System.Windows.Forms.DataGridView dataGridViewPaymentMethods;
        private System.Windows.Forms.GroupBox groupBoxBankCards;
        private System.Windows.Forms.DataGridView dataGridViewBankCards;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.GroupBox groupBoxUserOptions;
        private System.Windows.Forms.CheckBox checkBoxDefaultUserImage;
        private System.Windows.Forms.TextBox textBoxUserOptionsName;
        private System.Windows.Forms.TextBox textBoxUserOptionsSurname;
        private System.Windows.Forms.Button buttonPreviousImage;
        private System.Windows.Forms.Button buttonNextImage;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelUserOptionsName;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.TextBox textBoxUserOptionsFullname;
        private System.Windows.Forms.Label labelUserOptionsFullname;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.Label labelUserOptionsSurname;
        private System.Windows.Forms.Panel panelSellers;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.DataGridView dataGridViewSellers;
        private System.Windows.Forms.GroupBox groupBoxSellerOptions;
        private System.Windows.Forms.Button buttonNewSeller;
        private System.Windows.Forms.TextBox textBoxSellerOptionsWeb;
        private System.Windows.Forms.Label labelSellerOptionsWeb;
        private System.Windows.Forms.TextBox textBoxSellerOptionsEmail;
        private System.Windows.Forms.Label labelSellerOptionsEmail;
        private System.Windows.Forms.TextBox textBoxSellerOptionsTel;
        private System.Windows.Forms.Label labelSellerOptionsTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSellerOptionsSeller;
        private System.Windows.Forms.Label labelSellerOptionsAddress;
        private System.Windows.Forms.TextBox textBoxSellerOptionsAddress;
        private System.Windows.Forms.Button buttonDeleteSeller;
        private System.Windows.Forms.Button buttonUpdateSeller;
        private System.Windows.Forms.Button buttonSaveSeller;
    }
}

