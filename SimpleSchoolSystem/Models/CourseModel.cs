namespace SimpleSchoolSystem.Models;

public class CourseModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    // final grade
    //[Required(ErrorMessage = "Degree cannot be left empty")]
    //[DegreeRange(ErrorMessage = "Degree must be between 50 and 100")]
    public int Degree { get; set; }


    // passing grade
    public int MinDegree { get; set; }




    public int DepartmentId { get; set; }
    public DepartmentModel Department { get; set; } = null!;

    public List<CrsResultModel> CrsResults { get; set; } = null!;


}
