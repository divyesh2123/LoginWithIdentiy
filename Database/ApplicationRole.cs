using Microsoft.AspNetCore.Identity;

namespace LoginWithID
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
