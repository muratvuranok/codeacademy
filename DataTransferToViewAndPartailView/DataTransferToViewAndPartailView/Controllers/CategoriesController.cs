using DataTransferToViewAndPartailView.Data;
using DataTransferToViewAndPartailView.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DataTransferToViewAndPartailView.Controllers
{
    public class CategoriesController : Controller
    {
        northwindContext _context = new northwindContext();
        public IActionResult Index()
        {
            var categories = _context.Categories.Select(x => new CategoryVM
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                Description = x.Description
            });



            var c1 = categories.Skip(5).Take(5).AsEnumerable();
            var c2 = categories.Where(x => x.CategoryId % 2 == 0).Take(5).AsEnumerable();
            var c3 = categories.Where(x => x.CategoryId % 2 != 0).Take(5).AsEnumerable();
            var c4 = categories.Take(5).AsEnumerable();

            //ViewData["CategoriesViewData"] = c1;
            //TempData["CategoriesTepmData"] = c2;
            //ViewBag.CategoriesViewBag = c3;


            //ViewData["CodeEdu"] = "Code Academy - View Data";
            //TempData["CodeEduAz"] = "Code Academy - Temp Data";


            var tuple = Tuple.Create(c1, c2, c3, c4, "Code Academy", DateTime.Now);

            return View(tuple);
        }


        public IActionResult Create()
        {
            ViewData["CodeEdu1"] = "Code Academy 1- View Data";
            TempData["CodeEduAz1"] = "Code Academy 1- Temp Data";

            return View();
        }
    }

}
