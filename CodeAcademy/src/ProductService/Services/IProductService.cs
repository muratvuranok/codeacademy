using Models;

namespace CodeAcademy.ProductService.Services;
public interface IProductService
{
    Task<Product> CreateAsync(Product product);
    Task<IQueryable<Product>> GetAllAsync();
}

public class ProductService : IProductService
{

    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        this._productRepository = productRepository;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        if (product == null)
            throw new ArgumentNullException("Product Empty");

        await this._productRepository.Create(product);
        return product;
    }

    public async Task<IQueryable<Product>> GetAllAsync()
    {
        return _productRepository.Table;
    }
}
