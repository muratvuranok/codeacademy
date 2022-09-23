using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_TemplateApp.Models;

public class Product
{
    public Product()
    {
        this.ProductPhotos = new HashSet<ProductPhoto>();
    }

    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    [Column(TypeName = "decimal(18,2)")]
    public decimal StartPrice { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public double Rate { get; set; }
    public virtual ICollection<ProductPhoto> ProductPhotos { get; set; }
}

 
 