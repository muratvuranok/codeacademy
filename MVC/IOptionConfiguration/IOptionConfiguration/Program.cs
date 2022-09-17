using IOptionConfiguration.Models;
using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);


builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
    logging.AddEventLog();
});


builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.ResponseHeaders.Add("MyResponseHeader");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;

});


builder.Services.AddW3CLogging(logging =>
{
    // Log all W3C fields
    logging.LoggingFields = W3CLoggingFields.All;

    logging.FileSizeLimit = 5 * 1024 * 1024;
    logging.RetainedFileCountLimit = 2;
    logging.FileName = "MyLogFile";
    logging.LogDirectory = @"C:\logs";
    logging.FlushInterval = TimeSpan.FromSeconds(2);
});


// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.Configure<PositionOptions>(builder.Configuration.GetSection(PositionOptions.Position));
 

var app = builder.Build();
app.UseHttpLogging();
app.UseW3CLogging();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(  name: "category",  pattern: "Categories/{action=Index}/{id?}/{categoryName?}");
app.MapControllerRoute(  name: "category",  pattern: "Products/{productName}-p-{id}");
app.MapControllerRoute(  name: "default",  pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//  constoso.com
//  /categories/index
//  /categories/details/1
//  /categories/details/test


// / -p-HBCV00002VUQ7W?magaza=Hepsiburada
// / -p-HBV000011FJ31
// {productName}-p-{Id}
// {productName}-p-{Id}-magaza-