using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dotmim.Sync;
using Dotmim.Sync.SqlServer;
using Dotmim.Sync.MySql;
using Dotmim.Sync.Sqlite;
using System.ComponentModel;

namespace Maya.DatabaseSynchronization
{
    public class DBSyncer
    {
        public enum SyncType
        {
            BetweenSqlServerAndSQLite = 1,
            BetweenMySQLAndSQLite = 2
        }

        public void Run(SyncType syncType)
        {
            SyncAgent agent;
            SqlSyncProvider sqlServerProvider;
            MySqlSyncProvider mysqlServerProvider;
            SqliteSyncProvider clientProvider = clientProvider = new SqliteSyncProvider(Config.SqliteProvider);

            switch (syncType)
            {
                case SyncType.BetweenSqlServerAndSQLite:
                    sqlServerProvider = new SqlSyncProvider(Config.SqlProvider);
                    agent = new SyncAgent(clientProvider, sqlServerProvider);
                    break;
                case SyncType.BetweenMySQLAndSQLite:
                    mysqlServerProvider = new MySqlSyncProvider(Config.MySQLProvider);
                    agent = new SyncAgent(clientProvider, mysqlServerProvider);
                    break;
                default:
                    throw new Exception("Cannot find sync type !");
            }
            
            var setup = new SyncSetup(Config.SyncSetupTables);
            var result = agent.SynchronizeAsync(setup);
            Console.WriteLine(result.Result);
        }

    }
}
