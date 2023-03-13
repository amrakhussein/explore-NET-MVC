using Microsoft.AspNetCore.Identity;

using Microsoft.EntityFrameworkCore;

using SimpleSchoolSystem.Constants;
using SimpleSchoolSystem.Models;

namespace SimpleSchoolSystem.Data;


public static class AppSeedDataExtension
{
    public static void Seed(this ModelBuilder builder)
    {
        var mockedUserId = Guid.NewGuid().ToString();
        var mockedAdminId = Guid.NewGuid().ToString();

        var mockedAdminRoleId = Guid.NewGuid().ToString();
        var mockedUserRoleId = Guid.NewGuid().ToString();
        var mockedStandartRoleId = Guid.NewGuid().ToString();
        var mockedGuestRoleId = Guid.NewGuid().ToString();

        var hasher = new PasswordHasher<IdentityUser>();

        // add admin/user dummy data
        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = mockedUserId,
                FirstName = "Jhon",
                LastName = "Smith",
                UserName = "User",
                Email = "hello@host.com",
                NormalizedUserName = "USER",
                PasswordHash = hasher.HashPassword(null, "123")
            },
             new ApplicationUser
             {
                 Id = mockedAdminId,
                 FirstName = "Amr",
                 LastName = "Abdelkamel",
                 UserName = "Admin",
                 Email = "admin@host.com",
                 NormalizedUserName = "ADMIN",
                 PasswordHash = hasher.HashPassword(null, "123")
             }
        );

        // add identity roles
        builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Id = mockedAdminRoleId,
                Name = RoleConstants.Admin,
                NormalizedName = RoleConstants.Admin.ToUpper(),

                // not recommeded // for testing purposes
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new IdentityRole
            {
                Id = mockedStandartRoleId,
                Name = RoleConstants.Standard,
                NormalizedName = RoleConstants.Standard.ToUpper(),

                // not recommeded // for testing purposes
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new IdentityRole
            {
                Id = mockedUserRoleId,
                Name = RoleConstants.User,
                NormalizedName = RoleConstants.User.ToUpper(),

                // not recommeded // for testing purposes
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new IdentityRole
            {
                Id = mockedGuestRoleId,
                Name = RoleConstants.Guest,
                NormalizedName = RoleConstants.Guest.ToUpper(),

                // not recommeded // for testing purposes
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            }
            );


        // add roles to users
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = mockedUserRoleId,
                UserId = mockedUserId
            },
             new IdentityUserRole<string>
             {
                 RoleId = mockedAdminRoleId,
                 UserId = mockedAdminId
             });
    }
}