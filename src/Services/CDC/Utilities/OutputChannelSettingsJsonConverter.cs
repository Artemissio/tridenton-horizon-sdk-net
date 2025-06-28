using System.Text.Json;
using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Horizon.SDK.CDC.Models;
using Tridenton.Horizon.SDK.CDC.Models.OutputChannels;

namespace Tridenton.Horizon.SDK.CDC.Utilities;

internal sealed class OutputChannelSettingsJsonConverter : JsonConverter<OutputChannelSettings>
{
    public override OutputChannelSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        
        var root = document.RootElement;

        if (!root.TryGetProperty(nameof(OutputChannelSettings.Channel), out var channelProp))
        {
            throw new JsonException("Missing 'Channel' property.");
        }

        var channelName = channelProp.GetString();

        if (string.IsNullOrWhiteSpace(channelName))
        {
            throw new JsonException("Invalid or empty channel name.");
        }

        var channel = Enumeration.GetValue<OutputChannel>(channelName);

        if (channel is null)
        {
            throw new JsonException($"Unknown channel: {channelName}");
        }

        if (!root.TryGetProperty(nameof(OutputChannelSettings.Settings), out var settingsProp))
        {
            throw new JsonException("Missing 'Settings' property.");
        }

        var settingsJson = settingsProp.GetRawText();

        IOutputChannelSettingsMarker settings = channel switch
        {
            _ when channel == OutputChannel.Webhooks =>
                JsonSerializer.Deserialize<WebhookSettings>(settingsJson, options)
                ?? throw new JsonException("Failed to deserialize WebhookSettings"),

            _ => throw new NotSupportedException($"Connector '{channel}' is not supported.")
        };

        return new OutputChannelSettings
        {
            Channel = channel,
            Settings = settings
        };
    }

    public override void Write(Utf8JsonWriter writer, OutputChannelSettings value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        
        writer.WriteString(nameof(OutputChannelSettings.Channel), value.Channel);

        writer.WritePropertyName(nameof(OutputChannelSettings.Settings));
        JsonSerializer.Serialize(writer, value.Settings, value.Settings.GetType(), options);

        writer.WriteEndObject();
    }
}