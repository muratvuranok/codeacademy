namespace MVC_TemplateApp.Models;

public class ProductPhoto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public string Url { get; set; } = null!;
}

 
 