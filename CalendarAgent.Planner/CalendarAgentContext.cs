// -------------------------------------------------------------------
// <copyright file="CalendarAgentContext.cs" company="Kanhaya Tyagi">
// ©kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace CalendarAgent.Planner;

/// <summary>
/// Provides a source generation context for System.Text.Json serialization
/// of the <see cref="ScheduleMeetintOutputModel"/> type.
/// </summary>
[JsonSerializable(typeof(ScheduleMeetintOutputModel))]
internal sealed partial class CalendarAgentContext : JsonSerializerContext
{
}
