using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc;

using SimpleSchoolSystem.common;

namespace SimpleSchoolSystem.ViewModel;

public class CreateNewCourseVM
{
    [Required]
    [MaxLength(100)]
    [Display(Name = "Course:")]
    [UniqueNamePerDepartment(ErrorMessage = "Only unique names are allowed per department")]
    public string CourseName { get; set; }



    [Required]
    public int DepartmentId { get; set; }


    [Required(ErrorMessage = "Degree cannot be left empty")]
    [Range(50, 100, ErrorMessage = "Degree must be between 50 and 100")]
    public int MaxGrade { get; set; }

    [Required]
    [Remote(action: "CheckMinGrade", controller: "Course", AdditionalFields = "MaxGrade", ErrorMessage = "Minimum grade should be less tha maximum grade")]
    public int MinGrade { get; set; }

}
