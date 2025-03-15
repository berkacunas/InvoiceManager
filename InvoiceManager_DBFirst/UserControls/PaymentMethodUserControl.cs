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
    public partial class PaymentMethodUserControl : UserControl
    {
        public event Notify BankCardsLoaded;
        public event Notify BankCardSaved;
        public event Notify BankCardUpdated;
        public event Notify BankCardRemoved;

        public event Notify PaymentMethodsLoaded;
        public event Notify PaymentMethodSaved;
        public event Notify PaymentMethodUpdated;
        public event Notify PaymentMethodRemoved;

        public event Notify DataChanged;
        public event Notify PaymentMethodFormOpened;
        public event Notify PaymentMethodFormClosed;

        private InvoicesEntities dbContext;

        private BankCard _newBankCard;
        private PaymentMethod _newPaymentMethod;

        private Mode _bankCardMode;
        private Mode _paymentMode;

        private List<ColumnSortOrder[]> _columnSortOrdersBankCards = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        private List<ColumnSortOrder[]> _columnSortOrdersPaymentMethods = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        public PaymentMethodUserControl()
        {
            InitializeComponent();

            this.Load += paymentMethodUserControl_Load;

            this.dbContext = new InvoicesEntities();

            this.dataGridViewBankCards.DataBindingComplete += dataGridViewBankCards_DataBindingComplete;
            this.dataGridViewBankCards.DataSourceChanged += dataGridViewBankCards_DataSourceChanged;
            this.dataGridViewBankCards.CellClick += dataGridViewBankCards_CellClick;
            this.dataGridViewBankCards.ColumnHeaderMouseClick += dataGridViewBankCards_ColumnHeaderMouseClick;

            this.dataGridViewPaymentMethods.DataBindingComplete += dataGridViewPaymentMethods_DataBindingComplete;
            this.dataGridViewPaymentMethods.DataSourceChanged += dataGridViewPaymentMethods_DataSourceChanged;
            this.dataGridViewPaymentMethods.CellClick += dataGridViewPaymentMethods_CellClick;
            this.dataGridViewPaymentMethods.ColumnHeaderMouseClick += dataGridViewPaymentMethods_ColumnHeaderMouseClick;

            this.buttonNewCard.Click += buttonNewCard_Click;
            this.buttonSaveCard.Click += buttonSaveCard_Click;
            this.buttonUpdateCard.Click += buttonUpdateCard_Click;
            this.buttonDeleteCard.Click += buttonDeleteCard_Click;

            this.buttonNewPaymentMethod.Click += buttonNewPaymentMethod_Click;
            this.buttonSavePaymentMethod.Click += buttonSavePaymentMethod_Click;
            this.buttonUpdatePaymentMethod.Click += buttonUpdatePaymentMethod_Click;
            this.buttonDeletePaymentMethod.Click += buttonDeletePaymentMethod_Click;

            this.comboBoxPaymentMethodOptionsCard.SelectedIndexChanged += comboBoxPaymentMethodOptionsCard_SelectedIndexChanged;
            this.checkBoxCardOptionsEdit.CheckedChanged += checkBoxCardOptionsEdit_CheckedChanged;
            this.checkBoxPaymentMethodOptionsEdit.CheckedChanged += checkBoxPaymentMethodOptionsEdit_CheckedChanged;
        }

        #region Event Handlers

        private void paymentMethodUserControl_Load(object sender, EventArgs e)
        {
            this._setModes(Mode.Display);

            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewBankCards);
            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewPaymentMethods);

            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewBankCards, false);
            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewPaymentMethods, false);

            this._setEditableBankCards(false);
            this._setEditablePaymentMethods(false);

            this.comboBoxPaymentMethodOptionsCard.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethodOptionsCardType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethodOptionsCardOwner.DropDownStyle = ComboBoxStyle.DropDownList;

            this._bindDataToGridViewBankCard();
            this._bindDataToGridViewPaymentMethod();

            this.onPaymentMethodFormOpened("PaymentMethods", "Payment Method Window opened", DateTime.Now);
        }

        private void dataGridViewBankCards_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewBankCards.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewBankCards.Rows[0];
                if (row != null)
                    this._setBankCardControls(row);
            }
        }

        private void dataGridViewPaymentMethods_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewPaymentMethods.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewPaymentMethods.Rows[0];
                if (row != null)
                    this._setPaymentMethodControls(row);
            }
        }

        private void dataGridViewBankCards_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewBankCards.DataSource == null)
                return;

            string[] headerTexts = new string[] { "bankCardId", "Bank", "Type" };
            int[] columnWidths = new int[] { 50, 150, 150 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft,
                                                                        DataGridViewContentAlignment.MiddleLeft };

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewBankCards, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewBankCards.Columns["bankCardId"].Visible = false;
        }

        private void dataGridViewPaymentMethods_DataSourceChanged(object sender, EventArgs e)
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

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewPaymentMethods, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewPaymentMethods.Columns["paymentMethodId"].Visible = false;
            this.dataGridViewPaymentMethods.Columns["bankCardId"].Visible = false;
            this.dataGridViewPaymentMethods.Columns["cardOwnerId"].Visible = false;
        }
        
        private void dataGridViewBankCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._setEditableBankCards(false);
            this._checkCardOptionsEditableCheckBox(false);

            this._clearBankCardControls();
            DataGridViewRow row = this.dataGridViewBankCards.CurrentRow;
            this._setBankCardControls(row);
        }

        private void dataGridViewPaymentMethods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._setEditablePaymentMethods(false);
            this._checkPaymentMethodOptionsEditableCheckBox(false);

            this._clearPaymentMethodControls();
            DataGridViewRow row = this.dataGridViewPaymentMethods.CurrentRow;
            this._setPaymentMethodControls(row);
        }

        private void dataGridViewBankCards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewBankCards.Columns[e.ColumnIndex].HeaderText;

            var query = from bankCard in dbContext.BankCard
                        orderby bankCard.Name ascending
                        select new
                        {
                            bankCardId = bankCard.id,
                            bankCardName = bankCard.Name,
                            bankCardType = bankCard.Type
                        };

            switch (columnName)
            {
                case "Bank":
                    this.dataGridViewBankCards.DataSource = (this._columnSortOrdersBankCards[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.bankCardName).ToList() : query.OrderByDescending(r => r.bankCardName).ToList();
                    this._columnSortOrdersBankCards[0][0] = (this._columnSortOrdersBankCards[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Type":
                    this.dataGridViewBankCards.DataSource = (this._columnSortOrdersBankCards[1][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.bankCardType).ToList() : query.OrderByDescending(r => r.bankCardType).ToList();
                    this._columnSortOrdersBankCards[1][0] = (this._columnSortOrdersBankCards[1][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
            }
        }

        private void dataGridViewPaymentMethods_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewPaymentMethods.Columns[e.ColumnIndex].HeaderText;

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

            switch (columnName)
            {
                case "Method":
                    this.dataGridViewPaymentMethods.DataSource = (this._columnSortOrdersPaymentMethods[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.paymentMethodName).ToList() : query.OrderByDescending(r => r.paymentMethodName).ToList();
                    this._columnSortOrdersPaymentMethods[0][0] = (this._columnSortOrdersPaymentMethods[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Bank":
                    this.dataGridViewPaymentMethods.DataSource = (this._columnSortOrdersPaymentMethods[1][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.bankCardName).ToList() : query.OrderByDescending(r => r.bankCardName).ToList();
                    this._columnSortOrdersPaymentMethods[1][0] = (this._columnSortOrdersPaymentMethods[1][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Card Type":
                    this.dataGridViewPaymentMethods.DataSource = (this._columnSortOrdersPaymentMethods[2][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.bankCardType).ToList() : query.OrderByDescending(r => r.bankCardType).ToList();
                    this._columnSortOrdersPaymentMethods[2][0] = (this._columnSortOrdersPaymentMethods[2][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Card Owner":
                    this.dataGridViewPaymentMethods.DataSource = (this._columnSortOrdersPaymentMethods[3][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.personName).ToList() : query.OrderByDescending(r => r.personName).ToList();
                    this._columnSortOrdersPaymentMethods[3][0] = (this._columnSortOrdersPaymentMethods[3][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
            }
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
                this.onBankCardSaved("BankCards", $"New bank card {_newBankCard.id}: {_newBankCard.Name} saved", DateTime.Now);
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
                this.onBankCardUpdated("BankCards", $"Bank card {bankCard.id}: {bankCard.Name} updated", DateTime.Now);
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
                this.onBankCardRemoved("BankCards", $"Bank card {bankCard.id}: {bankCard.Name} removed", DateTime.Now);
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
                this.onPaymentMethodSaved("PaymentMethods", $"Payment method {_newPaymentMethod.id}: {_newPaymentMethod.Name} saved", DateTime.Now);
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
                this.onPaymentMethodUpdated("PaymentMethods", $"Payment method {paymentMethod.id}: {paymentMethod.Name} updated", DateTime.Now);
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
                this.onPaymentMethodRemoved("PaymentMethods", $"Payment method {paymentMethod.id}: {paymentMethod.Name} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing payment method.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewPaymentMethod();
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

            if (this.checkBoxPaymentMethodOptionsEdit.Checked)
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

        #endregion

        #region Databind Queries

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
            this.onBankCardsLoaded("BankCards", "Bank Cards Loaded", DateTime.Now);
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
            this.onPaymentMethodsLoaded("PaymentMethods", "Payment Methods Loaded", DateTime.Now);
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

        #endregion

        #region Set data to Controls

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

        #endregion

        #region Get data from Controls

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

        #endregion

        #region Get data from Db

        private int _getBankCardId(string bankCardName, string bankCardType)
        {
            if (string.IsNullOrEmpty(bankCardType))
                return this.dbContext.BankCard.Where(r => r.Name == bankCardName).FirstOrDefault().id;
            else
                return this.dbContext.BankCard.Where(r => r.Name == bankCardName && r.Type == bankCardType).FirstOrDefault().id;
        }

        #endregion

        #region Set Enabled & Checked & Read-only Controls

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
            this.checkBoxPaymentMethodOptionsEdit.Checked = check;
        }

        private void _setModes(Mode mode)
        {
            this._bankCardMode = mode;
            this._paymentMode = mode;
        }

        #endregion

        #region Clear Controls

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

        #endregion
        
        #region User-defined Event Handlers

        protected virtual void onBankCardsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.BankCardsLoaded?.Invoke(actionType, message, eventTime);
            this.onDataChanged(actionType, message, eventTime);
        }

        protected virtual void onBankCardSaved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.BankCardSaved?.Invoke(actionType, message, eventTime);
            this.onDataChanged(actionType, message, eventTime);
        }

        protected virtual void onBankCardUpdated(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.BankCardUpdated?.Invoke(actionType, message, eventTime);
            this.onDataChanged(actionType, message, eventTime);
        }

        protected virtual void onBankCardRemoved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.BankCardRemoved?.Invoke(actionType, message, eventTime);
            this.onDataChanged(actionType, message, eventTime);
        }

        protected virtual void onPaymentMethodsLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.PaymentMethodsLoaded?.Invoke(actionType, message, eventTime);
            this.onDataChanged(actionType, message, eventTime);
        }

        protected virtual void onPaymentMethodSaved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.PaymentMethodSaved?.Invoke(actionType, message, eventTime);
            this.onDataChanged(actionType, message, eventTime);
        }

        protected virtual void onPaymentMethodUpdated(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.PaymentMethodUpdated?.Invoke(actionType, message, eventTime);
            this.onDataChanged(actionType, message, eventTime);
        }

        protected virtual void onPaymentMethodRemoved(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.PaymentMethodRemoved?.Invoke(actionType, message, eventTime);
            this.onDataChanged(actionType, message, eventTime);
        }

        protected virtual void onDataChanged(string actionType, string message, DateTime eventTime)
        {
            this.DataChanged?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onPaymentMethodFormOpened(string actionType, string message, DateTime eventTime)
        {
            this.PaymentMethodFormOpened?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onPaymentMethodFormClosed(string actionType, string message, DateTime eventTime)
        {
            this.PaymentMethodFormClosed?.Invoke(actionType, message, eventTime);
        }

        #endregion
    }
}
