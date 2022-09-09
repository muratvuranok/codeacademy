// 1) dotnet add package Microsoft.EntityFrameworkCore.Design
// 1) dotnet add package Microsoft.EntityFrameworkCore.SqlServer

// --no-pluralize -> Sorguda tabloların isimlerini tekilleştirmez
// -t             -> Eklemek istediğiniz tablonun adını yazınız

// dotnet ef dbcontext scaffold "server=localhost,1433;uid=sa;database=northwind;pwd=Pro247!!;" Microsoft.EntityFrameworkCore.SqlServer -o Models  -t Categories -t Products

// dotnet ef dbcontext scaffold --help

// System.Console.WriteLine("Hello World");

using EFDbFirstApp.Models;
northwindContext db = new northwindContext();

var customers = db.Customers.ToList();
foreach (Customer customer in customers)
{
    System.Console.WriteLine(customer);
}


db.Categories.Add(new Category
{
    CategoryName = "Test Kategori",
    Description = "Açıklama Alanı"
});

bool result = db.SaveChanges() > 0;
System.Console.WriteLine($"Kategori Ekleme İşlemi Başarı{(result ? "lı" : "sız")}");

db.Categories.Add(
    new Category
    {
        CategoryName = "Test 1",
        Description = "Deneme",
        Products = new List<Product>{
            new Product{ProductName = "Ürün Adı", UnitPrice = 5, UnitsInStock = 10},
            new Product{ProductName = "Ürün Adı", UnitPrice = 5, UnitsInStock = 10},
            new Product{ProductName = "Ürün Adı", UnitPrice = 5, UnitsInStock = 10},
            new Product{ProductName = "Ürün Adı", UnitPrice = 5, UnitsInStock = 10},
            new Product{ProductName = "Ürün Adı", UnitPrice = 5, UnitsInStock = 10},
            new Product{ProductName = "Ürün Adı", UnitPrice = 5, UnitsInStock = 10},
            new Product{ProductName = "Ürün Adı", UnitPrice = 5, UnitsInStock = 10}
        }
    }
);
db.SaveChanges();

var products = db.Products.Where(x => x.SupplierId == null).ToList();
products.ForEach(x => x.SupplierId = 15);
db.SaveChanges();