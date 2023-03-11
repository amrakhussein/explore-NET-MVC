namespace SimpleSchoolSystem.Models;

public class CourseResultModel
{
    public int Id { get; set; }

    public int Grade { get; set; }

    public int CourseId { get; set; }
    public CourseModel Course { get; set; } = null!;

    public int TraineeId { get; set; }
    public TraineeModel Trainee { get; set; } = null!;
}
