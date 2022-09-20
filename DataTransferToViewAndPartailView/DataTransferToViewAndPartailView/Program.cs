var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



/*
 

Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.SqlServer

Scaffold-DbContext "server=localhost,1433;database=northwind;uid=sa;pwd=Pro247!!" Microsoft.EntityFrameworkCore.SqlServer -outputdir Models -t Categories,Products,Customers, Shippers





dotnet-aspnet-codegenerator controller -name ProductsController -m Product -dc northwindDbContext --relativeFolderPath Controllers --useDefaultLayout   


 */