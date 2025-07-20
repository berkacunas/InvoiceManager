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
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShops = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPaymentMethods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSellers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemApplicationLog = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBankFunds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFetchGroupBankFunds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFetchBankFunds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFetchBankFundTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFetchBankFundValues = new System.Windows.Forms.ToolStripMenuItem();
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProfileShopsText = new System.Windows.Forms.Label();
            this.labelProfileActiveProfile = new System.Windows.Forms.Label();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.labelProfileTransactionsText = new System.Windows.Forms.Label();
            this.labelProfileItemsText = new System.Windows.Forms.Label();
            this.labelProfileTransactionsVal = new System.Windows.Forms.Label();
            this.labelProfileItemsVal = new System.Windows.Forms.Label();
            this.labelProfileShopsVal = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelTopSide = new System.Windows.Forms.Panel();
            this.listViewActiveControls = new System.Windows.Forms.ListView();
            this.placeHolder = new System.Windows.Forms.Panel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.labelHorizontalLine1 = new System.Windows.Forms.Label();
            this.contextMenuStripTileView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBackupCsvFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBackupSqlite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRestoreSqlite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRestoreCsvFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            this.panelTopSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemWindows,
            this.dataToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolStripMenuItemView,
            this.toolStripMenuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1326, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLogin,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "&File";
            // 
            // toolStripMenuItemLogin
            // 
            this.toolStripMenuItemLogin.Name = "toolStripMenuItemLogin";
            this.toolStripMenuItemLogin.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemLogin.Text = "Login";
            this.toolStripMenuItemLogin.Click += new System.EventHandler(this.toolStripMenuItemLogin_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.ShortcutKeyDisplayString = "";
            this.toolStripMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
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
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.toolStripMenuItemBankFunds});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // toolStripMenuItemBankFunds
            // 
            this.toolStripMenuItemBankFunds.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFetchGroupBankFunds});
            this.toolStripMenuItemBankFunds.Name = "toolStripMenuItemBankFunds";
            this.toolStripMenuItemBankFunds.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBankFunds.Text = "Bank Funds";
            // 
            // toolStripMenuItemFetchGroupBankFunds
            // 
            this.toolStripMenuItemFetchGroupBankFunds.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFetchBankFunds,
            this.toolStripMenuItemFetchBankFundTypes,
            this.toolStripMenuItemFetchBankFundValues});
            this.toolStripMenuItemFetchGroupBankFunds.Name = "toolStripMenuItemFetchGroupBankFunds";
            this.toolStripMenuItemFetchGroupBankFunds.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemFetchGroupBankFunds.Text = "Fetch";
            // 
            // toolStripMenuItemFetchBankFunds
            // 
            this.toolStripMenuItemFetchBankFunds.Name = "toolStripMenuItemFetchBankFunds";
            this.toolStripMenuItemFetchBankFunds.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemFetchBankFunds.Text = "Funds";
            this.toolStripMenuItemFetchBankFunds.Click += new System.EventHandler(this.toolStripMenuItemFetchBankFunds_Click);
            // 
            // toolStripMenuItemFetchBankFundTypes
            // 
            this.toolStripMenuItemFetchBankFundTypes.Name = "toolStripMenuItemFetchBankFundTypes";
            this.toolStripMenuItemFetchBankFundTypes.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemFetchBankFundTypes.Text = "Fund Types";
            this.toolStripMenuItemFetchBankFundTypes.Click += new System.EventHandler(this.toolStripMenuItemFetchBankFundTypes_Click);
            // 
            // toolStripMenuItemFetchBankFundValues
            // 
            this.toolStripMenuItemFetchBankFundValues.Name = "toolStripMenuItemFetchBankFundValues";
            this.toolStripMenuItemFetchBankFundValues.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemFetchBankFundValues.Text = "Fund Values";
            this.toolStripMenuItemFetchBankFundValues.Click += new System.EventHandler(this.toolStripMenuItemFetchBankFundValues_Click);
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
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(180, 22);
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
            this.statusStripMain.Location = new System.Drawing.Point(0, 725);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1326, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
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
            this.splitContainerMain.Panel1.Controls.Add(this.panelProfile);
            this.splitContainerMain.Panel1.Controls.Add(this.panelTopSide);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.placeHolder);
            this.splitContainerMain.Size = new System.Drawing.Size(1325, 668);
            this.splitContainerMain.SplitterDistance = 224;
            this.splitContainerMain.TabIndex = 5;
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.tableLayoutPanel1);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProfile.Location = new System.Drawing.Point(0, 442);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(224, 226);
            this.panelProfile.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.32143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.67857F));
            this.tableLayoutPanel1.Controls.Add(this.labelProfileShopsText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileActiveProfile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxUserProfile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileTransactionsText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileItemsText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileTransactionsVal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileItemsVal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileShopsVal, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 226);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelProfileShopsText
            // 
            this.labelProfileShopsText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProfileShopsText.AutoSize = true;
            this.labelProfileShopsText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileShopsText.Location = new System.Drawing.Point(3, 202);
            this.labelProfileShopsText.Name = "labelProfileShopsText";
            this.labelProfileShopsText.Size = new System.Drawing.Size(49, 18);
            this.labelProfileShopsText.TabIndex = 6;
            this.labelProfileShopsText.Text = "Shops:";
            // 
            // labelProfileActiveProfile
            // 
            this.labelProfileActiveProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProfileActiveProfile.AutoSize = true;
            this.labelProfileActiveProfile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileActiveProfile.Location = new System.Drawing.Point(3, 130);
            this.labelProfileActiveProfile.Name = "labelProfileActiveProfile";
            this.labelProfileActiveProfile.Size = new System.Drawing.Size(95, 18);
            this.labelProfileActiveProfile.TabIndex = 2;
            this.labelProfileActiveProfile.Text = "Active Profile:";
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxUserProfile, 2);
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(95, 121);
            this.pictureBoxUserProfile.TabIndex = 1;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // labelProfileTransactionsText
            // 
            this.labelProfileTransactionsText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProfileTransactionsText.AutoSize = true;
            this.labelProfileTransactionsText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileTransactionsText.Location = new System.Drawing.Point(3, 154);
            this.labelProfileTransactionsText.Name = "labelProfileTransactionsText";
            this.labelProfileTransactionsText.Size = new System.Drawing.Size(88, 18);
            this.labelProfileTransactionsText.TabIndex = 4;
            this.labelProfileTransactionsText.Text = "Transactions:";
            // 
            // labelProfileItemsText
            // 
            this.labelProfileItemsText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProfileItemsText.AutoSize = true;
            this.labelProfileItemsText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileItemsText.Location = new System.Drawing.Point(3, 178);
            this.labelProfileItemsText.Name = "labelProfileItemsText";
            this.labelProfileItemsText.Size = new System.Drawing.Size(47, 18);
            this.labelProfileItemsText.TabIndex = 5;
            this.labelProfileItemsText.Text = "Items:";
            // 
            // labelProfileTransactionsVal
            // 
            this.labelProfileTransactionsVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProfileTransactionsVal.AutoSize = true;
            this.labelProfileTransactionsVal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileTransactionsVal.Location = new System.Drawing.Point(109, 154);
            this.labelProfileTransactionsVal.Name = "labelProfileTransactionsVal";
            this.labelProfileTransactionsVal.Size = new System.Drawing.Size(13, 18);
            this.labelProfileTransactionsVal.TabIndex = 7;
            this.labelProfileTransactionsVal.Text = "-";
            // 
            // labelProfileItemsVal
            // 
            this.labelProfileItemsVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProfileItemsVal.AutoSize = true;
            this.labelProfileItemsVal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileItemsVal.Location = new System.Drawing.Point(109, 178);
            this.labelProfileItemsVal.Name = "labelProfileItemsVal";
            this.labelProfileItemsVal.Size = new System.Drawing.Size(54, 18);
            this.labelProfileItemsVal.TabIndex = 8;
            this.labelProfileItemsVal.Text = "Default";
            // 
            // labelProfileShopsVal
            // 
            this.labelProfileShopsVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProfileShopsVal.AutoSize = true;
            this.labelProfileShopsVal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileShopsVal.Location = new System.Drawing.Point(109, 202);
            this.labelProfileShopsVal.Name = "labelProfileShopsVal";
            this.labelProfileShopsVal.Size = new System.Drawing.Size(54, 18);
            this.labelProfileShopsVal.TabIndex = 9;
            this.labelProfileShopsVal.Text = "Default";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(109, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(112, 18);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // panelTopSide
            // 
            this.panelTopSide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopSide.Controls.Add(this.listViewActiveControls);
            this.panelTopSide.Location = new System.Drawing.Point(0, 0);
            this.panelTopSide.Name = "panelTopSide";
            this.panelTopSide.Size = new System.Drawing.Size(224, 439);
            this.panelTopSide.TabIndex = 1;
            // 
            // listViewActiveControls
            // 
            this.listViewActiveControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewActiveControls.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewActiveControls.HideSelection = false;
            this.listViewActiveControls.Location = new System.Drawing.Point(0, 0);
            this.listViewActiveControls.Name = "listViewActiveControls";
            this.listViewActiveControls.Size = new System.Drawing.Size(224, 415);
            this.listViewActiveControls.TabIndex = 0;
            this.listViewActiveControls.UseCompatibleStateImageBehavior = false;
            // 
            // placeHolder
            // 
            this.placeHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placeHolder.AutoScroll = true;
            this.placeHolder.Location = new System.Drawing.Point(0, 0);
            this.placeHolder.Name = "placeHolder";
            this.placeHolder.Size = new System.Drawing.Size(1098, 668);
            this.placeHolder.TabIndex = 0;
            // 
            // toolStripMain
            // 
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1326, 25);
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
            this.labelHorizontalLine1.Size = new System.Drawing.Size(1326, 2);
            this.labelHorizontalLine1.TabIndex = 7;
            // 
            // contextMenuStripTileView
            // 
            this.contextMenuStripTileView.Name = "contextMenuStripTileView";
            this.contextMenuStripTileView.Size = new System.Drawing.Size(61, 4);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBackupSqlite,
            this.toolStripMenuItemBackupCsvFile});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRestoreSqlite,
            this.toolStripMenuItemRestoreCsvFile});
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // toolStripMenuItemBackupCsvFile
            // 
            this.toolStripMenuItemBackupCsvFile.Name = "toolStripMenuItemBackupCsvFile";
            this.toolStripMenuItemBackupCsvFile.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBackupCsvFile.Text = "Csv File...";
            this.toolStripMenuItemBackupCsvFile.Click += new System.EventHandler(this.toolStripMenuItemBackupCsvFile_Click);
            // 
            // toolStripMenuItemBackupSqlite
            // 
            this.toolStripMenuItemBackupSqlite.Name = "toolStripMenuItemBackupSqlite";
            this.toolStripMenuItemBackupSqlite.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBackupSqlite.Text = "Sqlite";
            this.toolStripMenuItemBackupSqlite.Click += new System.EventHandler(this.toolStripMenuItemBackupSqlite_Click);
            // 
            // toolStripMenuItemRestoreSqlite
            // 
            this.toolStripMenuItemRestoreSqlite.Name = "toolStripMenuItemRestoreSqlite";
            this.toolStripMenuItemRestoreSqlite.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemRestoreSqlite.Text = "Sqlite";
            this.toolStripMenuItemRestoreSqlite.Click += new System.EventHandler(this.toolStripMenuItemRestoreSqlite_Click);
            // 
            // toolStripMenuItemRestoreCsvFile
            // 
            this.toolStripMenuItemRestoreCsvFile.Name = "toolStripMenuItemRestoreCsvFile";
            this.toolStripMenuItemRestoreCsvFile.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemRestoreCsvFile.Text = "Csv File...";
            this.toolStripMenuItemRestoreCsvFile.Click += new System.EventHandler(this.toolStripMenuItemRestoreCsvFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 747);
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
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            this.panelTopSide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWindows;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransactions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemItems;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShops;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaymentMethods;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSellers;
        private System.Windows.Forms.StatusStrip statusStripMain;
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
        private System.Windows.Forms.Label labelHorizontalLine1;
        private System.Windows.Forms.Panel panelTopSide;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel placeHolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemApplicationLog;
        private System.Windows.Forms.ListView listViewActiveControls;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTileView;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelProfileActiveProfile;
        private System.Windows.Forms.Label labelProfileTransactionsText;
        private System.Windows.Forms.Label labelProfileItemsText;
        private System.Windows.Forms.Label labelProfileShopsText;
        private System.Windows.Forms.Label labelProfileItemsVal;
        private System.Windows.Forms.Label labelProfileShopsVal;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelProfileTransactionsVal;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBankFunds;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFetchGroupBankFunds;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFetchBankFunds;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFetchBankFundTypes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFetchBankFundValues;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogin;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackupSqlite;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackupCsvFile;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRestoreSqlite;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRestoreCsvFile;
    }
}

