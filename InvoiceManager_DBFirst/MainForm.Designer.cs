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
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.labelHorizontalLine1 = new System.Windows.Forms.Label();
            this.groupBoxWithListView = new System.Windows.Forms.GroupBox();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.panelApplicationLog = new System.Windows.Forms.Panel();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxTotalVatPrice = new System.Windows.Forms.TextBox();
            this.labelTotalVatPrice = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.buttonCancelTaction = new System.Windows.Forms.Button();
            this.checkBoxTactionsEditable = new System.Windows.Forms.CheckBox();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.textBoxItemGroup = new System.Windows.Forms.TextBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelItemSubType = new System.Windows.Forms.Label();
            this.buttonNewTaction = new System.Windows.Forms.Button();
            this.buttonDeleteTaction = new System.Windows.Forms.Button();
            this.buttonSaveTaction = new System.Windows.Forms.Button();
            this.labelVat = new System.Windows.Forms.Label();
            this.buttonUpdateTaction = new System.Windows.Forms.Button();
            this.groupBoxTactionOptions = new System.Windows.Forms.GroupBox();
            this.textBoxSeller = new System.Windows.Forms.TextBox();
            this.dateTimePickerTactionDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxSeller = new System.Windows.Forms.CheckBox();
            this.labelTactionDate = new System.Windows.Forms.Label();
            this.labelShop = new System.Windows.Forms.Label();
            this.textBoxShop = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTactionNo = new System.Windows.Forms.Label();
            this.textBoxTactionNo = new System.Windows.Forms.TextBox();
            this.groupBoxTactionDetailsOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxItemSubType = new System.Windows.Forms.ComboBox();
            this.buttonAdviceLastUnitPrice = new System.Windows.Forms.Button();
            this.labelVatPercantage = new System.Windows.Forms.Label();
            this.labelItemGroup = new System.Windows.Forms.Label();
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
            this.dataGridViewTactions = new System.Windows.Forms.DataGridView();
            this.groupBoxTactionDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewTactionDetails = new System.Windows.Forms.DataGridView();
            this.groupBoxTactions = new System.Windows.Forms.GroupBox();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelBottomSide.SuspendLayout();
            this.panelTopSide.SuspendLayout();
            this.groupBoxWithListView.SuspendLayout();
            this.panelApplicationLog.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.groupBoxTactionOptions.SuspendLayout();
            this.groupBoxTactionDetailsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactions)).BeginInit();
            this.groupBoxTactionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionDetails)).BeginInit();
            this.groupBoxTactions.SuspendLayout();
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
            // groupBoxWithListView
            // 
            this.groupBoxWithListView.Controls.Add(this.listViewLog);
            this.groupBoxWithListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWithListView.Location = new System.Drawing.Point(0, 0);
            this.groupBoxWithListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxWithListView.Name = "groupBoxWithListView";
            this.groupBoxWithListView.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxWithListView.Size = new System.Drawing.Size(577, 379);
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
            this.listViewLog.Size = new System.Drawing.Size(569, 357);
            this.listViewLog.TabIndex = 0;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            // 
            // panelApplicationLog
            // 
            this.panelApplicationLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelApplicationLog.Controls.Add(this.groupBoxWithListView);
            this.panelApplicationLog.Location = new System.Drawing.Point(0, 0);
            this.panelApplicationLog.Name = "panelApplicationLog";
            this.panelApplicationLog.Size = new System.Drawing.Size(577, 379);
            this.panelApplicationLog.TabIndex = 5;
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
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(77, 54);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(174, 23);
            this.textBoxItem.TabIndex = 6;
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
            // buttonNewTaction
            // 
            this.buttonNewTaction.Location = new System.Drawing.Point(24, 133);
            this.buttonNewTaction.Name = "buttonNewTaction";
            this.buttonNewTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonNewTaction.TabIndex = 21;
            this.buttonNewTaction.Text = "New";
            this.buttonNewTaction.UseVisualStyleBackColor = true;
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
            // buttonSaveTaction
            // 
            this.buttonSaveTaction.Location = new System.Drawing.Point(109, 133);
            this.buttonSaveTaction.Name = "buttonSaveTaction";
            this.buttonSaveTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveTaction.TabIndex = 22;
            this.buttonSaveTaction.Text = "Save";
            this.buttonSaveTaction.UseVisualStyleBackColor = true;
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
            // buttonUpdateTaction
            // 
            this.buttonUpdateTaction.Location = new System.Drawing.Point(194, 133);
            this.buttonUpdateTaction.Name = "buttonUpdateTaction";
            this.buttonUpdateTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonUpdateTaction.TabIndex = 23;
            this.buttonUpdateTaction.Text = "Update";
            this.buttonUpdateTaction.UseVisualStyleBackColor = true;
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
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(28, 61);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(34, 15);
            this.labelShop.TabIndex = 35;
            this.labelShop.Text = "Shop";
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
            // labelItemGroup
            // 
            this.labelItemGroup.AutoSize = true;
            this.labelItemGroup.Location = new System.Drawing.Point(20, 27);
            this.labelItemGroup.Name = "labelItemGroup";
            this.labelItemGroup.Size = new System.Drawing.Size(41, 15);
            this.labelItemGroup.TabIndex = 3;
            this.labelItemGroup.Text = "Group";
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
            // groupBoxTactionDetails
            // 
            this.groupBoxTactionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTactionDetails.Controls.Add(this.dataGridViewTactionDetails);
            this.groupBoxTactionDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactionDetails.Location = new System.Drawing.Point(745, 5);
            this.groupBoxTactionDetails.Name = "groupBoxTactionDetails";
            this.groupBoxTactionDetails.Size = new System.Drawing.Size(927, 479);
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
            this.groupBoxTactions.Location = new System.Drawing.Point(6, 4);
            this.groupBoxTactions.Name = "groupBoxTactions";
            this.groupBoxTactions.Size = new System.Drawing.Size(733, 832);
            this.groupBoxTactions.TabIndex = 8;
            this.groupBoxTactions.TabStop = false;
            this.groupBoxTactions.Text = "Transactions";
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
            this.groupBoxWithListView.ResumeLayout(false);
            this.panelApplicationLog.ResumeLayout(false);
            this.panelTransactions.ResumeLayout(false);
            this.groupBoxTactionOptions.ResumeLayout(false);
            this.groupBoxTactionOptions.PerformLayout();
            this.groupBoxTactionDetailsOptions.ResumeLayout(false);
            this.groupBoxTactionDetailsOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactions)).EndInit();
            this.groupBoxTactionDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionDetails)).EndInit();
            this.groupBoxTactions.ResumeLayout(false);
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
    }
}

