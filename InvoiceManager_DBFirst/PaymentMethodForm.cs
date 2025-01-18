using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    public partial class PaymentMethodForm : Form
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

        private enum SortOrder
        {
            ASC,
            DESC,
            UNORDERED
        }

        private InvoicesEntities dbContext;

        private BankCard _newBankCard;
        private PaymentMethod _newPaymentMethod;

        private Mode _bankCardMode;
        private Mode _paymentMethodMode;

        private SortOrder[] _sortOrdersDataGridViewItemGroups = { SortOrder.ASC, SortOrder.UNORDERED };
        private SortOrder[] _sortOrdersDataGridViewItems = { SortOrder.ASC, SortOrder.UNORDERED };

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
            this.comboBoxPaymentMethodOptionsPerson.DropDownStyle = ComboBoxStyle.DropDownList;

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

            string[] headerTexts = new string[] { "paymentMethodId", "bankCardId", "personId", "Method", "Bank", "Card Type", "Person" };
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
            this.dataGridViewPaymentMethods.Columns["personId"].Visible = false;
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
            this._clearBankCardControls();
            DataGridViewRow row = this.dataGridViewBankCards.CurrentRow;
            this._setBankCardControls(row);
        }

        private void DataGridViewPaymentMethods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearPaymentMethodControls();
            DataGridViewRow row = this.dataGridViewPaymentMethods.CurrentRow;
            this._setPaymentMethodControls(row);
        }

        private void buttonNewCard_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveCard_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateCard_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCard_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        join person in dbContext.Person on paymentMethod.PersonId equals person.id
                        orderby paymentMethod.Name ascending
                        select new
                        {
                            paymentMethodId = paymentMethod.id,
                            bankCardId = bankCard.id,
                            personId = person.id,
                            paymentMethodName = paymentMethod.Name,
                            bankCardName = bankCard.Name,
                            bankCardType = bankCard.Type,
                            personName = person.Name
                        };

            this.dataGridViewPaymentMethods.DataSource = query.ToList();
            //this.onPaymentMethodsLoaded("Payment Methods Loaded", DateTime.Now);
        }

        private void _bindDataToComboBoxBankCardOptionsCardType(BindType bindType, int bankCardId)
        {
            IQueryable<BankCard> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from bankCard in dbContext.BankCard orderby bankCard.Name ascending select bankCard;
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
            this.comboBoxCardOptionsCardType.ValueMember = "id";
        }

        private void _bindDataToComboBoxPaymentMethodOptionsCard(BindType bindType, int bankCardId)
        {
            IQueryable<BankCard> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from bankCard in dbContext.BankCard orderby bankCard.Name ascending select bankCard;
                    break;
                case BindType.Where:
                    query = from bankCard in dbContext.BankCard where bankCard.id == bankCardId select bankCard;
                    break;
                case BindType.Setnull:
                    this.comboBoxCardOptionsCardType.DataSource = null;
                    return;

            }

            this.comboBoxPaymentMethodOptionsCard.DataSource = query.ToList();
            this.comboBoxPaymentMethodOptionsCard.DisplayMember = "Name";
            this.comboBoxPaymentMethodOptionsCard.ValueMember = "id";
        }

        private void _bindDataToComboBoxPaymentMethodOptionsCardType(BindType bindType, int bankCardId)
        {
            IQueryable<BankCard> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from bankCard in dbContext.BankCard orderby bankCard.Name ascending select bankCard;
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
            this.comboBoxPaymentMethodOptionsCardType.ValueMember = "id";
        }

        private void _bindDataToComboBoxPaymentMethodOptionsPerson(BindType bindType, int personId)
        {
            IQueryable<Person> query = null;

            switch (bindType)
            {
                case BindType.Select:
                    query = from person in dbContext.Person orderby person.Name ascending select person;
                    break;
                case BindType.Where:
                    query = from person in dbContext.Person where person.id == personId select person;
                    break;
                case BindType.Setnull:
                    this.comboBoxPaymentMethodOptionsPerson.DataSource = null;
                    return;

            }

            this.comboBoxPaymentMethodOptionsPerson.DataSource = query.ToList();
            this.comboBoxPaymentMethodOptionsPerson.DisplayMember = "Name";
            this.comboBoxPaymentMethodOptionsPerson.ValueMember = "id";
        }

        private void _setBankCardControls(DataGridViewRow row)
        {
            int bankCardId = Convert.ToInt32(row.Cells["bankCardId"].Value);
            this.textBoxCardOptionsCard.Text = row.Cells["bankCardName"].Value.ToString();
            this._bindDataToComboBoxBankCardOptionsCardType(BindType.Where, bankCardId);
        }

        private void _setPaymentMethodControls(DataGridViewRow row)
        {
            int bankCardId = Convert.ToInt32(row.Cells["bankCardId"].Value);
            int personId = Convert.ToInt32(row.Cells["personId"].Value);

            this.textBoxPaymentMethodOptionsPaymentMethod.Text = row.Cells["paymentMethodName"].Value.ToString();
            this._bindDataToComboBoxPaymentMethodOptionsCard(BindType.Where, bankCardId);
            this._bindDataToComboBoxPaymentMethodOptionsCardType(BindType.Where, bankCardId);
            this._bindDataToComboBoxPaymentMethodOptionsPerson(BindType.Where, personId);
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

        private void _clearBankCardControls()
        {
            foreach (Control c in this.groupBoxBankCardOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _clearPaymentMethodControls()
        {
            foreach (Control c in this.groupBoxPaymentMethods.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _setModes(Mode mode)
        {
            this._bankCardMode = mode;
            this._paymentMethodMode = mode;
        }
    }
}
