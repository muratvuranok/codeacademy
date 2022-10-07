using Code.Application.Common.Interfaces;
using Code.Application.Dtos.User;
using System.Net;

namespace Code.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserManagerController : ApiBaseController
{


    private readonly IIdentityService _identityService;
    public UserManagerController(IIdentityService identityService)
    {
        this._identityService = identityService;
    }


    [HttpPost]
    public async Task<IActionResult> Post(UserCreateDto userCreateDto)
    {
        var result = await _identityService.CreateUserAsync(userCreateDto.UserName, userCreateDto.Password);
        if (result.Result.Succeeded)
        {
            return Ok(new
            {
                statusCode = HttpStatusCode.Created,
                userId = result.UserId,
                message = "User Created"
            });
        }

        return Ok(result.Result.Errors);
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await _identityService.GetAll();
        return Ok(new
        {
            result = users,
            statusCode = HttpStatusCode.OK,
            message = "User List"
        });
    }
}
