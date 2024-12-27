using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    public partial class ItemForm : Form
    {
        enum Mode
        {
            Display,
            Add,
            Edit,
            Search
        }

        private enum SortOrder
        {
            ASC,
            DESC,
            UNORDERED
        }

        private InvoicesEntities dbContext;

        private Item _newItem;
        private ItemGroup _newItemGroup;
        private ItemTopGroup _newItemTopGroup;

        private Mode _itemMode;
        private Mode _groupMode;
        private Mode _topGroupMode;

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
            this._setModes(Mode.Display);

            _setDefaultGridViewStyles(this.dataGridViewItemGroups);
            _setDefaultGridViewStyles(this.dataGridViewItems);

            _enableDataGridViewMultiSelect(this.dataGridViewItemGroups, false);
            _enableDataGridViewMultiSelect(this.dataGridViewItems, false);

            this._setEditableItems(false);
            this._setEditableItemGroups(false);
            this._setEditableItemTopGroups(false);

            this.comboBoxItemOptionsGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxGroupOptionsTopGroup.DropDownStyle = ComboBoxStyle.DropDownList;

            this._bindDataToGridViewItemGroup();
            this._bindDataToGridViewItem();
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
            int topGroupId = Convert.ToInt32(row.Cells["itemTopGroupId"].Value);

            this._bindDataToComboBoxTopGroupOptionsTopGroup(topGroupId);
            this._bindDataToComboBoxGroupOptionsTopGroup(topGroupId);

            this.textBoxGroupOptionsGroup.Text = row.Cells["itemGroupName"].Value.ToString();
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearItemControls();

            DataGridViewRow row = this.dataGridViewItems.CurrentRow;
            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);
            int groupId = Convert.ToInt32(row.Cells["itemGroupId"].Value);

            this._bindDataToComboBoxItemOptionsGroup(groupId);
            this.textBoxItemOptionsItem.Text = row.Cells["itemName"].Value.ToString();

            if (row.Cells["itemNote"].Value != null)
                this.textBoxItemOptionsNote.Text = row.Cells["itemNote"].Value.ToString();
        }

        private void buttonNewItem_Click(object sender, EventArgs e)
        {
            this._itemMode = (this._itemMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewItem.Text = (this._itemMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewItems.Enabled = (this._itemMode != Mode.Add);

            if (this._itemMode == Mode.Add)
            {
                this._bindDataToComboBoxItemOptionsGroup(0);
                this._setEditableItems(true);
                this._newItem = new Item();
            }
            else
            {
                this._bindDataToComboBoxItemOptionsGroup(-1);
                this._setEditableItems(false);
            }

            this._clearItemControls();
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
            this._setItemDataFromUiToObject(this._newItem);
            this.dbContext.Item.Add(this._newItem);

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearItemControls();
            this._setEditableItems(false);
            this._bindDataToGridViewItem();
            this._newItem = new Item();
            this._itemMode = Mode.Display;
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewGroup_Click(object sender, EventArgs e)
        {
            this._groupMode = (this._groupMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewGroup.Text = (this._groupMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewItemGroups.Enabled = (this._groupMode != Mode.Add);

            if (this._groupMode == Mode.Add)
            {
                this._bindDataToComboBoxGroupOptionsTopGroup(0);
                this._setEditableItemGroups(true);
                this._newItemGroup = new ItemGroup();
            }
            else
            {
                this._bindDataToComboBoxGroupOptionsTopGroup(-1);
                this._setEditableItemGroups(false);
            }

            this._clearItemGroupControls();
        }

        private void buttonSaveGroup_Click(object sender, EventArgs e)
        {
            this._setItemGroupDataFromUiToObject(this._newItemGroup);
            this.dbContext.ItemGroup.Add(this._newItemGroup);

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearItemGroupControls();
            this._setEditableItemGroups(false);
            this._bindDataToGridViewItemGroup();
            this._newItemGroup = new ItemGroup();
            this._groupMode = Mode.Display;
        }

        private void buttonUpdateGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewTopGroup_Click(object sender, EventArgs e)
        {
            this._topGroupMode = (this._topGroupMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewTopGroup.Text = (this._topGroupMode == Mode.Add) ? "Cancel" : "New";

            if (this._topGroupMode == Mode.Add)
            {
                this._setEditableItemTopGroups(true);
                this._newItemTopGroup = new ItemTopGroup();
            }
            else
                this._setEditableItemTopGroups(false);

            this._clearItemTopGroupControls();
        }

        private void buttonSaveTopGroup_Click(object sender, EventArgs e)
        {
            this._setItemTopGroupDataFromUiToObject(this._newItemTopGroup);
            this.dbContext.ItemTopGroup.Add(this._newItemTopGroup);

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item top group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearItemTopGroupControls();
            this._setEditableItemTopGroups(false);
            this._newItemTopGroup = new ItemTopGroup();
            this._topGroupMode = Mode.Display;
        }

        private void buttonUpdateTopGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteTopGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void _setItemDataFromUiToObject(Item item)
        {
            if (string.IsNullOrEmpty(this.textBoxItemOptionsItem.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter item.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxItemOptionsGroup.SelectedItem == null)
            {
                MessageBox.Show("Missing value.", "You didn't select item group.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            item.GroupId = ((ItemGroup)this.comboBoxItemOptionsGroup.SelectedItem).id;
            item.Name = this.textBoxItemOptionsItem.Text;
            item.Note = this.textBoxItemOptionsNote.Text;
        }

        private void _setItemGroupDataFromUiToObject(ItemGroup itemGroup)
        {
            if (string.IsNullOrEmpty(this.textBoxGroupOptionsGroup.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter item group.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxGroupOptionsTopGroup.SelectedItem == null)
            {
                MessageBox.Show("Missing value.", "You didn't select item top group.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            itemGroup.TopGroupId = ((ItemTopGroup)this.comboBoxGroupOptionsTopGroup.SelectedItem).id;
            itemGroup.Name = this.textBoxGroupOptionsGroup.Text;
        }

        private void _setItemTopGroupDataFromUiToObject(ItemTopGroup itemTopGroup)
        {
            if (this.comboBoxTopGroupOptionsTopGroup.SelectedItem == null)
            {
                MessageBox.Show("Missing value.", "You didn't select item top group.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            itemTopGroup.Name = ((ItemTopGroup)this.comboBoxTopGroupOptionsTopGroup.SelectedItem).Name;
        }

        public static void _enableDataGridViewMultiSelect(DataGridView gridview, bool enable)
        {
            gridview.MultiSelect = enable;
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
                            itemTopGroupId = itg.id,
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

        private void _bindDataToComboBoxItemOptionsGroup(int groupId)   // set groupId to 0 to fetch all data from db.
        {
            IQueryable<ItemGroup> query = null;

            if (groupId == 0)
                query = from itemGroup in dbContext.ItemGroup orderby itemGroup.Name ascending select itemGroup;
            else if (groupId > 0)
                query = from itemGroup in dbContext.ItemGroup where itemGroup.id == groupId select itemGroup;
            else if (groupId == -1)
            {
                this.comboBoxItemOptionsGroup.DataSource = null;
                return;
            }

            this.comboBoxItemOptionsGroup.DataSource = query.ToList();
            this.comboBoxItemOptionsGroup.DisplayMember = "Name";
            this.comboBoxItemOptionsGroup.ValueMember = "id";
        }

        private void _bindDataToComboBoxGroupOptionsTopGroup(int topGroupId)
        {
            IQueryable<ItemTopGroup> query = null;

            if (topGroupId == 0)
                query = from itemTopGroup in dbContext.ItemTopGroup orderby itemTopGroup.Name ascending select itemTopGroup;
            else if (topGroupId > 0)
                query = from itemTopGroup in dbContext.ItemTopGroup where itemTopGroup.id == topGroupId select itemTopGroup;
            else if (topGroupId == -1)
            {
                this.comboBoxGroupOptionsTopGroup.DataSource = null;
                return;
            }

            this.comboBoxGroupOptionsTopGroup.DataSource = query.ToList();
            this.comboBoxGroupOptionsTopGroup.DisplayMember = "Name";
            this.comboBoxGroupOptionsTopGroup.ValueMember = "id";
        }

        private void _bindDataToComboBoxTopGroupOptionsTopGroup(int topGroupId)
        {
            var query = from itemTopGroup in dbContext.ItemTopGroup where itemTopGroup.id == topGroupId select itemTopGroup;

            this.comboBoxTopGroupOptionsTopGroup.DataSource = query.ToList();
            this.comboBoxTopGroupOptionsTopGroup.DisplayMember = "Name";
            this.comboBoxTopGroupOptionsTopGroup.ValueMember = "id";
        }

        private void _setModes(Mode mode)
        {
            this._itemMode = mode;
            this._groupMode = mode;
            this._topGroupMode = mode;
        }

        private void _setEditableItems(bool isEditable)
        {
            this.buttonSaveItem.Enabled = isEditable;
            this.buttonUpdateItem.Enabled = !isEditable;
            this.buttonDeleteItem.Enabled = !isEditable;
        }

        private void _setEditableItemGroups(bool isEditable)
        {
            this.buttonSaveGroup.Enabled = isEditable;
            this.buttonUpdateGroup.Enabled = !isEditable;
            this.buttonDeleteGroup.Enabled = !isEditable;
        }

        private void _setEditableItemTopGroups(bool isEditable)
        {
            this.buttonSaveTopGroup.Enabled = isEditable;
            this.buttonUpdateTopGroup.Enabled = !isEditable;
            this.buttonDeleteTopGroup.Enabled = !isEditable;
        }

        private void _clearItemControls()
        {
            foreach (Control c in this.groupBoxItemOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _clearItemGroupControls()
        {
            foreach (Control c in this.groupBoxItemGroupOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _clearItemTopGroupControls()
        {
            foreach (Control c in this.groupBoxItemTopGroupOptions.Controls)
                if (c is ComboBox)
                    ((ComboBox)c).DataSource = null;
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
