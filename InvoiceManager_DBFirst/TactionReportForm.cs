using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this._reportTypes = new List<KeyValuePair<ReportType, string>>() { new KeyValuePair<ReportType, string>(ReportType.ItemCount, "Report by item count"),
                                                                               new KeyValuePair<ReportType, string>(ReportType.Shop, "Report by shop") };
        }

        private void TactionReportForm_Load(object sender, EventArgs e)
        {
            _setDefaultGridViewStyles(this.dataGridViewTactionReport);

            this.comboBoxReportType.DataSource = this._reportTypes;
            this.comboBoxReportType.ValueMember = "Key";
            this.comboBoxReportType.DisplayMember = "Value";
        }

        private void DataGridViewTactionReport_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewTactionReport.DataSource == null)
                return;

            string[] headerTexts = new string[] { "itemId", "Group", "Item", "Count", "Price per Item", "Purchased on", "Shops" };
            int[] columnWidths = new int[] { 50, 150, 200, 80, 150, 100, 120 };
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
            KeyValuePair<ReportType, string> item = (KeyValuePair<ReportType, string>)this.comboBoxReportType.SelectedItem;

            List<ItemsReport> items = new List<ItemsReport>();

            switch (item.Key)
            {
                case ReportType.ItemCount:

                    foreach (Taction taction in this.SelectedTactions) 
                    {
                        ItemsReport report = null;
                        foreach (TactionDetails detail in taction.TactionDetails)
                        {
                            report = items.Where(r => r.ItemId == detail.ItemId).FirstOrDefault();
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
                                items.Add(report);
                            }
                        }
                    }
                    
                    this.dataGridViewTactionReport.DataSource = items;
                    break;
                case ReportType.Shop:

                    break;
            }

            this.textBoxTotalPrice.Text = items.Sum(r => r.TotalPricePerItem).ToString();
        }

        private void toolStripMenuItemTextFile_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemExcel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemEmail_Click(object sender, EventArgs e)
        {

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
