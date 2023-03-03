using EntityCodeFirstLab.Data;

using SimpleSchoolSystem.Models;

namespace SimpleSchoolSystem.Repository;

public class CourseRepository : ICourseRepository
{
    private readonly ApplicationDbContext _context;

    public CourseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Add(CourseModel course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();
    }

    public void Delete(int? id)
    {
        var courseDeleted = GetById(id);
        _context.Courses.Remove(courseDeleted);
        _context.SaveChanges();
    }

    public CourseModel GetById(int? id) => _context.Courses.Find(id);

    public IEnumerable<CourseModel> GetAll() => _context.Courses.ToList();


    public void Delete(CourseModel? entity)
    {
        throw new NotImplementedException();
    }
}