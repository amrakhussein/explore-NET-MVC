using EntityCodeFirstLab.Data;

using Microsoft.AspNetCore.Mvc;

using SimpleSchoolSystem.Models;
using SimpleSchoolSystem.ViewModel;

namespace SimpleSchoolSystem.Controllers;

public class InstructorController : Controller
{
    ApplicationDbContext context = new();




    public IActionResult GetAllInstructors()
    {

        var instructorsModel = context.Instructors.ToList();

        // how to redirect not found page?

        if (instructorsModel == null) return NotFound();

        // render UI
        return View("AllInstructors", instructorsModel);

    }


    public IActionResult GetInstructorById(int id)
    {
        var instructorModel = context.Instructors?.FirstOrDefault(p => p.Id == id);

        // how to redirect not found page?

        if (instructorModel == null) return NotFound();


        // render UI
        return View("SingleInstructor", instructorModel);

    }


    // handle Add & Edit Instructors

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var instructor = context.Instructors.FirstOrDefault(p => p.Id == id);

        var deptOfInstructor = context.Departments
     .Where(d => d.Id == instructor.DepartmentId)
     .Select(d => d.Name)
     .FirstOrDefault();

        var courseOfInstructor = context.Courses
            .Where(c => c.Id == instructor.CourseId)
            .Select(c => c.Name)
            .FirstOrDefault();


        if (instructor == null) return NotFound();

        // fetch departments
        var departments = context.Departments.ToList();

        // fetch courses
        List<CourseModel> courses = context.Courses.ToList();

        var viewModel = new CreateNewInstructorViewModel
        {
            Name = instructor.Name,
            Age = instructor.Age,
            Department = deptOfInstructor,
            Course = courseOfInstructor,
            Id = id,
            Courses = courses,
            Departments = departments
        };

        if (instructor != null)
        {

            return View("Edit", viewModel);
        }
        // if ERR
        return RedirectToAction("GetAllInstructors");
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit([FromRoute] int id, CreateNewInstructorViewModel model)
    {
        // fetch the instructor
        var instructor = context.Instructors.FirstOrDefault(p => p.Id == id);

        if (model.Name != null)
        {
            // fetch the departments
            var departments = context.Departments.Where(d => d.Id == instructor.DepartmentId).ToList();

            // fetch the courses
            var courses = context.Courses.Where(c => c.Id == instructor.CourseId).ToList();

            //if (instructor == null ) return NotFound();

            // apply edit
            instructor.Name = model.Name;
            instructor.Age = model.Age;

            // apply new courses' names
            courses.ForEach(c => c.Name = model.Course);

            // apply new departments' names
            departments.ForEach(d => d.Name = model.Department);


            // TODO: handle notification

            context.SaveChanges();
            return RedirectToAction("GetAllInstructors");

        }
        else
        {
            // fetch departments
            var departments = context.Departments.ToList();

            // fetch courses
            var courses = context.Courses.ToList();

            var viewModel = new CreateNewInstructorViewModel
            {
                Name = instructor.Name,
                Age = instructor.Age,
                Courses = courses,
                Departments = departments
            };

            return View("AllInstructors", viewModel);
        }
    }

    // Create New Instructor
    public IActionResult Create()
    {
        // fetch departments
        var departments = context.Departments.ToList();

        // fetch courses
        var courses = context.Courses.ToList();

        var viewModel = new CreateNewInstructorViewModel
        {
            Courses = courses,
            Departments = departments
        };

        // render UI
        return View(viewModel);
    }

    // Add New Instructor Action
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Add(CreateNewInstructorViewModel model)
    {


        // test model state
        if (ModelState.IsValid)
        {
            Content("Success!!");
            //return RedirectToAction("Create");
        }

        var course = model.Course;
        var department = model.Department;

        var choosenCourse = context.Courses.Where(c => c.Id == int.Parse(model.Course)).FirstOrDefault();
        var choosenDepartment = context.Departments.Where(d => d.Id == int.Parse(model.Department)).FirstOrDefault();


        var newInstructor = new InstructorModel
        {
            Name = model.Name,
            Age = model.Age,
            Course = choosenCourse,
            Department = choosenDepartment,
        };


        try
        {
            // save the new instructor to database
            context.Instructors.Add(newInstructor);
            context.SaveChanges();

        }
        catch (Exception ex)
        {

            throw new Exception("Err happend while add new instructor to DB: " + ex.Message);
        }

        //TODO: handle notification

        return RedirectToAction("GetAllInstructors");
    }

    // handle delete
    [HttpGet]
    public IActionResult Delete(int? id)
    {

        var instructor = context.Instructors.Find(id);

        if (instructor != null)
        {

            return RedirectToAction("GetAllInstructors");
        }

        // if ERR
        return RedirectToAction("GetAllInstructors");
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        try
        {
            var instructor = context.Instructors.Find(id);

            var deletedInstructor = context.Instructors.Remove(instructor);
            context.SaveChanges();
            // Redirect to the index action to show the updated list
            return RedirectToAction("GetAllInstructors");
        }
        catch (Exception ex)
        {

            throw new Exception("Err occured during deleting an instructro record: " + ex.Message);
        }

    }

}
