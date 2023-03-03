using EntityCodeFirstLab.Data;

using SimpleSchoolSystem.Models;
using SimpleSchoolSystem.ViewModel;

namespace SimpleSchoolSystem.Repository;

public class InstructorRepository : IInstructorRepository
{
    private readonly ApplicationDbContext _context;

    public InstructorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Add(InstructorModel course)
    {
        _context.Instructors.Add(course);
        _context.SaveChanges();
    }

    public IEnumerable<InstructorModel> GetAll() => _context.Instructors.ToList();

    public InstructorModel GetById(int id) => _context.Instructors.Find(id);

    public InstructorModel GetById(int? id)
    {
        throw new NotImplementedException();
    }

    public CourseModel GetChoosenCourse(string course)
            => _context.Courses.Where(c => c.Id == int.Parse(course)).FirstOrDefault();

    public DepartmentModel GetChoosenDepartment(string department)
            => _context.Departments.Where(d => d.Id == int.Parse(department)).FirstOrDefault();

    public void Delete(int? id)
    {
        var courseDeleted = GetById(id);
        _context.Instructors.Remove(courseDeleted);
        _context.SaveChanges();
    }



    public void Delete(InstructorModel? entity)
    {
        throw new NotImplementedException();
    }



    public IEnumerable<DepartmentModel> GetDepartmentsById(int id)
    {
        var instructor = _context.Instructors.FirstOrDefault(p => p.Id == id);
        return _context.Departments.Where(d => d.Id == instructor.DepartmentId).ToList();
    }

    public IEnumerable<CourseModel> GetCoursesById(int id)
    {
        var instructor = _context.Instructors.FirstOrDefault(p => p.Id == id);
        return _context.Courses.Where(c => c.Id == instructor.CourseId).ToList();
    }

    public void EditInstructorInfo(int id, CreateNewInstructorViewModel model)
    {


        var instructor = _context.Instructors.FirstOrDefault(p => p.Id == id);

        _context.Departments.Where(d => d.Id == instructor.DepartmentId).ToList();
        _context.Courses.Where(c => c.Id == instructor.CourseId).ToList();

        // apply edit
        instructor.Name = model.Name;
        instructor.Age = model.Age;

        CourseRepository courseRepo;
        // fetch the departments
        var departments = GetDepartmentsById(id);

        // fetch the courses
        var courses = GetCoursesById(id);
        // apply new courses' names

        foreach (var course in courses)
        {
            course.Name = model.Course;
        }


        // apply new departments' names
        foreach (var department in departments)
        {
            department.Name = model.Department;
        }


        _context.SaveChanges();


    }

    public CreateNewInstructorViewModel EditInstructorInfoFaild(int id)
    {
        var instructor = _context.Instructors.FirstOrDefault(p => p.Id == id);
        // fetch departments
        IDepartmentRepository departmentRepository;
        ICourseRepository courseRepository;
        var departments = _context.Departments.ToList();

        // fetch courses
        var courses = _context.Courses.ToList();

        var viewModel = new CreateNewInstructorViewModel
        {
            Name = instructor.Name,
            Age = instructor.Age,
            Courses = courses,
            Departments = departments
        };


        return viewModel;
    }

    public IEnumerable<InstructorModel> SearchByName(string name)
      => _context.Instructors.Where(c => c.Name.Contains(name)).ToList();
}
