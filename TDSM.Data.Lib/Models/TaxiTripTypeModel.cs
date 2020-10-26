namespace TDSM.Data.Lib.Models
{

    /// <summary>
    /// Represent a single Type of a TaxiTrip
    /// </summary>
    public class TaxiTripTypeModel
    {
        /// <summary>
        /// Name of the type
        /// eg. Spot Trip, Ordered Trip, Sightseeing Trip, School Trip, Patients Trip etc..
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        public TaxiTripTypeModel(string name)
        {
            Name = name;
        }
    }
}