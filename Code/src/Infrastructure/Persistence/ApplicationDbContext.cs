namespace Code.Infrastructure.Persistence;
public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser >, IApplicationDbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
    {

    }
     
    public virtual DbSet<Category> Categories { get; set; } = null!;
    public virtual DbSet<Product> Products { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder builder)
    {  
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
