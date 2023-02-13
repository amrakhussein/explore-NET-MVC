using EntityCodeFirstLab.Data;

using Microsoft.AspNetCore.Mvc;

namespace SimpleSchoolSystem.Controllers;

public class StudentController : Controller
{
    ApplicationDbContext context = new();
    public IActionResult GetAllStudents()
    {

        var studentsModel = context.Trainees.ToList();

        if (studentsModel == null) return NotFound();

        // render UI
        return View("AllStudents", studentsModel);
    }


    public IActionResult GetStudentById(int id)
    {
        var student = context.Trainees.FirstOrDefault(t => t.Id == id);


        var courseRelatedInfo = (from cr in context.CrsResults
                                 join t in context.Trainees on cr.TraineeId equals t.Id
                                 join c in context.Courses on cr.CourseId equals c.Id
                                 where cr.TraineeId == id
                                 select new
                                 {
                                     StudentName = t.Name,
                                     CourseName = c.Name,
                                     CourseGrade = cr.Degree,
                                     IsPassed = cr.Degree > c.MinDegree ? true : false,
                                 }).ToList();




        ViewBag.CourseRelatedInfo = courseRelatedInfo;

        var StAverageDegree = context.CrsResults
            .Where(cr => cr.TraineeId == id)
            .Average(cr => cr.Degree);


        ViewBag.StAverageDegree = StAverageDegree;


        var StTotalDegree = context.CrsResults
            .Where(c => c.TraineeId == id)
            .Sum(cr => cr.Degree);

        ViewBag.StTotalDegree = StTotalDegree;

        //StudentDataWithCoursesVM vm = new StudentDataWithCoursesVM
        //{
        //    StudentName = "Ahmed",
        //    Courses =

        //};





        // how to redirect not found page?
        //if (studentViewModel == null) return NotFound();


        // render UI
        return View("SingleStudent");

    }
}
