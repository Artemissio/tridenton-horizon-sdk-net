using System.Text.Json.Serialization;

namespace Tridenton.Horizon.SDK.CDC.Models.DataConnectors;

public sealed record PostgreSQLSettings : RelationalDatabaseSettings
{
    [JsonConstructor]
    public PostgreSQLSettings() : base(5432)
    {
        Schema = "public";
    }
}