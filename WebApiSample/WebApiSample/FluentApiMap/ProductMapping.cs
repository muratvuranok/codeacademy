namespace WebApiSample.FluentApiMap;
public class ProductMapping : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products", "dbo");
        builder.Property(p => p.ProductID).IsRequired(true);
        builder.Property(p => p.ProductName).HasMaxLength(40).IsRequired(true);
        builder.Property(p => p.SupplierID).IsRequired(false);
        builder.Property(p => p.CategoryID).IsRequired(false);
        builder.Property(p => p.QuantityPerUnit).HasMaxLength(20).IsRequired(false);
        builder.Property(p => p.UnitPrice).IsRequired(false);
        builder.Property(p => p.UnitsInStock).IsRequired(false);
        builder.Property(p => p.UnitsOnOrder).IsRequired(false);
        builder.Property(p => p.ReorderLevel).IsRequired(false);
        builder.Property(p => p.Discontinued).IsRequired(true);


        builder.HasOne(x => x.Category)  // bir ürünün bir kategorisi vardır
            .WithMany(x => x.Products)   // bir kategorinin birden fazla ürünü vardır
            .HasForeignKey(x => x.CategoryID);  // foreignkey tanımlaması
    }
}

/*
 
 SELECT IS_NULLABLE,
    'builder.Property(p => p.' + COLUMN_NAME + ')'
    + IIF(CHARACTER_MAXIMUM_LENGTH is not NULL, '.HasMaxLength(' + cast(CHARACTER_MAXIMUM_LENGTH as nvarchar) + ')', '')
    + '.IsRequired(' + IIF(IS_NULLABLE = 'YES', 'false', 'true') + ');'
FROM
    INFORMATION_SCHEMA.COLUMNS
WHERE
    TABLE_NAME = N'Products'

 */