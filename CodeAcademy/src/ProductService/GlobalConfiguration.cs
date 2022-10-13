using CodeAcademy.ProductService.Data;
using CodeAcademy.ProductService.Repositories;
using CodeAcademy.ProductService.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeAcademy.ProductService;

public static class GlobalConfiguration
{
    public static IServiceCollection ProductServiceConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(option => option
        .UseSqlServer(configuration
        .GetConnectionString("default"), builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));


        services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        services.AddTransient<IProductRepository, ProductRepository>();
        return services;
    }
}
