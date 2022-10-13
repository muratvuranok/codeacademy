using MassTransit;
using Models;

public class ProductConsumer : IConsumer<Product>
{
    private ILogger<ProductConsumer> _logger;
    public ProductConsumer(ILogger<ProductConsumer> logger = null)
    {
        _logger = logger;
    }
    public async Task Consume(ConsumeContext<Product> context)
    {
        await Console.Out.WriteAsync(context.Message.Name);
        _logger.LogInformation(context.Message.Name);
    }
}
