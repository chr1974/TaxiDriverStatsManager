namespace TDSM.Data.Lib.Models
{
    /// <summary>
    /// Represent a TaxiCarMaintenanceTypeModel 
    /// </summary>
    public class TaxiCarMaintenanceTypeModel
    {
        /// <summary>
        /// primary id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descriptive name of the TypeModel
        /// examples: Carwash, Car Care, Tire Change, Interval Service etc.
        /// </summary>
        public string Name { get; set; }
    }
}