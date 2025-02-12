using Microsoft.Build.Tasks;
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
    public enum TactionReportType
    {
        Selection = 0,
        Daily = 1,
        Weekly = 2,
        Monthly = 3
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

            this._items = new List<ItemsReport>();
            this._isInitializing = true;

            this.dataGridViewTactionReport.DataSourceChanged += DataGridViewTactionReport_DataSourceChanged;
        }

        private void TactionReportForm_Load(object sender, EventArgs e)
        {
            _setDefaultGridViewStyles(this.dataGridViewTactionReport);

            this._comboBoxReportTypeItems = new List<string>(new string[] { "Report selection", "Report daily", "Report weekly", "Report monthly" });
            this.comboBoxReportType.DataSource = _comboBoxReportTypeItems;
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
            if (!this._isInitializing) 
                _reportType = (TactionReportType)this.comboBoxReportType.SelectedIndex;

            this._isInitializing = false;
            this._items.Clear();
            this.dataGridViewTactionReport.DataSource = null;
            this.textBoxTotalPrice.Text = string.Empty;

            switch (_reportType)
            {
                case TactionReportType.Selection:
                    this.Text = "Taction Report by Selection";

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
                case TactionReportType.Daily:
                    this.Text = "Daily Taction Report";
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

    }
}
