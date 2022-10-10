using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Category.Api.Controllers.v1;

[Route("api/v1/categories")]
[ApiController]
public class CategoriesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(new
        {
            Message = "Success"
        });
    }
}
