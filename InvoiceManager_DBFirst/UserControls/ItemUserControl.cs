using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst.UserControls
{
    public partial class ItemUserControl : UserControl
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

        public ItemUserControl()
        {
            InitializeComponent();

            this.Load += itemUserControl_Load;

            this.dbContext = new InvoicesEntities();

            this.dataGridViewItemTopGroups.DataSourceChanged += dataGridViewItemTopGroups_DataSourceChanged;
            this.dataGridViewItemTopGroups.CellClick += dataGridViewItemTopGroups_CellClick;
            this.dataGridViewItemTopGroups.ColumnHeaderMouseClick += dataGridViewItemTopGroups_ColumnHeaderMouseClick;

            this.dataGridViewItemGroups.DataBindingComplete += dataGridViewItemGroups_DataBindingComplete;
            this.dataGridViewItemGroups.DataSourceChanged += dataGridViewItemGroups_DataSourceChanged;
            this.dataGridViewItemGroups.CellClick += dataGridViewItemGroups_CellClick;
            this.dataGridViewItemGroups.ColumnHeaderMouseClick += dataGridViewItemGroups_ColumnHeaderMouseClick;

            this.dataGridViewItems.DataBindingComplete += dataGridViewItems_DataBindingComplete;
            this.dataGridViewItems.DataSourceChanged += dataGridViewItems_DataSourceChanged;
            this.dataGridViewItems.CellClick += dataGridViewItems_CellClick;
            this.dataGridViewItems.ColumnHeaderMouseClick += dataGridViewItems_ColumnHeaderMouseClick;

            this.buttonNewTopGroup.Click += buttonNewTopGroup_Click;
            this.buttonSaveTopGroup.Click += buttonSaveTopGroup_Click;
            this.buttonUpdateTopGroup.Click += buttonUpdateTopGroup_Click;
            this.buttonDeleteTopGroup.Click += buttonDeleteTopGroup_Click;

            this.buttonNewGroup.Click += buttonNewGroup_Click;
            this.buttonSaveGroup.Click += buttonSaveGroup_Click;
            this.buttonUpdateGroup.Click += buttonUpdateGroup_Click;
            this.buttonDeleteGroup.Click += buttonDeleteGroup_Click;

            this.buttonNewItem.Click += buttonNewItem_Click;
            this.buttonSaveItem.Click += buttonSaveItem_Click;
            this.buttonUpdateItem.Click += buttonUpdateItem_Click;
            this.buttonDeleteItem.Click += buttonDeleteItem_Click;

            this.buttonNewItemSubType.Click += buttonNewItemSubType_Click;
            this.buttonSaveItemSubType.Click += buttonSaveItemSubType_Click;
            this.buttonUpdateItemSubType.Click += buttonUpdateItemSubType_Click;
            this.buttonDeleteItemSubType.Click += buttonDeleteItemSubType_Click;

            this.checkBoxGroupOptionsEdit.CheckedChanged += checkBoxGroupOptionsEdit_CheckedChanged;
            this.checkBoxItemOptionsEdit.CheckedChanged += checkBoxItemOptionsEdit_CheckedChanged;
            this.checkBoxItemSubTypeOptionsEdit.CheckedChanged += checkBoxItemSubTypeOptionsEdit_CheckedChanged;

            this.comboBoxItemSubTypeOptionsItemSubType.SelectedIndexChanged += comboBoxItemSubTypeOptionsItemSubType_SelectedIndexChanged;
        }

        private void itemUserControl_Load(object sender, EventArgs e)
        {
            this._setModes(Mode.Display);

            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewItemTopGroups);
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewItemGroups);
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewItems);

            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewItemTopGroups, false);
            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewItems, false);
            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewItemGroups, false);

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

        private void dataGridViewItemGroups_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewItemGroups.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewItemGroups.Rows[0];
                if (row != null)
                    this._setItemGroupControls(row);
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

        private void dataGridViewItemTopGroups_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewItemTopGroups.DataSource == null)
                return;

            string[] headerTexts = new string[] { "itemTopGroupId", "Top Group" };
            int[] columnWidths = new int[] { 50, 150 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft };

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewItemTopGroups, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewItemTopGroups.Columns["id"].Visible = false;
        }

        private void dataGridViewItemGroups_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewItemGroups.DataSource == null)
                return;

            string[] tactionsHeaderTexts = new string[] { "itemGroupId", "itemTopGroupId", "Group", "Top Group" };
            int[] tactionsColumnWidths = new int[] { 50, 50, 150, 150 };
            DataGridViewContentAlignment[] tactionsColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft };

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewItemGroups, tactionsHeaderTexts, tactionsColumnWidths, tactionsColumnAlignments);

            this.dataGridViewItemGroups.Columns["itemGroupId"].Visible = false;
            this.dataGridViewItemGroups.Columns["itemTopGroupId"].Visible = false;
        }

        private void dataGridViewItems_DataSourceChanged(object sender, EventArgs e)
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

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewItems, tactionsHeaderTexts, tactionsColumnWidths, tactionsColumnAlignments);

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

                foreach (Item item in itemsToUpdate)
                {
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

        private void comboBoxItemSubTypeOptionsItemSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxItemSubTypeOptionsItemSubType.SelectedItem == null)    // if item has no subitem.
                return;

            this._newItemSubType = (ItemSubType)this.comboBoxItemSubTypeOptionsItemSubType.SelectedItem;
            this._newItemSubTypeDetails = new ItemSubTypeDetails();
            this._newItemSubTypeDetails.ItemSubTypeId = this._newItemSubType.id;
        }


        private void _setModes(Mode mode)
        {
            this._itemMode = mode;
            this._itemSubTypeMode = mode;
            this._groupMode = mode;
            this._topGroupMode = mode;
        }
    }
}
