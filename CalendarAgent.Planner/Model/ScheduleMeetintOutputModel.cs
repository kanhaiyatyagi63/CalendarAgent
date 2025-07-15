// -------------------------------------------------------------------
// <copyright file="ScheduleMeetintOutputModel.cs" company="Kanhaya Tyagi">
// ©kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

namespace CalendarAgent.Planner.Model;

/// <summary>
/// Represents the output model for a scheduled meeting, containing links to the calendar event and the meeting.
/// </summary>
public sealed class ScheduleMeetintOutputModel(string? htmlLink, string? meetLink)
{
    /// <summary>
    /// Gets or sets the HTML link to the scheduled calendar event.
    /// </summary>
    public string? HtmlLink { get; set; } = htmlLink;

    /// <summary>
    /// Gets or sets the link to the online meeting (e.g., Google Meet).
    /// </summary>
    public string? MeetLink { get; set; } = meetLink;
}
