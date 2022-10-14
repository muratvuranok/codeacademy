namespace CodeAcademy.ProductService.Repositories;

public interface IRepository<T> where T : class
{
    Task<T> Create(T entity);
    Task<IEnumerable<T>> Create(IEnumerable<T> entity);

    IQueryable<T> Table { get; } 
}
