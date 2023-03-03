namespace SimpleSchoolSystem.Repository;

public interface IGenericRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    void Add(T entity);
    T GetById(int? id);
    void Delete(int? id);
    void Delete(T? entity);
}
