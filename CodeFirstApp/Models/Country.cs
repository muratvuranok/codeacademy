using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models;

public class Country
{
    public Country()
    {
        this.Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string ISO { get; set; }
    public string Capital { get; set; }
    public string Currency { get; set; }
    public string Continent { get; set; }
    public string CustomProperty { get; set; }


    public override string ToString()
    {
        return $"Id -> {this.Id} Code -> {this.Code}";
    }
}

// dotnet new console -n ProjeAdi