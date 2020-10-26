using System;

namespace TDSM.Data.Lib.Models
{
    /// <summary>
    /// Represent a single trip
    /// </summary>
    public class TaxiTripModel
    {
        /// <summary>
        /// primary id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The recieptNumber on the trip reciept
        /// from the taxameter
        /// </summary>
        public string RecieptNumber { get; set; }
        
        /// <summary>
        /// How did the passenger pay for the trip 
        /// eg. card, cash, credit, voucher etc.
        /// </summary>
        public TaxiTripPaymentTypeModel PaymentType  { get; set; }

        /// <summary>
        /// What type of trip was done
        /// eg. Spot Trip, Ordered Trip, Special Trip, Patient Trip, School trip etc.
        /// </summary>
        public TaxiTripTypeModel TripType { get; set; }

        /// <summary>
        /// Start date and time of the trip
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End date and time of the trip
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The address or place wher the passenger was picked up.
        /// </summary>
        public string FromAddress { get; set; }

        /// <summary>
        /// The address or place where the passenger was dropped off.
        /// </summary>
        public string ToAddress { get; set; }

        /// <summary>
        /// How long time did the trip take in hours? eg 1.64 hours or 0.25 hours
        /// </summary>
        public double TimeUsed { get; set; }

        /// <summary>
        /// Total distance driven on the trip in km
        /// </summary>
        public double DistanceKm { get; set; }

        /// <summary>
        /// What did the passenger pay for the trip not including tips
        ///  -- Taxameter Fare --
        /// </summary>
        public decimal TripPrice { get; set; }

        /// <summary>
        /// How many pax was in the car during the trip
        /// </summary>
        public int NumberOfPax { get; set; }

        /// <summary>
        /// The constructor for TaxiTripModel
        /// </summary>
        /// <param name="recieptNumber"></param>
        /// <param name="paymentType"></param>
        /// <param name="tripType"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="fromAddress"></param>
        /// <param name="toAddress"></param>
        /// <param name="timeUsed"></param>
        /// <param name="distanceKm"></param>
        /// <param name="tripPrice"></param>
        /// <param name="numberOfPax"></param>
        public TaxiTripModel(string recieptNumber, TaxiTripPaymentTypeModel paymentType,
            TaxiTripTypeModel tripType, DateTime startDate, DateTime endDate,
            string fromAddress, string toAddress, double timeUsed, double distanceKm,
            decimal tripPrice, int numberOfPax)
        {
            RecieptNumber = recieptNumber;
            PaymentType = paymentType;
            TripType = tripType;
            StartDate = startDate;
            EndDate = endDate;
            FromAddress = fromAddress;
            ToAddress = toAddress;
            TimeUsed = timeUsed;
            DistanceKm = distanceKm;
            TripPrice = tripPrice;
            NumberOfPax = numberOfPax;
        }
    }
}