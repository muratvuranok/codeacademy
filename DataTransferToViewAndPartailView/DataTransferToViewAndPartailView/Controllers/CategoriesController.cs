using Microsoft.AspNetCore.Mvc;

namespace DataTransferToViewAndPartailView.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
