using Code.Application.Dtos.User;

namespace Code.Application.Common.Interfaces;
public interface IIdentityService
{
    Task<string> GetUserNameAsync(string userId);
    Task<bool> IsInRoleAsync(string userId, string roleName);
    Task<bool> AuthorizeAsync(string userId, string policyName);
    Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);
    Task<Result> DeleteUserAsync(string userId);
    Task<IEnumerable<UserDto>> GetAll();
}
