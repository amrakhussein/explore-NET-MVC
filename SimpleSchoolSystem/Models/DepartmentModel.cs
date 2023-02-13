namespace SimpleSchoolSystem.Models;

public class DepartmentModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<CourseModel> Courses { get; set; } = null!;
    public List<InstructorModel> Instructors { get; set; } = null!;
    public List<TraineeModel> Trainees { get; set; } = null!;
}
