using System;
using System.Collections;
using System.Collections.Generic;

namespace TDSM.Data.Lib.Models
{

    /// <summary>
    /// Represents a TaxiShift
    /// </summary>
    public class TaxiShiftModel
    {
        /// <summary>
        /// primary id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the shift number on the shift note
        /// </summary>
        public string ShiftNumber { get; set; }

        /// <summary>
        /// The star date and time of the shift
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date and time of the shift
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Total Km driven on the shift
        /// </summary>
        public double TaxiKm { get; set; }

        /// <summary>
        /// Total Km driven with paying passengers on the shift
        /// </summary>
        public double PaidKm { get; set; }

        /// <summary>
        /// Net revenue from wich a driver gets a commision
        /// </summary>
        public decimal NetRevenue { get; set; }

        /// <summary>
        /// Any tip money driver has got on the shift
        /// </summary>
        public decimal Tips { get; set; }

        /// <summary>
        /// Amount of Cash on the shift
        /// </summary>
        public decimal Cash { get; set; }

        /// <summary>
        /// how many hours the driver was logged into the taxameter
        /// on the shift
        /// </summary>
        public double LoggedInHours { get; set; }

        /// <summary>
        /// How many of the hours logged in was when there was paying 
        /// customers in the car
        /// </summary>
        public double PaidHours { get; set; }

        /// <summary>
        /// Which TaxiPermit or car was used...
        /// this will be populated from the selected TaxiCar
        /// when filling a shift
        /// </summary>
        public string TaxiPermit { get; set; }

        /// <summary>
        /// The drivers idnumber, will be filled out from logged in and selected driver
        /// on th shift
        /// </summary>
        public string DriverNumber { get; set; }

        /// <summary>
        /// A list of all the trips added to the shift
        /// </summary>
        public IList<TaxiTripModel> Trips { get; set; }

        /// <summary>
        /// Number of trips in the Trips list
        /// </summary>
        public int NumberOfTrips { get; private set; }


        /// <summary>
        /// The constructor for a TaxiDriver
        /// </summary>
        /// <param name="shiftNumber"></param>
        /// <param name="startDate"></param>
        /// <param name="taxiPermit"></param>
        /// <param name="driverNumber"></param>
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