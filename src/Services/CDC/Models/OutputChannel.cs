using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<DataConnector>))]
public sealed class OutputChannel : Enumeration
{
    private OutputChannel(int index, string value) : base(index, value) { }
    
    public static readonly OutputChannel None = new(0, string.Empty);
    public static readonly OutputChannel Webhooks = new(1, "Webhooks");
    public static readonly OutputChannel RabbitMq = new(2, "RabbitMq");
}