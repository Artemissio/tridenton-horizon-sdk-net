using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models.OutputChannels;

public sealed record WebhookSettings : IOutputChannelSettingsMarker
{
    [Required(ErrorMessage = "HTTP method is required")]
    public required WebhookHttpMethod HttpMethod { get; init; }

    [Required(ErrorMessage = "HTTP URL is required")]
    public required string Url { get; init; }

    public WebhookSettings()
    {
        HttpMethod = WebhookHttpMethod.Get;
        Url = string.Empty;
    }
}

[JsonConverter(typeof(EnumerationJsonConverter<WebhookHttpMethod>))]
public sealed class WebhookHttpMethod : Enumeration
{
    private WebhookHttpMethod(string value) : base(value) { }

    public static readonly WebhookHttpMethod Get = new("GET");
    public static readonly WebhookHttpMethod Post = new("POST");
    public static readonly WebhookHttpMethod Put = new("PUT");
    public static readonly WebhookHttpMethod Patch = new("PATCH");
    public static readonly WebhookHttpMethod Delete = new("DELETE");
}

public sealed record WebhooksAuthorizationSettings
{
    
}