using System;
using System.Collections.Generic;
using System.Text;

namespace TDSM.Data.Lib.Models
{
    public class TaxiCentralModel
    {
        public string Name { get; set; }
        public IList<TaxiCarModel> TaxiCars { get; set; }
        public IList<TaxiDriverModel> TaxiDrivers { get; set; }

        public TaxiCentralModel(string name)
        {
            Name = name;
            TaxiCars = new List<TaxiCarModel>();
            TaxiDrivers = new List<TaxiDriverModel>();
        }

    }
}
