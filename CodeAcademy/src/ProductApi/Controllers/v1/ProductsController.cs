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
        //for (int i = 1; i < 50000; i++)
        //{
        //    var entity = new Product
        //    {
        //        ProductName = $"{product.ProductName} -> {i}",
        //        UnitPrice = product.UnitPrice,
        //        UnitsInStock = product.UnitsInStock
        //    };

        //    await _publishEndpoint.Publish<Product>(entity);
        //}

        await _publishEndpoint.Publish<Product>(product);
        return Ok(new
        {
            Controller = "Products",
            Message = "Success",
            Method = "Post"
        });
    }
}
