using System;

namespace TDSM.Data.Lib.Models
{
    /// <summary>
    /// This model represent any type of maintenance on a TaxiCar
    /// Examles: service, wash, tire change etc.
    /// </summary>
    public class TaxiCarMaintenanceModel
    {
        /// <summary>
        /// The date and time of the maintenence
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// a descriptive title of the maintenance
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A description of what was done one the maintenance
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This is the type of maintenance taht was done,
        /// this field will be set from a dropdown loaded from db
        /// </summary>
        public TaxiCarMaintenanceTypeModel MaintenanceType { get; set; }

        /// <summary>
        /// Where was the maintenance done? company, location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// What was the milage on the TaxiCar when the maintenance was done
        /// </summary>
        public int Milage { get; set; }

        /// <summary>
        /// What was the cost of the maintenance
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// How was the maintenance paid for
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Constructor for the TaxiCarMaintenanceModel
        /// </summary>
        /// <param name="date"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="maintenanceType"></param>
        /// <param name="location"></param>
        /// <param name="milage"></param>
        /// <param name="amount"></param>
        /// <param name="paymentMethod"></param>
        public TaxiCarMaintenanceModel(DateTime date, string title, string description, 
            TaxiCarMaintenanceTypeModel maintenanceType, string location, int milage,
            decimal amount, string paymentMethod)
        {
            Date = date;
            Title = title;
            Description = description;
            MaintenanceType = maintenanceType;
            Location = location;
            Milage = milage;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }
    }
}