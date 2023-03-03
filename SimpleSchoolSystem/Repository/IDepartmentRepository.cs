using SimpleSchoolSystem.Models;

namespace SimpleSchoolSystem.Repository;

public interface IDepartmentRepository : IGenericRepository<DepartmentModel>
{
    IEnumerable<InstructorModel> GetInstructorsByDepartment(int id);
}
