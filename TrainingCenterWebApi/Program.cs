using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TrainingCenterWebApi;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

var configuration = builder.Configuration;
var generalSettings = configuration.GetSection(GeneralSettings.sectionName).Get<GeneralSettings>();

builder.Services.AddDbContext<MainDataBaseContext>(options =>
    options.UseNpgsql(generalSettings.ConnectionString));

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
    .AddEntityFrameworkStores<MainDataBaseContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<GeneralSettings>(configuration.GetSection(GeneralSettings.sectionName));
builder.Services.AddOpenApi();
var app = builder.Build();
 

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
