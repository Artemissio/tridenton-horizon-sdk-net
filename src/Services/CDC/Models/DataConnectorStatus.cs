using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<DataConnectorStatus>))]
public sealed class DataConnectorStatus : Enumeration
{
    private DataConnectorStatus(string value) : base(value) { }
    
    public static readonly DataConnectorStatus NotStarted = new("Not Started");
    public static readonly DataConnectorStatus Starting = new("Starting");
    public static readonly DataConnectorStatus Started = new("Started");
    public static readonly DataConnectorStatus Pausing = new("Pausing");
    public static readonly DataConnectorStatus Paused = new("Paused");
    public static readonly DataConnectorStatus Stopping = new("Stopping");
    public static readonly DataConnectorStatus Stopped = new("Stopped");
    public static readonly DataConnectorStatus EmptyEventsStream = new("Empty Events Stream");
}