using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tridenton.Horizon.SDK.CDC.Utilities;

namespace Tridenton.Horizon.SDK.CDC.Models.DataConnectors;

/// <summary>
/// Marker interface for data connector settings
/// </summary>
public interface IDataConnectorSettingsMarker {}

/// <summary>
/// 
/// </summary>
[JsonConverter(typeof(DataConnectorSettingsJsonConverter))]
public sealed record DataConnectorSettings
{
    /// <summary>
    /// 
    /// </summary>
    [Required(ErrorMessage = "Connector is required")]
    public required DataConnector Connector { get; init; }

    /// <summary>
    /// 
    /// </summary>
    [Required(ErrorMessage = "Settings is required")]
    public required IDataConnectorSettingsMarker Settings { get; init; }
}