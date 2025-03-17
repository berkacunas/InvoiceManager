using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst.UserControls
{
    public partial class SellerUserControl : UserControl
    {
        public event Notify SellersLoaded;
        public event Notify SellerSaved;
        public event Notify SellerUpdated;
        public event Notify SellerRemoved;

        public event Notify SellerChanged;
        public event Notify SellerFormOpened;
        public event Notify SellerFormClosed;

        private InvoicesEntities dbContext;

        private Seller _newSeller;

        private Mode _sellerMode;

        private List<ColumnSortOrder[]> _columnSortOrdersSellers = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        public SellerUserControl()
        {
            InitializeComponent();

            this.Load += sellerUserControl_Load;

            this.dbContext = new InvoicesEntities();

            this.dataGridViewSellers.DataBindingComplete += dataGridViewSellers_DataBindingComplete;
            this.dataGridViewSellers.DataSourceChanged += dataGridViewSellers_DataSourceChanged;
            this.dataGridViewSellers.CellClick += dataGridViewSellers_CellClick;
            this.dataGridViewSellers.ColumnHeaderMouseClick += dataGridViewSellers_ColumnHeaderMouseClick;

            this.buttonNewSeller.Click += buttonNewSeller_Click;
            this.buttonSaveSeller.Click += buttonSaveSeller_Click;
            this.buttonUpdateSeller.Click += buttonUpdateSeller_Click;
            this.buttonDeleteSeller.Click += buttonDeleteSeller_Click;
        }

        #region Event Handlers

        private void sellerUserControl_Load(object sender, EventArgs e)
        {
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewSellers);
            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewSellers, false);

            this.setModes(Mode.Display);
            this.bindDataToGridViewSellers();

            this.onSellerFormOpened("Sellers", "Window opened", DateTime.Now);
        }

        private void dataGridViewSellers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewSellers.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewSellers.Rows[0];
                if (row != null)
                    this.setSellerControls(row);
            }
        }

        private void dataGridViewSellers_DataSourceChanged(object sender, EventArgs e)
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

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewSellers, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewSellers.Columns["sellerId"].Visible = false;
            this.dataGridViewSellers.Columns["Address"].Visible = false;
            this.dataGridViewSellers.Columns["Email"].Visible = false;
        }

        private void dataGridViewSellers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearSellerControls();
            DataGridViewRow row = this.dataGridViewSellers.CurrentRow;
            this.setSellerControls(row);
        }

        private void dataGridViewSellers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewSellers.Columns[e.ColumnIndex].HeaderText;

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

            switch (columnName)
            {
                case "Seller":
                    this.dataGridViewSellers.DataSource = (this._columnSortOrdersSellers[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.sellerName).ToList() : query.OrderByDescending(r => r.sellerName).ToList();
                    this._columnSortOrdersSellers[0][0] = (this._columnSortOrdersSellers[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Tel":
                    this.dataGridViewSellers.DataSource = (this._columnSortOrdersSellers[1][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.tel).ToList() : query.OrderByDescending(r => r.tel).ToList();
                    this._columnSortOrdersSellers[1][0] = (this._columnSortOrdersSellers[1][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
                case "Web":
                    this.dataGridViewSellers.DataSource = (this._columnSortOrdersSellers[2][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.web).ToList() : query.OrderByDescending(r => r.web).ToList();
                    this._columnSortOrdersSellers[2][0] = (this._columnSortOrdersSellers[2][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
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
                this.setEditableSellers(true);
                this._newSeller = new Seller();
            }
            else
            {
                this.setEditableSellers(false);
            }

            this.clearSellerControls();
        }

        private void buttonSaveSeller_Click(object sender, EventArgs e)
        {
            this.setSellerDataFromUiToObject(this._newSeller);
            this.dbContext.Seller.Add(this._newSeller);

            try
            {
                this.dbContext.SaveChanges();
                this.onSellerSaved("Sellers", $"New seller {_newSeller.id}: {_newSeller.Name} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding seller.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.clearSellerControls();
            this.setEditableSellers(false);
            this.bindDataToGridViewSellers();
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

            this.setSellerDataFromUiToObject(seller);

            try
            {
                this.dbContext.SaveChanges();
                this.onSellerUpdated("Sellers", $"Seller {seller.id}: {seller.Name} updated", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating seller.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToGridViewSellers();
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
                this.onSellerRemoved("Sellers", $"Seller {seller.id}: {seller.Name} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting shop.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToGridViewSellers();
        }

        #endregion

        #region Databind Queries

        private void bindDataToGridViewSellers()
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

        #endregion

        #region Set data to Controls

        private void setSellerControls(DataGridViewRow row)
        {
            int sellerId = Convert.ToInt32(row.Cells["sellerId"].Value);

            this.textBoxSellerOptionsSeller.Text = row.Cells["sellerName"].Value.ToString();
            this.textBoxSellerOptionsAddress.Text = (row.Cells["Address"].Value != null) ? row.Cells["Address"].Value.ToString() : string.Empty;
            this.textBoxSellerOptionsTel.Text = (row.Cells["Tel"].Value != null) ? row.Cells["Tel"].Value.ToString() : string.Empty;
            this.textBoxSellerOptionsWeb.Text = (row.Cells["Web"].Value != null) ? row.Cells["Web"].Value.ToString() : string.Empty;
            this.textBoxSellerOptionsEmail.Text = (row.Cells["Email"].Value != null) ? row.Cells["Email"].Value.ToString() : string.Empty;
        }

        #endregion

        #region Get data from Controls

        private void setSellerDataFromUiToObject(Seller seller)
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


        #endregion

        #region Set Enabled & Checked & Read-only Controls

        private void setEditableSellers(bool isEditable)
        {
            this.buttonSaveSeller.Enabled = isEditable;
            this.buttonUpdateSeller.Enabled = !isEditable;
            this.buttonDeleteSeller.Enabled = !isEditable;
        }

        private void setModes(Mode mode)
        {
            this._sellerMode = mode;
        }

        #endregion

        #region Clear Controls

        private void clearSellerControls()
        {
            foreach (Control c in this.groupBoxSellerOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        #endregion

        #region User-defined Event Handlers

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

        #endregion
    }
}
