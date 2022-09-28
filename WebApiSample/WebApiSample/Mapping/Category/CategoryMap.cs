namespace WebApiSample.Mapping.Category;

public class CategoryMap : Profile
{
    public CategoryMap()
    {
        CreateMap<M.Category, CategoryDto>()
            .ForMember(
                        dest => dest.FullProperty,
                        opt => opt.MapFrom(src => $"{src.CategoryId} {src.CategoryName} {src.Description}"))
            .ReverseMap();


        CreateMap<M.Category, CategoryCreateDto>().ReverseMap(); 
        CreateMap<CategoryDto, CategoryCreateDto>().ReverseMap(); 
    }
}
