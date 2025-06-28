using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<DataConnector>))]
public sealed class DataConnector : Enumeration
{
    private DataConnector(string value) : base(value) { }
    
    public static readonly DataConnector None = new(string.Empty);
    public static readonly DataConnector PostgreSQL = new("PostgreSQL");
}