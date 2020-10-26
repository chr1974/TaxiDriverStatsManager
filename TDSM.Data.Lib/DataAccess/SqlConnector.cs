using System;
using System.Collections.Generic;
using System.Text;
using TDSM.Data.Lib.Models;

namespace TDSM.Data.Lib.DataAccess
{
    /// <summary>
    /// Connector for working with SqlServer Database
    /// </summary>
    public class SqlConnector : IDataConnection
    {
        // Sql Server Connector
        // TODO - Make the CreateTaxiCentral method actually save to the database
        /// <summary>
        /// Saves a new Taxi central to the database
        /// </summary>
        /// <param name="model">The Taxi central information</param>
        /// <returns>The Taxi Central information, including the unique identifier.</returns>
        public TaxiCentralModel CreateTaxiCentral(TaxiCentralModel model)
        {
            model.Name = "NONE";
            return model;
        }
    }
}
