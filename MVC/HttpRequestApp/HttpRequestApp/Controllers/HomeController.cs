using HttpRequestApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Text.Json;

namespace HttpRequestApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
    {
        this._logger = logger;
        this._httpClientFactory = httpClientFactory;
    }


    public IActionResult Index()
    {


        return View();
    }

    public async Task<IActionResult> Index1()
    {
        var GitHubBranches = new List<GitHubBranch>(); 
        var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            "https://api.github.com/repos/dotnet/AspNetCore.Docs/branches")
        {
            Headers =
            {
                { HeaderNames.Accept, "application/vnd.github.v3+json" },
                { HeaderNames.UserAgent, "HttpRequestsSample" }
            }
        };
         
        var httpClient = _httpClientFactory.CreateClient();
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            GitHubBranches = await JsonSerializer.DeserializeAsync<List<GitHubBranch>>(contentStream);
        }
        //if (GitHubBranches.Count == 0)
        //    return NotFound();


        return Ok(GitHubBranches);
    }



}