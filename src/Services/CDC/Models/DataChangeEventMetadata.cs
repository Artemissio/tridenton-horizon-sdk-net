namespace Tridenton.Horizon.SDK.CDC.Models;

public sealed record DataChangeEventMetadata
{
    public EventId EventId { get; private set; }
    public EventType Type { get; init; }
    
    public DataChangeEventTimestamps Timestamps { get; init; }

    public DataChangeEventMetadata()
    {
        EventId = EventId.NewId();
        Type = EventType.None;
    }

    public static readonly DataChangeEventMetadata Empty = new()
    {
        EventId = EventId.Empty,
        Type = EventType.None,
    };
}