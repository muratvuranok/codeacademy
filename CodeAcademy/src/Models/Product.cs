using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Product
{
    public Product()
    {
        this.Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string ProductName { get; set; } = null!;
    public short UnitsInStock { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal UnitPrice { get; set; }
}
 