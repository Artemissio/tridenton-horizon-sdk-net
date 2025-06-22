using System.Text.Json;

namespace Tridenton.Horizon.SDK.CDC.Models;

public sealed record DataChangeEventPayload
{
    public JsonElement[] Records { get; init; }

    public DataChangeEventPayload()
    {
        Records = [];
    }
    
    public static readonly DataChangeEventPayload Empty = new();
}