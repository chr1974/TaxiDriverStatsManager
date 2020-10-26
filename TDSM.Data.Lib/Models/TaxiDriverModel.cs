namespace TDSM.Data.Lib.Models
{
    /// <summary>
    /// Represent a TaxiDriver
    /// </summary>
    public class TaxiDriverModel
    {
        /// <summary>
        /// primary id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Drivers firstname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Drivers lastname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The drivers id in a central or on a shift
        /// </summary>
        public string DriverNumber { get; set; }

        /// <summary>
        /// Drivers email for password reset
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// drivers username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// password is stored encrypted as a hash
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// This is the password salt to use when checking logins
        /// </summary>
        public string PasswordSalt { get; set; }

        /// <summary>
        /// If set to true driver can make new drivers and look at all drivers registered in the system
        /// at first use, if user db is empty, the first user registered will be set to admin.
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// The TaxiDriver Constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="driverNumber"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="passwordHash"></param>
        /// <param name="passwordSalt"></param>
        public TaxiDriverModel(string firstName, string lastName, string driverNumber, string email,
            string username, string passwordHash, string passwordSalt, bool isAdmin)
        {
            FirstName = firstName;
            LastName = lastName;
            DriverNumber = driverNumber;
            Email = email;
            UserName = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            IsAdmin = isAdmin;
        }
    }
}