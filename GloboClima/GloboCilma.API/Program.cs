using GloboCilma.API.Config;
using GloboCilma.API.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add OpenWeatherMap API key
var openWeatherConfig = builder.Configuration.GetSection("OpenWeather");
builder.Services.Configure<OpenWeather>(openWeatherConfig);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { 
        Title = "GloboClima.ProductAPI", 
        Version = "v1",
        Contact = new OpenApiContact 
        {
            Name = "Joao Pedro Sarno Carvalho",
            Email = "jpsarno@gmail.com",
            Url = new Uri("https://github.com/jpsarno/teste-tecnico-fullstack")
        }
    });

    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});
builder.Services.AddHttpClient();
builder.Services.AddScoped<IOpenWeatherService, OpenWeatherService>();
builder.Services.AddScoped<IRestCountriesService, RestCountriesService>();

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
