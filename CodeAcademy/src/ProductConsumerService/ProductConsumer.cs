using CodeAcademy.ProductService.Services;
using MassTransit;
using Models;


namespace CodeAcademy.ProductService;

public class ProductConsumer : IConsumer<Product>
{
    private ILogger<ProductConsumer> _logger;
    private readonly IProductRepository _productRepository;
    public ProductConsumer(ILogger<ProductConsumer> logger = null, IProductRepository productRepository = null)
    {
        this._logger = logger;
        this._productRepository = productRepository;
    }

    public async Task Consume(ConsumeContext<Product> context)
    {
        await Console.Out.WriteAsync(context.Message.ProductName);
        var result = await _productRepository.Create(context.Message);
    }
}
