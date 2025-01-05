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


        public ShopForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.Shop.GetHicon());

            this.dbContext = new InvoicesEntities();

            this.dataGridViewShops.DataSourceChanged += DataGridViewShops_DataSourceChanged;
            this.dataGridViewShopTypes.DataSourceChanged += DataGridViewShopTypes_DataSourceChanged;
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            //this.onShopFormOpened("Shop Window opened", DateTime.Now);

            _setDefaultGridViewStyles(this.dataGridViewShops);
            _setDefaultGridViewStyles(this.dataGridViewShopTypes);

            _enableDataGridViewMultiSelect(this.dataGridViewShops, false);
            _enableDataGridViewMultiSelect(this.dataGridViewShopTypes, false);


            this._bindDataToGridViewShop();
            this._bindDataToGridViewShopType();

        }

        private void DataGridViewShops_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewShops.DataSource == null)
                return;

            string[] shopsHeaderTexts = new string[] { "shopId", "shopGroupId", "Shop", "Shop's Nickname", "Address", "Tel", "Web", "E-mail" };

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

    }
}
