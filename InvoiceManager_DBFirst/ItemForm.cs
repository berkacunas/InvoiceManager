using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst
{
    public partial class ItemForm : Form
    {
        public event Notify ItemsLoaded;
        public event Notify ItemSaved;
        public event Notify ItemUpdated;
        public event Notify ItemRemoved;

        public event Notify ItemGroupsLoaded;
        public event Notify ItemGroupSaved;
        public event Notify ItemGroupUpdated;
        public event Notify ItemGroupRemoved;

        public event Notify ItemTopGroupsLoaded;
        public event Notify ItemTopGroupSaved;
        public event Notify ItemTopGroupUpdated;
        public event Notify ItemTopGroupRemoved;

        public event Notify ItemChanged;
        public event Notify ItemFormOpened;
        public event Notify ItemFormClosed;

        private InvoicesEntities dbContext;

        private Item _newItem;
        private ItemSubType _newItemSubType;
        private ItemSubTypeDetails _newItemSubTypeDetails;
        private ItemGroup _newItemGroup;
        private ItemTopGroup _newItemTopGroup;

        private Mode _itemMode;
        private Mode _itemSubTypeMode;
        private Mode _groupMode;
        private Mode _topGroupMode;

        private ColumnSortOrder[] _sortOrdersDataGridViewItemTopGroups = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };
        private ColumnSortOrder[] _sortOrdersDataGridViewItemGroups = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };
        private ColumnSortOrder[] _sortOrdersDataGridViewItems = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };
        

        public ItemForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.Item.GetHicon());

            this.dbContext = new InvoicesEntities();

            this.dataGridViewItemTopGroups.DataSourceChanged += DataGridViewItemTopGroups_DataSourceChanged;
            this.dataGridViewItemGroups.DataSourceChanged += DataGridViewItemGroups_DataSourceChanged;
            this.dataGridViewItems.DataSourceChanged += DataGridViewItems_DataSourceChanged;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            this._setModes(Mode.Display);

            _setDefaultGridViewStyles(this.dataGridViewItemTopGroups);
            _setDefaultGridViewStyles(this.dataGridViewItemGroups);
            _setDefaultGridViewStyles(this.dataGridViewItems);

            _enableDataGridViewMultiSelect(this.dataGridViewItemTopGroups, false);
            _enableDataGridViewMultiSelect(this.dataGridViewItems, false);
            _enableDataGridViewMultiSelect(this.dataGridViewItemGroups, false);

            this._setEditableItemTopGroups(false);
            this._setEditableItemGroups(false);
            this._setEditableItems(false);
            this._setEditableItemSubTypes(false);

            this.comboBoxItemOptionsGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxGroupOptionsTopGroup.DropDownStyle = ComboBoxStyle.DropDownList;

            this.textBoxItemSubTypeOptionsItem.ReadOnly = true;

            this._bindDataToGridViewItemTopGroup();
            this._bindDataToGridViewItemGroup();
            this._bindDataToGridViewItem();
            

            this.onItemFormOpened("Items", "Window opened", DateTime.Now);
        }

        private void DataGridViewItemTopGroups_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewItemTopGroups.DataSource == null)
                return;

            string[] headerTexts = new string[] { "itemTopGroupId", "Top Group" };
            int[] columnWidths = new int[] { 50, 150 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft };

            _setDefaultGridViewHeaderStyles(this.dataGridViewItemTopGroups, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewItemTopGroups.Columns["id"].Visible = false;
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

        private void dataGridViewItemTopGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearItemTopGroupControls();
            DataGridViewRow row = this.dataGridViewItemTopGroups.CurrentRow;
            this._setItemTopGroupControls(row);
        }

        private void dataGridViewItemGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearItemGroupControls();
            DataGridViewRow row = this.dataGridViewItemGroups.CurrentRow;
            this._setItemGroupControls(row);
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearItemControls();
            this._clearItemSubTypeControls();
            DataGridViewRow row = this.dataGridViewItems.CurrentRow;
            this._setItemControls(row);
            this._setItemSubTypeControls(row);
            this._setItemSubTypeDetails(row);
        }

        private void dataGridViewItemTopGroups_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewItemTopGroups.Columns[e.ColumnIndex].HeaderText;

            var query = from itemTopGroup in dbContext.ItemTopGroup
                        select itemTopGroup;

            switch (columnName)
            {
                case "Top Group":

                    this.dataGridViewItemTopGroups.DataSource = (this._sortOrdersDataGridViewItemTopGroups[1] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.Name).ToList() : query.OrderByDescending(r => r.Name).ToList();
                    this._sortOrdersDataGridViewItemTopGroups[1] = (this._sortOrdersDataGridViewItemTopGroups[1] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
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
                    this.dataGridViewItemGroups.DataSource = (this._sortOrdersDataGridViewItemGroups[0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.itemGroupName).ToList() : query.OrderByDescending(r => r.itemGroupName).ToList();
                    this._sortOrdersDataGridViewItemGroups[0] = (this._sortOrdersDataGridViewItemGroups[0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
                case "Top Group":
                    this.dataGridViewItemGroups.DataSource = (this._sortOrdersDataGridViewItemGroups[1] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.itemTopGroupName).ToList() : query.OrderByDescending(r => r.itemTopGroupName).ToList();
                    this._sortOrdersDataGridViewItemGroups[1] = (this._sortOrdersDataGridViewItemGroups[1] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
            }
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
                    this.dataGridViewItems.DataSource = (this._sortOrdersDataGridViewItems[0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.itemName).ToList() : query.OrderByDescending(r => r.itemName).ToList();
                    this._sortOrdersDataGridViewItems[0] = (this._sortOrdersDataGridViewItems[0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Group":
                    this.dataGridViewItems.DataSource = (this._sortOrdersDataGridViewItems[1] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.itemGroupName).ToList() : query.OrderByDescending(r => r.itemGroupName).ToList();
                    this._sortOrdersDataGridViewItems[1] = (this._sortOrdersDataGridViewItems[1] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
            }
        }

        private void dataGridViewItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewItems.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewItems.Rows[0];
                if (row != null)
                {
                    this._setItemControls(row);
                    this._setItemSubTypeControls(row);
                    this._setItemSubTypeDetails(row);
                }
            }
        }

        private void dataGridViewItemGroups_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewItemGroups.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewItemGroups.Rows[0];
                if (row != null)
                    this._setItemGroupControls(row);
            }
        }

        private void checkBoxItemOptionsEdit_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewItems.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int groupId = (row == null) ? -1 : Convert.ToInt32(row.Cells["itemGroupId"].Value);

            if (checkBoxItemOptionsEdit.Checked)
                this._bindDataToComboBoxItemOptionsGroup(BindType.Select);
            else
                this._bindDataToComboBoxItemOptionsGroup(BindType.Where, groupId);
        }

        private void checkBoxItemSubTypeOptionsEdit_CheckedChanged(object sender, EventArgs e)
        {
            this._setEditableItemSubTypes(this.checkBoxItemSubTypeOptionsEdit.Checked);
        }

        private void checkBoxGroupOptionsEdit_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewItemGroups.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int topGroupId = (row == null) ? -1 : Convert.ToInt32(row.Cells["itemTopGroupId"].Value);

            if (checkBoxGroupOptionsEdit.Checked)
                this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Select);
            else
                this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Where, topGroupId);
        }

        private void comboBoxItemSubTypeOptionsItemSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxItemSubTypeOptionsItemSubType.SelectedItem == null)    // if item has no subitem.
                return;

            this._newItemSubType = (ItemSubType)this.comboBoxItemSubTypeOptionsItemSubType.SelectedItem;
            this._newItemSubTypeDetails = new ItemSubTypeDetails();
            this._newItemSubTypeDetails.ItemSubTypeId = this._newItemSubType.id;
        }

        private void buttonNewItem_Click(object sender, EventArgs e)
        {
            this._itemMode = (this._itemMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewItem.Text = (this._itemMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewItems.Enabled = (this._itemMode != Mode.Add);

            if (this._itemMode == Mode.Add)
            {
                this._bindDataToComboBoxItemOptionsGroup(BindType.Select);
                this._setEditableItems(true);
                this._newItem = new Item();
            }
            else
            {
                this._bindDataToComboBoxItemOptionsGroup(BindType.Setnull);
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
                this.onItemSaved("Items", $"New id {_newItem.id} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "An error occurred while adding item.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearItemControls();
            this._setEditableItems(false);
            this._bindDataToGridViewItem();
            this._newItem = new Item();
            this._itemMode = Mode.Display;
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewItems.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);
            Item item = dbContext.Item.Where(r => r.id == itemId).FirstOrDefault();

            this._setItemDataFromUiToObject(item);

            try
            {
                this.dbContext.SaveChanges();
                this.onItemUpdated("Items", $"Id {item.id} updated", DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewItem();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewItems.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);
            Item item = this.dbContext.Item.Where(r => r.id == itemId).FirstOrDefault();

            dbContext.Item.Remove(item);

            try
            {
                dbContext.SaveChanges();
                this.onItemRemoved("Items", $"Id {item.Name} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToComboBoxItemOptionsGroup(BindType.Setnull);
            this._bindDataToGridViewItem();
            this._clearItemControls();
        }

        private void buttonNewGroup_Click(object sender, EventArgs e)
        {
            this._groupMode = (this._groupMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewGroup.Text = (this._groupMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewItemGroups.Enabled = (this._groupMode != Mode.Add);

            if (this._groupMode == Mode.Add)
            {
                this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Select);
                this._setEditableItemGroups(true);
                this._newItemGroup = new ItemGroup();
            }
            else
            {
                this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Setnull);
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
                this.onItemGroupSaved("ItemGroups", $"New id {this._newItemGroup.Name} saved.", DateTime.Now);
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
            DataGridViewRow row = this.dataGridViewItemGroups.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int groupId = Convert.ToInt32(row.Cells["itemGroupId"].Value);
            ItemGroup itemGroup = dbContext.ItemGroup.Where(r => r.id == groupId).FirstOrDefault();

            this._setItemGroupDataFromUiToObject(itemGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onItemGroupUpdated("ItemGroups", $"Id {itemGroup.id} updated", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._bindDataToGridViewItemGroup();
            this._bindDataToGridViewItem();
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewItemGroups.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int groupId = Convert.ToInt32(row.Cells["itemGroupId"].Value);
            ItemGroup itemGroup = this.dbContext.ItemGroup.Where(r => r.id == groupId).FirstOrDefault();

            var itemsToUpdateQuery = from item in dbContext.Item
                                     join itemgroup in dbContext.ItemGroup on item.GroupId equals itemGroup.id
                                     where itemgroup.id == groupId
                                     select item;

            List<Item> itemsToUpdate = itemsToUpdateQuery.ToList();

            if (itemsToUpdate.Count > 0)
            {
                string message = $"You should change or delete items associated with Item Group: {itemGroup.Name} first before deleting this item group.\n\nThis items are:\n";

                foreach (Item item in itemsToUpdate) { 
                    message += $"Item id: {item.id}  ";
                    message += $"Item name: {item.Name}\n";
                }
                message = message.Remove(message.Length - 1, 1);

                MessageBox.Show(message, "Unable to delete item group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dbContext.ItemGroup.Remove(itemGroup);

            try
            {
                dbContext.SaveChanges();
                this.onItemGroupRemoved("ItemGroups", $"Id {itemGroup.id} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._bindDataToComboBoxItemOptionsGroup(BindType.Setnull);
            this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Setnull);
            this._bindDataToGridViewItemGroup();
            this._clearItemGroupControls();
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

            this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Setnull);
            this._clearItemTopGroupControls();
        }

        private void buttonSaveTopGroup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBoxTopGroupOptionsTopGroup.Text))
            {
                MessageBox.Show("Enter top group item name first.", "Text not entered.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._newItemTopGroup.Name = this.comboBoxTopGroupOptionsTopGroup.Text;
            this._newItemTopGroup = this.dbContext.ItemTopGroup.Add(this._newItemTopGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onItemTopGroupSaved("ItemTopGroups", $"New id {this._newItemTopGroup.id} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item top group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToComboBoxTopGroupOptionsTopGroup(BindType.Where, this._newItemTopGroup.id);
            this._bindDataToGridViewItemTopGroup();

            this._clearItemTopGroupControls();
            this._setEditableItemTopGroups(false);
            this._newItemTopGroup = new ItemTopGroup();
            this._topGroupMode = Mode.Display;
        }

        private void buttonUpdateTopGroup_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewItemTopGroups.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the top group item you want to update first.", "Item not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int itemTopGroupId = Convert.ToInt32(row.Cells["id"].Value);
            ItemTopGroup itemTopGroup = (ItemTopGroup)dbContext.ItemTopGroup.Where(r => r.id == itemTopGroupId).FirstOrDefault();
            this._setItemTopGroupDataFromUiToObject(itemTopGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onItemTopGroupUpdated("ItemGroups", $"Id {itemTopGroup.id} updated", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Where, itemTopGroup.id);
            this._bindDataToGridViewItemTopGroup();
            this._bindDataToGridViewItemGroup();
        }

        private void buttonDeleteTopGroup_Click(object sender, EventArgs e)
        {
            if (this.comboBoxTopGroupOptionsTopGroup.SelectedItem == null)
            {
                MessageBox.Show("Select the top group item you want to update first.", "Item not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ItemTopGroup itemTopGroup = (ItemTopGroup)this.comboBoxTopGroupOptionsTopGroup.SelectedItem;

            var itemGroupToUpdateQuery = from itemGroup in dbContext.ItemGroup
                                         join itemtopgroup in dbContext.ItemTopGroup on itemGroup.TopGroupId equals itemtopgroup.id
                                         where itemtopgroup.id == itemTopGroup.id
                                         select itemGroup;

            List<ItemGroup> itemGroupsToUpdate = itemGroupToUpdateQuery.ToList();

            if (itemGroupsToUpdate.Count > 0)
            {
                string message = $"You may want to change or delete item groups associated with Item Top Group: {itemTopGroup.Name} first before deleting this item top group.\n\nThis item groups are:\n";

                foreach (ItemGroup itemGroup in itemGroupsToUpdate)
                {
                    message += $"Item Group id: {itemGroup.id}  ";
                    message += $"Item Group name: {itemGroup.Name}\n";
                }
                message = message.Remove(message.Length - 1, 1);

                DialogResult dr = MessageBox.Show(message, "Do you really want to delete this ItemTopGroup. <No Group> title will be assigned for these ItemGroups ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var noTopGroupIdQuery = from itg in dbContext.ItemTopGroup
                                            where itg.Name == "<No Group>"
                                            select itg.id;


                    int noTopGroupId = (int)noTopGroupIdQuery.FirstOrDefault();

                    foreach (ItemGroup itemGroup in itemGroupsToUpdate)
                        itemGroup.TopGroupId = noTopGroupId;
                }
                else
                    return;
            }

            dbContext.ItemTopGroup.Remove(itemTopGroup);

            try
            {
                dbContext.SaveChanges();
                this.onItemTopGroupRemoved("ItemGroups", $"Id {itemTopGroup.id} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item top group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Setnull);
            this._bindDataToGridViewItemTopGroup();
            this._bindDataToGridViewItemGroup();
            this._clearItemTopGroupControls();
        }

        private void buttonNewItemSubType_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewItems.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);

            this._itemSubTypeMode = (this._itemSubTypeMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewItemSubType.Text = (this._itemSubTypeMode == Mode.Add) ? "Cancel" : "New";
            this.checkBoxItemSubTypeOptionsEdit.Checked = false;

            if (this._itemSubTypeMode == Mode.Add)
            {
                this._setEditableItemSubTypes(true);
                //this._newItemSubTypeDetails = new ItemSubTypeDetails();
                //this._newItemSubTypeDetails.ItemId = itemId;
                this._bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Setnull);
            }
            else
            {
                this._bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Where, itemId);
                this._setEditableItemSubTypes(false);
            }
        }

        private void buttonSaveItemSubType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBoxItemSubTypeOptionsItemSubType.Text))
            {
                MessageBox.Show("Enter item sub type name first.", "Text not entered.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string itemSubTypeName = this.comboBoxItemSubTypeOptionsItemSubType.Text;

            ItemSubType itemSubType = this.dbContext.ItemSubType.Where(r => r.Name == itemSubTypeName).FirstOrDefault();
            if (itemSubType != null)
                this._newItemSubTypeDetails.ItemSubTypeId = itemSubType.id;
            else
            {
                itemSubType = new ItemSubType();
                itemSubType.Name = itemSubTypeName;
                this.dbContext.ItemSubType.Add(itemSubType);
            }

            this._newItemSubTypeDetails.ItemSubType = itemSubType;
            this.dbContext.ItemSubTypeDetails.Add(this._newItemSubTypeDetails);

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting itemsubtype and itemsubtypedetails.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            this._bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Where, this._newItemSubTypeDetails.ItemId);
            this._setEditableItemSubTypes(false);
            this._newItemSubTypeDetails = new ItemSubTypeDetails();
            this._itemSubTypeMode = Mode.Display;
        }

        private void buttonUpdateItemSubType_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewItems.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the item you want to update its item sub types first.", "Item not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(this.comboBoxItemSubTypeOptionsItemSubType.Text))
            {
                MessageBox.Show("Enter item sub type name first.", "Text not entered.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);
            string itemSubTypeName = this.comboBoxItemSubTypeOptionsItemSubType.Text;

            if (string.IsNullOrEmpty(itemSubTypeName))
            {
                MessageBox.Show("Cannot set empty name.", "Text not entered.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ItemSubType itemSubType = this.dbContext.ItemSubType.Where(r => r.Name == itemSubTypeName).FirstOrDefault();
            if (itemSubType != null)
            {
                if (this.dbContext.ItemSubTypeDetails.Any(r => r.ItemId == itemId && r.ItemSubTypeId == itemSubType.id))
                {
                    MessageBox.Show("Item already has this sub item.", "Duplicate entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this._newItemSubTypeDetails.ItemSubTypeId = this.dbContext.ItemSubType.Where(r => r.Name == itemSubTypeName).FirstOrDefault().id;
            }
            else
            {
                itemSubType = new ItemSubType();
                itemSubType.Name = itemSubTypeName;
            
                this._newItemSubTypeDetails.ItemSubType = itemSubType;
            }

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating sub item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Where, itemId);
        }

        private void buttonDeleteItemSubType_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewItems.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the item you want to delete its item sub types first.", "Item not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxItemSubTypeOptionsItemSubType.SelectedItem == null)
            {
                MessageBox.Show("This item hasn't got any subitem.", "Subitem not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);
            ItemSubType itemSubType = (ItemSubType)this.comboBoxItemSubTypeOptionsItemSubType.SelectedItem;

            ItemSubTypeDetails itemSubTypeDetails = this.dbContext.ItemSubTypeDetails.Where(r => r.ItemId == itemId && r.ItemSubTypeId == itemSubType.id).FirstOrDefault();
            this.dbContext.ItemSubTypeDetails.Remove(itemSubTypeDetails);

            if (!this.dbContext.ItemSubTypeDetails.Any(r => r.ItemSubTypeId == itemSubType.id))
                this.dbContext.ItemSubType.Remove(itemSubType);

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating sub item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void _setDefaultGridViewStyles(DataGridView gridview)
        {
            gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridview.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);

            gridview.ReadOnly = true;

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
                MessageBox.Show("You didn't enter item.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxItemOptionsGroup.SelectedItem == null)
            {
                MessageBox.Show("You didn't select item group.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("You didn't enter item group.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxGroupOptionsTopGroup.SelectedItem == null)
            {
                MessageBox.Show("You didn't select item top group.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            itemGroup.TopGroupId = ((ItemTopGroup)this.comboBoxGroupOptionsTopGroup.SelectedItem).id;
            itemGroup.Name = this.textBoxGroupOptionsGroup.Text;
        }

        private void _setItemTopGroupDataFromUiToObject(ItemTopGroup itemTopGroup)
        {
            if (this.comboBoxTopGroupOptionsTopGroup.Text == null)
            {
                MessageBox.Show("You didn't select item top group.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            itemTopGroup.Name = this.comboBoxTopGroupOptionsTopGroup.Text;
        }

        private void _setItemTopGroupControls(DataGridViewRow row)
        {
            int topGroupId = Convert.ToInt32(row.Cells["id"].Value);
            this._bindDataComboBoxTopGroupOptionsTopGroup(BindType.Where, topGroupId);
        }

        private void _setItemGroupControls(DataGridViewRow row)
        {
            int topGroupId = Convert.ToInt32(row.Cells["itemTopGroupId"].Value);
            this.textBoxGroupOptionsGroup.Text = row.Cells["itemGroupName"].Value.ToString();

            this._bindDataToComboBoxTopGroupOptionsTopGroup(BindType.Where, topGroupId);
            this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Where, topGroupId);
        }

        private void _setItemControls(DataGridViewRow row)
        {
            int groupId = Convert.ToInt32(row.Cells["itemGroupId"].Value);

            this.textBoxItemOptionsItem.Text = row.Cells["itemName"].Value.ToString();
            if (row.Cells["itemNote"].Value != null)
                this.textBoxItemOptionsNote.Text = row.Cells["itemNote"].Value.ToString();

            this._bindDataToComboBoxItemOptionsGroup(BindType.Where, groupId);
        }

        private void _setItemSubTypeControls(DataGridViewRow row)
        {
            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);
            this.textBoxItemSubTypeOptionsItem.Text = row.Cells["itemName"].Value.ToString();
            this._bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Where, itemId);
        }

        private void _setItemSubTypeDetails(DataGridViewRow row)
        {
            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);
            this._newItemSubTypeDetails.ItemId = itemId;
        }

        public static void _enableDataGridViewMultiSelect(DataGridView gridview, bool enable)
        {
            gridview.MultiSelect = enable;
        }

        private void _bindDataToGridViewItemTopGroup()
        {
            var query = from itemTopGroup in dbContext.ItemTopGroup
                        orderby itemTopGroup.Name
                        select itemTopGroup;

            this.dataGridViewItemTopGroups.DataSource = query.ToList();
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
            this.onItemGroupsLoaded("ItemGroups", "ItemGroup data loaded", DateTime.Now);
            this.onItemTopGroupsLoaded("ItemTopGroups", "ItemTopGroup data loaded", DateTime.Now);
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
            this.onItemsLoaded("Items", "Item data loaded", DateTime.Now);
        }

        private void _bindDataComboBoxTopGroupOptionsTopGroup(BindType bindType, int topGroupId = 0)
        {
            IQueryable<ItemTopGroup> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from itemTopGroup in dbContext.ItemTopGroup orderby itemTopGroup.Name ascending select itemTopGroup;
                    break;
                case BindType.Where:
                    query = from itemTopGroup in dbContext.ItemTopGroup where itemTopGroup.id == topGroupId select itemTopGroup;
                    break;
                case BindType.Setnull:
                    this.comboBoxTopGroupOptionsTopGroup.DataSource = null;
                    return;
            }

            this.comboBoxTopGroupOptionsTopGroup.DisplayMember = "Name";
            this.comboBoxTopGroupOptionsTopGroup.ValueMember = "id";
            this.comboBoxTopGroupOptionsTopGroup.DataSource = query.ToList();
        }

        private void _bindDataToComboBoxTopGroupOptionsTopGroup(BindType bindType, int topGroupId)
        {
            IQueryable<ItemTopGroup> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    throw new NotImplementedException("This feature is unnecessary and is not implemented in this method.");
                case BindType.Where:
                    query = from itemTopGroup in dbContext.ItemTopGroup where itemTopGroup.id == topGroupId select itemTopGroup;
                    break;
                case BindType.Setnull:
                    throw new NotImplementedException("This feature is unnecessary and is not implemented in this method.");
            }

            this.comboBoxTopGroupOptionsTopGroup.DisplayMember = "Name";
            this.comboBoxTopGroupOptionsTopGroup.ValueMember = "id";
            this.comboBoxTopGroupOptionsTopGroup.DataSource = query.ToList();
        }

        private void _bindDataToComboBoxGroupOptionsTopGroup(BindType bindType, int topGroupId = 0)
        {
            IQueryable<ItemTopGroup> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from itemTopGroup in dbContext.ItemTopGroup orderby itemTopGroup.Name ascending select itemTopGroup;
                    break;
                case BindType.Where:
                    query = from itemTopGroup in dbContext.ItemTopGroup where itemTopGroup.id == topGroupId select itemTopGroup;
                    break;
                case BindType.Setnull:
                    this.comboBoxGroupOptionsTopGroup.DataSource = null;
                    return;
            }

            this.comboBoxGroupOptionsTopGroup.DisplayMember = "Name";
            this.comboBoxGroupOptionsTopGroup.ValueMember = "id";
            this.comboBoxGroupOptionsTopGroup.DataSource = query.ToList();
        }

        private void _bindDataToComboBoxItemOptionsGroup(BindType bindType, int groupId = 0) // When bindType is set to "Where", groupId must be passed.
        {
            IQueryable<ItemGroup> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from itemGroup in dbContext.ItemGroup orderby itemGroup.Name ascending select itemGroup;
                    break;
                case BindType.Where:
                    query = from itemGroup in dbContext.ItemGroup where itemGroup.id == groupId select itemGroup;
                    break;
                case BindType.Setnull:
                    this.comboBoxItemOptionsGroup.DataSource = null;
                    return;
            }

            this.comboBoxItemOptionsGroup.DisplayMember = "Name";
            this.comboBoxItemOptionsGroup.ValueMember = "id";
            this.comboBoxItemOptionsGroup.DataSource = query.ToList();
        }

        private void _bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType bindType, int itemId = 0)
        {
            IQueryable<ItemSubType> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    throw new NotImplementedException("_bindDataToComboBoxItemSubTypeOptionsItemSubType BindType.Select switch case is not implemented.");
                case BindType.Where:
                    /* SELECT DISTINCT(ItemSubType.id), ItemSubType.Name FROM ItemSubType 
                       JOIN TactionDetails ON ItemSubType.id = TactionDetails.ItemSubTypeId
                       JOIN Item ON Item.id = TactionDetails.ItemId
                       WHERE Item.id = (SELECT Item.id FROM Item WHERE Item.Name = 'Hamidiye Kaynak Suyu'); */

            query = from itemSubTypeDetails in dbContext.ItemSubTypeDetails
                    join item in dbContext.Item on itemSubTypeDetails.ItemId equals item.id
                    join itemSubType in dbContext.ItemSubType on itemSubTypeDetails.ItemSubTypeId equals itemSubType.id
                    where item.id == itemId
                    select itemSubType;

                    break;
                case BindType.Setnull:
                    this.comboBoxItemSubTypeOptionsItemSubType.DataSource = null;
                    return;
            }

            this.comboBoxItemSubTypeOptionsItemSubType.DisplayMember = "Name";
            this.comboBoxItemSubTypeOptionsItemSubType.ValueMember = "id";
            this.comboBoxItemSubTypeOptionsItemSubType.DataSource = query.ToList().Distinct().ToList();
        }

        private void _setModes(Mode mode)
        {
            this._itemMode = mode;
            this._itemSubTypeMode = mode;
            this._groupMode = mode;
            this._topGroupMode = mode;
        }

        private void _setEditableItems(bool isEditable)
        {
            this.buttonSaveItem.Enabled = isEditable;
            this.buttonUpdateItem.Enabled = !isEditable;
            this.buttonDeleteItem.Enabled = !isEditable;
        }
          
        private void _setEditableItemSubTypes(bool isEditable)
        {
            this.buttonSaveItemSubType.Enabled = isEditable;
            this.buttonUpdateItemSubType.Enabled = isEditable;
            this.buttonDeleteItemSubType.Enabled = isEditable;
            this.comboBoxItemSubTypeOptionsItemSubType.DropDownStyle = (isEditable) ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
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

        private void _clearItemSubTypeControls()
        {
            foreach (Control c in this.groupBoxItemSubTypeOptions.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is ComboBox)
                    ((ComboBox)c).DataSource = null;
            }
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

        protected virtual void onItemsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemsLoaded?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemSaved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemSaved?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemUpdated(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemUpdated?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemRemoved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemRemoved?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemGroupSaved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemGroupSaved?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemGroupUpdated(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemGroupUpdated?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemGroupsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemGroupsLoaded?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemGroupRemoved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemGroupRemoved?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemTopGroupSaved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemTopGroupSaved?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemTopGroupUpdated(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemTopGroupUpdated?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemTopGroupsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemTopGroupsLoaded?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemTopGroupRemoved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemTopGroupRemoved?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemChanged(string actionType, string message, DateTime eventTime)
        {
            this.ItemChanged?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onItemFormOpened(string actionType, string message, DateTime eventTime)
        {
            this.ItemFormOpened?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onItemFormClosed(string actionType, string message, DateTime eventTime)
        {
            this.ItemFormClosed?.Invoke(actionType, message, eventTime);
        }

        private void ItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    this.onItemFormClosed("Items", "Window closed by user", DateTime.Now);
                    break;

                case CloseReason.WindowsShutDown:
                    this.onItemFormClosed("Items", "Window closed as a part of Windows Shutdown", DateTime.Now);
                    break;

                case CloseReason.TaskManagerClosing:
                    this.onItemFormClosed("Items", "Window closed forcibly by Task Manager", DateTime.Now);
                    break;

                case CloseReason.FormOwnerClosing:
                    this.onItemFormClosed("Items", "Window closed by Form Owner", DateTime.Now);
                    break;

                default:
                    this.onItemFormClosed("Items", "Window closed with an unknown reasoun", DateTime.Now);
                    break;

            }
        }
    }
}
