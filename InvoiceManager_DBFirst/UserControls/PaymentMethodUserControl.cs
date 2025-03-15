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
        private InvoicesEntities dbContext;

        private BankCard _newBankCard;
        private PaymentMethod _newPaymentMethod;

        private Mode _bankCardMode;
        private Mode _paymentMode;

        private ColumnSortOrder[] _sortOrdersDataGridViewItemGroups = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };
        private ColumnSortOrder[] _sortOrdersDataGridViewItems = { ColumnSortOrder.ASC, ColumnSortOrder.UNORDERED };

        public PaymentMethodUserControl()
        {
            InitializeComponent();
        }
    }
}
