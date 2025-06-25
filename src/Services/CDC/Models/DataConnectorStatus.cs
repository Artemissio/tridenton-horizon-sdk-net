using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<DataConnectorStatus>))]
public sealed class DataConnectorStatus : Enumeration
{
    private DataConnectorStatus(int index, string value) : base(index, value) { }
    
    public static readonly DataConnectorStatus NotStarted = new(0, "Not Started");
    public static readonly DataConnectorStatus Starting = new(1, "Starting");
    public static readonly DataConnectorStatus Started = new(2, "Started");
    public static readonly DataConnectorStatus Pausing = new(3, "Pausing");
    public static readonly DataConnectorStatus Paused = new(4, "Paused");
    public static readonly DataConnectorStatus Stopping = new(5, "Stopping");
    public static readonly DataConnectorStatus Stopped = new(6, "Stopped");
    public static readonly DataConnectorStatus EmptyEventsStream = new(7, "Empty Events Stream");
}