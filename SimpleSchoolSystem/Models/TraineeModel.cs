namespace SimpleSchoolSystem.Models;

public class TraineeModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }

    public int DepartmentId { get; set; }
    public DepartmentModel Department { get; set; } = null!;
    public List<CrsResultModel> CrsResults { get; set; } = null!;
}
