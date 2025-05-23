﻿namespace InvoiceManager_DBFirst
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
            this.toolStripMenuItemTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTactionReport = new System.Windows.Forms.DataGridView();
            this.groupBoxReportType = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.labelReportBy = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionReport)).BeginInit();
            this.groupBoxReportType.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(686, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
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
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exportToolStripMenuItem.Text = "Export as...";
            // 
            // toolStripMenuItemTextFile
            // 
            this.toolStripMenuItemTextFile.Name = "toolStripMenuItemTextFile";
            this.toolStripMenuItemTextFile.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItemTextFile.Text = "Text File";
            this.toolStripMenuItemTextFile.Click += new System.EventHandler(this.toolStripMenuItemTextFile_Click);
            // 
            // toolStripMenuItemExcel
            // 
            this.toolStripMenuItemExcel.Name = "toolStripMenuItemExcel";
            this.toolStripMenuItemExcel.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItemExcel.Text = "Excel";
            this.toolStripMenuItemExcel.Click += new System.EventHandler(this.toolStripMenuItemExcel_Click);
            // 
            // toolStripMenuItemEmail
            // 
            this.toolStripMenuItemEmail.Name = "toolStripMenuItemEmail";
            this.toolStripMenuItemEmail.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItemEmail.Text = "E-mail";
            this.toolStripMenuItemEmail.Click += new System.EventHandler(this.toolStripMenuItemEmail_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridViewTactionReport
            // 
            this.dataGridViewTactionReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTactionReport.Location = new System.Drawing.Point(13, 104);
            this.dataGridViewTactionReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewTactionReport.Name = "dataGridViewTactionReport";
            this.dataGridViewTactionReport.Size = new System.Drawing.Size(660, 494);
            this.dataGridViewTactionReport.TabIndex = 2;
            // 
            // groupBoxReportType
            // 
            this.groupBoxReportType.Controls.Add(this.button2);
            this.groupBoxReportType.Controls.Add(this.button1);
            this.groupBoxReportType.Controls.Add(this.textBoxTotalPrice);
            this.groupBoxReportType.Controls.Add(this.labelTotalPrice);
            this.groupBoxReportType.Controls.Add(this.comboBoxReportType);
            this.groupBoxReportType.Controls.Add(this.labelReportBy);
            this.groupBoxReportType.Location = new System.Drawing.Point(13, 52);
            this.groupBoxReportType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxReportType.Name = "groupBoxReportType";
            this.groupBoxReportType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxReportType.Size = new System.Drawing.Size(660, 46);
            this.groupBoxReportType.TabIndex = 3;
            this.groupBoxReportType.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(536, 16);
            this.textBoxTotalPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(116, 23);
            this.textBoxTotalPrice.TabIndex = 5;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(456, 20);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(65, 15);
            this.labelTotalPrice.TabIndex = 4;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Location = new System.Drawing.Point(82, 15);
            this.comboBoxReportType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(238, 23);
            this.comboBoxReportType.TabIndex = 1;
            this.comboBoxReportType.SelectedIndexChanged += new System.EventHandler(this.comboBoxReportType_SelectedIndexChanged);
            // 
            // labelReportBy
            // 
            this.labelReportBy.AutoSize = true;
            this.labelReportBy.Location = new System.Drawing.Point(7, 19);
            this.labelReportBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReportBy.Name = "labelReportBy";
            this.labelReportBy.Size = new System.Drawing.Size(59, 15);
            this.labelReportBy.TabIndex = 0;
            this.labelReportBy.Text = "Report by";
            // 
            // TactionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 609);
            this.Controls.Add(this.groupBoxReportType);
            this.Controls.Add(this.dataGridViewTactionReport);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "TactionReportForm";
            this.Load += new System.EventHandler(this.TactionReportForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionReport)).EndInit();
            this.groupBoxReportType.ResumeLayout(false);
            this.groupBoxReportType.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Label labelReportBy;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}