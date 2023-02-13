using System.ComponentModel.DataAnnotations;

using SimpleSchoolSystem.common;
using SimpleSchoolSystem.Models;

namespace SimpleSchoolSystem.ViewModel;

public class CreateNewInstructorViewModel
{

    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Degree cannot be left empty")]
    [DegreeRange(ErrorMessage = "Degree must be between 50 and 100")]
    public int Age { get; set; }

    [Required]
    [Display(Name = "Course:")]


    public List<CourseModel>? Courses { get; set; }

    [Required]
    [Display(Name = "Department:")]


    public IEnumerable<DepartmentModel> Departments { get; set; } = null!;


    public string Department { get; set; } = null!;
    public string Course { get; set; } = null!;
}
