using Code.Application;
using Code.Infrastructure;
using Code.Infrastructure.Persistence;
using Code.WebApi.Filters;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers(options => options.Filters.Add<ApiExceptionFilterAttribute>());

builder.Services.AddFluentValidationAutoValidation(configuration => configuration.DisableDataAnnotationsValidation = false)
    .AddFluentValidationClientsideAdapters();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using (var scope = app.Services.CreateScope())
    {
        var initializer = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitialiser>();
        await initializer.InitializeAsync();
        await initializer.SeedAsync();
    }
}

//app.UseAuthentication();
//app.UseIdentityServer();

app.UseAuthorization();

app.MapControllers();

app.Run();

// dotnet ef database update -p ..\..\src\Infrastructure\Infrastructure.csproj -s WebApi.csproj
// dotnet ef migrations add initialize -p ..\..\src\Infrastructure\Infrastructure.csproj -s WebApi.csproj  