using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ProductApi.Controllers.v1;

[Route("api/v1/products")]
[ApiController]
public class ProductsController : ControllerBase
{

    private readonly IPublishEndpoint _publishEndpoint;
    public ProductsController(IPublishEndpoint publishEndpoint)
    {
        this._publishEndpoint = publishEndpoint;
    }


    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(new
        {
            Controller = "Products",
            Message = "Success"
        });
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Product product)
    {
        await _publishEndpoint.Publish<Product>(product);
        return Ok(new
        {
            Controller = "Products",
            Message = "Success",
            Method = "Post"
        });
    }
}
