using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<StreamStatus>))]
public sealed class StreamStatus : Enumeration
{
    private StreamStatus(string value) : base(value) { }

    public static readonly StreamStatus Empty = new("Empty");
    public static readonly StreamStatus Ok = new("OK");
    public static readonly StreamStatus Full = new("Full");
}