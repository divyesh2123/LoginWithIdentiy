using LoginWithID.Database;
using Microsoft.AspNetCore.Identity;

namespace LoginWithID
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
    

        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
