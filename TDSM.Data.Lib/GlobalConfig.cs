using System;
using System.Collections.Generic;
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
        /// List of all connections
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();


        /// <summary>
        /// Initialize the connections, set to true to use or false not to use
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textfiles"></param>
        public static void InitializeConnections(bool database, bool textfiles)
        {
            if (database)
            {
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textfiles)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
