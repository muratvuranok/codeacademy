using Microsoft.Extensions.Logging;

namespace Code.Infrastructure.Persistence;

public class ApplicationDbContextInitialiser
{
    private readonly ApplicationDbContext _context;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<ApplicationDbContextInitialiser> _logger;

    public ApplicationDbContextInitialiser(
        ApplicationDbContext context,
        RoleManager<IdentityRole> roleManager,
        UserManager<ApplicationUser> userManager,
        ILogger<ApplicationDbContextInitialiser> logger)
    {
        this._logger = logger;
        this._context = context;
        this._userManager = userManager;
        this._roleManager = roleManager;
    }


    public async Task InitializeAsync()
    {
        try
        {
            if (_context.Database.IsSqlServer())
            {
                await _context.Database.MigrateAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured while initalising the database...");
            throw;
        }
    }


    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception)
        {
            _logger.LogError("An error occured while seeding the database...");
            throw;
        }
    }

    public async Task TrySeedAsync()
    {
        // Default Roles
        var administratorRole = new IdentityRole("administrator");
        if (_roleManager.Roles.All(r => r.Name != administratorRole.Name))
        {
            await _roleManager.CreateAsync(administratorRole);
        }

        // Default Users

        var administrator = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost.com" };

        if (_userManager.Users.All(u => u.UserName != administrator.UserName))
        {
            await _userManager.CreateAsync(administrator, "Pa$$word1");
            //await _userManager.AddToRoleAsync(administrator, administratorRole.Name );
            await _userManager.AddToRolesAsync(administrator, new[] { administratorRole.Name });
        }


        // Default Categories
        if (!_context.Categories.Any())
        {
            await _context.Categories.AddRangeAsync(new List<Category>
            {
                new Category { CategoryName = "Beverages",      Description = "Soft drinks, coffees, teas, beers, and ales"},
                new Category { CategoryName = "Condiments",     Description = "Sweet and savory sauces, relishes, spreads, and seasonings"},
                new Category { CategoryName = "Confections",    Description = "Desserts, candies, and sweet breads"},
                new Category { CategoryName = "Dairy Products", Description = "Cheeses"},
                new Category { CategoryName = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal"},
                new Category { CategoryName = "Meat/Poultry",   Description = "Prepared meats"},
                new Category { CategoryName = "Produce",        Description = "Dried fruit and bean curd"},
                new Category { CategoryName = "Seafood",        Description = "Seaweed and fish"},
            });

            await _context.SaveChangesAsync();
        }
    }
}
