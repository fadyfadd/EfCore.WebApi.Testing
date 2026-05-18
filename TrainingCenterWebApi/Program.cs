using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TrainingCenterWebApi;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var configuration = builder.Configuration;
var generalSettings = configuration.GetSection(GeneralSettings.sectionName).Get<GeneralSettings>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins(generalSettings.CorsAllowedOrigins)
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});


builder.Services.AddControllers();



builder.Services.AddDbContext<MainDataBaseContext>(options =>
    options.UseNpgsql(generalSettings.ConnectionString));


builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
    .AddEntityFrameworkStores<MainDataBaseContext>()
    .AddDefaultTokenProviders();

builder.Services.AddSwaggerGen();


builder.Services.Configure<GeneralSettings>(configuration.GetSection(GeneralSettings.sectionName));
//builder.Services.AddOpenApi();
var app = builder.Build();
 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.MapOpenApi();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
