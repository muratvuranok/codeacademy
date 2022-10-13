using CodeAcademy.ProductService.Data;
using CodeAcademy.ProductService.Repositories;
using Models;

namespace CodeAcademy.ProductService.Services;

public interface IProductRepository : IRepository<Product> { }

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)  {  }
}
