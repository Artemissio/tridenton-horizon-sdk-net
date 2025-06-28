using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<OutputChannelStatus>))]
public sealed class OutputChannelStatus : Enumeration
{
    private OutputChannelStatus(string value) : base(value) { }
    
    public static readonly OutputChannelStatus NotStarted = new("Not Started");
    public static readonly OutputChannelStatus Starting = new("Starting");
    public static readonly OutputChannelStatus FailedToStart = new("Failed to Start");
    public static readonly OutputChannelStatus Started = new("Started");
    public static readonly OutputChannelStatus LimitExceeded = new("Limit Exceeded");
    public static readonly OutputChannelStatus Pausing = new("Pausing");
    public static readonly OutputChannelStatus Paused = new("Paused");
    public static readonly OutputChannelStatus Stopping = new("Stopping");
    public static readonly OutputChannelStatus Stopped = new("Stopped");
}