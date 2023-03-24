namespace SimpleSchoolSystem.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Grade { get; set; }
    public int PassingGrade { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public ICollection<CourseResult> CourseResults { get; set; } = null!;
    public ICollection<CourseInstructor> CourseInstructors { get; set; } = null!;
    public ICollection<Enrollment> Enrollments { get; set; } = null!;
}
