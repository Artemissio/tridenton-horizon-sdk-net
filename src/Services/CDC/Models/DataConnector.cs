using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models;

[JsonConverter(typeof(EnumerationJsonConverter<DataConnector>))]
public sealed class DataConnector : Enumeration
{
    private DataConnector(int index, string value) : base(index, value) { }
    
    public static readonly DataConnector None = new(0, string.Empty);
    public static readonly DataConnector PostgreSQL = new(1, "PostgreSQL");
}