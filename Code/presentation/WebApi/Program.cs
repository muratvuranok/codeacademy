using Code.Application;
using Code.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
 

builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);


var app = builder.Build();
 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseIdentityServer();
app.UseAuthorization();

app.MapControllers();

app.Run();

// dotnet ef database update -p ..\..\src\Infrastructure\Infrastructure.csproj -s WebApi.csproj
// dotnet ef migrations add initialize -p ..\..\src\Infrastructure\Infrastructure.csproj -s WebApi.csproj  