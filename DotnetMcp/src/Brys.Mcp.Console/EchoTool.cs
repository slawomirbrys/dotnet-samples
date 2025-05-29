using System.ComponentModel;
using ModelContextProtocol.Server;

namespace Brys.Mcp.Console;

[McpServerToolType]
public static class EchoTool
{
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message)
    {
        return $"Hello from C#: {message}";
    } 
    
    [McpServerTool, Description("Echoes in reverse the message sent from the client.")]
    public static string EchoReversed(string message)
    {
        return message.Reverse().ToString() ?? string.Empty;
    }
}