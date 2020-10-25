using System;
using System.Collections;
using System.Collections.Generic;

namespace TDSM.Data.Lib.Models
{
    public class TaxiShiftModel
    {
        public string ShiftNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TaxiKm { get; set; }
        public double PaidKm { get; set; }
        public decimal NetRevenue { get; set; }
        public decimal Tips { get; set; }
        public decimal Cash { get; set; }
        public double LoggedInHours { get; set; }
        public double PaidHours { get; set; }
        public string TaxiPermit { get; set; }
        public string DriverNumber { get; set; }
        public IList<TaxiTripModel> Trips { get; set; }
        public int NumberOfTrips { get; private set; }

        public TaxiShiftModel(string shiftNumber, DateTime startDate, string taxiPermit, string driverNumber)
        {
            ShiftNumber = shiftNumber;
            StartDate = startDate;
            EndDate = StartDate.AddHours(12);
            TaxiKm = 0.00;
            PaidKm = 0.00;
            NetRevenue = 0.00M;
            Tips = 0.00M;
            Cash = 0.00M;
            LoggedInHours = new TimeSpan(EndDate.Ticks - startDate.Ticks).Hours;
            PaidHours = 0.00;
            TaxiPermit = taxiPermit;
            DriverNumber = driverNumber;
            Trips = new List<TaxiTripModel>();
            NumberOfTrips = Trips.Count;
        }

    }
}