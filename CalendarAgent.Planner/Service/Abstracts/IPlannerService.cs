// -------------------------------------------------------------------
// <copyright file="IPlannerService.cs" company="Kanhaya Tyagi">
// ©kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

namespace CalendarAgent.Planner.Service.Abstracts;

/// <summary>
/// Provides methods for scheduling meetings in the planner service.
/// </summary>
public interface IPlannerService
{
    /// <summary>
    /// Schedules a meeting based on the provided input model.
    /// </summary>
    /// <param name="input">The input model containing meeting details.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the output model with meeting links.
    /// </returns>
    Task<ScheduleMeetintOutputModel> ScheduleMeetingAsync(ScheduleMeetingInputModel input);
}
