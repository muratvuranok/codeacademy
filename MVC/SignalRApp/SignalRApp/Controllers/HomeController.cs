namespace SignalRApp.Controllers;

public class HomeController : Controller
{
    #region Constructor
    private readonly ILogger<HomeController> _logger;
    private readonly IProductRepository _productRepository;

    public HomeController(ILogger<HomeController> logger, IProductRepository productRepository)
    {
        this._logger = logger;
        this._productRepository = productRepository;
    } 
    #endregion

    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Products()
    {
        return Ok(_productRepository.GetAll());
    }
}