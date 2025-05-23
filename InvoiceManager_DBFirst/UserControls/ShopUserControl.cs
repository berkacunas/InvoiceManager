﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst.UserControls
{
    public partial class ShopUserControl : UserControl
    {
        public event Notify ShopsLoaded;
        public event Notify ShopGroupsLoaded;
        public event Notify ShopTypesLoaded;

        public event ShopHandler ShopSaved;
        public event ShopUpdateHandler ShopUpdated;
        public event ShopHandler ShopRemoved;

        public event ShopGroupHandler ShopGroupSaved;
        public event ShopGroupUpdateHandler ShopGroupUpdated;
        public event ShopGroupHandler ShopGroupRemoved;

        public event ShopTypeHandler ShopTypeSaved;
        public event ShopTypeUpdateHandler ShopTypeUpdated;
        public event ShopTypeHandler ShopTypeRemoved;

        public event Notify ShopChanged;
        public event Notify ShopFormOpened;
        public event Notify ShopFormClosed;

        private InvoicesEntities dbContext;

        private Shop _newShop;
        private ShopGroup _newShopGroup;
        private ShopType _newShopType;

        private Mode _shopMode;
        private Mode _groupMode;
        private Mode _typeMode;

        private List<ColumnSortOrder[]> _columnSortOrdersShopTypes = new List<ColumnSortOrder[]> 
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        private List<ColumnSortOrder[]> _columnSortOrdersShopGroups = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        private List<ColumnSortOrder[]> _columnSortOrdersShops = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        public ShopUserControl()
        {
            InitializeComponent();

            this.Load += ShopUserControl_Load;

            this.dbContext = new InvoicesEntities();

            this.dataGridViewShopTypes.DataBindingComplete += dataGridViewShopTypes_DataBindingComplete;
            this.dataGridViewShopTypes.DataSourceChanged += dataGridViewShopTypes_DataSourceChanged;
            this.dataGridViewShopTypes.CellClick += dataGridViewShopTypes_CellClick;
            this.dataGridViewShopTypes.ColumnHeaderMouseClick += dataGridViewShopTypes_ColumnHeaderMouseClick;

            this.dataGridViewShopGroups.DataBindingComplete += dataGridViewShopGroups_DataBindingComplete;
            this.dataGridViewShopGroups.DataSourceChanged += dataGridViewShopGroups_DataSourceChanged;
            this.dataGridViewShopGroups.CellClick += dataGridViewShopGroups_CellClick;
            this.dataGridViewShopGroups.ColumnHeaderMouseClick += dataGridViewShopGroups_ColumnHeaderMouseClick;

            this.dataGridViewShops.DataBindingComplete += dataGridViewShops_DataBindingComplete;
            this.dataGridViewShops.DataSourceChanged += dataGridViewShops_DataSourceChanged;
            this.dataGridViewShops.CellClick += dataGridViewShops_CellClick;
            this.dataGridViewShops.ColumnHeaderMouseClick += dataGridViewShops_ColumnHeaderMouseClick;

            this.buttonNewShopType.Click += buttonNewShopType_Click;
            this.buttonSaveShopType.Click += buttonSaveShopType_Click;
            this.buttonUpdateShopType.Click += buttonUpdateShopType_Click;
            this.buttonDeleteShopType.Click += buttonDeleteShopType_Click;

            this.buttonNewShopGroup.Click += buttonNewShopGroup_Click;
            this.buttonSaveShopGroup.Click += buttonSaveShopGroup_Click;
            this.buttonUpdateShopGroup.Click += buttonUpdateShopGroup_Click;
            this.buttonDeleteShopGroup.Click += buttonDeleteShopGroup_Click;

            this.buttonNewShop.Click += buttonNewShop_Click;
            this.buttonSaveShop.Click += buttonSaveShop_Click;
            this.buttonUpdateShop.Click += buttonUpdateShop_Click;
            this.buttonDeleteShop.Click += buttonDeleteShop_Click;

            this.checkBoxShopGroupOptionsEdit.CheckedChanged += checkBoxShopGroupOptionsEdit_CheckedChanged;

        }

        #region Event Handlers

        private void ShopUserControl_Load(object sender, EventArgs e)
        {
            this.setModes(Mode.Display);

            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewShops);
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewShopGroups);
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewShopTypes);

            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewShops, false);
            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewShopGroups, false);
            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewShopTypes, false);

            this.comboBoxShopOptionsShopGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxShopGroupOptionsShopType.DropDownStyle = ComboBoxStyle.DropDownList;
            // this.comboBoxShopTypeOptionsShopType.DropDownStyle = ComboBoxStyle.DropDownList;  // Must be editable.

            this.bindDataToGridViewShop();
            this.bindDataToGridViewShopGroup();
            this.bindDataToGridViewShopType();

            this.onShopFormOpened("Shops", "Window opened", DateTime.Now);
        }

        private void dataGridViewShopTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewShopTypes.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewShopTypes.Rows[0];
                if (row != null)
                    this.setShopTypeControls(row);
            }
        }

        private void dataGridViewShopGroups_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewShopGroups.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewShopGroups.Rows[0];
                if (row != null)
                    this.setShopGroupControls(row);
            }
        }

        private void dataGridViewShops_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewShops.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewShops.Rows[0];
                if (row != null)
                    this.setShopControls(row);
            }
        }

        private void dataGridViewShopTypes_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewShopTypes.DataSource == null)
                return;

            string[] shopTypesHeaderTexts = new string[] { "shopTypeId", "Shop Type" };

            int[] shopTypesColumnWidths = new int[] { 50, 170 };
            DataGridViewContentAlignment[] shopTypesColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft};

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewShopTypes, shopTypesHeaderTexts, shopTypesColumnWidths, shopTypesColumnAlignments);

            this.dataGridViewShopTypes.Columns["shopTypeId"].Visible = false;
        }

        private void dataGridViewShopGroups_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewShopGroups.DataSource == null)
                return;

            string[] shopGroupsHeaderTexts = new string[] { "shopGroupId", "shopTypeId", "Group", "Type", "Owner" };

            int[] shopGroupsColumnWidths = new int[] { 50, 50, 230, 165, 165 };
            DataGridViewContentAlignment[] shopGroupsColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                          DataGridViewContentAlignment.MiddleLeft,
                                                                          DataGridViewContentAlignment.MiddleLeft,
                                                                          DataGridViewContentAlignment.MiddleLeft,
                                                                          DataGridViewContentAlignment.MiddleLeft };

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewShopGroups, shopGroupsHeaderTexts, shopGroupsColumnWidths, shopGroupsColumnAlignments);

            this.dataGridViewShopGroups.Columns["shopGroupId"].Visible = false;
            this.dataGridViewShopGroups.Columns["shopTypeId"].Visible = false;
        }

        private void dataGridViewShops_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewShops.DataSource == null)
                return;

            string[] shopsHeaderTexts = new string[] { "shopId", "shopGroupId", "Shop", "Nickname", "Address", "Tel", "Web", "Email" };

            int[] shopsColumnWidths = new int[] { 50, 50, 230, 165, 500, 110, 195, 200 };
            DataGridViewContentAlignment[] shopsColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft};

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewShops, shopsHeaderTexts, shopsColumnWidths, shopsColumnAlignments);

            this.dataGridViewShops.Columns["shopId"].Visible = false;
            this.dataGridViewShops.Columns["shopGroupId"].Visible = false;
            this.dataGridViewShops.Columns["Address"].Visible = false;
            this.dataGridViewShops.Columns["Web"].Visible = false;
            this.dataGridViewShops.Columns["Email"].Visible = false;
        }

        private void dataGridViewShopTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearShopTypeControls();
            DataGridViewRow row = this.dataGridViewShopTypes.CurrentRow;
            this.setShopTypeControls(row);
        }

        private void dataGridViewShopGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearShopGroupControls();
            DataGridViewRow row = this.dataGridViewShopGroups.CurrentRow;
            this.setShopGroupControls(row);
            this.checkEditableCheckBoxes(false);
        }

        private void dataGridViewShops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearShopControls();
            DataGridViewRow row = this.dataGridViewShops.CurrentRow;
            this.setShopControls(row);
        }

        private void dataGridViewShopTypes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewShopTypes.Columns[e.ColumnIndex].HeaderText;

            var query = from shopType in dbContext.ShopType
                        orderby shopType.Name
                        select new
                        {
                            shopTypeId = shopType.id,
                            shopTypeName = shopType.Name
                        };

            switch (columnName)
            {
                case "Shop Type":
                    
                    this.dataGridViewShopTypes.DataSource = (this._columnSortOrdersShopTypes[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.shopTypeName).ToList() : query.OrderByDescending(r => r.shopTypeName).ToList();
                    this._columnSortOrdersShopTypes[0][0] = (this._columnSortOrdersShopTypes[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
            }
        }

        private void dataGridViewShopGroups_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewShopGroups.Columns[e.ColumnIndex].HeaderText;

            var query = from shopGroup in dbContext.ShopGroup
                        join shopType in dbContext.ShopType on shopGroup.TypeId equals shopType.id
                        orderby shopGroup.Name ascending
                        select new
                        {
                            shopGroupId = shopGroup.id,
                            shopTypeId = shopType.id,
                            shopGroupName = shopGroup.Name,
                            shopTypeName = shopType.Name,
                            shopGroupOwner = shopGroup.Owner
                        };

            switch (columnName)
            {
                case "Group":
                    this.dataGridViewShopGroups.DataSource = (this._columnSortOrdersShopGroups[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.shopGroupName).ToList() : query.OrderByDescending(r => r.shopGroupName).ToList();
                    this._columnSortOrdersShopGroups[0][0] = (this._columnSortOrdersShopGroups[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Type":
                    this.dataGridViewShopGroups.DataSource = (this._columnSortOrdersShopGroups[1][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.shopTypeName).ToList() : query.OrderByDescending(r => r.shopTypeName).ToList();
                    this._columnSortOrdersShopGroups[1][0] = (this._columnSortOrdersShopGroups[1][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Owner":
                    this.dataGridViewShopGroups.DataSource = (this._columnSortOrdersShopGroups[2][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.shopGroupOwner).ToList() : query.OrderByDescending(r => r.shopGroupOwner).ToList();
                    this._columnSortOrdersShopGroups[2][0] = (this._columnSortOrdersShopGroups[2][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
            }
        }

        private void dataGridViewShops_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewShops.Columns[e.ColumnIndex].HeaderText;

            var query = from shop in dbContext.Shop
                        join shopGroup in dbContext.ShopGroup on shop.GroupId equals shopGroup.id
                        orderby shop.Name ascending
                        select new
                        {
                            shopId = shop.id,
                            shopGroupId = shopGroup.id,
                            shopName = shop.Name,
                            nickname = shop.Nickname,
                            address = shop.Address,
                            tel = shop.Tel,
                            web = shop.Web,
                            email = shop.Email
                        };

            switch (columnName)
            {
                case "Shop":
                    this.dataGridViewShops.DataSource = (this._columnSortOrdersShops[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.shopName).ToList() : query.OrderByDescending(r => r.shopName).ToList();
                    this._columnSortOrdersShops[0][0] = (this._columnSortOrdersShops[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Nickname":
                    this.dataGridViewShops.DataSource = (this._columnSortOrdersShops[1][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.nickname).ToList() : query.OrderByDescending(r => r.nickname).ToList();
                    this._columnSortOrdersShops[1][0] = (this._columnSortOrdersShops[1][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
                case "Tel":
                    this.dataGridViewShops.DataSource = (this._columnSortOrdersShops[2][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.tel).ToList() : query.OrderByDescending(r => r.tel).ToList();
                    this._columnSortOrdersShops[2][0] = (this._columnSortOrdersShops[2][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
            }
        }

        private void buttonNewShopType_Click(object sender, EventArgs e)
        {
            this._typeMode = (this._typeMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewShopType.Text = (this._typeMode == Mode.Add) ? "Cancel" : "New";

            if (this._typeMode == Mode.Add)
            {
                this.setEditableShopTypes(true);
                this.bindDataToComboBoxShopTypeOptionsShopType(BindType.Setnull);
                this._newShopType = new ShopType();
            }
            else
            {
                this.setEditableShopTypes(false);
                this.bindDataToComboBoxShopTypeOptionsShopType(BindType.Select);
            }

            this.clearShopTypeControls();
        }

        private void buttonSaveShopType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBoxShopTypeOptionsShopType.Text))
            {
                MessageBox.Show("Text not entered.", "Enter shop type name first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._newShopType.Name = this.comboBoxShopTypeOptionsShopType.Text;
            this._newShopType = this.dbContext.ShopType.Add(this._newShopType);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopTypeSaved(this._newShopType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding shop type.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToComboBoxShopTypeOptionsShopType(BindType.Where, this._newShopType.id);
            this.bindDataToGridViewShopType();
            this.clearShopTypeControls();
            this.setEditableShopTypes(false);
            this._newShopType = new ShopType();
            this._typeMode = Mode.Display;
        }

        private void buttonUpdateShopType_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewShopTypes.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Row not selected.", "Select the row you want to update first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(this.comboBoxShopTypeOptionsShopType.Text))
            {
                MessageBox.Show("Item not selected.", "Select the shop type you want to update first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int shopTypeId = Convert.ToInt32(row.Cells["shopTypeId"].Value);
            string shopTypeName = row.Cells["shopTypeName"].Value.ToString();

            ShopType shopType = this.dbContext.ShopType.Where(r => r.id == shopTypeId).FirstOrDefault();
            ShopType oldShopType = this.dbContext.ShopType.Where(r => r.id == shopTypeId).AsNoTracking().FirstOrDefault();

            this.setShopTypeDataFromUiToObject(shopType);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopTypeUpdated(shopType, oldShopType);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating shop type.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToComboBoxShopTypeOptionsShopType(BindType.Where, shopType.id);
            this.bindDataToGridViewShopType();
        }

        private void buttonDeleteShopType_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewShopTypes.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Row not selected.", "Select the row you want to delete first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int shopTypeId = Convert.ToInt32(row.Cells["shopTypeId"].Value);
            ShopType shopType = this.dbContext.ShopType.Where(r => r.id == shopTypeId).FirstOrDefault();

            var shopGroupsToUpdateQuery = from shopGroup in dbContext.ShopGroup
                                          join shoptype in dbContext.ShopType on shopGroup.TypeId equals shoptype.id
                                          where shopGroup.TypeId == shopTypeId
                                          select shopGroup;

            List<ShopGroup> shopGroupsToUpdate = shopGroupsToUpdateQuery.ToList();

            if (shopGroupsToUpdate.Count > 0)
            {
                string message = $"You should change or delete shop groups associated with Shop Type first before deleting this shop type.\n\nThis shop groups are:\n";

                foreach (ShopGroup shopGroup in shopGroupsToUpdate)
                {
                    message += $"Item id: {shopGroup.id}  ";
                    message += $"Item name: {shopGroup.Name}\n";
                }
                message = message.Remove(message.Length - 1, 1);

                MessageBox.Show(message, "Unable to delete shop type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.onShopTypeRemoved(shopType);
            dbContext.ShopType.Remove(shopType);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop Type.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToComboBoxShopGroupOptionsShopType(BindType.Setnull);
            this.bindDataToComboBoxShopTypeOptionsShopType(BindType.Setnull);
            this.bindDataToGridViewShopGroup();
            this.bindDataToGridViewShopType();
        }

        private void buttonNewShopGroup_Click(object sender, EventArgs e)
        {
            this._groupMode = (this._groupMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewShopGroup.Text = (this._groupMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewShopGroups.Enabled = (this._groupMode != Mode.Add);
            this.checkEditableCheckBoxes(this._groupMode == Mode.Add);

            if (this._groupMode == Mode.Add)
            {
                this.bindDataToComboBoxShopGroupOptionsShopType(BindType.Select);
                this.setEditableShopGroups(true);
                this._newShopGroup = new ShopGroup();
            }
            else
            {
                this.bindDataToComboBoxShopGroupOptionsShopType(BindType.Setnull);
                this.setEditableShopGroups(false);
            }

            this.clearShopGroupControls();
        }

        private void buttonSaveShopGroup_Click(object sender, EventArgs e)
        {
            this.setShopGroupDataFromUiToObject(this._newShopGroup);
            this.dbContext.ShopGroup.Add(this._newShopGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopGroupSaved(this._newShopGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.clearShopGroupControls();
            this.setEditableShopGroups(false);
            this.bindDataToGridViewShopGroup();
            this._newShopGroup = new ShopGroup();
            this._groupMode = Mode.Display;
        }

        private void buttonUpdateShopGroup_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewShopGroups.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Row not selected.", "Select the row you want to update first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int groupId = Convert.ToInt32(row.Cells["shopGroupId"].Value);
            ShopGroup shopGroup = dbContext.ShopGroup.Where(r => r.id == groupId).FirstOrDefault();
            ShopGroup oldShopGroup = dbContext.ShopGroup.Where(r => r.id == groupId).AsNoTracking().FirstOrDefault();

            this.setShopGroupDataFromUiToObject(shopGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopGroupUpdated(shopGroup, oldShopGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToGridViewShopGroup();
            this.checkEditableCheckBoxes(false);
        }

        private void buttonDeleteShopGroup_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewShopGroups.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to delete first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int groupId = Convert.ToInt32(row.Cells["shopGroupId"].Value);
            ShopGroup shopGroup = this.dbContext.ShopGroup.Where(r => r.id == groupId).FirstOrDefault();

            var shopsToUpdateQuery = from shop in dbContext.Shop
                                     join shopgroup in dbContext.ShopGroup on shop.GroupId equals shopgroup.id
                                     where shopgroup.id == groupId
                                     select shop;

            List<Shop> shopsToUpdate = shopsToUpdateQuery.ToList();

            if (shopsToUpdate.Count > 0)
            {
                string message = $"You should change or delete shops associated with Shop Groups first before deleting this shop group.\n\nThis shops are:\n";

                foreach (Shop shop in shopsToUpdate)
                {
                    message += $"Shop id: {shop.id}  ";
                    message += $"Shop name: {shop.Name}\n";
                }
                message = message.Remove(message.Length - 1, 1);

                MessageBox.Show(message, "Unable to delete shop group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.onShopGroupRemoved(shopGroup);
            dbContext.ShopGroup.Remove(shopGroup);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToComboBoxShopOptionsShopGroup(BindType.Setnull);
            this.bindDataToGridViewShopGroup();
            this.clearShopGroupControls();
        }

        private void buttonNewShop_Click(object sender, EventArgs e)
        {
            this._shopMode = (this._shopMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewShop.Text = (this._shopMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewShops.Enabled = (this._shopMode != Mode.Add);

            if (this._shopMode == Mode.Add)
            {
                this.bindDataToComboBoxShopOptionsShopGroup(BindType.Select);
                this.setEditableShops(true);
                this._newShop = new Shop();
            }
            else
            {
                this.bindDataToComboBoxShopOptionsShopGroup(BindType.Setnull);
                this.setEditableShops(false);
            }

            this.clearShopControls();
        }

        private void buttonSaveShop_Click(object sender, EventArgs e)
        {
            this.setShopDataFromUiToObject(this._newShop);
            this.dbContext.Shop.Add(this._newShop);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopSaved(this._newShop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.clearShopControls();
            this.setEditableShops(false);
            this.bindDataToGridViewShop();
            this._newShop = new Shop();
            this._shopMode = Mode.Display;
        }

        private void buttonUpdateShop_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewShops.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int shopId = Convert.ToInt32(row.Cells["shopId"].Value);
            Shop shop = dbContext.Shop.Where(r => r.id == shopId).FirstOrDefault();
            Shop oldShop = dbContext.Shop.Where(r => r.id == shopId).AsNoTracking().FirstOrDefault();

            this.setShopDataFromUiToObject(shop);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopUpdated(shop, oldShop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating shop.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToGridViewShop();
        }

        private void buttonDeleteShop_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewShops.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to delete first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int shopId = Convert.ToInt32(row.Cells["shopId"].Value);
            Shop shop = this.dbContext.Shop.Where(r => r.id == shopId).FirstOrDefault();

            this.onShopRemoved(shop);
            this.dbContext.Shop.Remove(shop);

            try
            {
                this.dbContext.SaveChanges();   
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToComboBoxShopOptionsShopGroup(BindType.Setnull);
            this.bindDataToGridViewShop();
            this.clearShopControls();
        }

        private void checkBoxShopGroupOptionsEdit_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewShopGroups.CurrentRow;
            int groupId = (row == null) ? -1 : Convert.ToInt32(row.Cells["shopGroupId"].Value);

            if (checkBoxShopGroupOptionsEdit.Checked)
                this.bindDataToComboBoxShopGroupOptionsShopType(BindType.Select);
            else
                this.bindDataToComboBoxShopGroupOptionsShopType(BindType.Where, groupId);
        }

        #endregion

        #region Databind Queries

        private void bindDataToGridViewShopType()
        {
            var query = from shopType in dbContext.ShopType
                        orderby shopType.Name
                        select new
                        {
                            shopTypeId = shopType.id,
                            shopTypeName = shopType.Name
                        };

            this.dataGridViewShopTypes.DataSource = query.ToList();
            //this.onShopTypesLoaded("ShopTypes Loaded", DateTime.Now);
            this.onShopTypesLoaded("ShopTypes", "ShopType data loaded", DateTime.Now);
        }

        private void bindDataToGridViewShopGroup()
        {
            var query = from shopGroup in dbContext.ShopGroup
                        join shopType in dbContext.ShopType on shopGroup.TypeId equals shopType.id
                        orderby shopGroup.Name ascending
                        select new
                        {
                            shopGroupId = shopGroup.id,
                            shopTypeId = shopType.id,
                            shopGroupName = shopGroup.Name,
                            shopTypeName = shopType.Name,
                            shopGroupOwner = shopGroup.Owner
                        };

            this.dataGridViewShopGroups.DataSource = query.ToList();
            this.onShopGroupsLoaded("ShopGroups", "ShopGroup data loaded", DateTime.Now);
        }

        private void bindDataToGridViewShop()
        {
            var query = from shop in dbContext.Shop
                        join shopGroup in dbContext.ShopGroup on shop.GroupId equals shopGroup.id
                        orderby shop.Name ascending
                        select new
                        {
                            shopId = shop.id,
                            shopGroupId = shopGroup.id,
                            shopName = shop.Name,
                            nickname = shop.Nickname,
                            address = shop.Address,
                            tel = shop.Tel,
                            web = shop.Web,
                            email = shop.Email
                        };

            this.dataGridViewShops.DataSource = query.ToList();
            this.onShopsLoaded("Shops", "Shop data loaded", DateTime.Now);

        }

        private void bindDataToComboBoxShopTypeOptionsShopType(BindType bindType, int shopTypeId = 0) // When bindType is set to "Where", shopTypeId must be passed.
        {
            IQueryable<ShopType> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from shopType in dbContext.ShopType orderby shopType.Name ascending select shopType;
                    break;
                case BindType.Where:
                    query = from shopType in dbContext.ShopType where shopType.id == shopTypeId select shopType;
                    break;
                case BindType.Setnull:
                    this.comboBoxShopTypeOptionsShopType.DataSource = null;
                    return;

            }

            this.comboBoxShopTypeOptionsShopType.DataSource = query.ToList();
            this.comboBoxShopTypeOptionsShopType.DisplayMember = "Name";
            this.comboBoxShopTypeOptionsShopType.ValueMember = "id";
        }

        private void bindDataToComboBoxShopGroupOptionsShopType(BindType bindType, int shopTypeId = 0) // When bindType is set to "Where", shopTypeId must be passed.
        {
            IQueryable<ShopType> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from shopType in dbContext.ShopType orderby shopType.Name ascending select shopType;
                    break;
                case BindType.Where:
                    query = from shopType in dbContext.ShopType where shopType.id == shopTypeId select shopType;
                    break;
                case BindType.Setnull:
                    this.comboBoxShopGroupOptionsShopType.DataSource = null;
                    return;

            }

            this.comboBoxShopGroupOptionsShopType.DataSource = query.ToList();
            this.comboBoxShopGroupOptionsShopType.DisplayMember = "Name";
            this.comboBoxShopGroupOptionsShopType.ValueMember = "id";
        }

        private void bindDataToComboBoxShopOptionsShopGroup(BindType bindType, int shopGroupId = 0)
        {
            IQueryable<ShopGroup> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from shoupGroup in dbContext.ShopGroup orderby shoupGroup.Name ascending select shoupGroup;
                    break;
                case BindType.Where:
                    query = from shoupGroup in dbContext.ShopGroup where shoupGroup.id == shopGroupId select shoupGroup;
                    break;
                case BindType.Setnull:
                    this.comboBoxShopOptionsShopGroup.DataSource = null;
                    return;

            }

            this.comboBoxShopOptionsShopGroup.DataSource = query.ToList();
            this.comboBoxShopOptionsShopGroup.DisplayMember = "Name";
            this.comboBoxShopOptionsShopGroup.ValueMember = "id";
        }

        #endregion

        #region Set data to Controls

        private void setShopTypeControls(DataGridViewRow row)
        {
            int shopTypeId = Convert.ToInt32(row.Cells["shopTypeId"].Value);
            this.bindDataToComboBoxShopTypeOptionsShopType(BindType.Where, shopTypeId);
        }

        private void setShopGroupControls(DataGridViewRow row)
        {
            int shopTypeId = Convert.ToInt32(row.Cells["shopTypeId"].Value);

            this.textBoxShopGroupOptionsGroupName.Text = row.Cells["shopGroupName"].Value.ToString();
            this.textBoxShopGroupOptionsOwner.Text = (row.Cells["shopGroupOwner"].Value != null) ? row.Cells["shopGroupOwner"].Value.ToString() : string.Empty;

            this.bindDataToComboBoxShopGroupOptionsShopType(BindType.Where, shopTypeId);
        }

        private void setShopControls(DataGridViewRow row)
        {
            int shopId = Convert.ToInt32(row.Cells["shopId"].Value);
            int shopGroupId = Convert.ToInt32(row.Cells["shopGroupId"].Value);

            this.textBoxShopOptionsShop.Text = row.Cells["shopName"].Value.ToString();
            this.textBoxShopOptionsNickName.Text = (row.Cells["nickname"].Value != null) ? row.Cells["nickname"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsAddress.Text = (row.Cells["address"].Value != null) ? row.Cells["address"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsTel.Text = (row.Cells["tel"].Value != null) ? row.Cells["tel"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsWeb.Text = (row.Cells["web"].Value != null) ? row.Cells["web"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsEmail.Text = (row.Cells["email"].Value != null) ? row.Cells["email"].Value.ToString() : string.Empty;

            this.bindDataToComboBoxShopOptionsShopGroup(BindType.Where, shopGroupId);
            // group için combo ekle: this._bindDataToComboBoxShopGroup(BindType.Where, shopGroupId);
        }

        #endregion

        #region Get data from Controls

        private void setShopTypeDataFromUiToObject(ShopType shopType)
        {
            if (string.IsNullOrEmpty(this.comboBoxShopTypeOptionsShopType.Text))
            {
                MessageBox.Show("You didn't select shop type.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            shopType.Name = this.comboBoxShopTypeOptionsShopType.Text;
        }

        private void setShopGroupDataFromUiToObject(ShopGroup shopGroup)
        {
            if (string.IsNullOrEmpty(this.textBoxShopGroupOptionsGroupName.Text))
            {
                MessageBox.Show("You didn't enter group.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxShopGroupOptionsShopType.SelectedItem == null)
            {
                MessageBox.Show("You didn't select shop type.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            shopGroup.Name = this.textBoxShopGroupOptionsGroupName.Text;
            shopGroup.Owner = this.textBoxShopGroupOptionsOwner.Text;
            shopGroup.TypeId = ((ShopType)this.comboBoxShopGroupOptionsShopType.SelectedItem).id;
        }

        private void setShopDataFromUiToObject(Shop shop)
        {
            if (string.IsNullOrEmpty(this.textBoxShopOptionsShop.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter shop.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxShopOptionsShopGroup.SelectedItem == null)
            {
                MessageBox.Show("Missing value.", "You didn't select shop group.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            shop.Name = this.textBoxShopOptionsShop.Text;
            shop.GroupId = ((ShopGroup)this.comboBoxShopOptionsShopGroup.SelectedItem).id;
            shop.Address = this.textBoxShopOptionsAddress.Text;
            shop.Nickname = this.textBoxShopOptionsNickName.Text;
            shop.Tel = this.textBoxShopOptionsTel.Text;
            shop.Web = this.textBoxShopOptionsWeb.Text;
            shop.Email = this.textBoxShopOptionsEmail.Text;
        }

        #endregion

        #region Set Enabled & Checked & Read-only Controls

        private void setEditableShopTypes(bool isEditable)
        {
            this.buttonSaveShopType.Enabled = isEditable;
            this.buttonUpdateShopType.Enabled = isEditable;
            this.buttonDeleteShopType.Enabled = isEditable;
        }

        private void setEditableShopGroups(bool isEditable)
        {
            this.buttonSaveShopGroup.Enabled = isEditable;
            this.buttonUpdateShopGroup.Enabled = !isEditable;
            this.buttonDeleteShopGroup.Enabled = !isEditable;
        }

        private void setEditableShops(bool isEditable)
        {
            this.buttonSaveShop.Enabled = isEditable;
            this.buttonUpdateShop.Enabled = !isEditable;
            this.buttonDeleteShop.Enabled = !isEditable;
        }

        private void checkEditableCheckBoxes(bool check)
        {
            this.checkBoxShopGroupOptionsEdit.Checked = check;
        }

        private void setModes(Mode mode)
        {
            this._shopMode = mode;
            this._groupMode = mode;
            this._typeMode = mode;
        }

        #endregion

        #region Clear Controls

        private void clearShopTypeControls()
        {
            // ShopType controls don't have any textboxes.
        }

        private void clearShopGroupControls()
        {
            foreach (Control c in this.groupBoxShopGroupOptions.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }
        }

        private void clearShopControls()
        {
            foreach (Control c in this.groupBoxShopOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        #endregion

        #region User-defined Event Handlers

        protected virtual void onShopTypesLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopTypesLoaded?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopTypeSaved(ShopType shopType) //protected virtual method
        {
            this.ShopTypeSaved?.Invoke(shopType);
            this.onShopChanged("ShopTypes", $"New shop type {shopType.id}: {shopType.Name} saved", DateTime.Now);
        }

        protected virtual void onShopTypeUpdated(ShopType newShopType, ShopType oldShopType) //protected virtual method
        {
            this.ShopTypeUpdated?.Invoke(newShopType, oldShopType);
            this.onShopChanged("ShopTypes", $"Shop type {newShopType.id}: {newShopType.Name} updated", DateTime.Now);
        }

        protected virtual void onShopTypeRemoved(ShopType shopType) //protected virtual method
        {
            this.ShopTypeRemoved?.Invoke(shopType);
            this.onShopChanged("ShopTypes", $"Shop type {shopType.id}: {shopType.Name} removed", DateTime.Now);
        }

        protected virtual void onShopGroupsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopGroupsLoaded?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopGroupSaved(ShopGroup shopGroup) //protected virtual method
        {
            this.ShopGroupSaved?.Invoke(shopGroup);
            this.onShopChanged("ShopGroups", $"New shop group {shopGroup.id}: {shopGroup.Name} saved.", DateTime.Now);
        }

        protected virtual void onShopGroupUpdated(ShopGroup newShopGroup, ShopGroup oldShopGroup) //protected virtual method
        {
            this.ShopGroupUpdated?.Invoke(newShopGroup, oldShopGroup);
            this.onShopChanged("ShopGroups", $"Shop group {newShopGroup.id}: {oldShopGroup.Name} updated", DateTime.Now);
        }

        protected virtual void onShopGroupRemoved(ShopGroup shopGroup) //protected virtual method
        {
            this.ShopGroupRemoved?.Invoke(shopGroup);
            this.onShopChanged("ShopGroups", $"Shop group {shopGroup.id}: {shopGroup.Name} removed", DateTime.Now);
        }

        protected virtual void onShopsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopsLoaded?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopSaved(Shop shop) //protected virtual method
        {
            this.ShopSaved?.Invoke(shop);
            this.onShopChanged("Shops", $"New shop {shop.id}: {shop.Name} saved", DateTime.Now);
        }

        protected virtual void onShopUpdated(Shop newShop, Shop oldShop) //protected virtual method
        {
            this.ShopUpdated?.Invoke(newShop, oldShop);
            this.onShopChanged("Shops", $"Shop {newShop.id}: {oldShop.Name} updated", DateTime.Now);
        }

        protected virtual void onShopRemoved(Shop shop) //protected virtual method
        {
            this.ShopRemoved?.Invoke(shop);
            this.onShopChanged("Shops", $"Shop {shop.id}: {shop.Name} removed", DateTime.Now);
        }
        
        protected virtual void onShopChanged(string actionType, string message, DateTime eventTime)
        {
            this.ShopChanged?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onShopFormOpened(string actionType, string message, DateTime eventTime)
        {
            this.ShopFormOpened?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onShopFormClosed(string actionType, string message, DateTime eventTime)
        {
            this.ShopFormClosed?.Invoke(actionType, message, eventTime);
        }

        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    this.onShopFormClosed("Shops", "Window closed by user", DateTime.Now);
                    break;

                case CloseReason.WindowsShutDown:
                    this.onShopFormClosed("Shops", "Window closed as a part of Windows Shutdown", DateTime.Now);
                    break;

                case CloseReason.TaskManagerClosing:
                    this.onShopFormClosed("Shops", "Window closed forcibly by Task Manager", DateTime.Now);
                    break;

                case CloseReason.FormOwnerClosing:
                    this.onShopFormClosed("Shops", "Window closed by Form Owner", DateTime.Now);
                    break;

                default:
                    this.onShopFormClosed("Shops", "Window closed with an unknown reasoun", DateTime.Now);
                    break;

            }
        }

        #endregion
    }
}
