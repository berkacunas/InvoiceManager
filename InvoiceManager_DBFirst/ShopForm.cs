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
    public partial class ShopForm : Form
    {
        public event Notify ShopsLoaded;
        public event Notify ShopSaved;
        public event Notify ShopUpdated;
        public event Notify ShopRemoved;

        public event Notify ShopGroupsLoaded;
        public event Notify ShopGroupSaved;
        public event Notify ShopGroupUpdated;
        public event Notify ShopGroupRemoved;

        public event Notify ShopTypesLoaded;
        public event Notify ShopTypeSaved;
        public event Notify ShopTypeUpdated;
        public event Notify ShopTypeRemoved;

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

        private ColumnSortOrder[] _sortOrdersDataGridViewShopGroups = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };
        private ColumnSortOrder[] _sortOrdersDataGridViewShops = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };

        public ShopForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.Shop.GetHicon());

            this.dbContext = new InvoicesEntities();

            this.FormClosing += ShopForm_FormClosing;

            this.dataGridViewShops.DataSourceChanged += DataGridViewShops_DataSourceChanged;
            this.dataGridViewShopGroups.DataSourceChanged += DataGridViewShopGroups_DataSourceChanged;
            this.dataGridViewShopTypes.DataSourceChanged += DataGridViewShopTypes_DataSourceChanged;
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            this._setModes(Mode.Display);

            _setDefaultGridViewStyles(this.dataGridViewShops);
            _setDefaultGridViewStyles(this.dataGridViewShopGroups);
            _setDefaultGridViewStyles(this.dataGridViewShopTypes);

            _enableDataGridViewMultiSelect(this.dataGridViewShops, false);
            _enableDataGridViewMultiSelect(this.dataGridViewShopGroups, false);
            _enableDataGridViewMultiSelect(this.dataGridViewShopTypes, false);

            this.comboBoxShopOptionsShopGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxShopGroupOptionsShopType.DropDownStyle = ComboBoxStyle.DropDownList;
            // this.comboBoxShopTypeOptionsShopType.DropDownStyle = ComboBoxStyle.DropDownList;  // Must be editable.

            this._bindDataToGridViewShop();
            this._bindDataToGridViewShopGroup();
            this._bindDataToGridViewShopType();

            this.onShopFormOpened("Shops", "Window opened", DateTime.Now);
        }

        private void DataGridViewShops_DataSourceChanged(object sender, EventArgs e)
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

            _setDefaultGridViewHeaderStyles(this.dataGridViewShops, shopsHeaderTexts, shopsColumnWidths, shopsColumnAlignments);

            this.dataGridViewShops.Columns["shopId"].Visible = false;
            this.dataGridViewShops.Columns["shopGroupId"].Visible = false;
            this.dataGridViewShops.Columns["Address"].Visible = false;
            this.dataGridViewShops.Columns["Web"].Visible = false;
            this.dataGridViewShops.Columns["Email"].Visible = false;
        }

        private void DataGridViewShopGroups_DataSourceChanged(object sender, EventArgs e)
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

            _setDefaultGridViewHeaderStyles(this.dataGridViewShopGroups, shopGroupsHeaderTexts, shopGroupsColumnWidths, shopGroupsColumnAlignments);

            this.dataGridViewShopGroups.Columns["shopGroupId"].Visible = false;
            this.dataGridViewShopGroups.Columns["shopTypeId"].Visible = false;
        }

        private void DataGridViewShopTypes_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewShopTypes.DataSource == null)
                return;

            string[] shopTypesHeaderTexts = new string[] { "shopTypeId", "Shop Type" };

            int[] shopTypesColumnWidths = new int[] { 50, 170 };
            DataGridViewContentAlignment[] shopTypesColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft};

            _setDefaultGridViewHeaderStyles(this.dataGridViewShopTypes, shopTypesHeaderTexts, shopTypesColumnWidths, shopTypesColumnAlignments);

            this.dataGridViewShopTypes.Columns["shopTypeId"].Visible = false;
        }

        private void dataGridViewShops_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewShops.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewShops.Rows[0];
                if (row != null)
                    this._setShopControls(row);
            }
        }

        private void dataGridViewShopGroups_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewShopGroups.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewShopGroups.Rows[0];
                if (row != null)
                    this._setShopGroupControls(row);
            }
        }

        private void dataGridViewShopTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewShopTypes.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewShopTypes.Rows[0];
                if (row != null)
                    this._setShopTypeControls(row);
            }
        }

        private void dataGridViewShops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearShopControls();
            DataGridViewRow row = this.dataGridViewShops.CurrentRow;
            this._setShopControls(row);
        }

        private void dataGridViewShopGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearShopGroupControls();
            DataGridViewRow row = this.dataGridViewShopGroups.CurrentRow;
            this._setShopGroupControls(row);
            this._checkEditableCheckBoxes(false);
        }

        private void dataGridViewShopTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearShopTypeControls();
            DataGridViewRow row = this.dataGridViewShopTypes.CurrentRow;
            this._setShopTypeControls(row);
        }

        private void buttonNewShop_Click(object sender, EventArgs e)
        {
            this._shopMode = (this._shopMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewShop.Text = (this._shopMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewShops.Enabled = (this._shopMode != Mode.Add);

            if (this._shopMode == Mode.Add)
            {
                this._bindDataToComboBoxShopOptionsShopGroup(BindType.Select);
                this._setEditableShops(true);
                this._newShop = new Shop();
            }
            else
            {
                this._bindDataToComboBoxShopOptionsShopGroup(BindType.Setnull);
                this._setEditableShops(false);
            }

            this._clearShopControls();
        }

        private void buttonSaveShop_Click(object sender, EventArgs e)
        {
            this._setShopDataFromUiToObject(this._newShop);
            this.dbContext.Shop.Add(this._newShop);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopSaved("Shops", $"New id {_newShop.Name} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearShopControls();
            this._setEditableShops(false);
            this._bindDataToGridViewShop();
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

            this._setShopDataFromUiToObject(shop);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopUpdated("Shops", $"Id {shop.id} updated", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating shop.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewShop();
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

            this.dbContext.Shop.Remove(shop);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopRemoved("Shops", $"Id {shop.id} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToComboBoxShopOptionsShopGroup(BindType.Setnull);
            this._bindDataToGridViewShop();
            this._clearShopControls();
        }

        private void buttonNewShopGroup_Click(object sender, EventArgs e)
        {
            this._groupMode = (this._groupMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewShopGroup.Text = (this._groupMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewShopGroups.Enabled = (this._groupMode != Mode.Add);
            this._checkEditableCheckBoxes(this._groupMode == Mode.Add);

            if (this._groupMode == Mode.Add)
            {
                this._bindDataToComboBoxShopGroupOptionsShopType(BindType.Select);
                this._setEditableShopGroups(true);
                this._newShopGroup = new ShopGroup();
            }
            else
            {
                this._bindDataToComboBoxShopGroupOptionsShopType(BindType.Setnull);
                this._setEditableShopGroups(false);
            }

            this._clearShopGroupControls();
        }

        private void buttonSaveShopGroup_Click(object sender, EventArgs e)
        {
            this._setShopGroupDataFromUiToObject(this._newShopGroup);
            this.dbContext.ShopGroup.Add(this._newShopGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopGroupSaved("ShopGroups", $"New id {this._newShopGroup.Name} saved.", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearShopGroupControls();
            this._setEditableShopGroups(false);
            this._bindDataToGridViewShopGroup();
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

            this._setShopGroupDataFromUiToObject(shopGroup);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopGroupUpdated("ShopGroups", $"Id {shopGroup.id} updated", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewShopGroup();
            this._checkEditableCheckBoxes(false);
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

            dbContext.ShopGroup.Remove(shopGroup);

            try
            {
                dbContext.SaveChanges();
                this.onShopGroupRemoved("ShopGroups", $"Id {shopGroup.id} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop group.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToComboBoxShopOptionsShopGroup(BindType.Setnull);
            //this._bindDataToComboBoxGroupOptionsTopGroup(BindType.Setnull);
            this._bindDataToGridViewShopGroup();
            this._clearShopGroupControls();
        }

        private void buttonNewShopType_Click(object sender, EventArgs e)
        {
            this._typeMode = (this._typeMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewShopType.Text = (this._typeMode == Mode.Add) ? "Cancel" : "New";

            if (this._typeMode == Mode.Add)
            {
                this._setEditableShopTypes(true);
                this._bindDataToComboBoxShopTypeOptionsShopType(BindType.Setnull);
                this._newShopType = new ShopType();
            }
            else
            {
                this._setEditableShopTypes(false);
                this._bindDataToComboBoxShopTypeOptionsShopType(BindType.Select);
            }

            this._clearShopTypeControls();
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
                this.onShopTypeSaved("ShopTypes", $"New id {this._newShopType.id} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding shop type.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToComboBoxShopTypeOptionsShopType(BindType.Where, this._newShopType.id);
            this._bindDataToGridViewShopType();
            this._clearShopTypeControls();
            this._setEditableShopTypes(false);
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
            this._setShopTypeDataFromUiToObject(shopType);

            try
            {
                this.dbContext.SaveChanges();
                this.onShopTypeUpdated("ShopTypes", $"Id {shopType.id} updated", DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating shop type.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToComboBoxShopTypeOptionsShopType(BindType.Where, shopType.id);
            this._bindDataToGridViewShopType();
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

            dbContext.ShopType.Remove(shopType);

            try
            {
                dbContext.SaveChanges();
                this.onShopTypeRemoved("ShopTypes", $"Id {shopType.id} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop Type.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToComboBoxShopGroupOptionsShopType(BindType.Setnull);
            this._bindDataToComboBoxShopTypeOptionsShopType(BindType.Setnull);
            this._bindDataToGridViewShopGroup();
            this._bindDataToGridViewShopType();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShopGroupOptionsEdit_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewShopGroups.CurrentRow;
            int groupId = (row == null) ? -1 : Convert.ToInt32(row.Cells["shopGroupId"].Value);

            if (checkBoxShopGroupOptionsEdit.Checked)
                this._bindDataToComboBoxShopGroupOptionsShopType(BindType.Select);
            else
                this._bindDataToComboBoxShopGroupOptionsShopType(BindType.Where, groupId);
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

        public static void _enableDataGridViewMultiSelect(DataGridView gridview, bool enable)
        {
            gridview.MultiSelect = enable;
        }

        private void _bindDataToGridViewShop()
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

        private void _bindDataToGridViewShopGroup()
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

        private void _bindDataToGridViewShopType()
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

        private void _bindDataToComboBoxShopOptionsShopGroup(BindType bindType, int shopGroupId = 0)
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

        private void _bindDataToComboBoxShopGroupOptionsShopType(BindType bindType, int shopTypeId = 0) // When bindType is set to "Where", shopTypeId must be passed.
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

        private void _bindDataToComboBoxShopTypeOptionsShopType(BindType bindType, int shopTypeId = 0) // When bindType is set to "Where", shopTypeId must be passed.
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

        private void _setShopControls(DataGridViewRow row)
        {
            int shopId = Convert.ToInt32(row.Cells["shopId"].Value);
            int shopGroupId = Convert.ToInt32(row.Cells["shopGroupId"].Value);

            this.textBoxShopOptionsShop.Text = row.Cells["shopName"].Value.ToString();
            this.textBoxShopOptionsNickName.Text = (row.Cells["nickname"].Value != null) ? row.Cells["nickname"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsAddress.Text = (row.Cells["address"].Value != null) ? row.Cells["address"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsTel.Text = (row.Cells["tel"].Value != null) ? row.Cells["tel"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsWeb.Text = (row.Cells["web"].Value != null) ? row.Cells["web"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsEmail.Text = (row.Cells["email"].Value != null) ? row.Cells["email"].Value.ToString() : string.Empty;

            this._bindDataToComboBoxShopOptionsShopGroup(BindType.Where, shopGroupId);
            // group için combo ekle: this._bindDataToComboBoxShopGroup(BindType.Where, shopGroupId);
        }

        private void _setShopGroupControls(DataGridViewRow row)
        {
            int shopTypeId = Convert.ToInt32(row.Cells["shopTypeId"].Value);

            this.textBoxShopGroupOptionsGroupName.Text = row.Cells["shopGroupName"].Value.ToString();
            this.textBoxShopGroupOptionsOwner.Text = (row.Cells["shopGroupOwner"].Value != null) ? row.Cells["shopGroupOwner"].Value.ToString() : string.Empty;

            this._bindDataToComboBoxShopGroupOptionsShopType(BindType.Where, shopTypeId);
        }

        private void _setShopTypeControls(DataGridViewRow row)
        {
            int shopTypeId = Convert.ToInt32(row.Cells["shopTypeId"].Value);
            this._bindDataToComboBoxShopTypeOptionsShopType(BindType.Where, shopTypeId);
        }

        private void _setShopDataFromUiToObject(Shop shop)
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

        private void _setShopGroupDataFromUiToObject(ShopGroup shopGroup)
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

        private void _setShopTypeDataFromUiToObject(ShopType shopType)
        {
            if (string.IsNullOrEmpty(this.comboBoxShopTypeOptionsShopType.Text))
            {
                MessageBox.Show("You didn't select shop type.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            shopType.Name = this.comboBoxShopTypeOptionsShopType.Text;
        }

        private void _clearShopControls()
        {
            foreach (Control c in this.groupBoxShopOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _clearShopGroupControls()
        {
            foreach (Control c in this.groupBoxShopGroupOptions.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }
        }

        private void _clearShopTypeControls()
        {
            // ShopType controls don't have any textboxes.
        }

        private void _setEditableShops(bool isEditable)
        {
            this.buttonSaveShop.Enabled = isEditable;
            this.buttonUpdateShop.Enabled = !isEditable;
            this.buttonDeleteShop.Enabled = !isEditable;
        }

        private void _setEditableShopGroups(bool isEditable)
        {
            this.buttonSaveShopGroup.Enabled = isEditable;
            this.buttonUpdateShopGroup.Enabled = !isEditable;
            this.buttonDeleteShopGroup.Enabled = !isEditable;
        }

        private void _setEditableShopTypes(bool isEditable)
        {
            this.buttonSaveShopType.Enabled = isEditable;
            this.buttonUpdateShopType.Enabled = isEditable;
            this.buttonDeleteShopType.Enabled = isEditable;
        }

        private void _setModes(Mode mode)
        {
            this._shopMode = mode;
            this._groupMode = mode;
            this._typeMode = mode;
        }

        private void _checkEditableCheckBoxes(bool check)
        {
            this.checkBoxShopGroupOptionsEdit.Checked = check;
        }

        protected virtual void onShopsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopsLoaded?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopSaved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopSaved?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopUpdated(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopUpdated?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopRemoved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopRemoved?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopGroupSaved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopGroupSaved?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopGroupUpdated(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopGroupUpdated?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopGroupsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopGroupsLoaded?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopGroupRemoved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopGroupRemoved?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopTypeSaved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopTypeSaved?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopTypeUpdated(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopTypeUpdated?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopTypesLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopTypesLoaded?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
        }

        protected virtual void onShopTypeRemoved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.ShopTypeRemoved?.Invoke(actionType, message, eventTime);
            this.onShopChanged(actionType, message, eventTime);
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
    }
}
