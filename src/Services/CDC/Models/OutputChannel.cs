using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<DataConnector>))]
public sealed class OutputChannel : Enumeration
{
    private OutputChannel(string value) : base(value) { }
    
    public static readonly OutputChannel None = new(string.Empty);
    public static readonly OutputChannel Webhooks = new("Webhooks");
    public static readonly OutputChannel RabbitMq = new("RabbitMq");
}