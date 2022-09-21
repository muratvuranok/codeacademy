using HttpRequestApp.Models;
using HttpRequestApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HttpRequestApp.Controllers;

public class TypedClientController : Controller
{
    private readonly GitHubService _gitHubService;
    public TypedClientController(GitHubService gitHubService)
    {
        _gitHubService = gitHubService;
    }
    public async Task<IActionResult> Index()
    {
        IEnumerable<GitHubBranch> GitHubBranches = null;
        try
        {
            GitHubBranches = await _gitHubService.GetAspNetCoreDocsBranchesAsync();
        }
        catch (HttpRequestException)
        {
            // ...
        }
        return Ok(GitHubBranches);
    }
}
