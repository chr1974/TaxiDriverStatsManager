namespace TDSM.Data.Lib.Models
{

    /// <summary>
    /// PaymentType for a TaxiTripModel
    /// </summary>
    public class TaxiTripPaymentTypeModel
    {
        /// <summary>
        /// Name of payment type
        /// eg. Visa, Mastercard, American Express, Cash, Credit Voucher etc...
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public TaxiTripPaymentTypeModel(string name)
        {
            Name = name;
        }
    }
}