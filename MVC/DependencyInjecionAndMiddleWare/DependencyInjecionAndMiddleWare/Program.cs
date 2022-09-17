var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// This method gets called by the runtime. Use this method to add services to the container. 
builder.Services.AddControllersWithViews();
/*
 * AddScoped    : uptimeService instance'ı HomeController nesneyi bellekte kaldığı sürece aynıdır.  Her action'da aynı instance kullanılır.
 * AddSingleton : uptimeService sadece bir adet olur
 * AddTransient : uptimeService, her ihtiyaç duyulduğunda instance oluşur.
 */



var app = builder.Build();

// Configure the HTTP request pipeline.
// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
