using MassTransit;

var builder = WebApplication.CreateBuilder(args);


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
