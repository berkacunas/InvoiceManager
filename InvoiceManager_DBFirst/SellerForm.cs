using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst
{
    public partial class SellerForm : Form
    {
        public event Notify SellersLoaded;
        public event Notify SellerSaved;
        public event Notify SellerUpdated;
        public event Notify SellerRemoved;

        public event Notify SellerGroupsLoaded;
        public event Notify SellerGroupSaved;
        public event Notify SellerGroupUpdated;
        public event Notify SellerGroupRemoved;

        public event Notify SellerTypesLoaded;
        public event Notify SellerTypeSaved;
        public event Notify SellerTypeUpdated;
        public event Notify SellerTypeRemoved;

        public event Notify SellerChanged;
        public event Notify SellerFormOpened;
        public event Notify SellerFormClosed;

        private InvoicesEntities dbContext;

        private Seller _newSeller;

        private Mode _sellerMode;

        private ColumnSortOrder[] _sortOrdersDataGridViewSellers = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };

        public SellerForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.Seller.GetHicon());

            this.dbContext = new InvoicesEntities();

            this.FormClosing += SellerForm_FormClosing;
            this.dataGridViewSellers.CellClick += DataGridViewSellers_CellClick;
            this.dataGridViewSellers.DataSourceChanged += DataGridViewSellers_DataSourceChanged;
            this.dataGridViewSellers.DataBindingComplete += DataGridViewSellers_DataBindingComplete;

        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            this._setModes(Mode.Display);

            _setDefaultGridViewStyles(this.dataGridViewSellers);

            _enableDataGridViewMultiSelect(this.dataGridViewSellers, false);

            this._bindDataToGridViewSellers();

            this.onSellerFormOpened("Shops", "Window opened", DateTime.Now);
        }

        private void DataGridViewSellers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewSellers.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewSellers.Rows[0];
                if (row != null)
                    this._setSellerControls(row);
            }
        }

        private void DataGridViewSellers_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewSellers.DataSource == null)
                return;

            string[] headerTexts = new string[] { "sellerId", "Seller", "Address", "Tel", "Web", "Email" };

            int[] columnWidths = new int[] { 50, 230, 50, 115, 179, 50 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft};

            _setDefaultGridViewHeaderStyles(this.dataGridViewSellers, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewSellers.Columns["sellerId"].Visible = false;
            this.dataGridViewSellers.Columns["Address"].Visible = false;
            this.dataGridViewSellers.Columns["Email"].Visible = false;
        }

        private void DataGridViewSellers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearSellerControls();
            DataGridViewRow row = this.dataGridViewSellers.CurrentRow;
            this._setSellerControls(row);
        }

        private void _bindDataToGridViewSellers()
        {
            var query = from seller in dbContext.Seller
                        orderby seller.Name ascending
                        select new
                        {
                            sellerId = seller.id,
                            sellerName = seller.Name,
                            address = seller.Address,
                            tel = seller.Tel,
                            web = seller.Web,
                            email = seller.Email
                        };

            this.dataGridViewSellers.DataSource = query.ToList();
            this.dataGridViewSellers.Refresh();
            this.onSellersLoaded("Sellers", "Seller data loaded", DateTime.Now);
        }

        private void _setSellerControls(DataGridViewRow row)
        {
            int sellerId = Convert.ToInt32(row.Cells["sellerId"].Value);
            
            this.textBoxSellerOptionsSeller.Text = row.Cells["sellerName"].Value.ToString();
            this.textBoxSellerOptionsAddress.Text = (row.Cells["Address"].Value != null) ? row.Cells["Address"].Value.ToString() : string.Empty;
            this.textBoxSellerOptionsTel.Text = (row.Cells["Tel"].Value != null) ? row.Cells["Tel"].Value.ToString() : string.Empty;
            this.textBoxSellerOptionsWeb.Text = (row.Cells["Web"].Value != null) ? row.Cells["Web"].Value.ToString() : string.Empty;
            this.textBoxSellerOptionsEmail.Text = (row.Cells["Email"].Value != null) ? row.Cells["Email"].Value.ToString() : string.Empty;
        }

        private void _setSellerDataFromUiToObject(Seller seller)
        {
            if (string.IsNullOrEmpty(this.textBoxSellerOptionsSeller.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter Seller.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            seller.Name = this.textBoxSellerOptionsSeller.Text;
            seller.Address = this.textBoxSellerOptionsAddress.Text;
            seller.Tel = this.textBoxSellerOptionsTel.Text;
            seller.Web = this.textBoxSellerOptionsWeb.Text;
            seller.Email = this.textBoxSellerOptionsEmail.Text;
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

        private void _clearSellerControls()
        {
            foreach (Control c in this.groupBoxSellerOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _setEditableSellers(bool isEditable)
        {
            this.buttonSaveSeller.Enabled = isEditable;
            this.buttonUpdateSeller.Enabled = !isEditable;
            this.buttonDeleteSeller.Enabled = !isEditable;
        }


        private void _setModes(Mode mode)
        {
            this._sellerMode = mode;
        }




        protected virtual void onSellersLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.SellersLoaded?.Invoke(actionType, message, eventTime);
            this.onSellerChanged(actionType, message, eventTime);
        }

        protected virtual void onSellerSaved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.SellerSaved?.Invoke(actionType, message, eventTime);
            this.onSellerChanged(actionType, message, eventTime);
        }

        protected virtual void onSellerUpdated(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.SellerUpdated?.Invoke(actionType, message, eventTime);
            this.onSellerChanged(actionType, message, eventTime);
        }

        protected virtual void onSellerRemoved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.SellerRemoved?.Invoke(actionType, message, eventTime);
            this.onSellerChanged(actionType, message, eventTime);
        }

        protected virtual void onSellerChanged(string actionType, string message, DateTime eventTime)
        {
            this.SellerChanged?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onSellerFormOpened(string actionType, string message, DateTime eventTime)
        {
            this.SellerFormOpened?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onSellerFormClosed(string actionType, string message, DateTime eventTime)
        {
            this.SellerFormClosed?.Invoke(actionType, message, eventTime);
        }

        private void SellerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    this.onSellerFormClosed("Sellers", "Window closed by user", DateTime.Now);
                    break;

                case CloseReason.WindowsShutDown:
                    this.onSellerFormClosed("Sellers", "Window closed as a part of Windows Shutdown", DateTime.Now);
                    break;

                case CloseReason.TaskManagerClosing:
                    this.onSellerFormClosed("Sellers", "Window closed forcibly by Task Manager", DateTime.Now);
                    break;

                case CloseReason.FormOwnerClosing:
                    this.onSellerFormClosed("Sellers", "Window closed by Form Owner", DateTime.Now);
                    break;

                default:
                    this.onSellerFormClosed("Sellers", "Window closed with an unknown reasoun", DateTime.Now);
                    break;

            }
        }

        private void buttonNewSeller_Click(object sender, EventArgs e)
        {
            this._sellerMode = (this._sellerMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewSeller.Text = (this._sellerMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewSellers.Enabled = (this._sellerMode != Mode.Add);

            if (this._sellerMode == Mode.Add)
            {
                this._setEditableSellers(true);
                this._newSeller = new Seller();
            }
            else
            {
                this._setEditableSellers(false);
            }

            this._clearSellerControls();
        }

        private void buttonSaveSeller_Click(object sender, EventArgs e)
        {
            this._setSellerDataFromUiToObject(this._newSeller);
            this.dbContext.Seller.Add(this._newSeller);

            try
            {
                this.dbContext.SaveChanges();
                this.onSellerSaved("Sellers", $"New seller added: {_newSeller.Name}", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding seller.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearSellerControls();
            this._setEditableSellers(false);
            this._bindDataToGridViewSellers();
            this._newSeller = new Seller();
            this._sellerMode = Mode.Display;
        }

        private void buttonUpdateSeller_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewSellers.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sellerId = Convert.ToInt32(row.Cells["sellerId"].Value);
            Seller seller = dbContext.Seller.Where(r => r.id == sellerId).FirstOrDefault();

            this._setSellerDataFromUiToObject(seller);

            try
            {
                this.dbContext.SaveChanges();
                this.onSellerUpdated("Sellers", $"Id {seller.id} updated", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating seller.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewSellers();
        }

        private void buttonDeleteSeller_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewSellers.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to delete first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sellerId = Convert.ToInt32(row.Cells["sellerId"].Value);
            Seller seller = this.dbContext.Seller.Where(r => r.id == sellerId).FirstOrDefault();




            var tactionsToUpdateQuery = from taction in dbContext.Taction
                                     join s in dbContext.Seller on taction.SellerId equals s.id
                                     where s.id == sellerId
                                        select taction;

            List<Taction> tactionsToUpdate = tactionsToUpdateQuery.ToList();

            if (tactionsToUpdate.Count > 0)
            {
                string message = $"You should change or delete tactions associated with Seller: {seller.Name} first before deleting this seller.\n\nThis taction ids are:\n";

                foreach (Taction taction in tactionsToUpdate)
                    message += $"Taction id: {taction.id}\n";
                
                message = message.Remove(message.Length - 1, 1);

                MessageBox.Show(message, "Unable to delete seller", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            this.dbContext.Seller.Remove(seller);

            try
            {
                this.dbContext.SaveChanges();
                this.onSellerRemoved("Sellers", $"Seller {seller.Name} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewSellers();
        }

    }
}
