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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelBottomSide = new System.Windows.Forms.Panel();
            this.panelLoginInfo = new System.Windows.Forms.Panel();
            this.panelTopSide = new System.Windows.Forms.Panel();
            this.listViewActiveControls = new System.Windows.Forms.ListView();
            this.placeHolder = new System.Windows.Forms.Panel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.labelHorizontalLine1 = new System.Windows.Forms.Label();
            this.contextMenuStripTileView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBoxUserLoginDetails = new System.Windows.Forms.PictureBox();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelBottomSide.SuspendLayout();
            this.panelLoginInfo.SuspendLayout();
            this.panelTopSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserLoginDetails)).BeginInit();
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
            this.menuStripMain.Size = new System.Drawing.Size(1326, 24);
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
            this.splitContainerMain.Panel1.Controls.Add(this.panelBottomSide);
            this.splitContainerMain.Panel1.Controls.Add(this.panelTopSide);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.placeHolder);
            this.splitContainerMain.Size = new System.Drawing.Size(1325, 668);
            this.splitContainerMain.SplitterDistance = 167;
            this.splitContainerMain.TabIndex = 5;
            // 
            // panelBottomSide
            // 
            this.panelBottomSide.Controls.Add(this.panelLoginInfo);
            this.panelBottomSide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomSide.Location = new System.Drawing.Point(0, 442);
            this.panelBottomSide.Name = "panelBottomSide";
            this.panelBottomSide.Size = new System.Drawing.Size(167, 226);
            this.panelBottomSide.TabIndex = 2;
            // 
            // panelLoginInfo
            // 
            this.panelLoginInfo.Controls.Add(this.pictureBoxUserLoginDetails);
            this.panelLoginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginInfo.Location = new System.Drawing.Point(0, 0);
            this.panelLoginInfo.Name = "panelLoginInfo";
            this.panelLoginInfo.Size = new System.Drawing.Size(167, 226);
            this.panelLoginInfo.TabIndex = 0;
            // 
            // panelTopSide
            // 
            this.panelTopSide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopSide.Controls.Add(this.listViewActiveControls);
            this.panelTopSide.Location = new System.Drawing.Point(0, 0);
            this.panelTopSide.Name = "panelTopSide";
            this.panelTopSide.Size = new System.Drawing.Size(165, 436);
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
            this.listViewActiveControls.Size = new System.Drawing.Size(165, 436);
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
            this.placeHolder.Size = new System.Drawing.Size(1155, 668);
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
            // pictureBoxUserLoginDetails
            // 
            this.pictureBoxUserLoginDetails.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxUserLoginDetails.Name = "pictureBoxUserLoginDetails";
            this.pictureBoxUserLoginDetails.Size = new System.Drawing.Size(69, 84);
            this.pictureBoxUserLoginDetails.TabIndex = 0;
            this.pictureBoxUserLoginDetails.TabStop = false;
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
            this.panelBottomSide.ResumeLayout(false);
            this.panelLoginInfo.ResumeLayout(false);
            this.panelTopSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserLoginDetails)).EndInit();
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
        private System.Windows.Forms.Panel panelBottomSide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBatch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBatchItemSubTypes;
        private System.Windows.Forms.Panel placeHolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemApplicationLog;
        private System.Windows.Forms.ListView listViewActiveControls;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTileView;
        private System.Windows.Forms.Panel panelLoginInfo;
        private System.Windows.Forms.PictureBox pictureBoxUserLoginDetails;
    }
}

