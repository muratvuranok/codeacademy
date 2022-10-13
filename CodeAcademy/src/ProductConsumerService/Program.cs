using CodeAcademy.ProductService;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ProductServiceConfiguration(builder.Configuration);


builder.Services.AddMassTransit(config =>
{
    config.AddConsumer<ProductConsumer>();
    config.UsingRabbitMq((ctx, cfg) =>
    {
        cfg.Host("amqp://guest:guest@localhost:5672");
        cfg.ReceiveEndpoint("product-queue", c =>
        {
            c.ConfigureConsumer<ProductConsumer>(ctx);
        });
    });
});


var app = builder.Build(); 
app.MapGet("/", () => "Hello World!"); 
app.Run();

// sln dizininde calistiriniz

// dotnet ef migrations add initialize --project   src\ProductService --startup-project     src\ProductConsumerService --output-dir   src\ProductService/Migrations
// dotnet ef database update --project   src\ProductService --startup-project     src\ProductConsumerService