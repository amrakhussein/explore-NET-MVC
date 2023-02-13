namespace SimpleSchoolSystem.Models;

public class InstructorModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;


    public int Age { get; set; }

    public int DepartmentId { get; set; }
    public DepartmentModel Department { get; set; } = null!;

    public int CourseId { get; set; }
    public CourseModel Course { get; set; } = null!;
}
