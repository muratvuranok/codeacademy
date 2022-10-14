using FluentValidation;
using P = Models;

namespace CodeAcademy.ProductService.Validations.Product;

public class ProductCreateValidation : AbstractValidator<P.Product>
{

    //private readonly ApplicationDbContext _context;
    //public ProductCreateValidation(ApplicationDbContext context)
    public ProductCreateValidation()
    {
        //this._context = context;
        RuleFor(x => x.ProductName)
            .MaximumLength(255)
            .WithMessage("ProductName 255'den uzun olamaz")
            .NotNull()
            .WithMessage("ProductName null olamaz")
            .NotEmpty()
            .WithMessage("ProductName boş geçilemez");
        //.MustAsync(UniqProductName).WithMessage("ProductName Uniq olmalıdır");
    }

    //public async Task<bool> UniqProductName(string productName, CancellationToken cancellationToken)
    //{
    //    var result = await _context.Products.AllAsync(x => x.ProductName != productName, cancellationToken);
    //    return result;
    //}
}
