using Microsoft.AspNetCore.Identity;

namespace LoginWithID.Database
{
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// First Name of User
        /// </summary>
        public string Name { get; set; }



        /// <summary>
        /// Contact of User
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Address1 of User
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address2 of User
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// City of User
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State of User
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// ZipCode of User
        /// </summary>
        public string Zipcode { get; set; }

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
