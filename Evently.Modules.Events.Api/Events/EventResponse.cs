namespace Evently.Modules.Events.Api.Events;

public sealed record EventResponse(
    Guid Id,
    string Title,
    string Description,
    DateTime StartsAtUtc,
    DateTime EndsAtUtc,
    string Location,
    EventStatus Status);
