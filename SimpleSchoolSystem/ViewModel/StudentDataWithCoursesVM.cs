namespace SimpleSchoolSystem.ViewModel;

public class StudentDataWithCoursesVM
{
    public string StudentName { get; set; }
    public List<CourseVM> Courses { get; set; } = new List<CourseVM>();
}
