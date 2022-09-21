using HttpRequestApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace HttpRequestApp.Controllers
{
    public class NamedClientController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;
        public NamedClientController(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;


        public async Task<IActionResult> Index()
        {
            IEnumerable<GitHubBranch>? GitHubBranches = null;

            var httpClient = _httpClientFactory.CreateClient("GitHub");
            var httpResponseMessage = await httpClient.GetAsync(
                "repos/dotnet/AspNetCore.Docs/branches");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                GitHubBranches = await JsonSerializer.DeserializeAsync
                    <IEnumerable<GitHubBranch>>(contentStream);
            }

            return Ok(GitHubBranches);
        }
    }
}
