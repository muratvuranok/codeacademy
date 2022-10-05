using Code.Application.Categories.Commands.CreateCategory;
using Code.Application.Categories.Commands.DeleteCategory;
using Code.Application.Categories.Commands.UpdateCategory;

namespace Code.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ApiBaseController
{
    [HttpGet]
    public async Task<IEnumerable<CategoryDto>> Get()
    {
        return await Mediator.Send(new GetCategoriesQuery());
    }

    [HttpPost]
    public async Task<int> Post([FromBody] CreateCategoryCommand command)
    {
        return await Mediator.Send(command);
    }

    [HttpDelete]
    public async Task Delete(DeleteCategoryCommand command)
    {
        await Mediator.Send(command);
    }

    [HttpPut]
    public async Task Update([FromBody] UpdateCategoryCommand command)
    {
        await Mediator.Send(command);
    }
}
