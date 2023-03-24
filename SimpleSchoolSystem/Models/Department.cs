namespace SimpleSchoolSystem.Models;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<Course> Courses { get; set; } = null!;
    public ICollection<Instructor> Instructors { get; set; } = null!;
    public ICollection<Trainee> Trainees { get; set; } = null!;
}
