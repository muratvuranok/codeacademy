namespace Code.Infrastructure.Persistence.Configurations;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.Property(x => x.CategoryName).HasMaxLength(100).IsRequired(true);
        builder.Property(x => x.Description).HasMaxLength(500).IsRequired(false);
    }
}
