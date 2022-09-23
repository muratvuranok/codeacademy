using Microsoft.EntityFrameworkCore;
using MVC_TemplateApp.Models;

namespace MVC_TemplateApp.Data;
 
public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {

    }

    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<ProductPhoto> ProductPhotos { get; set; }
}
