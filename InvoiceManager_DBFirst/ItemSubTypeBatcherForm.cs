using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    public partial class ItemSubTypeBatcherForm : Form
    {
        private InvoicesEntities dbContext;

        private Item _item;
        private ItemSubType _itemSubType;
        private ItemSubTypeDetails _itemSubTypeDetails;

        public ItemSubTypeBatcherForm()
        {
            InitializeComponent();

            this.dbContext = new InvoicesEntities();
        }

        private void buttonBatch_Click(object sender, EventArgs e)
        {
            //SELECT DISTINCT(ItemSubType.id), ItemSubType.Name FROM ItemSubType
            //JOIN TactionDetails ON ItemSubType.id = TactionDetails.ItemSubTypeId
            //JOIN Item ON Item.id = TactionDetails.ItemId
            //WHERE Item.id = (SELECT Item.id FROM Item WHERE Item.Name = 'Hamidiye Kaynak Suyu');

            List<Item> items =  this.dbContext.Item.ToList();
            foreach (Item i in items)
            {
                IQueryable<ItemSubType> query = from itemSubType in dbContext.ItemSubType
                                                    join details in dbContext.TactionDetails on itemSubType.id equals details.ItemSubTypeId
                                                    join item in dbContext.Item on details.ItemId equals item.id
                                                    where item.id == i.id
                                                    select itemSubType;


                List<ItemSubType> itemSubTypes = query.ToList().Distinct().ToList();
                ItemSubTypeDetails detail = null;
                foreach (ItemSubType itemSubType in itemSubTypes) 
                {
                    detail = new ItemSubTypeDetails();
                    detail.ItemSubTypeId = itemSubType.id;
                    detail.ItemId = i.id;
                    this.dbContext.ItemSubTypeDetails.Add(detail);
                }
            }

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "Something gone wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }
    }
}
