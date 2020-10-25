using System;

namespace TDSM.Data.Lib.Models
{
    public class TaxiTripModel
    {
        public string ReciepeNumber { get; set; }
        public TaxiTripPaymentTypeModel PaymentType  { get; set; }
        public TaxiTripTypeModel TripType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public double TimeUsed { get; set; }
        public double DistanceKm { get; set; }
        public decimal TripPrice { get; set; }
        public int NumberOfPax { get; set; }

        public TaxiTripModel(string reciepeNumber, TaxiTripPaymentTypeModel paymentType,
            TaxiTripTypeModel tripType, DateTime startDate, DateTime endDate,
            string fromAddress, string toAddress, double timeUsed, double distanceKm,
            decimal tripPrice, int numberOfPax)
        {
            ReciepeNumber = reciepeNumber;
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