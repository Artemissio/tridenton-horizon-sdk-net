using System.Text.Json;
using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Horizon.SDK.CDC.Models;
using Tridenton.Horizon.SDK.CDC.Models.DataConnectors;

namespace Tridenton.Horizon.SDK.CDC.Utilities;

internal sealed class DataConnectorSettingsJsonConverter : JsonConverter<DataConnectorSettings>
{
    public override DataConnectorSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        
        var root = document.RootElement;

        if (!root.TryGetProperty(nameof(DataConnectorSettings.Connector), out var connectorProp))
        {
            throw new JsonException("Missing 'Connector' property.");
        }

        var connectorName = connectorProp.GetString();

        if (string.IsNullOrWhiteSpace(connectorName))
        {
            throw new JsonException("Invalid or empty connector name.");
        }

        var connector = Enumeration.GetValue<DataConnector>(connectorName);

        if (connector is null)
        {
            throw new JsonException($"Unknown connector: {connectorName}");
        }

        if (!root.TryGetProperty(nameof(DataConnectorSettings.Settings), out var settingsProp))
        {
            throw new JsonException("Missing 'Settings' property.");
        }

        var settingsJson = settingsProp.GetRawText();

        IDataConnectorSettingsMarker settings = connector switch
        {
            _ when connector == DataConnector.PostgreSQL =>
                JsonSerializer.Deserialize<PostgreSQLSettings>(settingsJson, options)
                ?? throw new JsonException("Failed to deserialize PostgreSQLSettings"),

            _ => throw new NotSupportedException($"Connector '{connector}' is not supported.")
        };

        return new DataConnectorSettings
        {
            Connector = connector,
            Settings = settings
        };
    }

    public override void Write(Utf8JsonWriter writer, DataConnectorSettings value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        
        writer.WriteString(nameof(DataConnectorSettings.Connector), value.Connector);

        writer.WritePropertyName(nameof(DataConnectorSettings.Settings));
        JsonSerializer.Serialize(writer, value.Settings, value.Settings.GetType(), options);

        writer.WriteEndObject();
    }
}