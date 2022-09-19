using Microsoft.AspNetCore.Mvc;

namespace CodeMVCApp.Controllers;

public class ProductsController : BaseController
{
     

    public IActionResult Index()
    {


        return View();
    }
}
