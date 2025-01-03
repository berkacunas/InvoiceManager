using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

using Maya.DatabaseSynchronization;

namespace InvoiceManager_DBFirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void toolStripMenuItem_Transactions_Click(object sender, EventArgs e)
        {
            TactionForm form = new TactionForm();

            if (form.ShowDialog() == DialogResult.OK) 
            { 
                
            }
        }

        private void toolStripMenuItem_Items_Click(object sender, EventArgs e)
        {
            ItemForm form = new ItemForm();

            if (form.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void toolStripMenuItemSyncWithSQLiteDatabase_Click(object sender, EventArgs e)
        {
            DBSyncer dbsync = new DBSyncer();
            dbsync.Run(DBSyncer.SyncType.BetweenSqlServerAndSQLite);
        }
    }
}
