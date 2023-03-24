using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using SimpleSchoolSystem.Models;

namespace SimpleSchoolSystem.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{

    public DbSet<Department> Departments { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Trainee> Trainees { get; set; }
    public DbSet<CourseResult> CourseResults { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Identity Related with security schema
        builder.Entity<ApplicationUser>().ToTable("Users", "security");
        builder.Entity<IdentityRole>().ToTable("Roles", "security");

        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");

        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "security");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "security");

        // App Entities Relation
        builder.Entity<CourseInstructor>()
         .HasKey(ci => new { ci.CourseId, ci.InstructorId });

        builder.Entity<CourseInstructor>()
            .HasOne(ci => ci.Course)
            .WithMany(c => c.CourseInstructors)
            .HasForeignKey(ci => ci.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<CourseInstructor>()
            .HasOne(ci => ci.Instructor)
            .WithMany(i => i.CourseInstructors)
            .HasForeignKey(ci => ci.InstructorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Instructor>()
            .HasOne(i => i.Department)
            .WithMany(d => d.Instructors)
            .HasForeignKey(i => i.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Trainee>()
            .HasOne(t => t.Department)
            .WithMany(d => d.Trainees)
            .HasForeignKey(t => t.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Course>()
           .HasOne(c => c.Department)
           .WithMany(d => d.Courses)
           .HasForeignKey(c => c.DepartmentId)
           .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<CourseResult>()
            .HasOne(cr => cr.Course)
            .WithMany(c => c.CourseResults)
            .HasForeignKey(cr => cr.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<CourseResult>()
            .HasOne(cr => cr.Trainee)
            .WithMany(t => t.CourseResults)
            .HasForeignKey(cr => cr.TraineeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Enrollment>()
            .HasOne(e => e.Course)
            .WithMany(c => c.Enrollments)
            .HasForeignKey(e => e.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Enrollment>()
            .HasOne(e => e.Trainee)
            .WithMany(t => t.Enrollments)
            .HasForeignKey(e => e.TraineeId)
            .OnDelete(DeleteBehavior.Cascade);

        // seed dummy data
        builder.Seed();
    }
}
