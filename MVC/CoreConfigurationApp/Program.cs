using CodeApp;
using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);
// builder.Logging.ClearProviders();
// builder.Logging.AddConsole();


builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
    logging.AddEventLog();
});



var app = builder.Build();


var connection = app.Configuration.GetConnectionString("DefaultConnection");
var userName   = app.Configuration.GetSection(CodeAcademySettings.ConfigName)["UserName"];
var mail       = app.Configuration[CodeAcademySettings.ConfigName + ":Email"];
var fullName   = app.Configuration[$"{CodeAcademySettings.ConfigName}:FullName:FirstName"];


CodeAcademySettings codeAcademySettings = app.Configuration
.GetSection("CodeAcademySettings")
.Get<CodeAcademySettings>();

app.MapGet("/", () => $"{connection} - {userName} - CodeUserName : {codeAcademySettings.UserName} - Code Mail -> {mail} -> FullName:FirstName  : {fullName}");

app.Run();
