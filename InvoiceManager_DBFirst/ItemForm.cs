using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    public partial class ItemForm : Form
    {
        private enum SortOrder
        {
            ASC,
            DESC,
            UNORDERED
        }

        private InvoicesEntities dbContext;

        private SortOrder[] _sortOrdersDataGridViewItemGroups = { SortOrder.ASC, SortOrder.UNORDERED };
        private SortOrder[] _sortOrdersDataGridViewItems = { SortOrder.ASC, SortOrder.UNORDERED };
        

        public ItemForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.Item.GetHicon());

            this.dbContext = new InvoicesEntities();

            this.dataGridViewItemGroups.DataSourceChanged += DataGridViewItemGroups_DataSourceChanged;
            this.dataGridViewItems.DataSourceChanged += DataGridViewItems_DataSourceChanged;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            _setDefaultGridViewStyles(this.dataGridViewItemGroups);
            _setDefaultGridViewStyles(this.dataGridViewItems);

            this._bindDataToGridViewItemGroup();
            this._bindDataToGridViewItem();

            //this.dataGridViewItems.Columns["Item"].SortMode = DataGridViewColumnSortMode.Programmatic;
            //this.dataGridViewItems.Columns["Group"].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void DataGridViewItemGroups_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewItemGroups.DataSource == null)
                return;

            string[] tactionsHeaderTexts = new string[] { "itemGroupId", "itemTopGroupId", "Group", "Top Group" };
            int[] tactionsColumnWidths = new int[] { 50, 50, 150, 150 };
            DataGridViewContentAlignment[] tactionsColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft };

            _setDefaultGridViewHeaderStyles(this.dataGridViewItemGroups, tactionsHeaderTexts, tactionsColumnWidths, tactionsColumnAlignments);

            this.dataGridViewItemGroups.Columns["itemGroupId"].Visible = false;
            this.dataGridViewItemGroups.Columns["itemTopGroupId"].Visible = false;
        }

        private void DataGridViewItems_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewItems.DataSource == null)
                return;

            string[] tactionsHeaderTexts = new string[] { "itemId", "groupId", "Item", "Group", "Note" };
            int[] tactionsColumnWidths = new int[] { 50, 50, 280, 160, 120 };
            DataGridViewContentAlignment[] tactionsColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft };

            _setDefaultGridViewHeaderStyles(this.dataGridViewItems, tactionsHeaderTexts, tactionsColumnWidths, tactionsColumnAlignments);

            this.dataGridViewItems.Columns["itemId"].Visible = false;
            this.dataGridViewItems.Columns["itemGroupId"].Visible = false;
        }

        private void dataGridViewItemGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearItemGroupControls();

            DataGridViewRow row = this.dataGridViewItemGroups.CurrentRow;
            int groupId = Convert.ToInt32(row.Cells["itemGroupId"].Value);

            if (row.Cells["itemTopGroupName"].Value != null)
                this.textBoxGroupOptionsTopGroup.Text = row.Cells["itemTopGroupName"].Value.ToString();

            this.textBoxGroupOptionsGroup.Text = row.Cells["itemGroupName"].Value.ToString();
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearItemControls();

            DataGridViewRow row = this.dataGridViewItems.CurrentRow;
            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);

            this.comboBoxItemOptionsGroup.Text = row.Cells["itemGroupName"].Value.ToString();
            this.textBoxItemOptionsItem.Text = row.Cells["itemName"].Value.ToString();

            if (row.Cells["itemNote"].Value != null)
                this.textBoxItemOptionsNote.Text = row.Cells["itemNote"].Value.ToString();
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
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

        private void _bindDataToGridViewItemGroup()
        {
            var query = from itemGroup in dbContext.ItemGroup
                        join itemTopGroup in dbContext.ItemTopGroup on itemGroup.TopGroupId equals itemTopGroup.id into itemTopGroupJoinTable
                        from itg in itemTopGroupJoinTable.DefaultIfEmpty()
                        orderby itemGroup.Name ascending
                        select new
                        {
                            itemGroupId = itemGroup.id,
                            itemTopGroupId = (itg != null) ? itg.id : 0,
                            itemGroupName = itemGroup.Name,
                            itemTopGroupName = itg.Name
                        };

            this.dataGridViewItemGroups.DataSource = query.ToList();
        }

        private void _bindDataToGridViewItem()
        {
            var query = from item in dbContext.Item
                        join itemGroup in dbContext.ItemGroup on item.GroupId equals itemGroup.id
                        orderby item.Name ascending
                        select new
                        {
                            itemId = item.id,
                            itemGroupId = itemGroup.id,
                            itemName = item.Name,
                            itemGroupName = itemGroup.Name,
                            itemNote = item.Note
                        };

            this.dataGridViewItems.DataSource = query.ToList();
        }

        private void _clearItemGroupControls()
        {
            foreach (Control c in this.groupBoxItemGroupOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _clearItemControls()
        {
            foreach (Control c in this.groupBoxItemOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();

            foreach (Control c in this.groupBoxItemOptions.Controls)
                if (c is ComboBox)
                    ((ComboBox)c).Text = string.Empty;
        }

        private void dataGridViewItems_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewItems.Columns[e.ColumnIndex].HeaderText;

            var query = dbContext.Item.Join(dbContext.ItemGroup,
                        item => item.GroupId, itemGroup => itemGroup.id,
                        (item, itemGroup) =>
                        new
                        {
                            itemId = item.id,
                            itemGroupId = itemGroup.id,
                            itemName = item.Name,
                            itemGroupName = itemGroup.Name,
                            itemNote = item.Note
                        });

            switch (columnName)
            {
                case "Item":
                    this.dataGridViewItems.DataSource = (this._sortOrdersDataGridViewItems[0] == SortOrder.ASC) ? query.OrderBy(r => r.itemName).ToList() : query.OrderByDescending(r => r.itemName).ToList();
                    this._sortOrdersDataGridViewItems[0] = (this._sortOrdersDataGridViewItems[0] == SortOrder.ASC) ? SortOrder.DESC : SortOrder.ASC;
                    break;
                
                case "Group":
                    this.dataGridViewItems.DataSource = (this._sortOrdersDataGridViewItems[1] == SortOrder.ASC) ? query.OrderBy(r => r.itemGroupName).ToList() : query.OrderByDescending(r => r.itemGroupName).ToList();
                    this._sortOrdersDataGridViewItems[1] = (this._sortOrdersDataGridViewItems[1] == SortOrder.ASC) ? SortOrder.DESC : SortOrder.ASC;
                    break;
            }
        }

        private void dataGridViewItemGroups_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewItemGroups.Columns[e.ColumnIndex].HeaderText;

            var query = dbContext.ItemGroup.Join(dbContext.ItemTopGroup,
                        itemGroup => itemGroup.TopGroupId, itemTopGroup => itemTopGroup.id, 
                        (itemGroup, itemTopGroup) => 
                        new
                        {
                            itemGroupId = itemGroup.id,
                            itemTopGroupId = itemTopGroup.id,
                            itemGroupName = itemGroup.Name,
                            itemTopGroupName = itemTopGroup.Name
                        });

            switch (columnName)
            {
                case "Group":
                    this.dataGridViewItemGroups.DataSource = (this._sortOrdersDataGridViewItemGroups[0] == SortOrder.ASC) ? query.OrderBy(r => r.itemGroupName).ToList() : query.OrderByDescending(r => r.itemGroupName).ToList();
                    this._sortOrdersDataGridViewItemGroups[0] = (this._sortOrdersDataGridViewItemGroups[0] == SortOrder.ASC) ? SortOrder.DESC : SortOrder.ASC;
                    break;
                case "Top Group":
                    this.dataGridViewItemGroups.DataSource = (this._sortOrdersDataGridViewItemGroups[1] == SortOrder.ASC) ? query.OrderBy(r => r.itemTopGroupName).ToList() : query.OrderByDescending(r => r.itemTopGroupName).ToList();
                    this._sortOrdersDataGridViewItemGroups[1] = (this._sortOrdersDataGridViewItemGroups[1] == SortOrder.ASC) ? SortOrder.DESC : SortOrder.ASC;
                    break;
            }
        }
    }
}
