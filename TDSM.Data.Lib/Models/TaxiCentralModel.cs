using System;
using System.Collections.Generic;
using System.Text;

namespace TDSM.Data.Lib.Models
{
    /// <summary>
    /// Represent a TaxiCentral
    /// If a car is not a part of a central, make a default central called NONE
    /// to keep track of cars and drivers not part of a central
    /// </summary>
    public class TaxiCentralModel
    {
        /// <summary>
        /// The name of the taxi central
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// List of all TaxiCars represented in this central
        /// </summary>
        public IList<TaxiCarModel> TaxiCars { get; set; }

        /// <summary>
        /// List of taxi drivers in the central
        /// </summary>
        public IList<TaxiDriverModel> TaxiDrivers { get; set; }

        /// <summary>
        /// The constructor of a TaxiCar
        /// </summary>
        /// <param name="name"></param>
        public TaxiCentralModel(string name)
        {
            Name = name;
            TaxiCars = new List<TaxiCarModel>();
            TaxiDrivers = new List<TaxiDriverModel>();
        }

    }
}
