using System.ComponentModel;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Brys.DotNet.ConsoleByCopilot;

internal sealed class WeatherCommand : AsyncCommand<WeatherCommand.Settings>
{
    public sealed class Settings : CommandSettings
    {
        [CommandArgument(0, "<city>")]
        [Description("The name of the city to get the weather for.")]
        public string City { get; init; } = string.Empty;
    }

    public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        using var http = new HttpClient();
        http.DefaultRequestHeaders.UserAgent.ParseAdd("curl/7.0");

        var url = $"https://wttr.in/{Uri.EscapeDataString(settings.City)}?format=4";

        string result;
        try
        {
            result = await http.GetStringAsync(url);
        }
        catch (HttpRequestException ex)
        {
            AnsiConsole.MarkupLine($"[red]Error fetching weather:[/] {ex.Message}");
            return 1;
        }

        AnsiConsole.MarkupLine($"[bold yellow]Weather for {settings.City}:[/]");
        AnsiConsole.WriteLine(result.Trim());
        return 0;
    }
}
