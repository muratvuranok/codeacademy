using Hangfire;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BackgrounServiceApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BackgroundJobsController : ControllerBase
{
    private readonly ILogger<BackgroundJobsController> _logger;
    private readonly IBackgroundJobClient _backgroundJobClient;

    public BackgroundJobsController(ILogger<BackgroundJobsController> logger, IBackgroundJobClient backgroundJobClient)
    {
        this._logger = logger;
        this._backgroundJobClient = backgroundJobClient;
    }
     
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] string message)
    { 
        _backgroundJobClient.Enqueue(() => Console.WriteLine(message));
        _backgroundJobClient.Schedule(() => Console.WriteLine($"{message} -> {DateTime.Now}"), TimeSpan.FromSeconds(30));

        return Ok(new
        {
            Message = message,
            Controller = nameof(BackgroundJobsController),
            Status = HttpStatusCode.OK
        });
    }
}
