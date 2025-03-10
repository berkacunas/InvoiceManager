using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst.UserControls
{
    public partial class TactionUserControl : UserControl
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

        public event Notify TransactionsLoaded;
        public event Notify TransactionSaved;
        public event Notify TransactionUpdated;
        public event Notify TransactionRemoved;

        public event Notify TransactionChanged;
        public event Notify TransactionFormOpened;
        public event Notify TransactionFormClosed;

        private ImageList _imageList;

        private InvoicesEntities dbContext;
        private Taction _newTaction;
        private Mode _mode;

        public TactionUserControl()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
        }
    }
}
