using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tridenton.Core;
using Tridenton.Core.Utilities.Converters;

namespace Tridenton.Horizon.SDK.CDC.Models.OutputChannels;

public sealed record WebhookSettings : IOutputChannelSettingsMarker
{
    [Required(ErrorMessage = "HTTP method is required")]
    public WebhookHttpMethod HttpMethod { get; init; }

    [Required(ErrorMessage = "HTTP URL is required")]
    public string Url { get; set; }

    public WebhookSettings()
    {
        HttpMethod = WebhookHttpMethod.Get;
        Url = string.Empty;
    }
}

[JsonConverter(typeof(EnumerationJsonConverter<WebhookHttpMethod>))]
public sealed class WebhookHttpMethod : Enumeration
{
    private WebhookHttpMethod(int index, string value) : base(index, value) { }

    public static readonly WebhookHttpMethod Get = new(1, "GET");
    public static readonly WebhookHttpMethod Post = new(2, "POST");
    public static readonly WebhookHttpMethod Put = new(3, "PUT");
    public static readonly WebhookHttpMethod Patch = new(4, "PATCH");
    public static readonly WebhookHttpMethod Delete = new(5, "DELETE");
}

public sealed record WebhooksAuthorizationSettings
{
    
}