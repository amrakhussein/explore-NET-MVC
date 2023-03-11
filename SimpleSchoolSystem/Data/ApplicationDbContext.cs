using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using SimpleSchoolSystem.Models;

namespace SimpleSchoolSystem.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{

    public DbSet<DepartmentModel> Departments { get; set; }
    public DbSet<InstructorModel> Instructors { get; set; }
    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<TraineeModel> Trainees { get; set; }
    public DbSet<CourseResultModel> CourseResults { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>().ToTable("Users", "security");
        builder.Entity<IdentityRole>().ToTable("Roles", "security");

        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");

        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "security");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "security");

        // seed dummy data
        builder.Seed();

    }


}
