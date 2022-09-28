namespace WebApiSample.Dtos.CategoryDtos;

public class CategoryDto
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    public string? Description { get; set; } 
    public string? FullProperty { get; set; } 
}
