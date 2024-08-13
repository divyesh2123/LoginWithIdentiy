using System.ComponentModel.DataAnnotations;

namespace LoginWithID.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        /// <summary>
        /// Name of User
        /// </summary>
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }


        /// <summary>
        /// Contact of User
        /// </summary>
        [Required(ErrorMessage = "Contact Number is Required")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// Address1 of User
        /// </summary>
        [Required(ErrorMessage = "Address is Required")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address2 of User
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// City of User
        /// </summary>
        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        /// <summary>
        /// State of User
        /// </summary>
        [Required(ErrorMessage = "State is Required")]
        public string State { get; set; }

        /// <summary>
        /// ZipCode of User
        /// </summary>
        [Required(ErrorMessage = "ZipCode is Required")]

        public string Zipcode { get; set; }


        public bool IsActive { get; set; }
    }
}
