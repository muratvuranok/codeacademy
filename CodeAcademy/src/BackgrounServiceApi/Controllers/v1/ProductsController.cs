using CodeAcademy.ProductService.Services;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BackgrounServiceApi.Controllers.v1;

[Route("api/v1/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ILogger<BackgroundJobsController> _logger;
    private readonly IBackgroundJobClient _backgroundJobClient;
    private readonly IProductRepository _productRepository;
    public ProductsController(ILogger<BackgroundJobsController> logger, IBackgroundJobClient backgroundJobClient, IProductRepository productRepository)
    {
        this._logger = logger;
        this._backgroundJobClient = backgroundJobClient;
        this._productRepository = productRepository;
    }


    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Product product)
    {
        _backgroundJobClient.Schedule(() => _productRepository.Create(product), TimeSpan.FromSeconds(5)); 
        _logger.LogInformation("Product Insert Success");
        return Ok(new
        {
            Controller = "Products",
            Message = "Success",
            Method = "Post"
        });
    }
}
