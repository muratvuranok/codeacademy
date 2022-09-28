using System.Text.Json.Serialization;

namespace WebApiSample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{

    private readonly IMapper _mapper;
    private readonly NorthwindContext _northwindContext;
    public CategoriesController(NorthwindContext northwindContext, IMapper mapper)
    {
        this._mapper = mapper;
        this._northwindContext = northwindContext;
    }


    [HttpGet]
    public async Task<IEnumerable<CategoryDto>> Get()
    {
        //var categories = await _northwindContext.Categories.Select(x => new CategoryDto
        //{
        //    CategoryId = x.CategoryId,
        //    CategoryName = x.CategoryName,
        //    Description = x.Description
        //}).ToListAsync();

        var result = _mapper.Map<IEnumerable<CategoryDto>>(await _northwindContext.Categories.ToListAsync());

        return result;
    }

    [HttpGet("top-5")]
    public async Task<IEnumerable<CategoryDto>> GetTop5()
    {
        var categories = await _northwindContext.Categories.Select(x => new CategoryDto
        {
            CategoryId = x.CategoryId,
            CategoryName = x.CategoryName,
            Description = x.Description
        }).Take(5).ToListAsync();

        return categories;
    }


    [HttpPost]
    public async Task<CategoryDto> Post(
        [FromQuery] CategoryCreateDto categoryCreateDto, 
        [FromBody] CategoryCreateDto dto,
        [FromHeader] HeadData headData
        )
    {
        // Insert => Model -> Category


        return _mapper.Map<CategoryDto>(categoryCreateDto);
    }

    public class HeadData
    {
        [FromHeader]
        public string? CompanyName { get; set; }
        [FromHeader]
        public string? Email { get; set; }
        [FromHeader]
        public string? Address { get; set; }
        [FromHeader(Name="User-Agent")] 
        public string? UserAgent { get; set; }
        [FromHeader(Name = "Accept-Encoding")]
        public string? AcceptEncoding { get; set; }
        [FromHeader]
        public string? Accept { get; set; }
        [FromHeader]
        public string? Server { get; set; }
    }
}
