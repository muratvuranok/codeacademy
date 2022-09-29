namespace WebApiSample.Data;

public class NorthwindContext : DbContext
{
    public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

    public virtual DbSet<Category> Categories { get; set; } = null!;
    public virtual DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Category>()
            .Property(p => p.CategoryName)
            .HasMaxLength(25)
            .IsRequired(true);

        modelBuilder.Entity<Category>()
            .Property(p => p.Description)
            .HasMaxLength(500)
            .IsRequired(false)
            .HasColumnType("nvarchar");


        modelBuilder.Entity<StudentsCources>()
            .HasKey(cs => new { cs.StudentId, cs.CourseId });

        modelBuilder.Entity<StudentsCources>()
            .HasOne(x => x.Student)
            .WithMany(x => x.Cources)
            .HasForeignKey(x => x.StudentId);

        modelBuilder.Entity<StudentsCources>()
            .HasOne(x => x.Course)
            .WithMany(x => x.Students)
            .HasForeignKey(x => x.CourseId);



        //modelBuilder.ApplyConfiguration(new ProductMapping());
        //modelBuilder.ApplyConfiguration(new CategoryMapping());

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}
