using Dotmim.Sync.Sqlite;
using Dotmim.Sync.SqlServer;
using Dotmim.Sync;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DatabaseSync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBSync dbsync = new DBSync();
            dbsync.Run(DBSync.SyncType.BetweenSqlServerAndSQLite);
        }
    }
}
