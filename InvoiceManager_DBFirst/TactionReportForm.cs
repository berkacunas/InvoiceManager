﻿using Microsoft.Build.Tasks;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;
using Microsoft.Build.Framework.XamlTypes;


namespace InvoiceManager_DBFirst
{
    

    public partial class TactionReportForm : Form
    {
        enum ReportType
        {
            ItemCount = 0,
            Shop = 1
        }

        private List<Taction> _selectedTactions;
        List<ItemsReport> _items;

        private List<KeyValuePair<ReportType, string>> _reportTypes;

        public List<Taction> SelectedTactions
        {
            get { return _selectedTactions; }
            set { _selectedTactions = value; }
        }

        public TactionReportForm()
        {
            InitializeComponent();

            this.dataGridViewTactionReport.DataSourceChanged += DataGridViewTactionReport_DataSourceChanged;

            this._items = new List<ItemsReport>();
            this._reportTypes = new List<KeyValuePair<ReportType, string>>() { new KeyValuePair<ReportType, string>(ReportType.ItemCount, "Report by item count"),
                                                                               new KeyValuePair<ReportType, string>(ReportType.Shop, "Report by shop") };
        }

        private void TactionReportForm_Load(object sender, EventArgs e)
        {
            _setDefaultGridViewStyles(this.dataGridViewTactionReport);

            this.comboBoxReportType.ValueMember = "Key";
            this.comboBoxReportType.DisplayMember = "Value";
            this.comboBoxReportType.DataSource = this._reportTypes;
            
        }

        private void DataGridViewTactionReport_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewTactionReport.DataSource == null)
                return;

            string[] headerTexts = new string[] { "itemId", "Group", "Item", "Count", "Price per Item", "Shops" };
            int[] columnWidths = new int[] { 50, 150, 255, 65, 110, 100 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleLeft };

            _setDefaultGridViewHeaderStyles(this.dataGridViewTactionReport, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewTactionReport.Columns["ItemId"].Visible = false;
        }

        private void comboBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._items.Clear();

            KeyValuePair<ReportType, string> item = (KeyValuePair<ReportType, string>)this.comboBoxReportType.SelectedItem;

            switch (item.Key)
            {
                case ReportType.ItemCount:

                    foreach (Taction taction in this.SelectedTactions) 
                    {
                        ItemsReport report = null;
                        foreach (TactionDetails detail in taction.TactionDetails)
                        {
                            report = this._items.Where(r => r.ItemId == detail.ItemId).FirstOrDefault();
                            if (report != null)
                            {
                                report.ItemCount += detail.Unit;
                                report.TotalPricePerItem += (detail.DiscountedPrice != null) ? detail.DiscountedPrice.Value : detail.Unit * detail.UnitPrice;
                            }
                            else
                            {
                                report = new ItemsReport();
                                report.ItemId = detail.ItemId;
                                report.ItemGroupName = detail.Item.ItemGroup.Name;
                                report.ItemName = detail.Item.Name;
                                report.ItemCount = detail.Unit;
                                report.TotalPricePerItem = (detail.DiscountedPrice != null) ? detail.DiscountedPrice.Value : detail.Unit * detail.UnitPrice;
                                this._items.Add(report);
                            }

                            if (MayaMath.isInteger(report.ItemCount))
                                report.ItemCount = System.Math.Round(report.ItemCount);

                            report.TotalPricePerItem = System.Math.Round(report.TotalPricePerItem, 2);
                        }
                    }

                    break;
                case ReportType.Shop:



                    break;
            }

            if (this._items.Count > 0)
            {
                this.dataGridViewTactionReport.DataSource = this._items.OrderByDescending(r => r.TotalPricePerItem).ToList();
                this.textBoxTotalPrice.Text = System.Math.Round(this._items.Sum(r => r.TotalPricePerItem), 2).ToString();
            }
        }

        private void toolStripMenuItemTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Documents (*.txt)|  *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        return;
                    }
                }

                StringBuilder builder = new StringBuilder();

                foreach (ItemsReport report in this._items)
                {
                    string item = $"{report.ItemGroupName}  " +
                                  $"{report.ItemName}  " +
                                  $"{report.ItemCount}  " +
                                  $"Item Total: {report.TotalPricePerItem} TL\n";

                    builder.Append(item);
                }

                string totalPrice = $"Total Price: {this._items.Sum(r => r.TotalPricePerItem)}\n";
                builder.Append(totalPrice);

                string reportText = builder.ToString();

                using (StreamWriter outputFile = new StreamWriter(sfd.FileName))
                    outputFile.WriteLine(reportText);
            }
        }

        
        private void toolStripMenuItemExcel_Click(object sender, EventArgs e)
        {
            IList<ItemsReport> itemsList = (IList<ItemsReport>)this.dataGridViewTactionReport.DataSource;
            //BindingSource bindingSource = (BindingSource)this.dataGridViewTactionReport.DataSource;
            DataTable dataTable = (DataTable)this.dataGridViewTactionReport.DataSource;

            this.writeExcel(dataTable);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel (.xlsx)|  *.xlsx";
            sfd.FileName = "Output.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        return;
                    }
                }

                


                
            }
               

            //...
        }

        private void writeExcel(DataTable dataTable)
        {
            Workbook workbook = new Workbook();

            // Remove default worksheets
            workbook.Worksheets.Clear();

            // Add a worksheet and name it
            Worksheet worksheet = workbook.Worksheets.Add("InsertDataTable");

            // Write datatable to the worksheet
            worksheet.InsertDataTable(dataTable, true, 1, 1, true);

            // Save to an Excel file
            workbook.SaveToFile("InsertDataTable.xlsx", ExcelVersion.Version2016);

            // Dispose resources
            workbook.Dispose();
        }

        private void toolStripMenuItemEmail_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private static void _setDefaultGridViewStyles(DataGridView gridview)
        {
            gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridview.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);

            gridview.DefaultCellStyle.Font = new Font("Calibri", 10);
            gridview.DefaultCellStyle.ForeColor = Color.FromArgb(7, 7, 7); //  152, g: 255, b: 152
            gridview.DefaultCellStyle.BackColor = Color.White;

            gridview.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(7, 7, 7);
            gridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            gridview.DefaultCellStyle.SelectionForeColor = Color.FromArgb(7, 7, 7);
            gridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(163, 255, 179);

            gridview.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.5f, FontStyle.Bold);
            gridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private static void _setDefaultGridViewHeaderStyles(DataGridView gridview, string[] headerTexts, int[] columnWidths, DataGridViewContentAlignment[] columnAlignments)
        {
            for (int i = 0; i < gridview.Columns.Count; ++i)
            {
                gridview.Columns[i].HeaderCell.Value = headerTexts[i];
                gridview.Columns[i].Width = columnWidths[i];
                gridview.Columns[i].DefaultCellStyle.Alignment = columnAlignments[i];
            }
        }

        
    }
}
