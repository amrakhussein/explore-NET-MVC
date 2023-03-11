namespace SimpleSchoolSystem.Models;

public class CourseModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public int Grade { get; set; }

    public int PassingGrade { get; set; }

    public int DepartmentId { get; set; }
    public DepartmentModel Department { get; set; } = null!;

    public List<CourseResultModel> CourseResults { get; set; } = null!;
}
