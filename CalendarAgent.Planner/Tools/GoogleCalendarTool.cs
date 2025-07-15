// -------------------------------------------------------------------
// <copyright file="GoogleCalendarTool.cs" company="Kanhaya Tyagi">
// ©kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

using System.ComponentModel;
using System.Text.Json;

using ModelContextProtocol.Server;

namespace CalendarAgent.Planner.Tools;

/// <summary>
/// Provides Google Calendar related tools for scheduling meetings via the planner service.
/// </summary>
[McpServerToolType]
public class GoogleCalendarTool(IPlannerService plannerService)
{
    private readonly IPlannerService _plannerService = plannerService;

    /// <summary>
    /// Schedules a meeting using the planner service.
    /// </summary>
    /// <param name="meeting">The input model containing meeting details.</param>
    /// <returns>
    /// A JSON string representing the output model with meeting links.
    /// </returns>
    [McpServerTool(
        Name = "ScheduleMeeting",
        Title = "Schedules a meeting",
        ReadOnly = true,
        UseStructuredContent = true)]
    [Description("Schedule a meeting")]
    public async Task<string> ScheduleMeetingAsync(ScheduleMeetingInputModel meeting)
    {
        var response = await this._plannerService.ScheduleMeetingAsync(meeting).ConfigureAwait(false);

        return JsonSerializer.Serialize(response, CalendarAgentContext.Default.ScheduleMeetintOutputModel);
    }
}
