// -------------------------------------------------------------------
// <copyright file="ScheduleMeetingInputModel.cs" company="Kanhaya Tyagi">
// ©kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

namespace CalendarAgent.Planner.Model;

/// <summary>
/// Represents the input model for scheduling a meeting, including title, start and end times, and attendees.
/// </summary>
public sealed class ScheduleMeetingInputModel
{
    /// <summary>
    /// Gets or sets the title of the meeting.
    /// </summary>
    public string Title { get; set; } = "Untitled Meeting";

    /// <summary>
    /// Gets or sets the start time of the meeting as a string.
    /// </summary>
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the end time of the meeting as a string.
    /// </summary>
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the list of attendees for the meeting.
    /// </summary>
    public List<string> Attendees { get; set; } = [];
}
