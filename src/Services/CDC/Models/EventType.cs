using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<EventType>))]
public sealed class EventType : Enumeration
{
    private EventType(string value) : base(value) { }

    public static readonly EventType None = new(string.Empty);
    public static readonly EventType All = new(Constants.Wildcard);
    public static readonly EventType Create = new("Create");
    public static readonly EventType Update = new("Update");
    public static readonly EventType Delete = new("Delete");
}