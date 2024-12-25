﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InvoiceManager_DBFirst
{
    public partial class TactionForm : Form
    {
        enum Mode
        {
            Display,
            Add,
            Edit
        }

        private InvoicesEntities conn;
        private Taction _newTaction;
        private Mode _mode;

        public TactionForm()
        {
            InitializeComponent();

            this.conn = new InvoicesEntities();
            this.dataGridViewTactions.DataSourceChanged += DataGridViewTactions_DataSourceChanged;
            this.dataGridViewTactionDetails.DataSourceChanged += DataGridViewTactionDetails_DataSourceChanged;
        }

        private void TactionForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;

            this._setEditableTactions(false);
            this._setEditableDetails(false);
            this._setReadOnlyTotalPriceField();
            _limitTextBoxCharLength(this.textBoxVat, 2);

            _setDefaultGridViewStyles(this.dataGridViewTactions);
            _setDefaultGridViewStyles(this.dataGridViewTactionDetails);
            
            this._setAutoCompleteTextBoxes();
            this._bindDataToGridViewTaction();
            this._bindDataToComboBoxPaymentMethod();

            this._mode = Mode.Display;
        }

        private void DataGridViewTactions_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewTactions == null)
                return;

            string[] tactionsHeaderTexts = new string[] { "tactionId", "Date", "Shop", "Total Price", "Payment Type", "No", "Seller", "Who did it" };
            int[] tactionsColumnWidths = new int[] { 50, 110, 200, 100, 120, 50, 100, 100 };
            DataGridViewContentAlignment[] tactionsColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft };

            _setDefaultGridViewHeaderStyles(this.dataGridViewTactions, tactionsHeaderTexts, tactionsColumnWidths, tactionsColumnAlignments);

            this.dataGridViewTactions.Columns["tactionId"].Visible = false;
        }

        private void DataGridViewTactionDetails_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewTactionDetails.DataSource == null)
                return;

            string[] detailsHeaderTexts = new string[] { "detailsId", "tactionId", "Group", "Item", "Sub Type", "Unit", "Unit Price", "Vat", "Price", "(*) Rate", "(*) Price", "Note" };
            int[] detailsColumnWidths = new int[] { 50, 110, 115, 220, 115, 70, 85, 50, 70, 80, 80, 80 };
            DataGridViewContentAlignment[] detailsColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft };

            _setDefaultGridViewHeaderStyles(this.dataGridViewTactionDetails, detailsHeaderTexts, detailsColumnWidths, detailsColumnAlignments);

            this.dataGridViewTactionDetails.Columns["detailsId"].Visible = false;
            this.dataGridViewTactionDetails.Columns["tactionId"].Visible = false;
            this.dataGridViewTactionDetails.Columns["note"].Visible = false;
        }

        private void dataGridViewTactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._setEditableTactions(false);
            this._setEditableDetails(false);
            this._checkEditableCheckBoxes(false);

            DataGridViewRow row = this.dataGridViewTactions.CurrentRow;
            int tactionId = Convert.ToInt32(row.Cells["tactionId"].Value);

            this._bindDataToGridViewTactionDetails(tactionId);

            this.dateTimePickerTactionDate.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
            this.textBoxShop.Text = row.Cells["shopName"].Value.ToString();
            this.comboBoxPaymentMethod.Text = row.Cells["paymentName"].Value.ToString();
            this.textBoxTactionNo.Text = (row.Cells["tactionNo"].Value != null) ? row.Cells["tactionNo"].Value.ToString() : string.Empty;
            this.textBoxTotalPrice.Text = row.Cells["totalPrice"].Value.ToString();
        }

        private void dataGridViewTactionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewTactionDetails.CurrentRow;
            this.textBoxItemGroup.Text = row.Cells["itemGroup"].Value.ToString();
            this.textBoxItem.Text = row.Cells["itemName"].Value.ToString();
            this.textBoxItemSubType.Text = row.Cells["itemSubTypeId"].Value.ToString();
            this.textBoxUnit.Text = row.Cells["unit"].Value.ToString();
            this.textBoxUnitPrice.Text = row.Cells["unitPrice"].Value.ToString();
            this.textBoxVat.Text = row.Cells["vat"].Value.ToString();
            this.textBoxDiscountRate.Text = (row.Cells["discountRate"].Value != null) ? row.Cells["discountRate"].Value.ToString() : string.Empty;
            this.textBoxDiscountedPrice.Text = (row.Cells["discountedPrice"].Value != null) ? row.Cells["discountedPrice"].Value.ToString() : string.Empty;

            this.checkBoxDiscount.Checked = (!string.IsNullOrEmpty(this.textBoxDiscountRate.Text) || !string.IsNullOrEmpty(this.textBoxDiscountedPrice.Text));
        }

        private void buttonNewTaction_Click(object sender, EventArgs e)
        {
            this._newTaction = new Taction();
            this._mode = Mode.Add;

            this._setEditableTactions(true);
            this._setEditableDetails(true);
            this._checkEditableCheckBoxes(true);
            this._enableDiscountFields(false);
            this._enableSellerField(false);
            this._clearTactionControls();
            this._clearDetailsControls();
            this.dataGridViewTactionDetails.DataSource = null;
            this.dateTimePickerTactionDate.Value = DateTime.Now;
            this.comboBoxPaymentMethod.Text = string.Empty;
        }

        private void buttonSaveTaction_Click(object sender, EventArgs e)
        {
            if (this._newTaction.TactionDetails.Count == 0) 
            {
                MessageBox.Show("Transaction Details are missing.", "You didn't enter any transaction detail to the list.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (string.IsNullOrEmpty(this.textBoxShop.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter shop.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(this.comboBoxPaymentMethod.Text))
            {
                MessageBox.Show("Missing value.", "You didn't select payment method.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.checkBoxSeller.Checked)
            {
                if (string.IsNullOrEmpty(this.textBoxSeller.Text) )
                {
                    MessageBox.Show("Missing seller value.", "You checked seller option but you didn't enter a seller.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            this._newTaction.Dt = this.dateTimePickerTactionDate.Value;
            this._newTaction.ShopId = conn.Shop.Where(r => r.Name == this.textBoxShop.Text).FirstOrDefault().id;
            this._newTaction.PaymentMethodId = conn.PaymentMethod.Where(r => r.Name == this.comboBoxPaymentMethod.Text).FirstOrDefault().id;


            if (this.checkBoxSeller.Checked) 
                _newTaction.SellerId = conn.Seller.Where(r => r.Name == this.textBoxSeller.Text).FirstOrDefault().id;

            this._newTaction.No = this.textBoxTactionNo.Text;
            this._newTaction.TotalPrice = _newTaction.TactionDetails.Sum(r => r.UnitPrice * r.Unit);

            this.conn.Taction.Add(this._newTaction);

            try
            {
                this.conn.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while adding taction.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearTactionControls();
            this._clearDetailsControls();
            this.dataGridViewTactionDetails.DataSource = null;
            this._newTaction = new Taction();
        }

        private void buttonUpdateTaction_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteTaction_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewTactions.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Row not selected.", "Select the row you want to delete first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int tactionId = Convert.ToInt32(row.Cells["tactionId"].Value);
            var taction = conn.Taction.Where(r => r.id == tactionId).FirstOrDefault();

            try
            {
                var details = taction.TactionDetails.ToList();
                foreach (var detail in details)
                {
                    taction.TactionDetails.Remove(detail);
                    conn.TactionDetails.Remove(detail);
                }

                conn.Taction.Remove(taction);

                this.conn.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while deleting taction.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearTactionControls();
            this._clearDetailsControls();
            this.dataGridViewTactionDetails.DataSource = null;

            this._bindDataToGridViewTaction();
        }

        private void buttonCancelTaction_Click(object sender, EventArgs e)
        {
            this._setEditableTactions(false);
            this._setEditableDetails(false);
            this._checkEditableCheckBoxes(false);
            this._enableDiscountFields(false);
            this._enableSellerField(false);
            this._clearTactionControls();
            this._clearDetailsControls();
            this.dataGridViewTactionDetails.DataSource = null;
            this.comboBoxPaymentMethod.Text = string.Empty;

            this._newTaction = null;
            this._mode = Mode.Display;
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {

            if (!conn.Item.Any(r => r.Name == this.textBoxItem.Text))
            {
                MessageBox.Show("Input doesn't exist.", "The item you entered does not exist in database. Please first save this item to item table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(this.textBoxItemSubType.Text) && !conn.ItemSubType.Any(r => r.Name == this.textBoxItemSubType.Text))
            {
                MessageBox.Show("Input doesn't exist.", "The itemsubtype you entered does not exist in database. Please first save this itemsubtype into itemsubtype table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(this.textBoxUnit.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter unit.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(this.textBoxUnitPrice.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter unit price.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(this.textBoxVat.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter vat.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.checkBoxDiscount.Checked)
            {
                if (string.IsNullOrEmpty(this.textBoxDiscountRate.Text) && string.IsNullOrEmpty(this.textBoxDiscountedPrice.Text))
                {
                    MessageBox.Show("Missing discount value.", "You didn't enter discounted price or discount rate.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (this.checkBoxDiscount.Checked)
            {
                if (!string.IsNullOrEmpty(this.textBoxDiscountRate.Text) && !string.IsNullOrEmpty(this.textBoxDiscountedPrice.Text))
                {
                    MessageBox.Show("Too many values.", "You entered discounted price and discount rate, together. Enter only one of them.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            TactionDetails details = new TactionDetails();

            details.Taction = _newTaction;
            details.ItemId = conn.Item.Where(r => r.Name == this.textBoxItem.Text).FirstOrDefault().id;
            details.ItemSubTypeId = conn.ItemSubType.Where(r => r.Name == this.textBoxItemSubType.Text).FirstOrDefault()?.id;

            details.Unit = Convert.ToDecimal(this.textBoxUnit.Text);
            details.UnitPrice = Convert.ToDecimal(this.textBoxUnitPrice.Text);
            details.Vat = Convert.ToInt32(this.textBoxVat.Text);

            if (checkBoxDiscount.Checked)
            {
                if (!string.IsNullOrEmpty(this.textBoxDiscountRate.Text))
                {
                    details.DiscountRate = Convert.ToDecimal(this.textBoxDiscountRate.Text);

                    details.DiscountedPrice = (1 - details.DiscountRate) * details.UnitPrice;
                    this.textBoxDiscountedPrice.Text = details.DiscountedPrice.ToString();
                }
                else if (!string.IsNullOrEmpty(this.textBoxDiscountedPrice.Text))
                {
                    details.DiscountedPrice = Convert.ToDecimal(this.textBoxDiscountedPrice.Text);

                    details.DiscountRate = 1 - details.DiscountedPrice / details.UnitPrice;
                    this.textBoxDiscountRate.Text = Math.Round(Convert.ToDouble(details.DiscountRate), 2).ToString();
                }
            }

            details.Note = !string.IsNullOrEmpty(this.textBoxDetailsNote.Text) ? this.textBoxDetailsNote.Text : null;

            this._newTaction.TactionDetails.Add(details);
            this._addDetailsToDataGridView();

            textBoxTotalPrice.Text = _newTaction.TactionDetails.Sum(r => r.UnitPrice * r.Unit).ToString();
            //conn.SaveChanges();
        }

        private void buttonUpdateDetail_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveDetail_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxDetailsEditable_CheckedChanged(object sender, EventArgs e)
        {
            this._setEditableDetails(this.checkBoxDetailsEditable.Checked);
            this._enableDiscountFields(this.checkBoxDiscount.Checked);
        }

        private void checkBoxTactionsEditable_CheckedChanged(object sender, EventArgs e)
        {
            this._setEditableTactions(this.checkBoxTactionsEditable.Checked);
            this._enableSellerField(this.checkBoxSeller.Checked);
        }

        private void checkBoxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            this._enableDiscountFields(this.checkBoxDiscount.Checked);
        }

        private void checkBoxSeller_CheckedChanged(object sender, EventArgs e)
        {
            this._enableSellerField(this.checkBoxSeller.Checked);
        }

        private void textBoxUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            this._formatCurrencyTextBox(sender, e);
        }

        private void textBoxUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            this._formatCurrencyTextBox(sender, e);
        }

        private void textBoxVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            this._formatTwoDigitNumericTextBox(sender, e);
        }

        private void textBoxItemGroup_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = null;
            IQueryable<string> query = null;

            if (conn.ItemGroup.Any(r => r.Name == this.textBoxItemGroup.Text))
            {
                query = from item in conn.Item
                        join itemGroup in conn.ItemGroup on item.GroupId equals itemGroup.id
                        where itemGroup.Name == textBoxItemGroup.Text
                        select item.Name;

            }
            else
            {
                query = from item in conn.Item
                        join itemGroup in conn.ItemGroup on item.GroupId equals itemGroup.id
                        select item.Name;
            }

            autoCompleteStringCollection = this._createAutoCompleteStringCollection(query);

            if (autoCompleteStringCollection.Count == 1)
                this.textBoxItem.Text = autoCompleteStringCollection[0];

            this.textBoxItem.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void textBoxItem_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = null;
            IQueryable<string> query = null;

            if (conn.Item.Any(r => r.Name == this.textBoxItem.Text))
            {
                query = from itemGroup in conn.ItemGroup
                        join item in conn.Item on itemGroup.id equals item.GroupId
                        where item.Name == textBoxItem.Text
                        select itemGroup.Name;
            }
            else
            {
                query = from itemGroup in conn.ItemGroup
                        join item in conn.Item on itemGroup.id equals item.GroupId
                        select itemGroup.Name;
            }

            autoCompleteStringCollection = this._createAutoCompleteStringCollection(query);

            if (autoCompleteStringCollection.Count == 1)
                this.textBoxItemGroup.Text = autoCompleteStringCollection[0];

            this.textBoxItemGroup.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void _bindDataToGridViewTaction()
        {
            var query = from taction in conn.Taction
                        join shop in conn.Shop on taction.ShopId equals shop.id
                        join payment in conn.PaymentMethod on taction.PaymentMethodId equals payment.id

                        join seller in conn.Seller on taction.SellerId equals seller.id into sellerJoinTable
                        from sjt in sellerJoinTable.DefaultIfEmpty()
                            //join seller in conn.Seller on taction.SellerId equals seller.id

                        join person in conn.Person on taction.WhoDidIt equals person.id into personJoinTable
                        from pjt in personJoinTable.DefaultIfEmpty()
                            //join person in conn.Person on taction.WhoDidIt equals person.id

                        orderby taction.Dt ascending
                        select new
                        {
                            tactionId = taction.id,
                            date = taction.Dt,
                            shopName = shop.Name,
                            totalPrice = taction.TotalPrice + " TL",
                            paymentName = payment.Name,
                            tactionNo = taction.No,
                            sellerName = sjt.Name,
                            personName = pjt.Name + " " + pjt.Surname
                        };

            this.dataGridViewTactions.DataSource = query.ToList();
        }

        private void _bindDataToGridViewTactionDetails(int tactionId)
        {
            var query = from details in conn.TactionDetails
                        join item in conn.Item on details.ItemId equals item.id
                        join itemGroup in conn.ItemGroup on item.GroupId equals itemGroup.id
                        join itemSubType in conn.ItemSubType on details.ItemSubTypeId equals itemSubType.id into joinTable
                        from jt in joinTable.DefaultIfEmpty()
                        where details.TransactionId == tactionId
                        orderby details.UnitPrice * details.Unit descending
                        select new
                        {
                            detailsId = details.id,
                            tactionId = details.TransactionId,
                            itemGroup = itemGroup.Name,
                            itemName = item.Name,
                            itemSubTypeId = jt != null ? jt.Name : "",
                            unit = details.Unit,
                            unitPrice = details.UnitPrice,
                            vat = details.Vat,
                            price = details.Unit * details.UnitPrice,
                            discountRate = details.DiscountRate,
                            discountedPrice = details.DiscountedPrice,
                            note = details.Note
                        };

            this.dataGridViewTactionDetails.DataSource = query.ToList();
        }

        private void _addDetailsToDataGridView()
        {
            var query = from details in _newTaction.TactionDetails.ToList()
                                                         join item in conn.Item on details.ItemId equals item.id
                                                         join itemGroup in conn.ItemGroup on item.GroupId equals itemGroup.id
                                                         join itemSubType in conn.ItemSubType on details.ItemSubTypeId equals itemSubType.id into joinTable
                                                         from jt in joinTable.DefaultIfEmpty()
                                                         orderby details.UnitPrice * details.Unit descending
                                                         select new
                                                         {
                                                             detailsId = details.id,
                                                             tactionId = details.TransactionId,
                                                             itemGroup = itemGroup.Name,
                                                             itemName = item.Name,
                                                             itemSubTypeId = jt != null ? jt.Name : "",
                                                             unit = details.Unit,
                                                             unitPrice = details.UnitPrice,
                                                             vat = details.Vat,
                                                             price = details.Unit * details.UnitPrice,
                                                             discountRate = details.DiscountRate,
                                                             discountedPrice = details.DiscountedPrice,
                                                             note = details.Note
                                                         };

            this.dataGridViewTactionDetails.DataSource = query.ToList();
        }

        private void _bindDataToComboBoxPaymentMethod()
        {
            var query = from payment in conn.PaymentMethod
                        select payment;

            this.comboBoxPaymentMethod.DataSource = query.ToList();
            this.comboBoxPaymentMethod.DisplayMember = "Name";
            this.comboBoxPaymentMethod.ValueMember = "id";
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

            gridview.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.5f , FontStyle.Bold);
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

        private void _setAutoCompleteTextBoxes()
        {
            this.textBoxShop.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBoxSeller.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBoxItemGroup.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBoxItem.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBoxItemSubType.AutoCompleteMode = AutoCompleteMode.Suggest;

            this.textBoxShop.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxSeller.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxItemGroup.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxItemSubType.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var shopNameQuery = from shop in conn.Shop
                                select shop.Name;

            var sellerNameQuery = from seller in conn.Seller
                                  select seller.Name;

            var itemGroupNameQuery = from itemGroup in conn.ItemGroup
                                     select itemGroup.Name;

            var itemNameQuery = from item in conn.Item
                                select item.Name;

            var itemSubTypeNameQuery = from itemSubType in conn.ItemSubType
                                       select itemSubType.Name;

            AutoCompleteStringCollection shopNameCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection sellerNameCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection itemGroupNameCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection itemNameCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection itemSubTypeNameCollection = new AutoCompleteStringCollection();

            foreach (var shopName in shopNameQuery)
                shopNameCollection.Add(shopName);

            foreach (var sellerName in sellerNameQuery)
                sellerNameCollection.Add(sellerName);

            foreach (var itemGroupName in itemGroupNameQuery)
                itemGroupNameCollection.Add(itemGroupName);

            foreach (var itemName in itemNameQuery)
                itemNameCollection.Add(itemName);

            foreach (var itemSubTypeName in itemSubTypeNameQuery)
                itemSubTypeNameCollection.Add(itemSubTypeName);

            this.textBoxShop.AutoCompleteCustomSource = shopNameCollection;
            this.textBoxSeller.AutoCompleteCustomSource = sellerNameCollection;
            this.textBoxItemGroup.AutoCompleteCustomSource = itemGroupNameCollection;
            this.textBoxItem.AutoCompleteCustomSource = itemNameCollection;
            this.textBoxItemSubType.AutoCompleteCustomSource = itemSubTypeNameCollection;
        }

        private void _setEditableDetails(bool isEditable)
        {
            this.buttonAddDetail.Enabled = isEditable;
            this.buttonUpdateDetail.Enabled = isEditable;
            this.buttonRemoveDetail.Enabled = isEditable;
            this.checkBoxDiscount.Enabled = isEditable;
            this.textBoxItemGroup.ReadOnly = !isEditable;
            this.textBoxItem.ReadOnly = !isEditable;
            this.textBoxItemSubType.ReadOnly = !isEditable;
            this.textBoxUnit.ReadOnly = !isEditable;
            this.textBoxUnitPrice.ReadOnly = !isEditable;
            this.textBoxVat.ReadOnly = !isEditable;
            this.textBoxDiscountRate.ReadOnly = !isEditable;
            this.textBoxDiscountedPrice.ReadOnly = !isEditable;
            this.textBoxDetailsNote.ReadOnly = !isEditable;
        }

        private void _setEditableTactions(bool isEditable)
        {
            this.dataGridViewTactions.Enabled = !isEditable;
            this.buttonSaveTaction.Enabled = isEditable;
            this.buttonUpdateTaction.Enabled = isEditable;
            this.buttonCancelTaction.Enabled = isEditable;
            this.dateTimePickerTactionDate.Enabled = isEditable;
            this.textBoxShop.ReadOnly = !isEditable;
            this.comboBoxPaymentMethod.Enabled = isEditable;
            this.checkBoxSeller.Enabled = isEditable;
            this.textBoxSeller.ReadOnly = !isEditable;
            this.textBoxTactionNo.ReadOnly = !isEditable;
        }

        private static void _limitTextBoxCharLength(TextBox textBox, int maxLength)
        {
            textBox.MaxLength = maxLength;
        }

        private void _clearTactionControls()
        {
            foreach (Control c in this.groupBoxTactionOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();

            foreach (Control c in this.groupBoxTactionOptions.Controls)
                if (c is ComboBox)
                    ((ComboBox)c).Text = string.Empty;
        }

        private void _clearDetailsControls()
        {
            foreach (Control c in this.groupBoxTactionDetailsOptions.Controls)
                if (c is TextBox) 
                    ((TextBox)c).Clear(); 
        }

        private void _enableDiscountFields(bool enable)
        {
            this.textBoxDiscountRate.Enabled = enable;
            this.textBoxDiscountedPrice.Enabled = enable;
        }

        private void _enableSellerField(bool enable)
        {
            this.textBoxSeller.Enabled = enable;
        }

        private void _checkEditableCheckBoxes(bool check)
        {
            this.checkBoxTactionsEditable.Checked = check;
            this.checkBoxDetailsEditable.Checked = check;
        }

        private void _setReadOnlyTotalPriceField()
        {
            this.textBoxTotalPrice.ReadOnly = true;
        }

        private void _formatCurrencyTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            /* Allow only one decimal point. Block others */
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        private void _formatTwoDigitNumericTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private AutoCompleteStringCollection _createAutoCompleteStringCollection(IQueryable<string> query)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();

            foreach (var item in query)
                autoCompleteStringCollection.Add(item);

            return autoCompleteStringCollection;
        }
    }
}
