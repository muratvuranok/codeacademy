/*
 
 
 List<Product> Products = new()
{
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },
    new Product{ ProductId = 1, },


}
 */



using App_Expression;
using App_Expression.Services;

#region Product List
List<Product> products = new()
{
new Product { ProductID = 1, ProductName= "Chai", CategoryID = 1, Discontinued = false, QuantityPerUnit = "10 boxes x 20 bags", ReorderLevel = 10, SupplierID = 1, UnitPrice = 18.00F,UnitsInStock = 39,UnitsOnOrder= 0 },
new Product { ProductID = 2, ProductName= "Chang", CategoryID = 1, Discontinued = false, QuantityPerUnit = "24 - 12 oz bottles", ReorderLevel = 25, SupplierID = 1, UnitPrice = 19.00F,UnitsInStock = 17,UnitsOnOrder= 40 },
new Product { ProductID = 3, ProductName= "Aniseed Syrup", CategoryID = 2, Discontinued = false, QuantityPerUnit = "12 - 550 ml bottles", ReorderLevel = 25, SupplierID = 1, UnitPrice = 10.00F,UnitsInStock = 13,UnitsOnOrder= 70 },
new Product { ProductID = 4, ProductName= "Chef Anton's Cajun Seasoning", CategoryID = 2, Discontinued = false, QuantityPerUnit = "48 - 6 oz jars", ReorderLevel = 0, SupplierID = 2, UnitPrice = 22.00F,UnitsInStock = 53,UnitsOnOrder= 0 },
new Product { ProductID = 5, ProductName= "Chef Anton's Gumbo Mix", CategoryID = 2, Discontinued = true, QuantityPerUnit = "36 boxes", ReorderLevel = 0, SupplierID = 2, UnitPrice = 21.35F,UnitsInStock = 0,UnitsOnOrder= 0 },
new Product { ProductID = 6, ProductName= "Grandma's Boysenberry Spread", CategoryID = 2, Discontinued = false, QuantityPerUnit = "12 - 8 oz jars", ReorderLevel = 25, SupplierID = 3, UnitPrice = 25.00F,UnitsInStock = 120,UnitsOnOrder= 0 },
new Product { ProductID = 7, ProductName= "Uncle Bob's Organic Dried Pears", CategoryID = 7, Discontinued = false, QuantityPerUnit = "12 - 1 lb pkgs.", ReorderLevel = 10, SupplierID = 3, UnitPrice = 30.00F,UnitsInStock = 15,UnitsOnOrder= 0 },
new Product { ProductID = 8, ProductName= "Northwoods Cranberry Sauce", CategoryID = 2, Discontinued = false, QuantityPerUnit = "12 - 12 oz jars", ReorderLevel = 0, SupplierID = 3, UnitPrice = 40.00F,UnitsInStock = 6,UnitsOnOrder= 0 },
new Product { ProductID = 9, ProductName= "Mishi Kobe Niku", CategoryID = 6, Discontinued = true, QuantityPerUnit = "18 - 500 g pkgs.", ReorderLevel = 0, SupplierID = 4, UnitPrice = 97.00F,UnitsInStock = 29,UnitsOnOrder= 0 },
new Product { ProductID = 10, ProductName= "Ikura", CategoryID = 8, Discontinued = false, QuantityPerUnit = "12 - 200 ml jars", ReorderLevel = 0, SupplierID = 4, UnitPrice = 31.00F,UnitsInStock = 31,UnitsOnOrder= 0 },
new Product { ProductID = 11, ProductName= "Queso Cabrales", CategoryID = 4, Discontinued = false, QuantityPerUnit = "1 kg pkg.", ReorderLevel = 30, SupplierID = 5, UnitPrice = 21.00F,UnitsInStock = 22,UnitsOnOrder= 30 },
new Product { ProductID = 12, ProductName= "Queso Manchego La Pastora", CategoryID = 4, Discontinued = false, QuantityPerUnit = "10 - 500 g pkgs.", ReorderLevel = 0, SupplierID = 5, UnitPrice = 38.00F,UnitsInStock = 86,UnitsOnOrder= 0 },
new Product { ProductID = 13, ProductName= "Konbu", CategoryID = 8, Discontinued = false, QuantityPerUnit = "2 kg box", ReorderLevel = 5, SupplierID = 6, UnitPrice = 6.00F,UnitsInStock = 24,UnitsOnOrder= 0 },
new Product { ProductID = 14, ProductName= "Tofu", CategoryID = 7, Discontinued = false, QuantityPerUnit = "40 - 100 g pkgs.", ReorderLevel = 0, SupplierID = 6, UnitPrice = 23.25F,UnitsInStock = 35,UnitsOnOrder= 0 },
new Product { ProductID = 15, ProductName= "Genen Shouyu", CategoryID = 2, Discontinued = false, QuantityPerUnit = "24 - 250 ml bottles", ReorderLevel = 5, SupplierID = 6, UnitPrice = 15.50F,UnitsInStock = 39,UnitsOnOrder= 0 },
new Product { ProductID = 16, ProductName= "Pavlova", CategoryID = 3, Discontinued = false, QuantityPerUnit = "32 - 500 g boxes", ReorderLevel = 10, SupplierID = 7, UnitPrice = 17.45F,UnitsInStock = 29,UnitsOnOrder= 0 },
new Product { ProductID = 17, ProductName= "Alice Mutton", CategoryID = 6, Discontinued = true, QuantityPerUnit = "20 - 1 kg tins", ReorderLevel = 0, SupplierID = 7, UnitPrice = 39.00F,UnitsInStock = 0,UnitsOnOrder= 0 },
new Product { ProductID = 18, ProductName= "Carnarvon Tigers", CategoryID = 8, Discontinued = false, QuantityPerUnit = "16 kg pkg.", ReorderLevel = 0, SupplierID = 7, UnitPrice = 62.50F,UnitsInStock = 42,UnitsOnOrder= 0 },
new Product { ProductID = 19, ProductName= "Teatime Chocolate Biscuits", CategoryID = 3, Discontinued = false, QuantityPerUnit = "10 boxes x 12 pieces", ReorderLevel = 5, SupplierID = 8, UnitPrice = 9.20F,UnitsInStock = 25,UnitsOnOrder= 0 },
new Product { ProductID = 20, ProductName= "Sir Rodney's Marmalade", CategoryID = 3, Discontinued = false, QuantityPerUnit = "30 gift boxes", ReorderLevel = 0, SupplierID = 8, UnitPrice = 81.00F,UnitsInStock = 40,UnitsOnOrder= 0 },
new Product { ProductID = 21, ProductName= "Sir Rodney's Scones", CategoryID = 3, Discontinued = false, QuantityPerUnit = "24 pkgs. x 4 pieces", ReorderLevel = 5, SupplierID = 8, UnitPrice = 10.00F,UnitsInStock = 3,UnitsOnOrder= 40 },
new Product { ProductID = 22, ProductName= "Gustaf's Knäckebröd", CategoryID = 5, Discontinued = false, QuantityPerUnit = "24 - 500 g pkgs.", ReorderLevel = 25, SupplierID = 9, UnitPrice = 21.00F,UnitsInStock = 104,UnitsOnOrder= 0 },
new Product { ProductID = 23, ProductName= "Tunnbröd", CategoryID = 5, Discontinued = false, QuantityPerUnit = "12 - 250 g pkgs.", ReorderLevel = 25, SupplierID = 9, UnitPrice = 9.00F,UnitsInStock = 61,UnitsOnOrder= 0 },
new Product { ProductID = 24, ProductName= "Guaraná Fantástica", CategoryID = 1, Discontinued = true, QuantityPerUnit = "12 - 355 ml cans", ReorderLevel = 0, SupplierID = 10, UnitPrice = 4.50F,UnitsInStock = 20,UnitsOnOrder= 0 },
new Product { ProductID = 25, ProductName= "NuNuCa Nuß-Nougat-Creme", CategoryID = 3, Discontinued = false, QuantityPerUnit = "20 - 450 g glasses", ReorderLevel = 30, SupplierID = 11, UnitPrice = 14.00F,UnitsInStock = 76,UnitsOnOrder= 0 },
new Product { ProductID = 26, ProductName= "Gumbär Gummibärchen", CategoryID = 3, Discontinued = false, QuantityPerUnit = "100 - 250 g bags", ReorderLevel = 0, SupplierID = 11, UnitPrice = 31.23F,UnitsInStock = 15,UnitsOnOrder= 0 },
new Product { ProductID = 27, ProductName= "Schoggi Schokolade", CategoryID = 3, Discontinued = false, QuantityPerUnit = "100 - 100 g pieces", ReorderLevel = 30, SupplierID = 11, UnitPrice = 43.90F,UnitsInStock = 49,UnitsOnOrder= 0 },
new Product { ProductID = 28, ProductName= "Rössle Sauerkraut", CategoryID = 7, Discontinued = true, QuantityPerUnit = "25 - 825 g cans", ReorderLevel = 0, SupplierID = 12, UnitPrice = 45.60F,UnitsInStock = 26,UnitsOnOrder= 0 },
new Product { ProductID = 29, ProductName= "Thüringer Rostbratwurst", CategoryID = 6, Discontinued = true, QuantityPerUnit = "50 bags x 30 sausgs.", ReorderLevel = 0, SupplierID = 12, UnitPrice = 123.79F,UnitsInStock = 0,UnitsOnOrder= 0 },
new Product { ProductID = 30, ProductName= "Nord-Ost Matjeshering", CategoryID = 8, Discontinued = false, QuantityPerUnit = "10 - 200 g glasses", ReorderLevel = 15, SupplierID = 13, UnitPrice = 25.89F,UnitsInStock = 10,UnitsOnOrder= 0 },
new Product { ProductID = 31, ProductName= "Gorgonzola Telino", CategoryID = 4, Discontinued = false, QuantityPerUnit = "12 - 100 g pkgs", ReorderLevel = 20, SupplierID = 14, UnitPrice = 12.50F,UnitsInStock = 0,UnitsOnOrder= 70 },
new Product { ProductID = 32, ProductName= "Mascarpone Fabioli", CategoryID = 4, Discontinued = false, QuantityPerUnit = "24 - 200 g pkgs.", ReorderLevel = 25, SupplierID = 14, UnitPrice = 32.00F,UnitsInStock = 9,UnitsOnOrder= 40 },
new Product { ProductID = 33, ProductName= "Geitost", CategoryID = 4, Discontinued = false, QuantityPerUnit = "500 g", ReorderLevel = 20, SupplierID = 15, UnitPrice = 2.50F,UnitsInStock = 112,UnitsOnOrder= 0 },
new Product { ProductID = 34, ProductName= "Sasquatch Ale", CategoryID = 1, Discontinued = false, QuantityPerUnit = "24 - 12 oz bottles", ReorderLevel = 15, SupplierID = 16, UnitPrice = 14.00F,UnitsInStock = 111,UnitsOnOrder= 0 },
new Product { ProductID = 35, ProductName= "Steeleye Stout", CategoryID = 1, Discontinued = false, QuantityPerUnit = "24 - 12 oz bottles", ReorderLevel = 15, SupplierID = 16, UnitPrice = 18.00F,UnitsInStock = 20,UnitsOnOrder= 0 },
new Product { ProductID = 36, ProductName= "Inlagd Sill", CategoryID = 8, Discontinued = false, QuantityPerUnit = "24 - 250 g  jars", ReorderLevel = 20, SupplierID = 17, UnitPrice = 19.00F,UnitsInStock = 112,UnitsOnOrder= 0 },
new Product { ProductID = 37, ProductName= "Gravad lax", CategoryID = 8, Discontinued = false, QuantityPerUnit = "12 - 500 g pkgs.", ReorderLevel = 25, SupplierID = 17, UnitPrice = 26.00F,UnitsInStock = 11,UnitsOnOrder= 50 },
new Product { ProductID = 38, ProductName= "Côte de Blaye", CategoryID = 1, Discontinued = false, QuantityPerUnit = "12 - 75 cl bottles", ReorderLevel = 15, SupplierID = 18, UnitPrice = 263.50F,UnitsInStock = 17,UnitsOnOrder= 0 },
new Product { ProductID = 39, ProductName= "Chartreuse verte", CategoryID = 1, Discontinued = false, QuantityPerUnit = "750 cc per bottle", ReorderLevel = 5, SupplierID = 18, UnitPrice = 18.00F,UnitsInStock = 69,UnitsOnOrder= 0 },
new Product { ProductID = 40, ProductName= "Boston Crab Meat", CategoryID = 8, Discontinued = false, QuantityPerUnit = "24 - 4 oz tins", ReorderLevel = 30, SupplierID = 19, UnitPrice = 18.40F,UnitsInStock = 123,UnitsOnOrder= 0 },
new Product { ProductID = 41, ProductName= "Jack's New England Clam Chowder", CategoryID = 8, Discontinued = false, QuantityPerUnit = "12 - 12 oz cans", ReorderLevel = 10, SupplierID = 19, UnitPrice = 9.65F,UnitsInStock = 85,UnitsOnOrder= 0 },
new Product { ProductID = 42, ProductName= "Singaporean Hokkien Fried Mee", CategoryID = 5, Discontinued = true, QuantityPerUnit = "32 - 1 kg pkgs.", ReorderLevel = 0, SupplierID = 20, UnitPrice = 14.00F,UnitsInStock = 26,UnitsOnOrder= 0 },
new Product { ProductID = 43, ProductName= "Ipoh Coffee", CategoryID = 1, Discontinued = false, QuantityPerUnit = "16 - 500 g tins", ReorderLevel = 25, SupplierID = 20, UnitPrice = 46.00F,UnitsInStock = 17,UnitsOnOrder= 10 },
new Product { ProductID = 44, ProductName= "Gula Malacca", CategoryID = 2, Discontinued = false, QuantityPerUnit = "20 - 2 kg bags", ReorderLevel = 15, SupplierID = 20, UnitPrice = 19.45F,UnitsInStock = 27,UnitsOnOrder= 0 },
new Product { ProductID = 45, ProductName= "Rogede sild", CategoryID = 8, Discontinued = false, QuantityPerUnit = "1k pkg.", ReorderLevel = 15, SupplierID = 21, UnitPrice = 9.50F,UnitsInStock = 5,UnitsOnOrder= 70 },
new Product { ProductID = 46, ProductName= "Spegesild", CategoryID = 8, Discontinued = false, QuantityPerUnit = "4 - 450 g glasses", ReorderLevel = 0, SupplierID = 21, UnitPrice = 12.00F,UnitsInStock = 95,UnitsOnOrder= 0 },
new Product { ProductID = 47, ProductName= "Zaanse koeken", CategoryID = 3, Discontinued = false, QuantityPerUnit = "10 - 4 oz boxes", ReorderLevel = 0, SupplierID = 22, UnitPrice = 9.50F,UnitsInStock = 36,UnitsOnOrder= 0 },
new Product { ProductID = 48, ProductName= "Chocolade", CategoryID = 3, Discontinued = false, QuantityPerUnit = "10 pkgs.", ReorderLevel = 25, SupplierID = 22, UnitPrice = 12.75F,UnitsInStock = 15,UnitsOnOrder= 70 },
new Product { ProductID = 49, ProductName= "Maxilaku", CategoryID = 3, Discontinued = false, QuantityPerUnit = "24 - 50 g pkgs.", ReorderLevel = 15, SupplierID = 23, UnitPrice = 20.00F,UnitsInStock = 10,UnitsOnOrder= 60 },
new Product { ProductID = 50, ProductName= "Valkoinen suklaa", CategoryID = 3, Discontinued = false, QuantityPerUnit = "12 - 100 g bars", ReorderLevel = 30, SupplierID = 23, UnitPrice = 16.25F,UnitsInStock = 65,UnitsOnOrder= 0 },
new Product { ProductID = 51, ProductName= "Manjimup Dried Apples", CategoryID = 7, Discontinued = false, QuantityPerUnit = "50 - 300 g pkgs.", ReorderLevel = 10, SupplierID = 24, UnitPrice = 53.00F,UnitsInStock = 20,UnitsOnOrder= 0 },
new Product { ProductID = 52, ProductName= "Filo Mix", CategoryID = 5, Discontinued = false, QuantityPerUnit = "16 - 2 kg boxes", ReorderLevel = 25, SupplierID = 24, UnitPrice = 7.00F,UnitsInStock = 38,UnitsOnOrder= 0 },
new Product { ProductID = 53, ProductName= "Perth Pasties", CategoryID = 6, Discontinued = true, QuantityPerUnit = "48 pieces", ReorderLevel = 0, SupplierID = 24, UnitPrice = 32.80F,UnitsInStock = 0,UnitsOnOrder= 0 },
new Product { ProductID = 54, ProductName= "Tourtière", CategoryID = 6, Discontinued = false, QuantityPerUnit = "16 pies", ReorderLevel = 10, SupplierID = 25, UnitPrice = 7.45F,UnitsInStock = 21,UnitsOnOrder= 0 },
new Product { ProductID = 55, ProductName= "Pâté chinois", CategoryID = 6, Discontinued = false, QuantityPerUnit = "24 boxes x 2 pies", ReorderLevel = 20, SupplierID = 25, UnitPrice = 24.00F,UnitsInStock = 115,UnitsOnOrder= 0 },
new Product { ProductID = 56, ProductName= "Gnocchi di nonna Alice", CategoryID = 5, Discontinued = false, QuantityPerUnit = "24 - 250 g pkgs.", ReorderLevel = 30, SupplierID = 26, UnitPrice = 38.00F,UnitsInStock = 21,UnitsOnOrder= 10 },
new Product { ProductID = 57, ProductName= "Ravioli Angelo", CategoryID = 5, Discontinued = false, QuantityPerUnit = "24 - 250 g pkgs.", ReorderLevel = 20, SupplierID = 26, UnitPrice = 19.50F,UnitsInStock = 36,UnitsOnOrder= 0 },
new Product { ProductID = 58, ProductName= "Escargots de Bourgogne", CategoryID = 8, Discontinued = false, QuantityPerUnit = "24 pieces", ReorderLevel = 20, SupplierID = 27, UnitPrice = 13.25F,UnitsInStock = 62,UnitsOnOrder= 0 },
new Product { ProductID = 59, ProductName= "Raclette Courdavault", CategoryID = 4, Discontinued = false, QuantityPerUnit = "5 kg pkg.", ReorderLevel = 0, SupplierID = 28, UnitPrice = 55.00F,UnitsInStock = 79,UnitsOnOrder= 0 },
new Product { ProductID = 60, ProductName= "Camembert Pierrot", CategoryID = 4, Discontinued = false, QuantityPerUnit = "15 - 300 g rounds", ReorderLevel = 0, SupplierID = 28, UnitPrice = 34.00F,UnitsInStock = 19,UnitsOnOrder= 0 },
new Product { ProductID = 61, ProductName= "Sirop d'érable", CategoryID = 2, Discontinued = false, QuantityPerUnit = "24 - 500 ml bottles", ReorderLevel = 25, SupplierID = 29, UnitPrice = 28.50F,UnitsInStock = 113,UnitsOnOrder= 0 },
new Product { ProductID = 62, ProductName= "Tarte au sucre", CategoryID = 3, Discontinued = false, QuantityPerUnit = "48 pies", ReorderLevel = 0, SupplierID = 29, UnitPrice = 49.30F,UnitsInStock = 17,UnitsOnOrder= 0 },
new Product { ProductID = 63, ProductName= "Vegie-spread", CategoryID = 2, Discontinued = false, QuantityPerUnit = "15 - 625 g jars", ReorderLevel = 5, SupplierID = 7, UnitPrice = 43.90F,UnitsInStock = 24,UnitsOnOrder= 0 },
new Product { ProductID = 64, ProductName= "Wimmers gute Semmelknödel", CategoryID = 5, Discontinued = false, QuantityPerUnit = "20 bags x 4 pieces", ReorderLevel = 30, SupplierID = 12, UnitPrice = 33.25F,UnitsInStock = 22,UnitsOnOrder= 80 },
new Product { ProductID = 65, ProductName= "Louisiana Fiery Hot Pepper Sauce", CategoryID = 2, Discontinued = false, QuantityPerUnit = "32 - 8 oz bottles", ReorderLevel = 0, SupplierID = 2, UnitPrice = 21.05F,UnitsInStock = 76,UnitsOnOrder= 0 },
new Product { ProductID = 66, ProductName= "Louisiana Hot Spiced Okra", CategoryID = 2, Discontinued = false, QuantityPerUnit = "24 - 8 oz jars", ReorderLevel = 20, SupplierID = 2, UnitPrice = 17.00F,UnitsInStock = 4,UnitsOnOrder= 100 },
new Product { ProductID = 67, ProductName= "Laughing Lumberjack Lager", CategoryID = 1, Discontinued = false, QuantityPerUnit = "24 - 12 oz bottles", ReorderLevel = 10, SupplierID = 16, UnitPrice = 14.00F,UnitsInStock = 52,UnitsOnOrder= 0 },
new Product { ProductID = 68, ProductName= "Scottish Longbreads", CategoryID = 3, Discontinued = false, QuantityPerUnit = "10 boxes x 8 pieces", ReorderLevel = 15, SupplierID = 8, UnitPrice = 12.50F,UnitsInStock = 6,UnitsOnOrder= 10 },
new Product { ProductID = 69, ProductName= "Gudbrandsdalsost", CategoryID = 4, Discontinued = false, QuantityPerUnit = "10 kg pkg.", ReorderLevel = 15, SupplierID = 15, UnitPrice = 36.00F,UnitsInStock = 26,UnitsOnOrder= 0 },
new Product { ProductID = 70, ProductName= "Outback Lager", CategoryID = 1, Discontinued = false, QuantityPerUnit = "24 - 355 ml bottles", ReorderLevel = 30, SupplierID = 7, UnitPrice = 15.00F,UnitsInStock = 15,UnitsOnOrder= 10 },
new Product { ProductID = 71, ProductName= "Flotemysost", CategoryID = 4, Discontinued = false, QuantityPerUnit = "10 - 500 g pkgs.", ReorderLevel = 0, SupplierID = 15, UnitPrice = 21.50F,UnitsInStock = 26,UnitsOnOrder= 0 },
new Product { ProductID = 72, ProductName= "Mozzarella di Giovanni", CategoryID = 4, Discontinued = false, QuantityPerUnit = "24 - 200 g pkgs.", ReorderLevel = 0, SupplierID = 14, UnitPrice = 34.80F,UnitsInStock = 14,UnitsOnOrder= 0 },
new Product { ProductID = 73, ProductName= "Röd Kaviar", CategoryID = 8, Discontinued = false, QuantityPerUnit = "24 - 150 g jars", ReorderLevel = 5, SupplierID = 17, UnitPrice = 15.00F,UnitsInStock = 101,UnitsOnOrder= 0 },
new Product { ProductID = 74, ProductName= "Longlife Tofu", CategoryID = 7, Discontinued = false, QuantityPerUnit = "5 kg pkg.", ReorderLevel = 5, SupplierID = 4, UnitPrice = 10.00F,UnitsInStock = 4,UnitsOnOrder= 20 },
new Product { ProductID = 75, ProductName= "Rhönbräu Klosterbier", CategoryID = 1, Discontinued = false, QuantityPerUnit = "24 - 0.5 l bottles", ReorderLevel = 25, SupplierID = 12, UnitPrice = 7.75F,UnitsInStock = 125,UnitsOnOrder= 0 },
new Product { ProductID = 76, ProductName= "Lakkalikööri", CategoryID = 1, Discontinued = false, QuantityPerUnit = "500 ml", ReorderLevel = 20, SupplierID = 23, UnitPrice = 18.00F,UnitsInStock = 57,UnitsOnOrder= 0 },
new Product { ProductID = 77, ProductName= "Original Frankfurter grüne Soße", CategoryID = 2, Discontinued = false, QuantityPerUnit = "12 boxes", ReorderLevel = 15, SupplierID = 12, UnitPrice = 13.00F,UnitsInStock = 32,UnitsOnOrder= 0 },
};
#endregion


/*
select 'new Product { ProductID = '+cast(ProductID as nvarchar) +', ProductName= "'+ProductName+'", CategoryID = '+cast(CategoryID as nvarchar) +', Discontinued = '+ CAST(Discontinued  as nvarchar)+', QuantityPerUnit = "'+cast(QuantityPerUnit as nvarchar) +'", ReorderLevel = '+cast(ReorderLevel as nvarchar) +', SupplierID = '+cast(SupplierID as nvarchar) +', UnitPrice = '+cast(UnitPrice as nvarchar) +'F,UnitsInStock = '+cast(UnitsInStock as nvarchar) +',UnitsOnOrder= '+cast(UnitsOnOrder as nvarchar) +' },'  from Products order by 1   
 */


// Linq to Entity
var result = products.Where(x => x.UnitPrice > 10);



// Linq to Sql

var retVal = from x in products
             where x.UnitPrice > 10
             select x;



var productList = new List<List<Product>> {
    products.Take(10).ToList(),
    products.Skip(10).Take(10).ToList(),
    products.Skip(20).Take(10).ToList(),
    products.Skip(30).Take(10).ToList(),
    products.Skip(40).Take(10).ToList(),
    products.Skip(50).Take(10).ToList()
};


List<int> ids = new List<int>();

var resultIds = productList.SelectMany(x => x.Select(c => c.ProductID));

int value = 10;


IProductService service = new ProductService();
ICollection<Product> productList1 = new List<Product>();


//if (value > 0)
//{
//    productList1 = service.GetProducts(x => x.ProductID > value);
//}

//string search = "";

//if (!string.IsNullOrWhiteSpace(search))
//{
//    productList1 = service.GetProducts(x => x.ProductID > value);
//}

//var retVal1 =  productList.WhereIf()

//if(value > 10)
//{
//    productList1.Take(10);
//}
//else
//{
//    productList.ToList();
//}
string search = "";
var dd = productList1
    .WhereIf(value > 10, x => x.ProductID > value)
    .WhereIf(!string.IsNullOrWhiteSpace(search), x => x.ProductName.Contains(search));