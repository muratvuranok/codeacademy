using Microsoft.AspNetCore.Mvc;

namespace HttpRequestApp.Controllers
{

    public class Category
    {

    }


    public class CategoriesController : Controller
    {
        public IActionResult GetCategory(int id)
        {

            var categories = new   {    };

            var category = new Category();
            return Ok(category);
        }
    }
}
