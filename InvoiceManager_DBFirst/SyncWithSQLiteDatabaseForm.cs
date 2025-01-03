using Dotmim.Sync;
using Maya.DatabaseSynchronization;
using Maya.Redirection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager_DBFirst
{
    public partial class SyncWithSQLiteDatabaseForm : Form
    {
        public SyncWithSQLiteDatabaseForm()
        {
            InitializeComponent();
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            DBSyncer dbsync = new DBSyncer();
            Task<SyncResult> result = dbsync.Run(DBSyncer.SyncType.BetweenSqlServerAndSQLite);
            // Instantiate the writer

            TextBoxStreamWriter writer = new TextBoxStreamWriter(this.textBoxOutput);
            // Redirect the out Console stream
            Console.SetOut(writer);

            Console.WriteLine("Now redirecting output to the text box\n");
            Console.WriteLine(result.Result);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
