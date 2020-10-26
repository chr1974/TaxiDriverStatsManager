using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
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
            using(IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(
                GlobalConfig.GetConnectionString("TDMSDatabase")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTaxiCentral_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;

            }
        }

        public TaxiCentralModel GetTaxiCentralById(int id)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(
                GlobalConfig.GetConnectionString("TDMSDatabase")))
            {
                throw new NotImplementedException();
            }
        }

        public TaxiCentralModel GetAllTaxiCentrals()
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(
                GlobalConfig.GetConnectionString("TDMSDatabase")))
            {
                throw new NotImplementedException();
            }
        }
    }
}
