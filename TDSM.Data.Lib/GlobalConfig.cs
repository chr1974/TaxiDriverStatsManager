using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TDSM.Data.Lib.DataAccess;

namespace TDSM.Data.Lib
{
    /// <summary>
    /// Initalizes connections and
    /// keep track of data connections in a list
    /// </summary>
    public static class GlobalConfig
    {
        /// <summary>
        /// connection
        /// </summary>
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Initialize the connections, set to true to use or false not to use
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textfiles"></param>
        public static void InitializeConnections(DatabaseType db = DatabaseType.Sql)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
