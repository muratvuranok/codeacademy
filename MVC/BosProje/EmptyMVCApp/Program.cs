using CodeEduAz.Extentions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



//app.Map("/test", branch =>
//{ 
//    branch.Run(async (ahmet) =>   // return;
//    {
//        if (ahmet.Request.Query.ContainsKey("id"))
//        {
//            ahmet.Response.ContentType = "text/utf8";
//            await ahmet.Response.WriteAsync($"Hello Middleware -> Gelen Degerimiz {ahmet.Request.Query["id"]}");
//        }
//        else
//        {
//            await ahmet.Response.WriteAsync("id degeri bulunamadi");
//        }
//    }); 
//});

//app.MapGet("/", () => "Hello World!");
//app.Run(async (requestDelegate) =>
//{
//    Console.WriteLine("Test Request");
//});

app.Use(async (context, task) =>
{
    Console.WriteLine("1. Çalışır");
    await task.Invoke();
    Console.WriteLine("Response 8");

});
app.Use(async (context, task) =>
{
    Console.WriteLine("2. Çalışır1");
    await task.Invoke();
    Console.WriteLine("Response 7");

});
app.Use(async (context, task) =>
{
    Console.WriteLine("3. çalışır");
    await task.Invoke();
    Console.WriteLine("Response 6");

});
app.Use(async (context, task) =>
{
    Console.WriteLine("4. Çalışır");
    await task.Invoke();
    Console.WriteLine("Response 5");

});


//app.MapGet("/test", () => Console.WriteLine("test -> 1 MapGet Middleware Start"));
//app.MapGet("/deneme", () => Console.WriteLine("deneme -> 2 MapGet Middleware Start"));
//app.MapGet("/mid", () => Console.WriteLine("mid -> 3 MapGet Middleware Start"));
//app.MapGet("/denemeler", () => Console.WriteLine("denemeler -> 4 MapGet Middleware Start"));
//app.MapGet("/", () => Console.WriteLine("5 MapGet Middleware Start"));


//app.UseMyFirstMiddleware();


app.Run();


//  var builder = new ConfigurationBuilder()
//      .SetBasePath(Directory.GetCurrentDirectory())
//      .AddJsonFile("appsettings.json", true, true)
//      .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true, true)
//      .AddEnvironmentVariables();
//  Configuration = builder.Build();
