﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst.UserControls
{
    public partial class TactionUserControl : UserControl
    {
        public event Notify TransactionsLoad;
        public event Notify TransactionFormOpened;
        public event Notify TransactionFormClosed;

        public event Notify TransactionChanged;

        public event TactionHandler TransactionSave;
        public event TactionUpdateHandler TransactionUpdate;
        public event TactionHandler TransactionRemove;

        private ImageList _imageList;

        private InvoicesEntities dbContext;
        private Taction _newTaction;
        private Mode _mode;

        public TactionUserControl()
        {
            InitializeComponent();

            this.createContextMenu();
            this.createImageList();

            this.dbContext = new InvoicesEntities();

            this.Load += tactionUserControl_Load;

            this.dataGridViewTactions.DataBindingComplete += dataGridViewTactions_DataBindingComplete;
            this.dataGridViewTactions.DataSourceChanged += dataGridViewTactions_DataSourceChanged;
            this.dataGridViewTactions.CellClick += dataGridViewTactions_CellClick;

            this.dataGridViewTactionDetails.DataBindingComplete += dataGridViewTactionDetails_DataBindingComplete;
            this.dataGridViewTactionDetails.DataSourceChanged += dataGridViewTactionDetails_DataSourceChanged;
            this.dataGridViewTactionDetails.CellClick += dataGridViewTactionDetails_CellClick;

            this.buttonNewTaction.Click += buttonNewTaction_Click;
            this.buttonSaveTaction.Click += buttonSaveTaction_Click;
            this.buttonUpdateTaction.Click += buttonUpdateTaction_Click;
            this.buttonDeleteTaction.Click += buttonDeleteTaction_Click;
            this.buttonCancelTaction.Click += buttonCancelTaction_Click;

            this.buttonAddDetail.Click += buttonAddDetail_Click;
            this.buttonUpdateDetail.Click += buttonUpdateDetail_Click;
            this.buttonRemoveDetail.Click += buttonRemoveDetail_Click;
            this.buttonClearDetail.Click += buttonClearDetail_Click;

            this.buttonAdviceLastUnitPrice.Click += buttonAdviceLastUnitPrice_Click;

            this.checkBoxDetailsEditable.CheckedChanged += checkBoxDetailsEditable_CheckedChanged;
            this.checkBoxTactionsEditable.CheckedChanged += checkBoxTactionsEditable_CheckedChanged;
            this.checkBoxDiscount.CheckedChanged += checkBoxDiscount_CheckedChanged;
            this.checkBoxSeller.CheckedChanged += checkBoxSeller_CheckedChanged;

            this.textBoxUnit.KeyPress += textBoxUnit_KeyPress;
            this.textBoxUnitPrice.KeyPress += textBoxUnitPrice_KeyPress;
            this.textBoxVat.KeyPress += textBoxVat_KeyPress;

            this.textBoxItemGroup.Leave += textBoxItemGroup_Leave;
            this.textBoxItem.Leave += textBoxItem_Leave;
        }

        #region Event Handlers

        private void tactionUserControl_Load(object sender, EventArgs e)
        {
            this.setEditableTactions(false);
            this.setEditableDetails(false);
            this.setReadOnlyTotalPriceField();
            this.setReadOnlyTotalVatPriceField();
            limitTextBoxCharLength(this.textBoxVat, 2);

            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewTactions);
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewTactionDetails);
            setButtonImages(buttonAdviceLastUnitPrice, _imageList, "QuestionMark", Color.White, Color.FromArgb(70, 70, 70), FlatStyle.Flat, 0);

            this.comboBoxPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxOwner.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxItemSubType.DropDownStyle = ComboBoxStyle.DropDownList;

            this.setAutoCompleteTextBoxes();
            this.bindDataToGridViewTaction();

            this._mode = Mode.Display;

            this.dateTimePickerTactionDate.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerTactionDate.ShowUpDown = true;
            this.dateTimePickerTactionDate.CustomFormat = "dd.MM.yyyy dddd HH:mm";

            this.onTransactionFormOpened("Transactions", "Window opened", DateTime.Now);
        }

        private void dataGridViewTactions_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewTactions.DataSource == null)
                return;

            string[] tactionsHeaderTexts = new string[] { "tactionId", "paymentId", "ownerId", "Date", "Shop", "Total Price", "Payment Type", "No", "Seller", "Who did it" };
            int[] tactionsColumnWidths = new int[] { 50, 50, 50, 110, 200, 100, 120, 50, 100, 100 };
            DataGridViewContentAlignment[] tactionsColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft };

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewTactions, tactionsHeaderTexts, tactionsColumnWidths, tactionsColumnAlignments);

            this.dataGridViewTactions.Columns["tactionId"].Visible = false;
            this.dataGridViewTactions.Columns["paymentId"].Visible = false;
            this.dataGridViewTactions.Columns["ownerId"].Visible = false;
        }

        private void dataGridViewTactionDetails_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewTactionDetails.DataSource == null)
                return;

            string[] detailsHeaderTexts = new string[] { "detailsId", "tactionId", "itemId", "itemSubTypeId", "Group", "Item", "Sub Type", "Unit", "Unit Price", "Vat", "Price", "(*) Rate", "(*) Price", "Note" };
            int[] detailsColumnWidths = new int[] { 50, 50, 50, 50, 115, 220, 115, 70, 85, 50, 70, 80, 80, 80 };
            DataGridViewContentAlignment[] detailsColumnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleRight,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft };

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewTactionDetails, detailsHeaderTexts, detailsColumnWidths, detailsColumnAlignments);

            this.dataGridViewTactionDetails.Columns["detailsId"].Visible = false;
            this.dataGridViewTactionDetails.Columns["tactionId"].Visible = false;
            this.dataGridViewTactionDetails.Columns["itemId"].Visible = false;
            this.dataGridViewTactionDetails.Columns["itemSubTypeId"].Visible = false;
            this.dataGridViewTactionDetails.Columns["note"].Visible = false;
        }

        private void dataGridViewTactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.setEditableTactions(false);
            this.setEditableDetails(false);
            this.checkEditableCheckBoxes(false);

            DataGridViewRow row = this.dataGridViewTactions.CurrentRow;
            int tactionId = this.setTactionControls(row);
            this.bindDataToGridViewTactionDetails(tactionId);
        }

        private void dataGridViewTactionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewTactionDetails.CurrentRow;
            this.setTactionDetailsControls(row);
        }

        private void dataGridViewTactions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewTactions.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewTactions.Rows[0];
                if (row != null)
                {
                    int tactionId = this.setTactionControls(row);
                    this.bindDataToGridViewTactionDetails(tactionId);
                }
            }
        }

        private void dataGridViewTactionDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewTactionDetails.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewTactionDetails.Rows[0];
                if (row != null)
                    this.setTactionDetailsControls(row);
            }
        }

        private void buttonNewTaction_Click(object sender, EventArgs e)
        {
            this._newTaction = new Taction();
            this._mode = Mode.Add;

            this.setEditableTactions(true);
            this.setEditableDetails(true);
            this.checkEditableCheckBoxes(true);
            this.enableDiscountFields(false);
            this.enableSellerField(false);
            this.clearTactionControls();
            this.clearDetailsControls();
            this.dataGridViewTactionDetails.DataSource = null;
            this.dateTimePickerTactionDate.Value = DateTime.Now;

            this.bindDataToComboBoxPaymentMethod(BindType.Select);
            this.bindDataToComboBoxOwner(BindType.Select);
        }

        private void buttonSaveTaction_Click(object sender, EventArgs e)
        {
            this.setTactionDataFromUiToObject(this._newTaction);
            this.dbContext.Taction.Add(this._newTaction);

            try
            {
                this.dbContext.SaveChanges();
                this.onTransactionSaved(this._newTaction);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding taction.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.clearTactionControls();
            this.clearDetailsControls();
            this.dataGridViewTactionDetails.DataSource = null;
            this.bindDataToGridViewTaction();
            this._newTaction = new Taction();
        }

        private void buttonUpdateTaction_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewTactions.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Row not selected.", "Select the row you want to update first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tactionId = Convert.ToInt32(row.Cells["tactionId"].Value);
            Taction taction = dbContext.Taction.Where(r => r.id == tactionId).Include(r => r.TactionDetails).FirstOrDefault();
            Taction oldTaction = dbContext.Taction.Where(r => r.id == tactionId).Include(r => r.TactionDetails).AsNoTracking().FirstOrDefault();

            if (taction.TactionDetails.Count == 0)
            {
                MessageBox.Show("Transaction Details are missing.", "You didn't enter any transaction detail to the list.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.setTactionDataFromUiToObject(taction);

            try
            {
                this.dbContext.SaveChanges();
                this.onTransactionUpdated(taction, oldTaction);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating taction.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.bindDataToGridViewTaction();
        }

        private void buttonDeleteTaction_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewTactions.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Row not selected.", "Select the row you want to delete first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tactionId = Convert.ToInt32(row.Cells["tactionId"].Value);
            var taction = dbContext.Taction.Where(r => r.id == tactionId).FirstOrDefault();

            this.onTransactionRemoved(taction);

            try
            {
                var details = taction.TactionDetails.ToList();
                foreach (var detail in details)
                {
                    taction.TactionDetails.Remove(detail);
                    dbContext.TactionDetails.Remove(detail);
                }

                dbContext.Taction.Remove(taction);
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting taction.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.clearTactionControls();
            this.clearDetailsControls();
            this.dataGridViewTactionDetails.DataSource = null;

            this.bindDataToGridViewTaction();
        }

        private void buttonCancelTaction_Click(object sender, EventArgs e)
        {
            this.setEditableTactions(false);
            this.setEditableDetails(false);
            this.checkEditableCheckBoxes(false);
            this.enableDiscountFields(false);
            this.enableSellerField(false);
            this.clearTactionControls();
            this.clearDetailsControls();
            this.dataGridViewTactionDetails.DataSource = null;

            this.bindDataToComboBoxPaymentMethod(BindType.Setnull);
            this.bindDataToComboBoxOwner(BindType.Setnull);

            this._newTaction = null;
            this._mode = Mode.Display;
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            TactionDetails details = new TactionDetails();
            if (!this.setTactionDetailsDataFromUiToObject(details))
                return;

            this._newTaction.TactionDetails.Add(details);
            this.updateDataGridViewTactionDetails();
            this.clearDetailsControls();
            this.setTactionTotalPrice(this._newTaction);
        }

        private void buttonUpdateDetail_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewTactionDetails.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Row not selected.", "Select the row you want to update first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int detailsId = Convert.ToInt32(row.Cells["detailsId"].Value);
            int tactionId = Convert.ToInt32(row.Cells["tactionId"].Value);
            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);

            decimal unit = Convert.ToDecimal(row.Cells["unit"].Value);
            decimal unitPrice = Convert.ToDecimal(row.Cells["unitPrice"].Value);
            decimal vat = Convert.ToDecimal(row.Cells["vat"].Value);

            TactionDetails details = null;

            if (this.dbContext.TactionDetails.Count(r => r.id == detailsId) > 0)
            {
                details = this.dbContext.TactionDetails.Where(r => r.id == detailsId).FirstOrDefault();
                if (!this.setTactionDetailsDataFromUiToObject(details))
                    return;

                this.dbContext.SaveChanges();
            }
            else
            {
                details = this._newTaction.TactionDetails.Where(r => r.ItemId == itemId && r.Unit == unit && r.UnitPrice == unitPrice && r.Vat == vat).FirstOrDefault();
                if (!this.setTactionDetailsDataFromUiToObject(details))
                    return;
            }

            this.updateDataGridViewTactionDetails();
            this.setTactionTotalPrice(_newTaction);
        }

        private void buttonRemoveDetail_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewTactionDetails.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Row not selected.", "Select the row you want to remove first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int detailsId = Convert.ToInt32(row.Cells["detailsId"].Value);
            int tactionId = Convert.ToInt32(row.Cells["tactionId"].Value);
            int itemId = Convert.ToInt32(row.Cells["itemId"].Value);

            decimal unit = Convert.ToDecimal(row.Cells["unit"].Value);
            decimal unitPrice = Convert.ToDecimal(row.Cells["unitPrice"].Value);
            decimal vat = Convert.ToDecimal(row.Cells["vat"].Value);

            TactionDetails details = this.dbContext.TactionDetails.Where(r => r.id == detailsId).FirstOrDefault();
            if (details != null)
            {
                Taction taction = this.dbContext.Taction.Where(r => r.id == tactionId).FirstOrDefault();

                try
                {
                    taction.TactionDetails.Remove(details);
                    this.dbContext.TactionDetails.Remove(details);
                    this.dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while removing taction detail.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.bindDataToGridViewTactionDetails(tactionId);
                this.setTactionTotalPrice(taction);
            }
            else
            {
                details = this._newTaction.TactionDetails.Where(r => r.ItemId == itemId && r.Unit == unit && r.UnitPrice == unitPrice && r.Vat == vat).FirstOrDefault();
                this._newTaction.TactionDetails.Remove(details);
                this.updateDataGridViewTactionDetails();
                this.setTactionTotalPrice(_newTaction);
            }
        }

        private void buttonClearDetail_Click(object sender, EventArgs e)
        {
            this.clearDetailsControls();
        }

        private void buttonAdviceLastUnitPrice_Click(object sender, EventArgs e)
        {
            string itemName = this.textBoxItem.Text;
            int itemSubTypeId = 0;

            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Enter an item first to get its last unit price.", "Item not entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!dbContext.Item.Any(r => r.Name == itemName))
            {
                MessageBox.Show("Cannot find this item in database.", "Item not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxItemSubType.SelectedItem != null)
                itemSubTypeId = ((ItemSubType)this.comboBoxItemSubType.SelectedItem).id;

            int itemId = dbContext.Item.Where(r => r.Name == itemName).FirstOrDefault().id;

            try
            {
                this.textBoxUnitPrice.Text = adviceUnitPriceForItem(itemId, itemSubTypeId).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot find unit price for this item. TactionDetails is NULL.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.textBoxVat.Text = adviceVatForItem(itemId).ToString();
        }

        private void checkBoxDetailsEditable_CheckedChanged(object sender, EventArgs e)
        {
            this.setEditableDetails(this.checkBoxDetailsEditable.Checked);
            this.enableDiscountFields(this.checkBoxDiscount.Checked);
        }

        private void checkBoxTactionsEditable_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewTactions.CurrentRow;

            //int tactionId = Convert.ToInt32(row.Cells["tactionId"].Value);
            int paymentId = Convert.ToInt32(row.Cells["paymentId"].Value);
            int ownerId = Convert.ToInt32(row.Cells["ownerId"].Value);

            this.setEditableTactions(this.checkBoxTactionsEditable.Checked);
            this.enableSellerField(this.checkBoxSeller.Checked);
            this.bindDataToComboBoxPaymentMethod(BindType.Select, paymentId);
            this.bindDataToComboBoxOwner(BindType.Select, ownerId);
        }

        private void checkBoxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            this.enableDiscountFields(this.checkBoxDiscount.Checked);
        }

        private void checkBoxSeller_CheckedChanged(object sender, EventArgs e)
        {
            this.enableSellerField(this.checkBoxSeller.Checked);
        }

        private void textBoxUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.formatCurrencyTextBox(sender, e);
        }

        private void textBoxUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.formatCurrencyTextBox(sender, e);
        }

        private void textBoxVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.formatTwoDigitNumericTextBox(sender, e);
        }
       
        private void textBoxItemGroup_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = null;
            IQueryable<string> query = null;

            if (dbContext.ItemGroup.Any(r => r.Name == this.textBoxItemGroup.Text))
            {
                query = from item in dbContext.Item
                        join itemGroup in dbContext.ItemGroup on item.GroupId equals itemGroup.id
                        where itemGroup.Name == textBoxItemGroup.Text
                        select item.Name;
            }
            else
            {
                query = from item in dbContext.Item
                        join itemGroup in dbContext.ItemGroup on item.GroupId equals itemGroup.id
                        select item.Name;
            }

            autoCompleteStringCollection = this.createAutoCompleteStringCollection(query);

            if (autoCompleteStringCollection.Count == 1)
                this.textBoxItem.Text = autoCompleteStringCollection[0];

            this.textBoxItem.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void textBoxItem_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = null;
            IQueryable<string> query = null;

            if (dbContext.Item.Any(r => r.Name == this.textBoxItem.Text))
            {
                query = from itemGroup in dbContext.ItemGroup
                        join item in dbContext.Item on itemGroup.id equals item.GroupId
                        where item.Name == textBoxItem.Text
                        select itemGroup.Name;

                int itemId = dbContext.Item.Where(r => r.Name == this.textBoxItem.Text).FirstOrDefault().id;
                this.bindDataToComboBoxItemSubType(BindType.Select, itemId);
                this.comboBoxItemSubType.Enabled = true;
            }
            else
            {
                query = from itemGroup in dbContext.ItemGroup
                        join item in dbContext.Item on itemGroup.id equals item.GroupId
                        select itemGroup.Name;
            }

            autoCompleteStringCollection = this.createAutoCompleteStringCollection(query);

            if (autoCompleteStringCollection.Count == 1)
                this.textBoxItemGroup.Text = autoCompleteStringCollection[0];

            this.textBoxItemGroup.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void contextMenuItemReportByItemSubType_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = this.dataGridViewTactions.SelectedRows;
            if (selectedRows == null)
            {
                MessageBox.Show("You didn't select any row. Select rows for reporting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TactionReportForm tactionReportForm = new TactionReportForm();
            tactionReportForm.ReportType = TactionReportType.ItemSubType;
            tactionReportForm.SelectedTactions = this.getSelectedTactions(selectedRows);

            if (tactionReportForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void contextMenuItemReportByItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = this.dataGridViewTactions.SelectedRows;
            if (selectedRows == null)
            {
                MessageBox.Show("You didn't select any row. Select rows for reporting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = this.dataGridViewTactions.SelectedRows[0] as DataGridViewRow;
            DateTime selectedDate = this.getTactionFromRow(row).Dt;

            TactionReportForm tactionReportForm = new TactionReportForm();
            tactionReportForm.ReportType = TactionReportType.Item;
            tactionReportForm.SelectedTactions = this.getSelectedTactions(selectedRows);

            if (tactionReportForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void contextMenuItemReportByItemGroup_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = this.dataGridViewTactions.SelectedRows;
            if (selectedRows == null)
            {
                MessageBox.Show("You didn't select any row. Select rows for reporting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TactionReportForm tactionReportForm = new TactionReportForm();
            tactionReportForm.ReportType = TactionReportType.ItemGroup;
            tactionReportForm.SelectedTactions = this.getSelectedTactions(selectedRows);

            if (tactionReportForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void contextMenuItemReportMonthly_Click(object sender, EventArgs e)
        {
            TactionReportForm tactionReportForm = new TactionReportForm();
            tactionReportForm.ReportType = TactionReportType.Monthly;
            tactionReportForm.DbSetTaction = this.dbContext.Taction;

            if (tactionReportForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        #endregion

        #region Databind Queries

        private void bindDataToGridViewTaction()
        {
            var query = from taction in dbContext.Taction
                        join shop in dbContext.Shop on taction.ShopId equals shop.id
                        join payment in dbContext.PaymentMethod on taction.PaymentMethodId equals payment.id

                        join seller in dbContext.Seller on taction.SellerId equals seller.id into sellerJoinTable
                        from sjt in sellerJoinTable.DefaultIfEmpty()
                            //join seller in dbContext.Seller on taction.SellerId equals seller.id

                        join user in dbContext.User on taction.WhoDidIt equals user.id into personJoinTable
                        from pjt in personJoinTable.DefaultIfEmpty()
                            //join user in dbContext.User on taction.WhoDidIt equals user.id

                        orderby taction.Dt descending
                        select new
                        {
                            tactionId = taction.id,
                            paymentId = payment.id,
                            ownerId = pjt.id,
                            date = taction.Dt,
                            shopName = shop.Name,
                            totalPrice = taction.TotalPrice + " TL",
                            paymentName = payment.Name,
                            tactionNo = taction.No,
                            sellerName = sjt.Name,
                            personName = pjt.Fullname
                        };

            this.dataGridViewTactions.DataSource = query.ToList();
            this.onTransactionsLoaded("Transactions", "Transaction data Loaded", DateTime.Now);
        }

        private void bindDataToGridViewTactionDetails(int tactionId)
        {
            var query = from details in dbContext.TactionDetails
                        join item in dbContext.Item on details.ItemId equals item.id
                        join itemGroup in dbContext.ItemGroup on item.GroupId equals itemGroup.id
                        join itemSubType in dbContext.ItemSubType on details.ItemSubTypeId equals itemSubType.id into joinTable
                        from jt in joinTable.DefaultIfEmpty()
                        where details.TransactionId == tactionId
                        orderby details.UnitPrice * details.Unit descending
                        select new
                        {
                            detailsId = details.id,
                            tactionId = details.TransactionId,
                            itemId = item.id,
                            itemSubTypeId = jt != null ? jt.id : 0,
                            itemGroup = itemGroup.Name,
                            itemName = item.Name,
                            itemSubTypeName = jt != null ? jt.Name : "",
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

        private void updateDataGridViewTactionDetails()
        {
            var query = from details in _newTaction.TactionDetails.ToList()
                        join item in dbContext.Item on details.ItemId equals item.id
                        join itemGroup in dbContext.ItemGroup on item.GroupId equals itemGroup.id
                        join itemSubType in dbContext.ItemSubType on details.ItemSubTypeId equals itemSubType.id into joinTable
                        from jt in joinTable.DefaultIfEmpty()
                        orderby details.UnitPrice * details.Unit descending
                        select new
                        {
                            detailsId = details.id,
                            tactionId = details.TransactionId,
                            itemId = item.id,
                            itemSubTypeId = jt != null ? jt.id : 0,
                            itemGroup = itemGroup.Name,
                            itemName = item.Name,
                            itemSubTypeName = jt != null ? jt.Name : "",
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

        private void bindDataToComboBoxPaymentMethod(BindType bindType, int paymentMethodId = 0)
        {
            IQueryable<PaymentMethod> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from payment in dbContext.PaymentMethod orderby payment.Name select payment;
                    break;
                case BindType.Where:
                    query = from payment in dbContext.PaymentMethod where payment.id == paymentMethodId select payment;
                    break;
                case BindType.Setnull:
                    this.comboBoxPaymentMethod.DataSource = null;
                    return;
            }

            this.comboBoxPaymentMethod.DataSource = query.ToList();
            this.comboBoxPaymentMethod.DisplayMember = "Name";
            this.comboBoxPaymentMethod.ValueMember = "id";

            if (bindType == BindType.Select && paymentMethodId > 0)
                this.comboBoxPaymentMethod.SelectedValue = paymentMethodId;
        }

        private void bindDataToComboBoxOwner(BindType bindType, int ownerId = 0)
        {
            IQueryable<User> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from user in dbContext.User select user;
                    break;
                case BindType.Where:
                    query = from user in dbContext.User where user.id == ownerId select user;
                    break;
                case BindType.Setnull:
                    this.comboBoxOwner.DataSource = null;
                    return;
            }

            this.comboBoxOwner.DataSource = query.ToList();
            this.comboBoxOwner.DisplayMember = "Fullname";
            this.comboBoxOwner.ValueMember = "id";

            if (bindType == BindType.Select && ownerId == 0)
                this.comboBoxOwner.SelectedValue = 4;   // <No One>
            else if (bindType == BindType.Select && ownerId > 0)
                this.comboBoxOwner.SelectedValue = ownerId;
            else if (bindType == BindType.Where)
                this.comboBoxOwner.SelectedValue = ownerId;
        }

        private void bindDataToComboBoxItemSubType(BindType bindType, int itemId = 0, int itemSubTypeId = 0)
        {
            IQueryable<ItemSubType> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    var querySubType = from itemSubTypeDetails in dbContext.ItemSubTypeDetails
                                       join item in dbContext.Item on itemSubTypeDetails.ItemId equals item.id
                                       join itemSubType in dbContext.ItemSubType on itemSubTypeDetails.ItemSubTypeId equals itemSubType.id
                                       where item.id == itemId
                                       select itemSubType;

                    this.comboBoxItemSubType.DisplayMember = "Name";
                    this.comboBoxItemSubType.ValueMember = "id";
                    this.comboBoxItemSubType.DataSource = querySubType.ToList().Distinct().ToList();
                    return;
                case BindType.Where:
                    if (itemSubTypeId == 0)
                    {
                        this.comboBoxItemSubType.DataSource = null;
                        return;
                    }
                    else
                        query = from itemSubType in dbContext.ItemSubType
                                where itemSubType.id == itemSubTypeId
                                select itemSubType;
                    break;
                case BindType.Setnull:
                    this.comboBoxItemSubType.DataSource = null;
                    return;
            }

            this.comboBoxItemSubType.DataSource = query.ToList();
            this.comboBoxItemSubType.DisplayMember = "Name";
            this.comboBoxItemSubType.ValueMember = "id";
        }

        #endregion

        #region Set data to Controls

        private void setAutoCompleteTextBoxes()
        {
            this.textBoxShop.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBoxSeller.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBoxItemGroup.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBoxItem.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.textBoxItemSubType.AutoCompleteMode = AutoCompleteMode.Suggest;

            this.textBoxShop.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxSeller.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxItemGroup.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //this.textBoxItemSubType.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var shopNameQuery = from shop in dbContext.Shop
                                select shop.Name;

            var sellerNameQuery = from seller in dbContext.Seller
                                  select seller.Name;

            var itemGroupNameQuery = from itemGroup in dbContext.ItemGroup
                                     select itemGroup.Name;

            var itemNameQuery = from item in dbContext.Item
                                select item.Name;

            var itemSubTypeNameQuery = from itemSubType in dbContext.ItemSubType
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
            //this.textBoxItemSubType.AutoCompleteCustomSource = itemSubTypeNameCollection;
        }

        private int setTactionControls(DataGridViewRow row)
        {
            /* Returns TactionId */
            int tactionId = Convert.ToInt32(row.Cells["tactionId"].Value);
            int paymentId = Convert.ToInt32(row.Cells["paymentId"].Value);

            this.dateTimePickerTactionDate.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
            this.textBoxShop.Text = row.Cells["shopName"].Value.ToString();
            this.bindDataToComboBoxPaymentMethod(BindType.Where, paymentId);

            if (row.Cells["ownerId"].Value != null)
            {
                int ownerId = Convert.ToInt32(row.Cells["ownerId"].Value);
                this.bindDataToComboBoxOwner(BindType.Where, ownerId);
            }

            this.textBoxTactionNo.Text = (row.Cells["tactionNo"].Value != null) ? row.Cells["tactionNo"].Value.ToString() : string.Empty;

            Taction taction = dbContext.Taction.Where(r => r.id == tactionId).FirstOrDefault();
            setTactionTotalPrice(taction);
            //this.textBoxTotalPrice.Text = row.Cells["totalPrice"].Value.ToString();

            return tactionId;
        }

        private void setTactionDetailsControls(DataGridViewRow row)
        {
            this.textBoxItemGroup.Text = row.Cells["itemGroup"].Value.ToString();
            this.textBoxItem.Text = row.Cells["itemName"].Value.ToString();
            //this.textBoxItemSubType.Text = row.Cells["itemSubTypeId"].Value.ToString();
            this.bindDataToComboBoxItemSubType(BindType.Where, 0, Convert.ToInt32(row.Cells["itemSubTypeId"].Value));
            this.textBoxUnit.Text = row.Cells["unit"].Value.ToString();
            this.textBoxUnitPrice.Text = row.Cells["unitPrice"].Value.ToString();
            this.textBoxVat.Text = row.Cells["vat"].Value.ToString();
            this.textBoxDiscountRate.Text = (row.Cells["discountRate"].Value != null) ? row.Cells["discountRate"].Value.ToString() : string.Empty;
            this.textBoxDiscountedPrice.Text = (row.Cells["discountedPrice"].Value != null) ? row.Cells["discountedPrice"].Value.ToString() : string.Empty;
            this.checkBoxDiscount.Checked = (!string.IsNullOrEmpty(this.textBoxDiscountRate.Text) || !string.IsNullOrEmpty(this.textBoxDiscountedPrice.Text));
            this.textBoxDetailsNote.Text = (row.Cells["note"].Value != null) ? row.Cells["note"].Value.ToString() : string.Empty;
        }

        private void setTactionTotalPrice(Taction taction)
        {
            Tuple<decimal, decimal> totalPriceAndVatPrice = this.calculateTotalPriceAndVatPrice(taction);
            textBoxTotalPrice.Text = totalPriceAndVatPrice.Item1.ToString();
            textBoxTotalVatPrice.Text = totalPriceAndVatPrice.Item2.ToString();
        }

        #endregion

        #region Get data from Controls

        private void setTactionDataFromUiToObject(Taction taction)
        {
            if (taction.TactionDetails.Count == 0)
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

            if (string.IsNullOrEmpty(this.comboBoxOwner.Text))
            {
                MessageBox.Show("Missing value.", "You didn't select owner of this transaction.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.checkBoxSeller.Checked)
            {
                if (string.IsNullOrEmpty(this.textBoxSeller.Text))
                {
                    MessageBox.Show("Missing seller value.", "You checked seller option but you didn't enter a seller.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            taction.Dt = this.dateTimePickerTactionDate.Value;
            taction.ShopId = dbContext.Shop.Where(r => r.Name == this.textBoxShop.Text).FirstOrDefault().id;
            taction.PaymentMethodId = ((PaymentMethod)this.comboBoxPaymentMethod.SelectedItem).id;
            taction.WhoDidIt = ((User)this.comboBoxOwner.SelectedItem).id;
            if (this.checkBoxSeller.Checked)
                taction.SellerId = dbContext.Seller.Where(r => r.Name == this.textBoxSeller.Text).FirstOrDefault().id;

            taction.No = this.textBoxTactionNo.Text;

            taction.TotalPrice = 0;
            foreach (TactionDetails details in taction.TactionDetails)
                taction.TotalPrice += (details.DiscountedPrice == null) ? (details.UnitPrice * details.Unit) : (details.DiscountedPrice.Value);
            // taction.TotalPrice += taction.TactionDetails.Sum(r => r.UnitPrice * r.Unit);
        }

        private bool setTactionDetailsDataFromUiToObject(TactionDetails details)
        {
            if (!dbContext.Item.Any(r => r.Name == this.textBoxItem.Text))
            {
                MessageBox.Show("Input doesn't exist.", "The item you entered does not exist in database. Please first save this item to item table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.textBoxUnit.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter unit.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.textBoxUnitPrice.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter unit price.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.textBoxVat.Text))
            {
                MessageBox.Show("Missing value.", "You didn't enter vat.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (this.checkBoxDiscount.Checked)
            {
                if (string.IsNullOrEmpty(this.textBoxDiscountRate.Text) && string.IsNullOrEmpty(this.textBoxDiscountedPrice.Text))
                {
                    MessageBox.Show("Missing discount value.", "You didn't enter discounted price or discount rate.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (this._newTaction == null)   // Edit mode: taction exists in db, we get this taction object from database.
            {
                DataGridViewRow row = this.dataGridViewTactions.CurrentRow;
                int tactionId = Convert.ToInt32(row.Cells["tactionId"].Value);
                this._newTaction = dbContext.Taction.Where(r => r.id == tactionId).FirstOrDefault();
            }

            details.Taction = this._newTaction;
            details.ItemId = dbContext.Item.Where(r => r.Name == this.textBoxItem.Text).FirstOrDefault().id;


            if (this.comboBoxItemSubType.SelectedItem != null)
            {
                ItemSubType itemSubType = (ItemSubType)this.comboBoxItemSubType.SelectedItem;
                details.ItemSubTypeId = itemSubType.id;
            }

            details.Unit = Convert.ToDecimal(this.textBoxUnit.Text);
            details.UnitPrice = Convert.ToDecimal(this.textBoxUnitPrice.Text);
            details.Vat = Convert.ToInt32(this.textBoxVat.Text);

            if (checkBoxDiscount.Checked)
            {
                if (!string.IsNullOrEmpty(this.textBoxDiscountRate.Text))
                {
                    decimal newRate = Convert.ToDecimal(this.textBoxDiscountRate.Text);
                    if (details.DiscountRate == null || details.DiscountRate != newRate) // if empty or if value changed.
                    {
                        details.DiscountRate = newRate;
                        details.DiscountedPrice = calculateDiscountedUnitPrice(details.DiscountRate.Value, details.UnitPrice, details.Unit);

                        this.textBoxDiscountedPrice.Text = details.DiscountedPrice.ToString();
                    }
                }
                if (!string.IsNullOrEmpty(this.textBoxDiscountedPrice.Text))
                {
                    decimal newDiscountedPrice = Convert.ToDecimal(this.textBoxDiscountedPrice.Text) * details.Unit;
                    if (details.DiscountedPrice == null || details.DiscountedPrice != newDiscountedPrice) // if empty or if value changed.
                    {
                        // details.DiscountedPrice is total discounted price per item. It's not discounted unit price.
                        details.DiscountedPrice = newDiscountedPrice;
                        details.DiscountRate = calculateDiscountRate(Convert.ToDecimal(this.textBoxDiscountedPrice.Text), details.UnitPrice);

                        this.textBoxDiscountRate.Text = Math.Round(Convert.ToDouble(details.DiscountRate), 2).ToString();
                    }
                }
            }

            details.Note = !string.IsNullOrEmpty(this.textBoxDetailsNote.Text) ? this.textBoxDetailsNote.Text : null;

            return true;
        }

        private List<Taction> getSelectedTactions(DataGridViewSelectedRowCollection rowCollection)
        {
            List<Taction> selectedTactions = new List<Taction>();

            foreach (DataGridViewRow row in this.dataGridViewTactions.SelectedRows)
            {
                Taction taction = this.getTactionFromRow(row);
                selectedTactions.Add(taction);
            }

            return selectedTactions;
        }

        private Taction getTactionFromRow(DataGridViewRow row)
        {
            Type type = row.DataBoundItem.GetType();
            int? tactionId = (int)type.GetProperty("tactionId").GetValue(row.DataBoundItem, null);

            if (tactionId != null)
                return this.dbContext.Taction.Where(r => r.id == tactionId).FirstOrDefault();

            return null;
        }

        #endregion

        #region Create Controls

        private void createImageList()
        {
            _imageList = new ImageList
            {
                ImageSize = new Size(19, 19),
                ColorDepth = ColorDepth.Depth32Bit
            };
            _imageList.Images.Add("Thinker", BitmapResourceLoader.Thinker);
            _imageList.Images.Add("FAQ", BitmapResourceLoader.FAQ);
            _imageList.Images.Add("QuestionMark", BitmapResourceLoader.QuestionMark);
            _imageList.Images.Add("Question1", BitmapResourceLoader.Question1);
            _imageList.Images.Add("Question2", BitmapResourceLoader.Question2);
        }
        
        private void createContextMenu()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();

            ToolStripMenuItem contextMenuItemReportByItemSubType = new ToolStripMenuItem("Report by Item Sub Type...", BitmapResourceLoader.Sqlite, new EventHandler(contextMenuItemReportByItemSubType_Click), Keys.None);
            ToolStripMenuItem contextMenuItemReportByItem = new ToolStripMenuItem("Report by Item...", BitmapResourceLoader.Sqlite, new EventHandler(contextMenuItemReportByItem_Click), Keys.None);
            ToolStripMenuItem contextMenuItemReportByItemGroup = new ToolStripMenuItem("Report by Item Group...", BitmapResourceLoader.Sqlite, new EventHandler(contextMenuItemReportByItemGroup_Click), Keys.None);
            ToolStripMenuItem contextMenuItemReportYearly = new ToolStripMenuItem("Report monthly...", BitmapResourceLoader.Sqlite, new EventHandler(contextMenuItemReportMonthly_Click), Keys.None);
            ToolStripMenuItem contextMenuItemExit = new ToolStripMenuItem("Exit");

            menuStrip.Items.AddRange(new ToolStripItem[] { contextMenuItemReportByItemSubType,
                                                           contextMenuItemReportByItem,
                                                           contextMenuItemReportByItemGroup,
                                                           contextMenuItemReportYearly,
                                                           contextMenuItemExit });

            this.ContextMenuStrip = menuStrip;
        }

        #endregion

        #region Create data for Controls

        private AutoCompleteStringCollection createAutoCompleteStringCollection(IQueryable<string> query)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();

            foreach (var item in query)
                autoCompleteStringCollection.Add(item);

            return autoCompleteStringCollection;
        }

        #endregion

        #region Set Enabled & Checked & Read-only Controls

        private void setEditableTactions(bool isEditable)
        {
            this.dataGridViewTactions.Enabled = !isEditable;
            this.buttonSaveTaction.Enabled = isEditable;
            this.buttonUpdateTaction.Enabled = isEditable;
            this.buttonCancelTaction.Enabled = isEditable;
            this.dateTimePickerTactionDate.Enabled = isEditable;
            this.textBoxShop.ReadOnly = !isEditable;
            this.comboBoxPaymentMethod.Enabled = isEditable;
            this.comboBoxOwner.Enabled = isEditable;
            this.checkBoxSeller.Enabled = isEditable;
            this.textBoxSeller.ReadOnly = !isEditable;
            this.textBoxTactionNo.ReadOnly = !isEditable;
        }

        private void setEditableDetails(bool isEditable)
        {
            this.buttonAddDetail.Enabled = isEditable;
            this.buttonUpdateDetail.Enabled = isEditable;
            this.buttonRemoveDetail.Enabled = isEditable;
            this.buttonClearDetail.Enabled = isEditable;
            this.buttonAdviceLastUnitPrice.Enabled = isEditable;
            this.checkBoxDiscount.Enabled = isEditable;
            this.textBoxItemGroup.ReadOnly = !isEditable;
            this.textBoxItem.ReadOnly = !isEditable;
            this.comboBoxItemSubType.Enabled = !isEditable;
            this.textBoxUnit.ReadOnly = !isEditable;
            this.textBoxUnitPrice.ReadOnly = !isEditable;
            this.textBoxVat.ReadOnly = !isEditable;
            this.textBoxDiscountRate.ReadOnly = !isEditable;
            this.textBoxDiscountedPrice.ReadOnly = !isEditable;
            this.textBoxDetailsNote.ReadOnly = !isEditable;
        }

        private void enableDiscountFields(bool enable)
        {
            this.textBoxDiscountRate.Enabled = enable;
            this.textBoxDiscountedPrice.Enabled = enable;
        }

        private void enableSellerField(bool enable)
        {
            this.textBoxSeller.Enabled = enable;
        }

        private void checkEditableCheckBoxes(bool check)
        {
            this.checkBoxTactionsEditable.Checked = check;
            this.checkBoxDetailsEditable.Checked = check;
        }

        private void setReadOnlyTotalPriceField()
        {
            this.textBoxTotalPrice.ReadOnly = true;
        }

        private void setReadOnlyTotalVatPriceField()
        {
            this.textBoxTotalVatPrice.ReadOnly = true;
        }

        #endregion

        #region Format Controls

        private void formatCurrencyTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            /* Allow only one decimal point. Block others */
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        private void formatTwoDigitNumericTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private static void limitTextBoxCharLength(TextBox textBox, int maxLength)
        {
            textBox.MaxLength = maxLength;
        }


        #endregion

        #region Style Controls

        private static void setButtonImages(Button button, ImageList imageList, string imageIndexOfKey, Color foreColor, Color backColor, FlatStyle flatStyle, int borderWidth)
        {
            button.ImageList = imageList;
            button.ImageIndex = imageList.Images.IndexOfKey(imageIndexOfKey);
            button.ForeColor = foreColor;
            //button.BackColor = backColor;
            button.FlatStyle = flatStyle;
            button.FlatAppearance.BorderSize = borderWidth;
        }

        #endregion

        #region Clear Controls

        private void clearTactionControls()
        {
            foreach (Control c in this.groupBoxTactionOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();

            foreach (Control c in this.groupBoxTactionOptions.Controls)
                if (c is ComboBox)
                    ((ComboBox)c).Text = string.Empty;
        }

        private void clearDetailsControls()
        {
            foreach (Control c in this.groupBoxTactionDetailsOptions.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is ComboBox)
                    ((ComboBox)c).DataSource = null;
            }
        }

        #endregion

        #region Calculations

        private static decimal calculateDiscountedUnitPrice(decimal rate, decimal unitPrice, decimal unit)
        {
            return (1 - (rate / 100)) * unitPrice * unit;
        }

        private static decimal calculateDiscountRate(decimal discountedUnitPrice, decimal unitPrice) // Returns rate value between 0 and 100.
        {
            return (1 - discountedUnitPrice / unitPrice) * 100;
        }

        private decimal calculateItemPrice(decimal unitPrice, decimal unit, decimal? discountedPrice = null)
        {
            // return (details.DiscountedPrice == null) ? (details.UnitPrice * details.Unit) : (details.DiscountedPrice.Value);

            return (discountedPrice == null) ? unitPrice * unit : discountedPrice.Value;
        }

        private decimal calculateItemVatPrice(decimal itemPrice, int vat)
        {
            return itemPrice * vat / 100;
        }

        private Tuple<decimal, decimal> calculateTotalPriceAndVatPrice(Taction taction)
        {
            decimal totalPrice = 0;
            decimal totalVatPrice = 0;
            foreach (TactionDetails details in taction.TactionDetails)
            {
                decimal itemPrice = this.calculateItemPrice(details.UnitPrice, details.Unit, details.DiscountedPrice);

                totalVatPrice += this.calculateItemVatPrice(itemPrice, details.Vat);
                totalPrice += itemPrice;
            }

            return new Tuple<decimal, decimal>(totalPrice, totalVatPrice);
        }

        private decimal adviceUnitPriceForItem(int itemId, int itemSubTypeId = 0)
        {
            var query = from details in dbContext.TactionDetails
                        join itemSubType in dbContext.Item on details.ItemSubTypeId equals itemSubType.id into joinTable
                        from jt in joinTable.DefaultIfEmpty()
                        join taction in dbContext.Taction on details.TransactionId equals taction.id
                        where details.ItemId == itemId
                        select details;

            if (itemSubTypeId > 0)
                query = query.Where(r => r.ItemSubTypeId == itemSubTypeId);

            TactionDetails tactionDetails = query.OrderByDescending(r => r.Taction.Dt).FirstOrDefault();
            if (tactionDetails == null)
                throw new Exception("TactionDetails is null");

            return Convert.ToDecimal(tactionDetails.UnitPrice);
        }

        private int adviceVatForItem(int itemId)
        {
            var query = from details in dbContext.TactionDetails
                        join taction in dbContext.Taction on details.TransactionId equals taction.id
                        where details.ItemId == itemId
                        orderby taction.Dt descending
                        select details.Vat;

            return Convert.ToInt32(query.FirstOrDefault());
        }

        #endregion

        #region User-defined Event Handlers

        protected virtual void onTransactionsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.TransactionsLoad?.Invoke(actionType, message, eventTime);
            this.onTransactionChanged(actionType, message, eventTime);
        }

        protected virtual void onTransactionSaved(Taction taction) //protected virtual method
        {
            this.TransactionSave?.Invoke(taction);
            this.onTransactionChanged("Transactions", $"New transaction id {taction.id}: {taction.Shop.Name} saved", DateTime.Now);
        }

        protected virtual void onTransactionUpdated(Taction newTaction, Taction oldTaction) //protected virtual method
        {
            this.TransactionUpdate?.Invoke(newTaction, oldTaction);
            this.onTransactionChanged("Transactions", $"Transaction id {oldTaction.id}: {newTaction.Shop.Name} updated", DateTime.Now);
        }

        protected virtual void onTransactionRemoved(Taction taction) //protected virtual method
        {
            this.TransactionRemove?.Invoke(taction);
            this.onTransactionChanged("Transactions", $"Transaction id {taction.id}: {taction.Shop.Name} removed", DateTime.Now);
        }

        protected virtual void onTransactionChanged(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.TransactionChanged?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onTransactionFormOpened(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.TransactionFormOpened?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onTransactionFormClosed(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.TransactionFormClosed?.Invoke(actionType, message, eventTime);
        }

        private void TactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    this.onTransactionFormClosed("Transactions", "Window closed by user", DateTime.Now);
                    break;

                case CloseReason.WindowsShutDown:
                    this.onTransactionFormClosed("Transactions", "Window closed as a part of Windows Shutdown", DateTime.Now);
                    break;

                case CloseReason.TaskManagerClosing:
                    this.onTransactionFormClosed("Transactions", "Window closed forcibly by Task Manager", DateTime.Now);
                    break;

                case CloseReason.FormOwnerClosing:
                    this.onTransactionFormClosed("Transactions", "Window closed by Form Owner", DateTime.Now);
                    break;

                default:
                    this.onTransactionFormClosed("Transactions", "Window closed with an unknown reasoun", DateTime.Now);
                    break;
            }
        }

        #endregion
    }
}
