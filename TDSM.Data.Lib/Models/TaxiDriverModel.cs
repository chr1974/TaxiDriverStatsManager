namespace TDSM.Data.Lib.Models
{
    public class TaxiDriverModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DriverNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public TaxiDriverModel(string firstName, string lastName, string driverNumber, string email,
            string username, string passwordHash, string passwordSalt)
        {
            FirstName = firstName;
            LastName = lastName;
            DriverNumber = driverNumber;
            Email = email;
            UserName = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }
    }
}