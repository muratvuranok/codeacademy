using Microsoft.EntityFrameworkCore;
using CodeFirstApp.Models;

namespace CodeFirstApp.Data;
public class MyContext : DbContext
{
    public virtual DbSet<Country> Countries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=localhost,1433;uid=sa;pwd=Pro247!!;database=CodeFirstDb");
        base.OnConfiguring(optionsBuilder);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { 
        modelBuilder.Entity<Country>(model =>
        {
            model.HasKey(prop => prop.Id);
            model.Property(prop => prop.ISO).HasMaxLength(10).IsRequired(false);
            model.Property(prop => prop.Name).HasMaxLength(100).IsRequired(true);
            model.Property(prop => prop.Code).HasMaxLength(2).IsRequired(false);
            model.Property(prop => prop.Phone).HasMaxLength(30).IsRequired(false);
            model.Property(prop => prop.Capital).HasMaxLength(100).IsRequired(false);
            model.Property(prop => prop.Currency).HasMaxLength(5).IsRequired(false);
            model.Property(prop => prop.Continent).HasMaxLength(100).IsRequired(false);
        });

        base.OnModelCreating(modelBuilder);
    }
}

// dotnet ef migrations add initalize
// dotnet ef database update