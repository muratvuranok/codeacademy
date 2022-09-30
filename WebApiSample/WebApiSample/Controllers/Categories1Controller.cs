namespace WebApiSample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Categories1Controller : ControllerBase
{

    private readonly IMapper _mapper;
    private readonly NorthwindContext _northwindContext;
    private IValidator<CategoryCreateDto> _validator;
    public Categories1Controller(NorthwindContext northwindContext, IMapper mapper, IValidator<CategoryCreateDto> validator)
    {
        this._mapper = mapper;
        this._northwindContext = northwindContext;
        this._validator = validator;
    }

    #region Old

    /*

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


    //[HttpPost]
    //public async Task<CategoryDto> Post(
    //    [FromQuery] CategoryCreateDto categoryCreateDto,
    //    [FromBody] CategoryCreateDto dto,
    //    [FromHeader] HeadData headData
    //    )
    //{
    //    // Insert => Model -> Category
    //    string r = "";

    //    var result = await _validator.ValidateAsync(dto);

    //    return _mapper.Map<CategoryDto>(categoryCreateDto);
    //}

    /// <summary>
    /// Create New Category
    /// </summary>
    /// <param name="categoryCreateDto">CategoryCreateDto categoryCreateDto</param>
    /// <returns>CategoryDto</returns>
    [HttpPost]
    public async Task<CategoryDto> Post([FromBody] CategoryCreateDto categoryCreateDto)
    {
        // Insert => Model -> Category
       
        //var result = await _validator.ValidateAsync(categoryCreateDto);
        //if (!result.IsValid)
        //{

        //}
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
        [FromHeader(Name = "User-Agent")]
        public string? UserAgent { get; set; }
        [FromHeader(Name = "Accept-Encoding")]
        public string? AcceptEncoding { get; set; }
        [FromHeader]
        public string? Accept { get; set; }
        [FromHeader]
        public string? Server { get; set; }
    }
    */

    #endregion
     


    // CRUD

   
}
