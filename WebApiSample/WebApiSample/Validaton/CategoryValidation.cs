namespace WebApiSample.Validaton
{
    public class CategoryValidation : AbstractValidator<CategoryCreateDto>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.CategoryName)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .WithMessage(Messages.CategoryNameCanNotBeNull)
                .NotEmpty()
                .WithMessage(Messages.CategoryNameCanNotBeNull)    
                .MaximumLength(20)
                .WithMessage(Messages.CategoryNameMustBeGratherThen20)
                .MinimumLength(1)
                .WithMessage(Messages.CategoryNameMinValueMustBeOne);
        }
    }
}
