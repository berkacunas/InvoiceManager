using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    public partial class ShopForm : Form
    {
        enum Mode
        {
            Display,
            Add,
            Edit,
            Search
        }

        enum BindType
        {
            Select,
            Where,
            Setnull
        }

        private InvoicesEntities dbContext;

        private Shop _newShop;
        private ShopGroup _newShopGroup;
        private ShopType _newShopType;

        private Mode _shopMode;
        private Mode _shopGroupMode;
        private Mode _shopTypeMode;


        public ShopForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.Shop.GetHicon());

            this.dbContext = new InvoicesEntities();

            this.dataGridViewShops.DataSourceChanged += DataGridViewShops_DataSourceChanged;
            this.dataGridViewShopGroups.DataSourceChanged += DataGridViewShopGroups_DataSourceChanged;
            this.dataGridViewShopTypes.DataSourceChanged += DataGridViewShopTypes_DataSourceChanged;
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            this._setModes(Mode.Display);

            //this.onShopFormOpened("Shop Window opened", DateTime.Now);

            _setDefaultGridViewStyles(this.dataGridViewShops);
            _setDefaultGridViewStyles(this.dataGridViewShopGroups);
            _setDefaultGridViewStyles(this.dataGridViewShopTypes);

            _enableDataGridViewMultiSelect(this.dataGridViewShops, false);
            _enableDataGridViewMultiSelect(this.dataGridViewShopGroups, false);
            _enableDataGridViewMultiSelect(this.dataGridViewShopTypes, false);

            this.comboBoxShopTypeOptionsShopType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxShopGroupOptionsShopType.DropDownStyle = ComboBoxStyle.DropDownList;

            this._bindDataToGridViewShop();
            this._bindDataToGridViewShopGroups();
            this._bindDataToGridViewShopType();
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
        }

        private void dataGridViewShopTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearShopTypeControls();
            DataGridViewRow row = this.dataGridViewShopTypes.CurrentRow;
            this._setShopTypeControls(row);
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
            //this.onShopsLoaded("Shops Loaded", DateTime.Now);
        }

        private void _bindDataToGridViewShopGroups()
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
            //this.onShopGroupsLoaded("ShopGroups Loaded", DateTime.Now);
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

            this.textBoxShopOptionsShopName.Text = row.Cells["shopName"].Value.ToString();
            this.textBoxShopOptionsNickName.Text = (row.Cells["nickname"].Value != null) ? row.Cells["nickname"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsAddress.Text = (row.Cells["address"].Value != null) ? row.Cells["address"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsTel.Text = (row.Cells["tel"].Value != null) ? row.Cells["tel"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsWeb.Text = (row.Cells["web"].Value != null) ? row.Cells["web"].Value.ToString() : string.Empty;
            this.textBoxShopOptionsEmail.Text = (row.Cells["email"].Value != null) ? row.Cells["email"].Value.ToString() : string.Empty;

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
            this._bindDataToComboBoxShopGroupOptionsShopType(BindType.Where, shopTypeId);
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
         
            this._bindDataToComboBoxShopGroupOptionsShopType(BindType.Setnull);
        }

        private void _clearShopTypeControls()
        {
            this._bindDataToComboBoxShopTypeOptionsShopType(BindType.Setnull);
        }

        private void _setModes(Mode mode)
        {
            this._shopMode = mode;
            this._shopGroupMode = mode;
            this._shopTypeMode = mode;
        }

        private void buttonNewShop_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveShop_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateShop_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteShop_Click(object sender, EventArgs e)
        {

        }
    }
}
