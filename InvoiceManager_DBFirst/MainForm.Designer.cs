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
            this.toolStripMenuItemSyncWithSQLiteDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShops = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPaymentMethods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSellers = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLiveDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxWithListView = new System.Windows.Forms.GroupBox();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.groupBoxWithListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.windowsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1229, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSync});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "&File";
            // 
            // toolStripMenuItemSync
            // 
            this.toolStripMenuItemSync.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSyncWithSQLiteDatabase});
            this.toolStripMenuItemSync.Name = "toolStripMenuItemSync";
            this.toolStripMenuItemSync.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItemSync.Text = "Sync";
            // 
            // toolStripMenuItemSyncWithSQLiteDatabase
            // 
            this.toolStripMenuItemSyncWithSQLiteDatabase.Name = "toolStripMenuItemSyncWithSQLiteDatabase";
            this.toolStripMenuItemSyncWithSQLiteDatabase.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItemSyncWithSQLiteDatabase.Text = "Sync with SQLite database";
            this.toolStripMenuItemSyncWithSQLiteDatabase.Click += new System.EventHandler(this.toolStripMenuItemSyncWithSQLiteDatabase_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTransactions,
            this.toolStripMenuItemItems,
            this.toolStripMenuItemShops,
            this.toolStripMenuItemPaymentMethods,
            this.toolStripMenuItemUsers,
            this.toolStripMenuItemSellers});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // toolStripMenuItemTransactions
            // 
            this.toolStripMenuItemTransactions.Name = "toolStripMenuItemTransactions";
            this.toolStripMenuItemTransactions.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemTransactions.Text = "Transactions";
            this.toolStripMenuItemTransactions.Click += new System.EventHandler(this.toolStripMenuItemTransactions_Click);
            // 
            // toolStripMenuItemItems
            // 
            this.toolStripMenuItemItems.Name = "toolStripMenuItemItems";
            this.toolStripMenuItemItems.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemItems.Text = "Items";
            this.toolStripMenuItemItems.Click += new System.EventHandler(this.toolStripMenuItem_Items_Click);
            // 
            // toolStripMenuItemShops
            // 
            this.toolStripMenuItemShops.Name = "toolStripMenuItemShops";
            this.toolStripMenuItemShops.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemShops.Text = "Shops";
            this.toolStripMenuItemShops.Click += new System.EventHandler(this.toolStripMenuItemShops_Click);
            // 
            // toolStripMenuItemPaymentMethods
            // 
            this.toolStripMenuItemPaymentMethods.Name = "toolStripMenuItemPaymentMethods";
            this.toolStripMenuItemPaymentMethods.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemPaymentMethods.Text = "Payment Methods";
            this.toolStripMenuItemPaymentMethods.Click += new System.EventHandler(this.toolStripMenuItemPaymentMethods_Click);
            // 
            // toolStripMenuItemUsers
            // 
            this.toolStripMenuItemUsers.Name = "toolStripMenuItemUsers";
            this.toolStripMenuItemUsers.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemUsers.Text = "Users";
            this.toolStripMenuItemUsers.Click += new System.EventHandler(this.toolStripMenuItemUsers_Click);
            // 
            // toolStripMenuItemSellers
            // 
            this.toolStripMenuItemSellers.Name = "toolStripMenuItemSellers";
            this.toolStripMenuItemSellers.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemSellers.Text = "Sellers";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLiveDateTime});
            this.statusStripMain.Location = new System.Drawing.Point(0, 668);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1229, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLiveDateTime
            // 
            this.toolStripStatusLabelLiveDateTime.Name = "toolStripStatusLabelLiveDateTime";
            this.toolStripStatusLabelLiveDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBoxWithListView
            // 
            this.groupBoxWithListView.Controls.Add(this.listViewLog);
            this.groupBoxWithListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWithListView.Location = new System.Drawing.Point(0, 0);
            this.groupBoxWithListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxWithListView.Name = "groupBoxWithListView";
            this.groupBoxWithListView.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxWithListView.Size = new System.Drawing.Size(1033, 644);
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
            this.listViewLog.Size = new System.Drawing.Size(1025, 622);
            this.listViewLog.TabIndex = 0;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.groupBoxWithListView);
            this.splitContainerMain.Size = new System.Drawing.Size(1229, 644);
            this.splitContainerMain.SplitterDistance = 192;
            this.splitContainerMain.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 690);
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
            this.groupBoxWithListView.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransactions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemItems;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSync;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSyncWithSQLiteDatabase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShops;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaymentMethods;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSellers;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLiveDateTime;
        private System.Windows.Forms.GroupBox groupBoxWithListView;
        private System.Windows.Forms.ListView listViewLog;
        private System.Windows.Forms.SplitContainer splitContainerMain;
    }
}

