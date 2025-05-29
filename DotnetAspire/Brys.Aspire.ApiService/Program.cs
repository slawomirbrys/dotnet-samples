using Brys.Aspire.ApiService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();
builder.Services.AddLogging(config =>
{
    config.AddSimpleConsole(options =>
    {
        options.IncludeScopes = true;
        options.SingleLine = true;
        options.TimestampFormat = "[yyyy-MM-dd HH:mm:ss] ";
    });
});

// Own services
builder.Services.AddSingleton<WeatherService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();


app.MapGet("/weatherforecast", (WeatherService service) =>
{
    return service.GetWeatherForecast();
});

app.MapDefaultEndpoints();

app.Run();
