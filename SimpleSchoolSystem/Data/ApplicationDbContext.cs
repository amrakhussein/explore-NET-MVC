using System.Diagnostics;

using Microsoft.EntityFrameworkCore;

using SimpleSchoolSystem.Models;

namespace EntityCodeFirstLab.Data;

internal class ApplicationDbContext : DbContext
{

    public DbSet<DepartmentModel> Departments { get; set; }
    public DbSet<InstructorModel> Instructors { get; set; }
    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<TraineeModel> Trainees { get; set; }
    public DbSet<CrsResultModel> CrsResults { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source =.; Initial Catalog = SchoolSystemTestDB; Integrated Security = True; TrustServerCertificate=true")
             .LogTo(log => Debug.WriteLine(log));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


    }


}
