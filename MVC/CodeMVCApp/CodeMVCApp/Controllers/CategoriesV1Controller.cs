using CodeMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeMVCApp.Controllers;

public class CategoriesV1Controller : BaseController
{
    List<Category> db = new List<Category>  {
              new Category {CategoryID = 1, CategoryName="Beverages",       Description="Soft drinks, coffees, teas, beers, and ales"},
              new Category {CategoryID = 2, CategoryName="Condiments",      Description="Sweet and savory sauces, relishes, spreads, and seasonings"},
              new Category {CategoryID = 3, CategoryName="Confections",     Description="Desserts, candies, and sweet breads"},
              new Category {CategoryID = 4, CategoryName="Dairy Products",  Description="Cheeses"},
              new Category {CategoryID = 5, CategoryName=@"Grains/Cereals", Description="Breads, crackers, pasta, and cereal"},
              new Category {CategoryID = 6, CategoryName=@"Meat/Poultry",   Description="Prepared meats"},
              new Category {CategoryID = 7, CategoryName="Produce",         Description="Dried fruit and bean curd"},
              new Category {CategoryID = 8, CategoryName="Seafood",         Description="Seaweed and fish"},
              new Category {CategoryID = 9, CategoryName="Seafood",         Description="Test"}
            };



    [HttpGet("categories/details/{categoryId}")]
    public IActionResult Details(int? categoryId)
    {

        if (categoryId.HasValue)
        {
            var category = db.FirstOrDefault(x => x.CategoryID == categoryId);

            //string data = "murat.vuranok@code.edu.az";
            //return View(model: data);

            return View(model: category);
        }

        return RedirectToAction(nameof(Index));
        //return RedirectToAction("Index");
    }



    // Kategori Listeleme Sayfası1
    public IActionResult Index()
    {
        return View();
    }

    // Default değer GET
    public IActionResult Create()
    {


        //return View("Index");
        //return RedirectToAction("Index");  // www.contoso.com/categories/index
        //return RedirectToAction("Index", "products");  // www.contoso.com/products/index
        //return RedirectToAction("Index", "products", 1);  // www.contoso.com/products/index/1
        //return RedirectToAction("Index", "products", 1,"regions-in-sample-code");  // www.contoso.com/products/index/1
        return View();
    }


    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public IActionResult Create(
        string categoryName,
        string description,
        IFormCollection collections,
        Category category)
    {

        // kategoriAdi = txtKategoriAdi.Text;
        // aciklama = txtAciklama.Text;
        string kategoriAdi = collections["categoryName"];

        //return View("Index");
        //return RedirectToAction("Index");  // www.contoso.com/categories/index
        //return RedirectToAction("Index", "products");  // www.contoso.com/products/index
        //return RedirectToAction("Index", "products", 1);  // www.contoso.com/products/index/1
        //return RedirectToAction("Index", "products", 1,"regions-in-sample-code");  // www.contoso.com/products/index/1
        return View();
    }
}
