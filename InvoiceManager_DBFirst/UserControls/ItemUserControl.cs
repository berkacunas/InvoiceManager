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

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst.UserControls
{
    public partial class ItemUserControl : UserControl
    {
        public event Notify ItemsLoad;
        public event Notify ItemGroupLoad;
        public event Notify ItemTopGroupLoad;

        public event Notify ItemChanged;
        public event Notify ItemFormOpened;
        public event Notify ItemFormClosed;

        public event ItemHandler ItemSave;
        public event ItemUpdateHandler ItemUpdate;
        public event ItemHandler ItemRemove;

        public event ItemSubTypeHandler ItemSubTypeSave;
        public event ItemSubTypeUpdateHandler ItemSubTypeUpdate;
        public event ItemSubTypeHandler ItemSubTypeRemove;
        
        public event ItemGroupHandler ItemGroupSave;
        public event ItemGroupUpdateHandler ItemGroupUpdate;
        public event ItemGroupHandler ItemGroupRemove;
        
        public event ItemTopGroupHandler ItemTopGroupSave;
        public event ItemTopGroupUpdateHandler ItemTopGroupUpdate;
        public event ItemTopGroupHandler ItemTopGroupRemove;

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


        private List<ColumnSortOrder[]> _columnSortOrdersItemTopGroups = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        private List<ColumnSortOrder[]> _columnSortOrdersItemGroups = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        private List<ColumnSortOrder[]> _columnSortOrdersItems = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

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

        #region Event Handlers

        private void itemUserControl_Load(object sender, EventArgs e)
        {
            this.setModes(Mode.Display);

            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewItemTopGroups);
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewItemGroups);
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewItems);

            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewItemTopGroups, false);
            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewItems, false);
            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewItemGroups, false);

            this.setEditableItemTopGroups(false);
            this.setEditableItemGroups(false);
            this.setEditableItems(false);
            this.setEditableItemSubTypes(false);

            this.comboBoxItemOptionsGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxGroupOptionsTopGroup.DropDownStyle = ComboBoxStyle.DropDownList;

            this.textBoxItemSubTypeOptionsItem.ReadOnly = true;

            this.bindDataToGridViewItemTopGroup();
            this.bindDataToGridViewItemGroup();
            this.bindDataToGridViewItem();


            this.onItemFormOpened("Items", "Window opened", DateTime.Now);
        }

        private void dataGridViewItemGroups_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewItemGroups.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewItemGroups.Rows[0];
                if (row != null)
                    this.setItemGroupControls(row);
            }
        }

        private void dataGridViewItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewItems.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewItems.Rows[0];
                if (row != null)
                {
                    this.setItemControls(row);
                    this.setItemSubTypeControls(row);
                    this.setItemSubTypeDetails(row);
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

            this.dataGridViewItemTopGroups.Columns["itemTopGroupId"].Visible = false;
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
            int[] tactionsColumnWidths = new int[] { 50, 50, 280, 160, 150 };
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
            this.clearItemTopGroupControls();
            DataGridViewRow row = this.dataGridViewItemTopGroups.CurrentRow;
            this.setItemTopGroupControls(row);
        }

        private void dataGridViewItemGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearItemGroupControls();
            DataGridViewRow row = this.dataGridViewItemGroups.CurrentRow;
            this.setItemGroupControls(row);
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearItemControls();
            this.clearItemSubTypeControls();
            DataGridViewRow row = this.dataGridViewItems.CurrentRow;
            this.setItemControls(row);
            this.setItemSubTypeControls(row);
            this.setItemSubTypeDetails(row);
        }

        private void dataGridViewItemTopGroups_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewItemTopGroups.Columns[e.ColumnIndex].HeaderText;

            var query = from itemTopGroup in dbContext.ItemTopGroup
                        select itemTopGroup;

            switch (columnName)
            {
                case "Top Group":

                    this.dataGridViewItemTopGroups.DataSource = (this._columnSortOrdersItemTopGroups[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.Name).ToList() : query.OrderByDescending(r => r.Name).ToList();
                    this._columnSortOrdersItemTopGroups[0][0] = (this._columnSortOrdersItemTopGroups[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
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
                    this.dataGridViewItemGroups.DataSource = (this._columnSortOrdersItemGroups[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.itemGroupName).ToList() : query.OrderByDescending(r => r.itemGroupName).ToList();
                    this._columnSortOrdersItemGroups[0][0] = (this._columnSortOrdersItemGroups[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
                case "Top Group":
                    this.dataGridViewItemGroups.DataSource = (this._columnSortOrdersItemGroups[1][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.itemTopGroupName).ToList() : query.OrderByDescending(r => r.itemTopGroupName).ToList();
                    this._columnSortOrdersItemGroups[1][0] = (this._columnSortOrdersItemGroups[1][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
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
                    this.dataGridViewItems.DataSource = (this._columnSortOrdersItems[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.itemName).ToList() : query.OrderByDescending(r => r.itemName).ToList();
                    this._columnSortOrdersItems[0][0] = (this._columnSortOrdersItems[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Group":
                    this.dataGridViewItems.DataSource = (this._columnSortOrdersItems[1][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.itemGroupName).ToList() : query.OrderByDescending(r => r.itemGroupName).ToList();
                    this._columnSortOrdersItems[1][0] = (this._columnSortOrdersItems[1][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
                case "Note":
                    this.dataGridViewItems.DataSource = (this._columnSortOrdersItems[2][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.itemNote).ToList() : query.OrderByDescending(r => r.itemNote).ToList();
                    this._columnSortOrdersItems[2][0] = (this._columnSortOrdersItems[2][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
            }
        }

        private void buttonNewTopGroup_Click(object sender, EventArgs e)
        {
            this._topGroupMode = (this._topGroupMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewTopGroup.Text = (this._topGroupMode == Mode.Add) ? "Cancel" : "New";

            if (this._topGroupMode == Mode.Add)
            {
                this.setEditableItemTopGroups(true);
                this._newItemTopGroup = new ItemTopGroup();
            }
            else
                this.setEditableItemTopGroups(false);

            this.bindDataToComboBoxGroupOptionsTopGroup(BindType.Setnull);
            this.clearItemTopGroupControls();
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
                this.onItemTopGroupSaved(this._newItemTopGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item top group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToComboBoxTopGroupOptionsTopGroup(BindType.Where, this._newItemTopGroup.id);
            this.bindDataToGridViewItemTopGroup();

            this.clearItemTopGroupControls();
            this.setEditableItemTopGroups(false);
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
            ItemTopGroup oldItemTopGroup = (ItemTopGroup)dbContext.ItemTopGroup.Where(r => r.id == itemTopGroupId).AsNoTracking().FirstOrDefault();

            this.setItemTopGroupDataFromUiToObject(itemTopGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onItemTopGroupUpdated(itemTopGroup, oldItemTopGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.bindDataToComboBoxGroupOptionsTopGroup(BindType.Where, itemTopGroup.id);
            this.bindDataToGridViewItemTopGroup();
            this.bindDataToGridViewItemGroup();
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

            this.onItemTopGroupRemoved(itemTopGroup);
            dbContext.ItemTopGroup.Remove(itemTopGroup);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item top group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToComboBoxGroupOptionsTopGroup(BindType.Setnull);
            this.bindDataToGridViewItemTopGroup();
            this.bindDataToGridViewItemGroup();
            this.clearItemTopGroupControls();
        }

        private void buttonNewGroup_Click(object sender, EventArgs e)
        {
            this._groupMode = (this._groupMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewGroup.Text = (this._groupMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewItemGroups.Enabled = (this._groupMode != Mode.Add);

            if (this._groupMode == Mode.Add)
            {
                this.bindDataToComboBoxGroupOptionsTopGroup(BindType.Select);
                this.setEditableItemGroups(true);
                this._newItemGroup = new ItemGroup();
            }
            else
            {
                this.bindDataToComboBoxGroupOptionsTopGroup(BindType.Setnull);
                this.setEditableItemGroups(false);
            }

            this.clearItemGroupControls();
        }

        private void buttonSaveGroup_Click(object sender, EventArgs e)
        {
            this.setItemGroupDataFromUiToObject(this._newItemGroup);
            this.dbContext.ItemGroup.Add(this._newItemGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onItemGroupSaved(this._newItemGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.clearItemGroupControls();
            this.setEditableItemGroups(false);
            this.bindDataToGridViewItemGroup();
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

            this.setItemGroupDataFromUiToObject(itemGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onItemGroupUpdated(itemGroup, oldItemGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.bindDataToGridViewItemGroup();
            this.bindDataToGridViewItem();
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

            this.onItemGroupRemoved(itemGroup);
            dbContext.ItemGroup.Remove(itemGroup);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.bindDataToComboBoxItemOptionsGroup(BindType.Setnull);
            this.bindDataToComboBoxGroupOptionsTopGroup(BindType.Setnull);
            this.bindDataToGridViewItemGroup();
            this.clearItemGroupControls();
        }

        private void buttonNewItem_Click(object sender, EventArgs e)
        {
            this._itemMode = (this._itemMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewItem.Text = (this._itemMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewItems.Enabled = (this._itemMode != Mode.Add);

            if (this._itemMode == Mode.Add)
            {
                this.bindDataToComboBoxItemOptionsGroup(BindType.Select);
                this.setEditableItems(true);
                this._newItem = new Item();
            }
            else
            {
                this.bindDataToComboBoxItemOptionsGroup(BindType.Setnull);
                this.setEditableItems(false);
            }

            this.clearItemControls();
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
            this.setItemDataFromUiToObject(this._newItem);
            this.dbContext.Item.Add(this._newItem);

            try
            {
                this.dbContext.SaveChanges();
                this.onItemSaved(this._newItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "An error occurred while adding item.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.clearItemControls();
            this.setEditableItems(false);
            this.bindDataToGridViewItem();
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
            Item oldItem = dbContext.Item.Where(r => r.id == itemId).AsNoTracking().FirstOrDefault();

            this.setItemDataFromUiToObject(item);

            try
            {
                this.dbContext.SaveChanges();
                this.onItemUpdated(item, oldItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToGridViewItem();
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
            
            this.onItemRemoved(item);
            dbContext.Item.Remove(item);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToComboBoxItemOptionsGroup(BindType.Setnull);
            this.bindDataToGridViewItem();
            this.clearItemControls();
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
                this.setEditableItemSubTypes(true);
                this.bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Setnull);
            }
            else
            {
                this.bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Where, itemId);
                this.setEditableItemSubTypes(false);
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
                this.onItemSubTypeSaved(itemSubType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting itemsubtype and itemsubtypedetails.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            this.bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Where, this._newItemSubTypeDetails.ItemId);
            this.setEditableItemSubTypes(false);
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
                this.onItemSubTypeUpdated("ItemSubTypes", $"Item sub type {itemSubType.id}: {itemSubType.Name} updated", DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating sub item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Where, itemId);
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

            this.onItemSubTypeRemoved(itemSubType);

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
                this.bindDataToComboBoxGroupOptionsTopGroup(BindType.Select);
            else
                this.bindDataToComboBoxGroupOptionsTopGroup(BindType.Where, topGroupId);
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
                this.bindDataToComboBoxItemOptionsGroup(BindType.Select);
            else
                this.bindDataToComboBoxItemOptionsGroup(BindType.Where, groupId);
        }

        private void checkBoxItemSubTypeOptionsEdit_CheckedChanged(object sender, EventArgs e)
        {
            this.setEditableItemSubTypes(this.checkBoxItemSubTypeOptionsEdit.Checked);
        }

        private void comboBoxItemSubTypeOptionsItemSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxItemSubTypeOptionsItemSubType.SelectedItem == null)    // if item has no subitem.
                return;

            this._newItemSubType = (ItemSubType)this.comboBoxItemSubTypeOptionsItemSubType.SelectedItem;
            this._newItemSubTypeDetails = new ItemSubTypeDetails();
            this._newItemSubTypeDetails.ItemSubTypeId = this._newItemSubType.id;
        }

        #endregion

        #region Databind Queries

        private void bindDataToGridViewItemTopGroup()
        {
            var query = from itemTopGroup in dbContext.ItemTopGroup
                        orderby itemTopGroup.Name
                        select new
                        {
                            itemTopGroupId = itemTopGroup.id,
                            itemTopGroupName = itemTopGroup.Name
                        };

            this.dataGridViewItemTopGroups.DataSource = query.ToList();
        }

        private void bindDataToGridViewItemGroup()
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

        private void bindDataToGridViewItem()
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

        private void bindDataComboBoxTopGroupOptionsTopGroup(BindType bindType, int topGroupId = 0)
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

        private void bindDataToComboBoxTopGroupOptionsTopGroup(BindType bindType, int topGroupId)
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

        private void bindDataToComboBoxGroupOptionsTopGroup(BindType bindType, int topGroupId = 0)
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

        private void bindDataToComboBoxItemOptionsGroup(BindType bindType, int groupId = 0) // When bindType is set to "Where", groupId must be passed.
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

        private void bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType bindType, int itemId = 0)
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

        #endregion

        #region Set data to Controls

        private void setItemTopGroupControls(DataGridViewRow row)
        {
            int topGroupId = Convert.ToInt32(row.Cells["itemTopGroupId"].Value);
            this.bindDataComboBoxTopGroupOptionsTopGroup(BindType.Where, topGroupId);
        }

        private void setItemGroupControls(DataGridViewRow row)
        {
            int topGroupId = Convert.ToInt32(row.Cells["itemTopGroupId"].Value);
            this.textBoxGroupOptionsGroup.Text = row.Cells["itemGroupName"].Value.ToString();

            this.bindDataToComboBoxTopGroupOptionsTopGroup(BindType.Where, topGroupId);
            this.bindDataToComboBoxGroupOptionsTopGroup(BindType.Where, topGroupId);
        }

        private void setItemControls(DataGridViewRow row)
        {
            int groupId = Convert.ToInt32(row.Cells["itemGroupId"].Value);

            this.textBoxItemOptionsItem.Text = row.Cells["itemName"].Value.ToString();
            if (row.Cells["itemNote"].Value != null)
                this.textBoxItemOptionsNote.Text = row.Cells["itemNote"].Value.ToString();

            this.bindDataToComboBoxItemOptionsGroup(BindType.Where, groupId);
        }

        private void setItemSubTypeControls(DataGridViewRow row)
        {
            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);
            this.textBoxItemSubTypeOptionsItem.Text = row.Cells["itemName"].Value.ToString();
            this.bindDataToComboBoxItemSubTypeOptionsItemSubType(BindType.Where, itemId);
        }

        #endregion

        #region Get data from Controls

        private void setItemDataFromUiToObject(Item item)
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

        private void setItemGroupDataFromUiToObject(ItemGroup itemGroup)
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

        private void setItemTopGroupDataFromUiToObject(ItemTopGroup itemTopGroup)
        {
            if (this.comboBoxTopGroupOptionsTopGroup.Text == null)
            {
                MessageBox.Show("You didn't select item top group.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            itemTopGroup.Name = this.comboBoxTopGroupOptionsTopGroup.Text;
        }

        private void setItemSubTypeDetails(DataGridViewRow row)
        {
            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);
            this._newItemSubTypeDetails.ItemId = itemId;
        }

        #endregion

        #region Set Enabled & Checked & Read-only Controls

        private void setEditableItems(bool isEditable)
        {
            this.buttonSaveItem.Enabled = isEditable;
            this.buttonUpdateItem.Enabled = !isEditable;
            this.buttonDeleteItem.Enabled = !isEditable;
        }

        private void setEditableItemSubTypes(bool isEditable)
        {
            this.buttonSaveItemSubType.Enabled = isEditable;
            this.buttonUpdateItemSubType.Enabled = isEditable;
            this.buttonDeleteItemSubType.Enabled = isEditable;
            this.comboBoxItemSubTypeOptionsItemSubType.DropDownStyle = (isEditable) ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
        }

        private void setEditableItemGroups(bool isEditable)
        {
            this.buttonSaveGroup.Enabled = isEditable;
            this.buttonUpdateGroup.Enabled = !isEditable;
            this.buttonDeleteGroup.Enabled = !isEditable;
        }

        private void setEditableItemTopGroups(bool isEditable)
        {
            this.buttonSaveTopGroup.Enabled = isEditable;
            this.buttonUpdateTopGroup.Enabled = !isEditable;
            this.buttonDeleteTopGroup.Enabled = !isEditable;
        }

        private void setModes(Mode mode)
        {
            this._itemMode = mode;
            this._itemSubTypeMode = mode;
            this._groupMode = mode;
            this._topGroupMode = mode;
        }

        #endregion

        #region Clear Controls

        private void clearItemControls()
        {
            foreach (Control c in this.groupBoxItemOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void clearItemSubTypeControls()
        {
            foreach (Control c in this.groupBoxItemSubTypeOptions.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is ComboBox)
                    ((ComboBox)c).DataSource = null;
            }
        }

        private void clearItemGroupControls()
        {
            foreach (Control c in this.groupBoxItemGroupOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void clearItemTopGroupControls()
        {
            foreach (Control c in this.groupBoxItemTopGroupOptions.Controls)
                if (c is ComboBox)
                    ((ComboBox)c).DataSource = null;
        }

        #endregion

        #region User-defined Event Handlers

        protected virtual void onItemsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemsLoad?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemSaved(Item item) //protected virtual method
        {
            this.ItemSave?.Invoke(item);
            this.onItemChanged("Items", $"New item {_newItem.id}: {_newItem.Name} saved", DateTime.Now);
        }

        protected virtual void onItemUpdated(Item newItem, Item oldItem) //protected virtual method
        {
            this.ItemUpdate?.Invoke(newItem, oldItem);
            this.onItemChanged("Items", $"Item {newItem.id}: {newItem.Name} updated", DateTime.Now);
        }

        protected virtual void onItemRemoved(Item item) //protected virtual method
        {
            this.ItemRemove?.Invoke(item);
            this.onItemChanged("Items", $"Item {item.id}: {item.Name} removed", DateTime.Now);
        }

        protected virtual void onItemSubTypeSaved(ItemSubType itemSubType) //protected virtual method
        {
            this.ItemSubTypeSave?.Invoke(itemSubType);
            this.onItemChanged("ItemSubTypes", $"New item sub type {itemSubType.id}: {itemSubType.Name} saved", DateTime.Now);
        }

        protected virtual void onItemSubTypeUpdated(ItemSubType newSubType, ItemSubType oldSubType) //protected virtual method
        {
            this.ItemSubTypeUpdate?.Invoke(newSubType, oldSubType);
            this.onItemChanged("ItemSubTypes", $"Item sub type {newSubType.id}: {newSubType.Name} updated", DateTime.Now);
        }

        protected virtual void onItemSubTypeRemoved(ItemSubType itemSubType) //protected virtual method
        {
            this.ItemSubTypeRemove?.Invoke(itemSubType);
            this.onItemChanged("ItemSubTypes", $"Item sub type {itemSubType.id}: {itemSubType.Name} removed", DateTime.Now);
        }

        protected virtual void onItemGroupSaved(ItemGroup itemGroup) //protected virtual method
        {
            this.ItemGroupSave?.Invoke(itemGroup);
            this.onItemChanged("ItemGroups", $"New item group {itemGroup.id}: {itemGroup.Name} saved.", DateTime.Now);
        }

        protected virtual void onItemGroupUpdated(ItemGroup newItemGroup, ItemGroup oldItemGroup) //protected virtual method
        {
            this.ItemGroupUpdate?.Invoke(newItemGroup, oldItemGroup);
            this.onItemChanged("ItemGroups", $"Item group {newItemGroup.id}: {newItemGroup.Name} updated.", DateTime.Now);
        }

        protected virtual void onItemGroupsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemGroupLoad?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemGroupRemoved(ItemGroup itemGroup) //protected virtual method
        {
            this.ItemGroupRemove?.Invoke(itemGroup);
            this.onItemChanged("ItemGroups", $"Item group {itemGroup.id}: {itemGroup.Name} removed.", DateTime.Now);
        }

        protected virtual void onItemTopGroupsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ItemTopGroupLoad?.Invoke(actionType, message, eventTime);
            this.onItemChanged(actionType, message, eventTime);
        }

        protected virtual void onItemTopGroupSaved(ItemTopGroup itemTopGroup) //protected virtual method
        {
            this.ItemTopGroupSave?.Invoke(itemTopGroup);
            this.onItemChanged("ItemTopGroups", $"New item top group {itemTopGroup.id}: {itemTopGroup.Name} saved.", DateTime.Now);
        }

        protected virtual void onItemTopGroupUpdated(ItemTopGroup newItemTopGroup, ItemTopGroup oldItemTopGroup) //protected virtual method
        {
            this.ItemTopGroupUpdate?.Invoke(newItemTopGroup, oldItemTopGroup);
            this.onItemChanged("ItemTopGroups", $"Item top group {newItemTopGroup.id}: {newItemTopGroup.Name} updated.", DateTime.Now);
        }

        protected virtual void onItemTopGroupRemoved(ItemTopGroup itemTopGroup) //protected virtual method
        {
            this.ItemTopGroupRemove?.Invoke(itemTopGroup);
            this.onItemChanged("ItemTopGroups", $"Item top group {itemTopGroup.id}: {itemTopGroup.Name} removed.", DateTime.Now);
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

        #endregion

    }
}
