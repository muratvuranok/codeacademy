using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers.v1;

[Route("api/v1/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    public async Task<IActionResult> Get()
    {
        return Ok(new
        {
            Controller = "Products",
            Message = "Success"
        });
    }
}
