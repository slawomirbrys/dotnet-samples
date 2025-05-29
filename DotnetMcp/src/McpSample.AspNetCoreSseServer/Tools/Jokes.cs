﻿using ModelContextProtocol.Server;
using System.ComponentModel;

namespace McpSample.AspNetCoreSseServer;

[McpServerToolType]
public class Jokes
{
    [McpServerTool, Description("Returns a joke about a specific topic")]
    public string GetJoke(string topic)
    {
        Console.WriteLine("==========================");
        Console.WriteLine($"Function get joke with topic: {topic}");
        var message = $"I don't do jokes about {topic}.";
        Console.WriteLine("Function report: " + message);
        Console.WriteLine($"Function End get joke with topic: {topic}");
        Console.WriteLine("==========================");
        return message;
    }
}
