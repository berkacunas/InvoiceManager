using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst
{
    public partial class PaymentMethodForm : Form
    {
        private InvoicesEntities dbContext;

        private BankCard _newBankCard;
        private PaymentMethod _newPaymentMethod;

        private Mode _bankCardMode;
        private Mode _paymentMode;

        private ColumnSortOrder[] _sortOrdersDataGridViewItemGroups = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };
        private ColumnSortOrder[] _sortOrdersDataGridViewItems = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };

        public PaymentMethodForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.PaymentMethod.GetHicon());

            this.dbContext = new InvoicesEntities();

            this.dataGridViewBankCards.DataSourceChanged += DataGridViewBankCards_DataSourceChanged;
            this.dataGridViewPaymentMethods.DataSourceChanged += DataGridViewPaymentMethods_DataSourceChanged;

            this.dataGridViewBankCards.DataBindingComplete += DataGridViewBankCards_DataBindingComplete;
            this.dataGridViewPaymentMethods.DataBindingComplete += DataGridViewPaymentMethods_DataBindingComplete;

            this.dataGridViewBankCards.CellClick += DataGridViewBankCards_CellClick;
            this.dataGridViewPaymentMethods.CellClick += DataGridViewPaymentMethods_CellClick;
        }

        private void PaymentMethodForm_Load(object sender, EventArgs e)
        {
            this._setModes(Mode.Display);

            //this.onPaymentMethodFormOpened("Payment Method Window opened", DateTime.Now);

            _setDefaultGridViewStyles(this.dataGridViewBankCards);
            _setDefaultGridViewStyles(this.dataGridViewPaymentMethods);

            _enableDataGridViewMultiSelect(this.dataGridViewBankCards, false);
            _enableDataGridViewMultiSelect(this.dataGridViewPaymentMethods, false);

            this._setEditableBankCards(false);
            this._setEditablePaymentMethods(false);
            
            this.comboBoxPaymentMethodOptionsCard.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethodOptionsCardType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethodOptionsCardOwner.DropDownStyle = ComboBoxStyle.DropDownList;

            this._bindDataToGridViewBankCard();
            this._bindDataToGridViewPaymentMethod();
        }

        private void DataGridViewBankCards_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewBankCards.DataSource == null)
                return;

            string[] headerTexts = new string[] { "bankCardId", "Bank", "Type" };
            int[] columnWidths = new int[] { 50, 150, 150 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft };

            _setDefaultGridViewHeaderStyles(this.dataGridViewBankCards, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewBankCards.Columns["bankCardId"].Visible = false;
        }

        private void DataGridViewPaymentMethods_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewPaymentMethods.DataSource == null)
                return;

            string[] headerTexts = new string[] { "paymentMethodId", "bankCardId", "cardOwnerId", "Method", "Bank", "Card Type", "Card Owner" };
            int[] columnWidths = new int[] { 50, 50, 50, 200, 160, 120, 160 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft };

            _setDefaultGridViewHeaderStyles(this.dataGridViewPaymentMethods, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewPaymentMethods.Columns["paymentMethodId"].Visible = false;
            this.dataGridViewPaymentMethods.Columns["bankCardId"].Visible = false;
            this.dataGridViewPaymentMethods.Columns["cardOwnerId"].Visible = false;
        }

        private void DataGridViewBankCards_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewBankCards.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewBankCards.Rows[0];
                if (row != null)
                    this._setBankCardControls(row);
            }
        }

        private void DataGridViewPaymentMethods_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewPaymentMethods.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewPaymentMethods.Rows[0];
                if (row != null)
                    this._setPaymentMethodControls(row);
            }
        }

        private void DataGridViewBankCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._setEditableBankCards(false);
            this._checkCardOptionsEditableCheckBox(false);

            this._clearBankCardControls();
            DataGridViewRow row = this.dataGridViewBankCards.CurrentRow;
            this._setBankCardControls(row);
        }

        private void DataGridViewPaymentMethods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._setEditablePaymentMethods(false);
            this._checkPaymentMethodOptionsEditableCheckBox(false);

            this._clearPaymentMethodControls();
            DataGridViewRow row = this.dataGridViewPaymentMethods.CurrentRow;
            this._setPaymentMethodControls(row);
        }

        private void buttonNewCard_Click(object sender, EventArgs e)
        {
            this._bankCardMode = (this._bankCardMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewCard.Text = (this._bankCardMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewBankCards.Enabled = (this._bankCardMode != Mode.Add);

            if (this._bankCardMode == Mode.Add)
            {
                this._bindDataToComboBoxCardOptionsCardType(BindType.Select);
                this._setEditableBankCards(true);
                this._newBankCard = new BankCard();
            }
            else
            {
                this._bindDataToComboBoxCardOptionsCardType(BindType.Setnull);
                this._setEditableBankCards(false);
            }

            this._clearBankCardControls();
        }

        private void buttonSaveCard_Click(object sender, EventArgs e)
        {
            this._setBankCardDataFromUiToObject(this._newBankCard);
            this.dbContext.BankCard.Add(this._newBankCard);

            try
            {
                this.dbContext.SaveChanges();
                //this.onBankCardSaved($"Item {_newBankCard.Name} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding bank card.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearBankCardControls();
            this._setEditableBankCards(false);
            this._bindDataToGridViewBankCard();
            this._newBankCard = new BankCard();
            this._bankCardMode = Mode.Display;

        }

        private void buttonUpdateCard_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewBankCards.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int bankCardId = Convert.ToInt32(row.Cells["bankCardId"].Value);
            BankCard bankCard = dbContext.BankCard.Where(r => r.id == bankCardId).FirstOrDefault();

            this._setBankCardDataFromUiToObject(bankCard);

            try
            {
                this.dbContext.SaveChanges();
                //this.onBankCardUpdated($"BankCard {bankCard.Name} updated", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating bank card.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewBankCard();
        }

        private void buttonDeleteCard_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewBankCards.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to delete first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int bankCardId = Convert.ToInt32(row.Cells["bankCardId"].Value);
            BankCard bankCard = dbContext.BankCard.Where(r => r.id == bankCardId).FirstOrDefault();

            dbContext.BankCard.Remove(bankCard);

            try
            {
                dbContext.SaveChanges();
                //this.onBankCardRemoved($"BankCard card {bankCard.Name} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting bank card.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToComboBoxCardOptionsCardType(BindType.Setnull);
            this._bindDataToGridViewBankCard();
            this._clearBankCardControls();
        }

        private void buttonNewPaymentMethod_Click(object sender, EventArgs e)
        {
            this._paymentMode = (this._paymentMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewPaymentMethod.Text = (this._paymentMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewPaymentMethods.Enabled = (this._paymentMode != Mode.Add);

            if (this._paymentMode == Mode.Add)
            {
                this._bindDataToComboBoxPaymentMethodOptionsCard(BindType.Select);
                this._bindDataToComboBoxPaymentMethodOptionsCardOwner(BindType.Select);

                this._clearPaymentMethodControls();
                this._setEditablePaymentMethods(true);
                this._newPaymentMethod = new PaymentMethod();
            }
            else
            {
                this._bindDataToComboBoxPaymentMethodOptionsCard(BindType.Setnull);
                this._bindDataToComboBoxPaymentMethodOptionsCardOwner(BindType.Setnull);

                this._setEditablePaymentMethods(false);
            }

            this._clearPaymentMethodControls();
        }

        private void buttonSavePaymentMethod_Click(object sender, EventArgs e)
        {
            this._setPaymentMethodDataFromUiToObject(this._newPaymentMethod);
            this.dbContext.PaymentMethod.Add(this._newPaymentMethod);

            try
            {
                this.dbContext.SaveChanges();
                //this.onPaymentMethodSaved($"Item {this._newPaymentMethod.Name} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding payment method.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearPaymentMethodControls();
            this._setEditablePaymentMethods(false);
            this._bindDataToGridViewPaymentMethod();
            this._newPaymentMethod = new PaymentMethod();
            this._paymentMode = Mode.Display;
        }

        private void buttonUpdatePaymentMethod_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewPaymentMethods.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int paymentMethodId = Convert.ToInt32(row.Cells["paymentMethodId"].Value);
            PaymentMethod paymentMethod = this.dbContext.PaymentMethod.Where(r => r.id == paymentMethodId).FirstOrDefault();

            this._setPaymentMethodDataFromUiToObject(paymentMethod);

            try
            {
                this.dbContext.SaveChanges();
                //this.onPaymentMethodUpdated($"PaymentMethod {paymentMethod.Name} updated", DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewPaymentMethod();
            this._checkPaymentMethodOptionsEditableCheckBox(false);
        }

        private void buttonDeletePaymentMethod_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewPaymentMethods.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to remove first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int paymentMethodId = Convert.ToInt32(row.Cells["paymentMethodId"].Value);
            var paymentMethod = dbContext.PaymentMethod.Where(r => r.id == paymentMethodId).FirstOrDefault();

            var tactionConflictionsQuery = from taction in dbContext.Taction
                                           join paymentmethod in dbContext.PaymentMethod on taction.PaymentMethodId equals paymentmethod.id
                                           where paymentmethod.id == paymentMethodId
                                           select taction;

            List<Taction> tactionsToConflict = tactionConflictionsQuery.ToList();

            if (tactionsToConflict.Count > 0)
            {
                string message = $"You can't delete this payment method. There are {tactionsToConflict.Count} tactions associated with this payment method.\nIf you are serious about deleting this payment method, you have to delete all these taction before deleting this payment method.";
                MessageBox.Show(message, "Unable to delete item group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dbContext.PaymentMethod.Remove(paymentMethod);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing payment method.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewPaymentMethod();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxPaymentMethodOptionsCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bankCardName = this.comboBoxPaymentMethodOptionsCard.Text;
            this._bindDataToComboBoxPaymentMethodOptionsCardType(BindType.Select, bankCardName);
        }

        private void checkBoxCardOptionsEdit_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewBankCards.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string bankCardName = row.Cells["bankCardName"].Value.ToString();

            string bankCardType = null;
            if (row.Cells["bankCardType"].Value != null)
                bankCardType = row.Cells["bankCardType"].Value.ToString();

            int bankCardId = this._getBankCardId(bankCardName, bankCardType);

            if (this.checkBoxCardOptionsEdit.Checked)
                this._bindDataToComboBoxCardOptionsCardType(BindType.Select, 0, bankCardName, bankCardType);
            else
                this._bindDataToComboBoxCardOptionsCardType(BindType.Where, bankCardId);
        }

        private void checkBoxPaymentMethodOptionsEdit_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewPaymentMethods.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string bankCardName = row.Cells["bankCardName"].Value.ToString();

            string bankCardType = null;
            if (row.Cells["bankCardType"].Value != null)
                bankCardType = row.Cells["bankCardType"].Value.ToString();

            int bankCardId = this._getBankCardId(bankCardName, bankCardType);
            int cardOwnerId = Convert.ToInt32(row.Cells["cardOwnerId"].Value);

            if (this.checkBoxPaymentOptionsEdit.Checked)
            {
                this._bindDataToComboBoxPaymentMethodOptionsCard(BindType.Select, bankCardName);
                this._bindDataToComboBoxPaymentMethodOptionsCardType(BindType.Select, bankCardName, bankCardType);
                this._bindDataToComboBoxPaymentMethodOptionsCardOwner(BindType.Select, cardOwnerId);
            }
            else
            {
                this._bindDataToComboBoxPaymentMethodOptionsCard(BindType.Where, bankCardName, bankCardType);
                this._bindDataToComboBoxPaymentMethodOptionsCardType(BindType.Where, bankCardName, null, bankCardId);
                this._bindDataToComboBoxPaymentMethodOptionsCardOwner(BindType.Where, cardOwnerId);
            }
        }

        private void _bindDataToGridViewBankCard()
        {
            var query = from bankCard in dbContext.BankCard
                        orderby bankCard.Name ascending
                        select new
                        {
                            bankCardId = bankCard.id,
                            bankCardName = bankCard.Name,
                            bankCardType = bankCard.Type
                        };

            this.dataGridViewBankCards.DataSource = query.ToList();
            //this.onBankCardsLoaded("Bank Cards Loaded", DateTime.Now);
        }

        private void _bindDataToGridViewPaymentMethod()
        {
            var query = from paymentMethod in dbContext.PaymentMethod
                        join bankCard in dbContext.BankCard on paymentMethod.BankCardId equals bankCard.id
                        join user in dbContext.User on paymentMethod.CardOwnerId equals user.id
                        orderby paymentMethod.Name ascending
                        select new
                        {
                            paymentMethodId = paymentMethod.id,
                            bankCardId = bankCard.id,
                            cardOwnerId = user.id,
                            paymentMethodName = paymentMethod.Name,
                            bankCardName = bankCard.Name,
                            bankCardType = bankCard.Type,
                            personName = user.Name
                        };

            this.dataGridViewPaymentMethods.DataSource = query.ToList();
            //this.onPaymentMethodsLoaded("Payment Methods Loaded", DateTime.Now);
        }

        private void _bindDataToComboBoxCardOptionsCardType(BindType bindType, int bankCardId = 0, string bankCardName = null, string bankCardType = null)
        {
            IQueryable<BankCard> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from bankCard in dbContext.BankCard where bankCard.Name == bankCardName orderby bankCard.Name ascending select bankCard;
                    break;
                case BindType.Where:
                    query = from bankCard in dbContext.BankCard where bankCard.id == bankCardId select bankCard;
                    break;
                case BindType.Setnull:
                    this.comboBoxCardOptionsCardType.DataSource = null;
                    return;

            }

            this.comboBoxCardOptionsCardType.DataSource = query.ToList();
            this.comboBoxCardOptionsCardType.DisplayMember = "Type";
            this.comboBoxCardOptionsCardType.ValueMember = "Type";

            if (bindType == BindType.Select && !string.IsNullOrEmpty(bankCardType))
                this.comboBoxCardOptionsCardType.SelectedValue = bankCardType;
        }

        private void _bindDataToComboBoxPaymentMethodOptionsCard(BindType bindType, string bankCardName = null, string bankCardType = null)
        {
            switch (bindType)
            {
                case BindType.Select:
                    var querySelect = from bankCard in dbContext.BankCard group bankCard by bankCard.Name into g orderby g.Key select new { Name = g.Key };

                    this.comboBoxPaymentMethodOptionsCard.DataSource = querySelect.ToList();
                    this.comboBoxPaymentMethodOptionsCard.DisplayMember = "Name";
                    this.comboBoxPaymentMethodOptionsCard.ValueMember = "Name";
                    break;
                case BindType.Where:
                    var queryWhere = from bankCard in dbContext.BankCard where bankCard.Name == bankCardName && bankCard.Type == bankCardType select bankCard;

                    this.comboBoxPaymentMethodOptionsCard.DataSource = queryWhere.ToList();
                    this.comboBoxPaymentMethodOptionsCard.DisplayMember = "Name";
                    this.comboBoxPaymentMethodOptionsCard.ValueMember = "Name";
                    break;
                case BindType.Setnull:
                    this.comboBoxCardOptionsCardType.DataSource = null;
                    break;
            }

            if (bindType == BindType.Select && !string.IsNullOrEmpty(bankCardName))
                this.comboBoxPaymentMethodOptionsCard.SelectedValue = bankCardName;
        }

        private void _bindDataToComboBoxPaymentMethodOptionsCardType(BindType bindType, string bankCardName, string bankCardType = null, int bankCardId = 0)
        {
            IQueryable<BankCard> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from bankCard in dbContext.BankCard where bankCard.Name == bankCardName orderby bankCard.Name ascending select bankCard;
                    break;
                case BindType.Where:
                    query = from bankCard in dbContext.BankCard where bankCard.id == bankCardId select bankCard;
                    break;
                case BindType.Setnull:
                    this.comboBoxCardOptionsCardType.DataSource = null;
                    return;

            }

            this.comboBoxPaymentMethodOptionsCardType.DataSource = query.ToList();
            this.comboBoxPaymentMethodOptionsCardType.DisplayMember = "Type";
            this.comboBoxPaymentMethodOptionsCardType.ValueMember = "Type";

            if (bindType == BindType.Select && !string.IsNullOrEmpty(bankCardType))
                this.comboBoxPaymentMethodOptionsCardType.SelectedValue = bankCardType;
        }

        private void _bindDataToComboBoxPaymentMethodOptionsCardOwner(BindType bindType, int cardOwnerId = 0)
        {
            IQueryable<User> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from user in dbContext.User orderby user.Name ascending select user;
                    break;
                case BindType.Where:
                    query = from user in dbContext.User where user.id == cardOwnerId select user;
                    break;
                case BindType.Setnull:
                    this.comboBoxPaymentMethodOptionsCardOwner.DataSource = null;
                    return;

            }

            this.comboBoxPaymentMethodOptionsCardOwner.DataSource = query.ToList();
            this.comboBoxPaymentMethodOptionsCardOwner.DisplayMember = "Name";
            this.comboBoxPaymentMethodOptionsCardOwner.ValueMember = "id";

            if (bindType == BindType.Select && cardOwnerId > 0)
                this.comboBoxPaymentMethodOptionsCardOwner.SelectedValue = cardOwnerId;
        }

        private void _setBankCardControls(DataGridViewRow row)
        {
            int bankCardId = Convert.ToInt32(row.Cells["bankCardId"].Value);
            this.textBoxCardOptionsCard.Text = row.Cells["bankCardName"].Value.ToString();
            this._bindDataToComboBoxCardOptionsCardType(BindType.Where, bankCardId);
        }

        private void _setPaymentMethodControls(DataGridViewRow row)
        {
            string bankCardName = row.Cells["bankCardName"].Value.ToString();
            
            string bankCardType = null;
            if (row.Cells["bankCardType"].Value != null)
                bankCardType = row.Cells["bankCardType"].Value.ToString();

            int bankCardId = this._getBankCardId(bankCardName, bankCardType);
            int cardOwnerId = Convert.ToInt32(row.Cells["cardOwnerId"].Value);

            this.textBoxPaymentMethodOptionsPaymentMethod.Text = row.Cells["paymentMethodName"].Value.ToString();
            this._bindDataToComboBoxPaymentMethodOptionsCard(BindType.Where, bankCardName, bankCardType);
            this._bindDataToComboBoxPaymentMethodOptionsCardType(BindType.Where, null, null, bankCardId);
            this._bindDataToComboBoxPaymentMethodOptionsCardOwner(BindType.Where, cardOwnerId);
        }

        private void _setBankCardDataFromUiToObject(BankCard bankCard)
        {
            if (string.IsNullOrEmpty(this.textBoxCardOptionsCard.Text))
            {
                MessageBox.Show("\"You didn't enter card name.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bankCard.Name = textBoxCardOptionsCard.Text;

            if (!string.IsNullOrEmpty(this.comboBoxCardOptionsCardType.Text))
                bankCard.Type = this.comboBoxCardOptionsCardType.Text;
        }

        private void _setPaymentMethodDataFromUiToObject(PaymentMethod paymentMethod)
        {
            if (string.IsNullOrEmpty(this.textBoxPaymentMethodOptionsPaymentMethod.Text))
            {
                MessageBox.Show("You didn't enter payment method name.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxPaymentMethodOptionsCard.SelectedItem == null)
            {
                MessageBox.Show("You didn't select bank card.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxPaymentMethodOptionsCardOwner.SelectedItem == null)
            {
                MessageBox.Show("You didn't select card owner.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            paymentMethod.Name = this.textBoxPaymentMethodOptionsPaymentMethod.Text;

            string bankCardName = this.comboBoxPaymentMethodOptionsCard.Text;
            string bankCardType = this.comboBoxPaymentMethodOptionsCardType.Text;
            
            paymentMethod.BankCardId = this._getBankCardId(bankCardName, bankCardType);
            paymentMethod.CardOwnerId = Convert.ToInt32(this.comboBoxPaymentMethodOptionsCardOwner.SelectedValue);
        }

        private int _getBankCardId(string bankCardName, string bankCardType)
        {
            if (string.IsNullOrEmpty(bankCardType))
                return this.dbContext.BankCard.Where(r => r.Name == bankCardName).FirstOrDefault().id;
            else
                return this.dbContext.BankCard.Where(r => r.Name == bankCardName && r.Type == bankCardType).FirstOrDefault().id;
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

        private void _setEditableBankCards(bool isEditable)
        {
            this.buttonSaveCard.Enabled = isEditable;
            this.buttonUpdateCard.Enabled = !isEditable;
            this.buttonDeleteCard.Enabled = !isEditable;
        }

        private void _setEditablePaymentMethods(bool isEditable) 
        {
            this.buttonSavePaymentMethod.Enabled = isEditable;
            this.buttonUpdatePaymentMethod.Enabled = !isEditable;
            this.buttonDeletePaymentMethod.Enabled = !isEditable;
        }

        private void _checkCardOptionsEditableCheckBox(bool check)
        {
            this.checkBoxCardOptionsEdit.Checked = check;
        }

        private void _checkPaymentMethodOptionsEditableCheckBox(bool check)
        {
            this.checkBoxPaymentOptionsEdit.Checked = check;
        }

        private void _clearBankCardControls()
        {
            foreach (Control c in this.groupBoxBankCardOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _clearPaymentMethodControls()
        {
            foreach (Control c in this.groupBoxPaymentMethodOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _setModes(Mode mode)
        {
            this._bankCardMode = mode;
            this._paymentMode = mode;
        }
    }
}
