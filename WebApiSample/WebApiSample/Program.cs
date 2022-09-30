using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;
using WebApiSample.Validaton;
using static WebApiSample.Filters.RedocFixerDocumentFilter;


string MyAllowSpecificOrigins = "_myAllowSpecificOrigins"; 
var builder = WebApplication.CreateBuilder(args);

 
builder.Services.AddControllers();

builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


//builder.Services
//    .AddFluentValidationAutoValidation()
//    .AddFluentValidationClientsideAdapters();

//builder.Services.AddValidatorsFromAssemblyContaining<CategoryValidation>();


builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.DefaultApiVersion = new ApiVersion(Convert.ToInt32(builder.Configuration["Version"]), 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
});



builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "1",
        Title = "Code Academy",
        Description = "Code Academy Api Services Documentations",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });

    //options.OperationFilter<RemoveVersionFromParameter>();
    options.DocumentFilter<ReplaceVersionWithExactValueInPath>();
});


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://127.0.0.1:5500")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//app.Use(async (context, next) =>
//{
//    var token = context.Session.GetString("Token");
//    if (!string.IsNullOrEmpty(token))
//    {
//        context.Request.Headers.Add("Authorization", "Bearer " + token);
//    }
//    await next();
//});


app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();


app.Run();
