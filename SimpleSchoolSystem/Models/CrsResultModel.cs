namespace SimpleSchoolSystem.Models;

public class CrsResultModel
{
    public int Id { get; set; }

    // final grade
    public int Degree { get; set; }



    public int CourseId { get; set; }
    public CourseModel Course { get; set; } = null!;

    public int TraineeId { get; set; }
    public TraineeModel Trainee { get; set; } = null!;
}
