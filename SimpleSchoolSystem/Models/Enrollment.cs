namespace SimpleSchoolSystem.Models;

public class Enrollment
{
    public int Id { get; set; }
    public bool HasEnrolled { get; set; }

    public int TraineeId { get; set; }
    public Trainee Trainee { get; set; } = null!;
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
}