namespace Code.Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.Property(x => x.ProductName).HasMaxLength(200).IsRequired(true);
        builder.Property(x => x.UnitPrice).IsRequired(false);
        builder.Property(x => x.UnitsInStock).IsRequired(false);
        builder.Property(x => x.CategoryId).IsRequired(false);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);
    }
}
