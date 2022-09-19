using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodeMVCApp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CodeMVCAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CodeMVCAppContext") ?? throw new InvalidOperationException("Connection string 'CodeMVCAppContext' not found.")));

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


//app.MapControllerRoute(
//    name: "categories",
//    pattern: "categories/details/{categoryId}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=categories}/{action=index}/{id?}");
 
app.Run();
