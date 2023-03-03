using EntityCodeFirstLab.Data;

using SimpleSchoolSystem.Models;

namespace SimpleSchoolSystem.Repository;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly ApplicationDbContext _context;

    public DepartmentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Add(DepartmentModel department)
    {
        _context.Departments.Add(department);
        _context.SaveChanges();
    }

    public void Delete(int? id)
    {
        var departmentDeleted = GetById(id);
        _context.Departments.Remove(departmentDeleted);
        _context.SaveChanges();
    }

    public DepartmentModel GetById(int? id) => _context.Departments.Find(id);

    public IEnumerable<DepartmentModel> GetAll() => _context.Departments.ToList();

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<InstructorModel> GetInstructorsByDepartment(int id) =>
        _context.Instructors.Where(i => i.DepartmentId == id).ToList();


    public void Delete(DepartmentModel? entity)
    {
        throw new NotImplementedException();
    }
}
