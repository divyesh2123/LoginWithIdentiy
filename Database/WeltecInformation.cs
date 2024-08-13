using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginWithID.Database
{
    public class WeltecInformation: IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
        ApplicationUserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
    {

        public WeltecInformation(DbContextOptions<WeltecInformation> options)
           : base(options)
        {

           

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();


            });

            builder.Entity<ApplicationRole>().HasData(new ApplicationRole[] {
                new ApplicationRole{Id= "CUS",Name="Customer",NormalizedName = "CUSTOMER"},
                new ApplicationRole{Id="RET",Name="Retailer",NormalizedName="RETAILER"},
                new ApplicationRole{Id="ADN",Name="Admin",NormalizedName="ADMIN"},
            });


        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<ApplicationRole> ApplicationRole { get; set; }

        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }
    }
}
