using McpSample.AspNetCoreSseServer;
using ModelContextProtocol;

var builder = WebApplication.CreateBuilder(args);

// Add default services
builder.AddServiceDefaults();
builder.Services.AddProblemDetails();

// add MCP server
builder.Services
    .AddMcpServer()
    .WithTools<Jokes>()
    .WithTools<WeatherTool>()
    //.WithToolsFromAssembly();
    .WithHttpTransport();

var app = builder.Build();

// Initialize default endpoints
app.MapDefaultEndpoints();
app.UseHttpsRedirection();

// map endpoints
app.MapGet("/", () => $"Hello MCP Server! {DateTime.Now}");
app.MapMcp();

app.Run();
