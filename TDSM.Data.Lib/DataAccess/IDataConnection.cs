using TDSM.Data.Lib.Models;

namespace TDSM.Data.Lib.DataAccess
{
    public interface IDataConnection
    {
        TaxiCentralModel CreateTaxiCentral(TaxiCentralModel model);
    }
}