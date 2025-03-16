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

        private List<ColumnSortOrder[]> _columnSortOrdersSellerTypes = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        private List<ColumnSortOrder[]> _columnSortOrdersSellerGroups = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        private List<ColumnSortOrder[]> _columnSortOrdersSellers = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        public SellerUserControl()
        {
            InitializeComponent();

            this.Load += sellerUserControl_Load;
        }

        private void sellerUserControl_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
