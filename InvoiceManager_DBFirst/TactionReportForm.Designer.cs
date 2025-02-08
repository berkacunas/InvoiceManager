namespace InvoiceManager_DBFirst
{
    partial class TactionReportForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTactionReport = new System.Windows.Forms.DataGridView();
            this.groupBoxReportType = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.labelReportBy = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionReport)).BeginInit();
            this.groupBoxReportType.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTextFile,
            this.toolStripMenuItemExcel,
            this.toolStripMenuItemEmail});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export as...";
            // 
            // toolStripMenuItemExcel
            // 
            this.toolStripMenuItemExcel.Name = "toolStripMenuItemExcel";
            this.toolStripMenuItemExcel.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemExcel.Text = "Excel";
            this.toolStripMenuItemExcel.Click += new System.EventHandler(this.toolStripMenuItemExcel_Click);
            // 
            // toolStripMenuItemTextFile
            // 
            this.toolStripMenuItemTextFile.Name = "toolStripMenuItemTextFile";
            this.toolStripMenuItemTextFile.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemTextFile.Text = "Text File";
            this.toolStripMenuItemTextFile.Click += new System.EventHandler(this.toolStripMenuItemTextFile_Click);
            // 
            // toolStripMenuItemEmail
            // 
            this.toolStripMenuItemEmail.Name = "toolStripMenuItemEmail";
            this.toolStripMenuItemEmail.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEmail.Text = "E-mail";
            this.toolStripMenuItemEmail.Click += new System.EventHandler(this.toolStripMenuItemEmail_Click);
            // 
            // dataGridViewTactionReport
            // 
            this.dataGridViewTactionReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTactionReport.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewTactionReport.Name = "dataGridViewTactionReport";
            this.dataGridViewTactionReport.Size = new System.Drawing.Size(606, 461);
            this.dataGridViewTactionReport.TabIndex = 2;
            // 
            // groupBoxReportType
            // 
            this.groupBoxReportType.Controls.Add(this.buttonClear);
            this.groupBoxReportType.Controls.Add(this.buttonReport);
            this.groupBoxReportType.Controls.Add(this.comboBoxReportType);
            this.groupBoxReportType.Controls.Add(this.labelReportBy);
            this.groupBoxReportType.Location = new System.Drawing.Point(12, 46);
            this.groupBoxReportType.Name = "groupBoxReportType";
            this.groupBoxReportType.Size = new System.Drawing.Size(606, 42);
            this.groupBoxReportType.TabIndex = 3;
            this.groupBoxReportType.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(525, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 24);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(444, 12);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 24);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Location = new System.Drawing.Point(70, 13);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(321, 22);
            this.comboBoxReportType.TabIndex = 1;
            this.comboBoxReportType.SelectedIndexChanged += new System.EventHandler(this.comboBoxReportType_SelectedIndexChanged);
            // 
            // labelReportBy
            // 
            this.labelReportBy.AutoSize = true;
            this.labelReportBy.Location = new System.Drawing.Point(6, 17);
            this.labelReportBy.Name = "labelReportBy";
            this.labelReportBy.Size = new System.Drawing.Size(58, 14);
            this.labelReportBy.TabIndex = 0;
            this.labelReportBy.Text = "Report by";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.textBoxTotalPrice);
            this.groupBoxDetails.Controls.Add(this.labelTotalPrice);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 560);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(606, 41);
            this.groupBoxDetails.TabIndex = 4;
            this.groupBoxDetails.TabStop = false;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(429, 17);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(63, 14);
            this.labelTotalPrice.TabIndex = 4;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(498, 13);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotalPrice.TabIndex = 5;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TactionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 608);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxReportType);
            this.Controls.Add(this.dataGridViewTactionReport);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TactionReportForm";
            this.Text = "TactionReportForm";
            this.Load += new System.EventHandler(this.TactionReportForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionReport)).EndInit();
            this.groupBoxReportType.ResumeLayout(false);
            this.groupBoxReportType.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExcel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTextFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEmail;
        private System.Windows.Forms.DataGridView dataGridViewTactionReport;
        private System.Windows.Forms.GroupBox groupBoxReportType;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Label labelReportBy;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}