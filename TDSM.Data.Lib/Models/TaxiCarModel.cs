using System.Collections;
using System.Collections.Generic;

namespace TDSM.Data.Lib.Models
{
    /// <summary>
    /// Represent a TaxiCar
    /// </summary>
    public class TaxiCarModel
    {
        /// <summary>
        /// primary id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Brand of the car eg. Toyota, Mercedes, Ford etc.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// The Model of the Car eg. Prius, E 350, Mustang Shelby Cobra
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The year the car was made
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// The license plate on the car 
        /// </summary>
        public string LicencePlate { get; set; }

        /// <summary>
        /// The TaxiPermit ID or RoofNumber 
        /// </summary>
        public string Permit { get; set; }

        /// <summary>
        /// The Milage of the car when added to the database
        /// </summary>
        public int Milage { get; set; }

        /// <summary>
        /// This is a list holding all shifts made with the car
        /// </summary>
        public IList<TaxiShiftModel> Shifts { get; set; }

        /// <summary>
        /// This is a list holding all maintenances made on the car
        /// </summary>
        public IList<TaxiCarMaintenanceModel> Maintenances { get; set; }

        /// <summary>
        /// The constructor for the TaxiCarModel
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="licensePlate"></param>
        /// <param name="permit"></param>
        /// <param name="milage"></param>
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