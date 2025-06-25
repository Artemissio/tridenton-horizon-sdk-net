using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<OutputChannelStatus>))]
public sealed class OutputChannelStatus : Enumeration
{
    private OutputChannelStatus(int index, string value) : base(index, value) { }
    
    public static readonly OutputChannelStatus NotStarted = new(0, "Not Started");
    public static readonly OutputChannelStatus Starting = new(1, "Starting");
    public static readonly OutputChannelStatus FailedToStart = new(2, "Failed to Start");
    public static readonly OutputChannelStatus Started = new(3, "Started");
    public static readonly OutputChannelStatus LimitExceeded = new(4, "Limit Exceeded");
    public static readonly OutputChannelStatus Pausing = new(5, "Pausing");
    public static readonly OutputChannelStatus Paused = new(6, "Paused");
    public static readonly OutputChannelStatus Stopping = new(7, "Stopping");
    public static readonly OutputChannelStatus Stopped = new(8, "Stopped");
}