namespace SimpleSchoolSystem.Models;

public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public ICollection<CourseInstructor> CourseInstructors { get; set; } = null!;
}
