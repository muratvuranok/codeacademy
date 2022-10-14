using CodeAcademy.ProductService.Data;

namespace CodeAcademy.ProductService.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<T> Create(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<IEnumerable<T>> Create(IEnumerable<T> entities)
    {
        await _context.Set<T>().AddRangeAsync(entities);
        await _context.SaveChangesAsync();
        return entities;
    }
     
    public virtual IQueryable<T> Table => _context.Set<T>();
}
