namespace WebApiSample.FluentApiMap;
public class CategoryMapping : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories", "dbo");
        builder.Property(p => p.CategoryName).HasMaxLength(25).IsRequired(true);
        builder.Property(p => p.Description).HasMaxLength(500).HasColumnType("nvarchar").IsRequired(false);
    }
}
 