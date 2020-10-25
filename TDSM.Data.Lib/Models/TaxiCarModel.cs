using System.Collections;
using System.Collections.Generic;

namespace TDSM.Data.Lib.Models
{
    public class TaxiCarModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicencePlate { get; set; }
        public string Permit { get; set; }
        public int Milage { get; set; }
        public IList<TaxiShiftModel> Shifts { get; set; }
        public IList<TaxiCarMaintenanceModel> Maintenances { get; set; }

        public TaxiCarModel(string brand, string model, int year, string licensePlate, string permit, int milage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            LicencePlate = licensePlate;
            Permit = permit;
            Milage = milage;
            Shifts = new List<TaxiShiftModel>();
            Maintenances = new List<TaxiCarMaintenanceModel>();
        }
    }
}