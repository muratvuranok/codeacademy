using CodeFirstApp.Models;
using CodeFirstApp.Data;

MyContext context = new MyContext();
context.Countries.Add(new Country
{
    Code = "Cd",
    Name = "Name",
    Phone = "Phone ",
    ISO = "ISO",
    Capital = "Capital",
    Currency = "Crncy",
    Continent = "Continent",
    CustomProperty = "CustomProperty"
});

context.SaveChanges();
Console.Clear();
foreach (Country country in context.Countries)
{
    System.Console.WriteLine(country);
}

