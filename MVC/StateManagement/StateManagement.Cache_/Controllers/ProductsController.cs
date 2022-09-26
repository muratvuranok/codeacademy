using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using StateManagement.Session_.Models;

namespace StateManagement.Cache_.Controllers;

public class ProductsController : Controller
{

    #region Products
    List<Product> products = new()
    {
        new Product {Id = 17, ProductName = "Alice Mutton"},
        new Product {Id = 3,  ProductName = "Aniseed Syrup"},
        new Product {Id = 40, ProductName = "Boston Crab Meat"},
        new Product {Id = 60, ProductName = "Camembert Pierrot"},
        new Product {Id = 18, ProductName = "Carnarvon Tigers"},
        new Product {Id = 1,  ProductName = "Chai"},
        new Product {Id = 2,  ProductName = "Chang"},
        new Product {Id = 39, ProductName = "Chartreuse verte"},
        new Product {Id = 4,  ProductName = "Chef Anton's Cajun Seasoning"},
        new Product {Id = 5,  ProductName = "Chef Anton's Gumbo Mix"},
        new Product {Id = 48, ProductName = "Chocolade"},
        new Product {Id = 38, ProductName = "Côte de Blaye"},
        new Product {Id = 58, ProductName = "Escargots de Bourgogne"},
        new Product {Id = 52, ProductName = "Filo Mix"},
        new Product {Id = 71, ProductName = "Flotemysost"},
        new Product {Id = 33, ProductName = "Geitost"},
        new Product {Id = 15, ProductName = "Genen Shouyu"},
        new Product {Id = 56, ProductName = "Gnocchi di nonna Alice"},
        new Product {Id = 31, ProductName = "Gorgonzola Telino"},
        new Product {Id = 6,  ProductName = "Grandma's Boysenberry Spread"},
        new Product {Id = 37, ProductName = "Gravad lax"},
        new Product {Id = 24, ProductName = "Guaraná Fantástica"},
        new Product {Id = 69, ProductName = "Gudbrandsdalsost"},
        new Product {Id = 44, ProductName = "Gula Malacca"},
        new Product {Id = 26, ProductName = "Gumbär Gummibärchen"},
        new Product {Id = 22, ProductName = "Gustaf's Knäckebröd"},
        new Product {Id = 10, ProductName = "Ikura"},
        new Product {Id = 36, ProductName = "Inlagd Sill"},
        new Product {Id = 43, ProductName = "Ipoh Coffee"},
        new Product {Id = 41, ProductName = "Jack's New England Clam Chowder"},
        new Product {Id = 13, ProductName = "Konbu"},
        new Product {Id = 76, ProductName = "Lakkalikööri"},
        new Product {Id = 67, ProductName = "Laughing Lumberjack Lager"},
        new Product {Id = 74, ProductName = "Longlife Tofu"},
        new Product {Id = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce"},
        new Product {Id = 66, ProductName = "Louisiana Hot Spiced Okra"},
        new Product {Id = 51, ProductName = "Manjimup Dried Apples"},
        new Product {Id = 32, ProductName = "Mascarpone Fabioli"},
        new Product {Id = 49, ProductName = "Maxilaku"},
        new Product {Id = 9,  ProductName = "Mishi Kobe Niku"},
        new Product {Id = 72, ProductName = "Mozzarella di Giovanni"},
        new Product {Id = 30, ProductName = "Nord-Ost Matjeshering"},
        new Product {Id = 8,  ProductName = "Northwoods Cranberry Sauce"},
        new Product {Id = 25, ProductName = "NuNuCa Nuß-Nougat-Creme"},
        new Product {Id = 77, ProductName = "Original Frankfurter grüne Soße"},
        new Product {Id = 78, ProductName = "Original Frankfurter grüne Soße"},
        new Product {Id = 70, ProductName = "Outback Lager"},
        new Product {Id = 55, ProductName = "Pâté chinois"},
        new Product {Id = 16, ProductName = "Pavlova"},
        new Product {Id = 53, ProductName = "Perth Pasties"},
        new Product {Id = 11, ProductName = "Queso Cabrales"},
        new Product {Id = 12, ProductName = "Queso Manchego La Pastora"},
        new Product {Id = 59, ProductName = "Raclette Courdavault"},
        new Product {Id = 57, ProductName = "Ravioli Angelo"},
        new Product {Id = 75, ProductName = "Rhönbräu Klosterbier"},
        new Product {Id = 73, ProductName = "Röd Kaviar"},
        new Product {Id = 45, ProductName = "Rogede sild"},
        new Product {Id = 28, ProductName = "Rössle Sauerkraut"},
        new Product {Id = 34, ProductName = "Sasquatch Ale"},
        new Product {Id = 27, ProductName = "Schoggi Schokolade"},
        new Product {Id = 68, ProductName = "Scottish Longbreads"},
        new Product {Id = 42, ProductName = "Singaporean Hokkien Fried Mee"},
        new Product {Id = 20, ProductName = "Sir Rodney's Marmalade"},
        new Product {Id = 21, ProductName = "Sir Rodney's Scones"},
        new Product {Id = 61, ProductName = "Sirop d'érable"},
        new Product {Id = 46, ProductName = "Spegesild"},
        new Product {Id = 35, ProductName = "Steeleye Stout"},
        new Product {Id = 62, ProductName = "Tarte au sucre"},
        new Product {Id = 19, ProductName = "Teatime Chocolate Biscuits"},
        new Product {Id = 29, ProductName = "Thüringer Rostbratwurst"},
        new Product {Id = 14, ProductName = "Tofu"},
        new Product {Id = 54, ProductName = "Tourtière"},
        new Product {Id = 23, ProductName = "Tunnbröd"},
        new Product {Id = 7,  ProductName = "Uncle Bob's Organic Dried Pears"},
        new Product {Id = 79, ProductName = "Ürün Adı"},
        new Product {Id = 80, ProductName = "Ürün Adı"},
        new Product {Id = 81, ProductName = "Ürün Adı"},
        new Product {Id = 82, ProductName = "Ürün Adı"},
        new Product {Id = 83, ProductName = "Ürün Adı"},
        new Product {Id = 84, ProductName = "Ürün Adı"},
        new Product {Id = 85, ProductName = "Ürün Adı"},
        new Product {Id = 86, ProductName = "Ürün Adı"},
        new Product {Id = 87, ProductName = "Ürün Adı"},
        new Product {Id = 88, ProductName = "Ürün Adı"},
        new Product {Id = 89, ProductName = "Ürün Adı"},
        new Product {Id = 90, ProductName = "Ürün Adı"},
        new Product {Id = 91, ProductName = "Ürün Adı"},
        new Product {Id = 92, ProductName = "Ürün Adı"},
        new Product {Id = 50, ProductName = "Valkoinen suklaa"},
        new Product {Id = 63, ProductName = "Vegie-spread"},
        new Product {Id = 64, ProductName = "Wimmers gute Semmelknödel"},
        new Product {Id = 47, ProductName = "Zaanse koeken"}
    };
    #endregion

    private const string CACHE_DATE_KEY = "date";
    private const string CACHE_PRODUCT_KEY = "products";


    private IMemoryCache _memoryCache;
    public ProductsController(IMemoryCache memoryCache)
    {
        this._memoryCache = memoryCache;
    }

    public IActionResult GetDate()
    {
        if (!_memoryCache.TryGetValue(CACHE_DATE_KEY, out DateTime _date))
        {

            _date = DateTime.Now;
            _memoryCache.Set(CACHE_DATE_KEY, _date);
        }

        return Ok(new
        {
            _date = _date,
            _currentDate = DateTime.Now
        });
    }



    public IActionResult SetAbsoluteExpiration()
    {
        //if (!_memoryCache.TryGetValue(CACHE_PRODUCT_KEY, out string _products))
        //{
        //    _products = JsonSerializer.Serialize(products);
        //    _memoryCache.Set(CACHE_PRODUCT_KEY, _products);
        //}


        //return Json(JsonSerializer.Deserialize<List<Product>>(_products));


        //if (_products != null)
        //    return Json(JsonSerializer.Deserialize<List<Product>>(_products));
        //// return Json(data);

        //return Json(new
        //{
        //    Result = "Data Not Found, Refresh Page"
        //});


        if (!_memoryCache.TryGetValue(CACHE_DATE_KEY, out DateTime _date))
        {
            _date = DateTime.Now;
            MemoryCacheEntryOptions options = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(10));

            // kullanıcı, ne kadar sıklıkla istekte bulunsada, verilen süre boyunca cache bozulmayacktır. Cache zamanı belirtirken kesinlik kullanmamak önemlidir. Eğer kesin tarih belirtrseniz, o tarih bir daha oluşmayacağından cache bir daha çalışmayacaktır. Eğer kesin zaman dilimi kullanmanızı gerektirecek bir durum var ise, dinamik olarak ayarlayınız her yılın bu tarihinde cache yenilensin gibi. Yıl bilgisini değişken olarak verip her yılın aynı ay ve gününde cache yenileyebilirsiniz.

            _memoryCache.Set(CACHE_DATE_KEY, _date, options);
        }


        return Json(new
        {
            _date = _date,
            __now = DateTime.Now
        });
    }


    public IActionResult SetSlidingExpiration()
    {

        if (!_memoryCache.TryGetValue(CACHE_DATE_KEY, out DateTime _date))
        {
            _date = DateTime.Now;
            MemoryCacheEntryOptions options = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(20));
            // Kullanıcı verilen süre boyunca istekte bulunmazsa, cache otomatik yenilenir. Süre zarfı boyunca kullanıcı istekte bulunmaya devam ederse, her istekte zaman yenilenir (öteleme işlemi uygular) ve datalar cache'den gelmeye devam eder.
            _memoryCache.Set(CACHE_DATE_KEY, _date, options);
        }


        return Json(new
        {
            _date = _date,
            __now = DateTime.Now
        });
    }

    public IActionResult Index()
    {
        return View(products);
    }


    [HttpPost]
    public IActionResult Index(Product product)
    {


        return RedirectToAction(nameof(Index));
    }
}

