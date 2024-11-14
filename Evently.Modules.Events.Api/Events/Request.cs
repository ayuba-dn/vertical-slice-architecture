namespace Evently.Modules.Events.Api.Events;

public sealed class Request
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartsAtUtc { get; set; }
    public DateTime EndsAtUtc { get; set; }
    public string Location { get; set; }

}
