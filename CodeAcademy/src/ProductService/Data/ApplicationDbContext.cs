using Microsoft.EntityFrameworkCore;
using Models;

namespace CodeAcademy.ProductService.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public virtual DbSet<Product> Products { get; set; } = null!;
}
