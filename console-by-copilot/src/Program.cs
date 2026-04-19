using Brys.DotNet.ConsoleByCopilot;
using Spectre.Console.Cli;

var app = new CommandApp();
app.Configure(config =>
{
    config.AddCommand<WeatherCommand>("weather")
          .WithDescription("Get current weather for a city.")
          .WithExample("weather", "Rapperswil")
          .WithExample("weather", "London");
});

return await app.RunAsync(args);
