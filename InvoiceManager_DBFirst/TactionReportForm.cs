using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Spire.Xls;

using InvoiceManager_DBFirst.Globals;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace InvoiceManager_DBFirst
{
    public enum TactionReportType
    {
        ItemSubType = 0,
        Item = 1,
        ItemGroup = 2,
        Weekly = 3,
        Monthly = 4
    }

    public partial class TactionReportForm : Form
    {
        private DbSet<Taction> _dbSetTaction;
        private List<Taction> _selectedTactions;
        private DateTime _selectedDate;

        private List<ItemsReport> _items;
        private TactionReportType _reportType;
        private List<string> _comboBoxReportTypeItems;

        private bool _isInitializing;


        public List<Taction> SelectedTactions
        {
            get { return _selectedTactions; }
            set { _selectedTactions = value; }
        }

        public TactionReportType ReportType
        {
            get { return _reportType; }
            set { _reportType = value; }
        }

        public DbSet<Taction> DbSetTaction
        {
            get { return _dbSetTaction; }
            set { _dbSetTaction = value; }
        }

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set { _selectedDate = value; }
        }

        public TactionReportForm()
        {
            InitializeComponent();

            this.dataGridViewTactionReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTactionReport.ReadOnly = true;

            this._items = new List<ItemsReport>();
            this._isInitializing = true;

            this.dataGridViewTactionReport.DataSourceChanged += DataGridViewTactionReport_DataSourceChanged;
        }

        private void TactionReportForm_Load(object sender, EventArgs e)
        {
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewTactionReport);

            this._comboBoxReportTypeItems = new List<string>(new string[] { "Item's Sub Type", "Item", "Item Group", "Report monthly" });
            this.comboBoxReportType.DataSource = _comboBoxReportTypeItems;
        }

        private void DataGridViewTactionReport_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewTactionReport.DataSource == null)
                return;

            string[] headerTexts = new string[] { "itemId", "itemSubTypeId", "itemGroupId", "Group", "Item", "Sub Type", "Count", "Price", "Shops" };
            int[] columnWidths = new int[] { 50, 50, 50, 150, 255, 80, 65, 70, 100 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleLeft };

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewTactionReport, headerTexts, columnWidths, columnAlignments);

            switch (this._reportType)
            {
                case TactionReportType.ItemSubType:
                    this.dataGridViewTactionReport.Columns["ItemName"].Visible = true;
                    this.dataGridViewTactionReport.Columns["ItemSubTypeName"].Visible = true;
                    break;

                case TactionReportType.Item:
                    this.dataGridViewTactionReport.Columns["ItemSubTypeName"].Visible = false;
                    break;

                case TactionReportType.ItemGroup:
                    this.dataGridViewTactionReport.Columns["ItemName"].Visible = false;
                    this.dataGridViewTactionReport.Columns["ItemSubTypeName"].Visible = false;
                    this.dataGridViewTactionReport.Columns["ItemUnit"].Visible = false;
                    break;
            }

            //this.resizeForm();

            this.dataGridViewTactionReport.Columns["itemId"].Visible = false;
            this.dataGridViewTactionReport.Columns["itemSubTypeId"].Visible = false;
            this.dataGridViewTactionReport.Columns["itemGroupId"].Visible = false;
        }

        private void comboBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this._isInitializing) 
                _reportType = (TactionReportType)this.comboBoxReportType.SelectedIndex;

            this._isInitializing = false;
            this._items.Clear();
            this.dataGridViewTactionReport.DataSource = null;
            this.textBoxTotalPrice.Text = string.Empty;

            switch (_reportType)
            {
                case TactionReportType.Item:
                    this.Text = "Report by Item";

                    foreach (Taction taction in this.SelectedTactions)
                    {
                        ItemsReport report = null;
                        foreach (TactionDetails detail in taction.TactionDetails)
                        {
                            // return NULL if _items is empty.
                            report = this._items.Where(r => r.ItemId == detail.ItemId).FirstOrDefault();   // Gruplama kriteri

                            if (report != null)
                            {
                                report.IncreaseItemUnit(detail.Unit);
                                report.IncreaseTotalPricePerItem(this.getTotalPricePerItem(detail));
                            }
                            else
                            {
                                report = new ItemsReport(detail);
                                this._items.Add(report);
                            }

                            report.FormatItemUnit();
                            report.FormatTotalPricePerItem();
                        }
                    }

                    this.resetItemUnit();
                    break;

                case TactionReportType.ItemSubType:
                    this.Text = "Report by Item's Sub Type";

                    foreach (Taction taction in this.SelectedTactions) 
                    {
                        ItemsReport report = null;
                        foreach (TactionDetails detail in taction.TactionDetails)
                        {
                            // return NULL if _items is empty.
                            report = (detail.ItemSubType != null) ? this._items.Where(r => r.ItemId == detail.ItemId && r.ItemSubTypeId == detail.ItemSubTypeId).FirstOrDefault()
                                                                  : this._items.Where(r => r.ItemId == detail.ItemId).FirstOrDefault();   // Gruplama kriteri

                            if (report != null)
                            {
                                report.IncreaseItemUnit(detail.Unit);
                                report.IncreaseTotalPricePerItem(this.getTotalPricePerItem(detail));
                            }
                            else
                            {
                                report = new ItemsReport(detail);
                                this._items.Add(report);
                            }

                            report.FormatItemUnit();
                            report.FormatTotalPricePerItem();
                        }
                    }

                    break;
                case TactionReportType.ItemGroup:
                    this.Text = "Report by Item Group";

                    foreach (Taction taction in this.SelectedTactions)
                    {
                        ItemsReport report = null;
                        foreach (TactionDetails detail in taction.TactionDetails)
                        {
                            // return NULL if _items is empty.
                            report = this._items.Where(r => r.ItemGroupId == detail.Item.GroupId).FirstOrDefault();  // Gruplama kriteri

                            if (report != null)
                            {
                                report.IncreaseItemUnit(detail.Unit);
                                report.IncreaseTotalPricePerItem(this.getTotalPricePerItem(detail));
                            }
                            else
                            {
                                report = new ItemsReport(detail);
                                this._items.Add(report);
                            }

                            report.FormatItemUnit();
                            report.FormatTotalPricePerItem();
                        }
                    }

                    this.resetItemUnit();
                    break;

                case TactionReportType.Weekly:
                    this.Text = "Weekly Taction Report";
                    break;

                case TactionReportType.Monthly:
                    this.Text = "Monthly Taction Report";
                    break;
            }

            if (this._items.Count > 0)
            {
                this.dataGridViewTactionReport.DataSource = this._items.OrderByDescending(r => r.TotalPricePerItem).ToList();
                this.textBoxTotalPrice.Text = System.Math.Round(this._items.Sum(r => r.TotalPricePerItem), 2).ToString();
            }
        }

        private void resetItemUnit()
        {
            // This func is incomplete.

            List<ItemsReport> items = null;
            int id = 0;

            foreach (ItemsReport report in this._items)
            {
                items = this._items.Where(r => r.ItemId == report.ItemId).ToList();
                if (items.Count > 1) 
                    ;

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].ItemSubTypeId != null)
                    {
                        if (id != 0 && items[i].ItemSubTypeId != id)
                            this._items[i].ItemUnit = null;

                        
                        //id = this._items[i].ItemSubTypeId.Value; // What is the purpose of this assignment. Find out it and uncomment the line. (Problem: this._items[i].ItemSubTypeId might return as NULL. A NULL check might or might not be the proper way to fix it.)
                    }
                }

            }

            //for (int i = 0; i < this._items.Count; i++)
            //{
            //    itemId = this._items[i].ItemId;
            //    if (this._items[i].ItemSubTypeId != null)
            //    {
            //        if (subItemId != 0 && this._items[i].ItemId == itemId && this._items[i].ItemSubTypeId != subItemId)
            //            this._items[i].ItemUnit = null;

            //        subItemId = this._items[i].ItemSubTypeId.Value;
            //    }
            //}
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
                                  $"{report.ItemUnit}  " +
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

        private void toolStripMenuItemEmail_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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

        private void resizeForm()
        {
            switch (this._reportType)
            {
                case TactionReportType.ItemSubType:
                    this.Size = new Size(706, 652);
                    this.groupBoxReportType.Size = new Size(660, 46);
                    this.dataGridViewTactionReport.Size = new Size(660, 494);
                    break;
                case TactionReportType.Item:
                    this.Size = new Size(561, 652); // 145
                    this.groupBoxReportType.Size = new Size(515, 46);
                    this.dataGridViewTactionReport.Size = new Size(515, 494);
                    break;
                case TactionReportType.ItemGroup:
                    this.Size = new Size(306, 652);
                    this.groupBoxReportType.Size = new Size(260, 46);
                    this.dataGridViewTactionReport.Size = new Size(260, 494);
                    break;
            }
            
        }

        #region Helper Functions

        private decimal getTotalPricePerItem(TactionDetails detail)
        {
            return (detail.DiscountedPrice != null) ? detail.DiscountedPrice.Value : detail.Unit * detail.UnitPrice;
        }

        

        #endregion


    }
}
