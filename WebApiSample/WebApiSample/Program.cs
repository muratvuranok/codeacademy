using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;
using WebApiSample.Validaton;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services
    .AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters();

builder.Services.AddValidatorsFromAssemblyContaining<CategoryValidation>();


builder.Services.AddEndpointsApiExplorer();
 
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
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
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseAuthorization();

app.MapControllers();

app.Run();
