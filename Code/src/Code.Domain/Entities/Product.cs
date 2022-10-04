using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Domain.Entities;

public class Product : BaseAuditableEntity
{
    public string ProductName { get; set; } = null!;
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public int? CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}