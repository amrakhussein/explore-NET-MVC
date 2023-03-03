using SimpleSchoolSystem.Models;
using SimpleSchoolSystem.ViewModel;

namespace SimpleSchoolSystem.Repository;

public interface IInstructorRepository : IGenericRepository<InstructorModel>
{
    CourseModel GetChoosenCourse(string course);
    DepartmentModel GetChoosenDepartment(string department);

    IEnumerable<DepartmentModel> GetDepartmentsById(int id);
    IEnumerable<CourseModel> GetCoursesById(int id);

    void EditInstructorInfo(int id, CreateNewInstructorViewModel model);
    CreateNewInstructorViewModel EditInstructorInfoFaild(int id);

    IEnumerable<InstructorModel> SearchByName(string name);
}