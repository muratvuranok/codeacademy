using Code.Application.Common.Interfaces;
using Code.Infrastructure.Dtos.User;
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
                StatusCode = HttpStatusCode.Created,
                UserId = result.UserId,
                Message = "User Created"
            });
        }

        return Ok(result.Result.Errors);
    }
}
