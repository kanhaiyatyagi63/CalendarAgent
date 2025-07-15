// -------------------------------------------------------------------
// <copyright file="Program.cs" company="Kanhaya Tyagi">
// ©kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

using CalendarAgent.Planner.Service;
using CalendarAgent.Planner.Tools;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConsole(consoleLogOptions =>
{
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services.AddScoped<IPlannerService, PlannerService>();
builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithTools<GoogleCalendarTool>();

var app = builder.Build();
Console.WriteLine("🚀 MCP Google Calendar Agent running...");
await app.RunAsync();
