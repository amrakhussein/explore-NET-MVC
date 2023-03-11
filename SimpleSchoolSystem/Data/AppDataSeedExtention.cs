using Microsoft.AspNetCore.Identity;

using Microsoft.EntityFrameworkCore;

using SimpleSchoolSystem.Models;

namespace SimpleSchoolSystem.Data;


public static class AppSeedDataExtension
{
    public static void Seed(this ModelBuilder builder)
    {
        var mockedUserId = Guid.NewGuid().ToString();
        var mockedAdminRoleId = Guid.NewGuid().ToString();
        var mockedUserRoleId = Guid.NewGuid().ToString();



        var hasher = new PasswordHasher<IdentityUser>();


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
            }
        );


        builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Id = mockedAdminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN".ToUpper(),

                // not recommeded // for testing purposes
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new IdentityRole
            {
                Id = mockedUserRoleId,
                Name = "User",
                NormalizedName = "USER".ToUpper(),

                // not recommeded // for testing purposes
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            });


        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = mockedUserRoleId,
                UserId = mockedUserId
            }
        );




    }
}