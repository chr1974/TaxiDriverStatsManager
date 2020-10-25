using System;

namespace TDSM.Data.Lib.Models
{
    public class TaxiCarMaintenanceModel
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaxiCarMaintenanceTypeModel MaintenanceType { get; set; }
        public string Location { get; set; }
        public int Milage { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }

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