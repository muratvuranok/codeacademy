using Microsoft.AspNetCore.Mvc;

namespace IOptionConfiguration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        //private readonly PositionOptions _options;
        public HomeController(
            ILogger<HomeController> logger,
            IConfiguration configuration
            //,IOptions<PositionOptions> options
            )
        {
            this._logger = logger;
            this._configuration = configuration;
            //this._options = options.Value;
        }


        public IActionResult Index(string magaza = null)
        {

            _logger.LogInformation("Bilgilendirme için eklendi");
            // Örnek 1
            //var name = _configuration["Position:Title"];

            //var position = new PositionOptions();  
            //_configuration.GetSection(PositionOptions.Position).Bind(position); 
            //var newPosition = _configuration.GetSection(PositionOptions.Position).Get<PositionOptions>();


            //string positionInfo = $"{position.Title} - {position.Name}";
            //string newPositionInfo = $"{newPosition.Title} - {newPosition.Name}";

            //return Ok(newPositionInfo);

            //_logger.LogWarning($"Name : {_options.Name} + Title : {_options.Title}");
            //_logger.LogError("İşlem Bitti");
            //_logger.LogCritical("İşlem Bitti");
            //return Ok(_options);

            return View();
        }
    }
}