using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using RedisApi.Extentsions;

namespace RedisApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IDistributedCache _cache;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IDistributedCache cache)
    {
        this._logger = logger;
        this._cache = cache;
    }

    //[HttpGet(Name = "GetWeatherForecast")]
    //public IEnumerable<WeatherForecast> Get()
    //{
    //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //    {
    //        Date = DateTime.Now.AddDays(index),
    //        TemperatureC = Random.Shared.Next(-20, 55),
    //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //    })
    //    .ToArray();
    //} 


    [HttpGet]
    public async Task<IActionResult> Get()
    {
        string recordKey = $"WeatherForecast_{DateTime.Now.ToString("yyyyMMdd_HHmm")}";

        var result = await _cache.GetRecordAsync<WeatherForecast[]>(recordKey);

        if (result == null)
        {
            var data = Enumerable.Range(1, 5000).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();

            await _cache.SetRecordAsycn(recordKey, data);
        }

        return Ok(recordKey);
    }
}