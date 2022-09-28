using Microsoft.EntityFrameworkCore;
using WebApiSample.Models;

namespace WebApiSample.Data;

public class NorthwindContext : DbContext
{
    public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
    {

    }
     
    public virtual DbSet<Category> Categories { get; set; }
}
