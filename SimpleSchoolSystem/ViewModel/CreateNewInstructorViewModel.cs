using System.ComponentModel.DataAnnotations;

using SimpleSchoolSystem.Models;

namespace SimpleSchoolSystem.ViewModel;

public class CreateNewInstructorViewModel
{

    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    public int Age { get; set; }

    [Required]
    [Display(Name = "Department:")]
    public string Department { get; set; } = null!;
    [Required]
    [Display(Name = "Course:")]
    public string Course { get; set; } = null!;

    public IEnumerable<CourseModel>? Courses { get; set; }

    public IEnumerable<DepartmentModel> Departments { get; set; } = null!;
}
