using Microsoft.AspNetCore.Mvc;
using MVC_TemplateApp.Models;
using System.Diagnostics;

namespace MVC_TemplateApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        { 
            var products = new List<Product>
            {
                new Product {
                    Name = "Fresh organic kiwi",
                    StartPrice = 10.00M,
                    Price = 70.99M,
                    Rate = 4,
                    ProductPhotos = new List<ProductPhoto >{
                        new ProductPhoto
                            {
                                Url = "/images/products/product-image-2-1.jpg"
                            },
                        new ProductPhoto
                            {
                                Url = "/images/products/product-image-2-2.jpg"
                            }
                    }
                } 
            };
             
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}