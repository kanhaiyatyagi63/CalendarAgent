// -------------------------------------------------------------------
// <copyright file="PlannerService.cs" company="Kanhaya Tyagi">
// ©kanhaiyatyagi63 All rights reserved.
// </copyright>
// -------------------------------------------------------------------

namespace CalendarAgent.Planner.Service;

/// <inheritdoc />
public sealed class PlannerService : IPlannerService
{
    /// <inheritdoc />
    public async Task<ScheduleMeetintOutputModel> ScheduleMeetingAsync(ScheduleMeetingInputModel input)
    {
        try
        {
            UserCredential credential;
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CalendarAgentTokenStore");
                string[] scopes = new[] { CalendarService.Scope.Calendar };
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));
            }

            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "MCP Calendar Agent",
            });

            var newEvent = new Event()
            {
                Summary = input.Title,
                Start = new EventDateTime
                {
                    DateTimeDateTimeOffset = DateTime.Parse(input.StartTime),
                    TimeZone = "Asia/Kolkata",
                },
                End = new EventDateTime
                {
                    DateTimeDateTimeOffset = DateTime.Parse(input.EndTime),
                    TimeZone = "Asia/Kolkata",
                },
                ConferenceData = new ConferenceData
                {
                    CreateRequest = new CreateConferenceRequest
                    {
                        RequestId = Guid.NewGuid().ToString(),
                        ConferenceSolutionKey = new ConferenceSolutionKey
                        {
                            Type = "hangoutsMeet",
                        },
                    },
                },
                Attendees = [.. input.Attendees.Select(email => new EventAttendee { Email = email })],
            };

            var request = service.Events.Insert(newEvent, "primary");
            request.ConferenceDataVersion = 1;
            var createdEvent = await request.ExecuteAsync();

            return new ScheduleMeetintOutputModel(createdEvent.HtmlLink, createdEvent.HangoutLink);
        }
        catch (Exception ex)
        {
            // Log the exception (logging mechanism not shown here)
            Console.WriteLine($"Error scheduling meeting: {ex.Message}");
            return new ScheduleMeetintOutputModel(null, null);
        }
    }
}
