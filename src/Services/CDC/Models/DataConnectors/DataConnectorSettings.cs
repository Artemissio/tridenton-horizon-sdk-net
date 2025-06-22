using System.ComponentModel.DataAnnotations;

namespace Tridenton.Horizon.SDK.CDC.Models.DataConnectors;

/// <summary>
/// Marker interface for data connector settings
/// </summary>
public interface IDataConnectorSettingsMarker {}

/// <summary>
/// 
/// </summary>
public sealed record DataConnectorSettings
{
    /// <summary>
    /// 
    /// </summary>
    [Required(ErrorMessage = "Channel is required")]
    public required DataConnector Connector { get; init; }

    /// <summary>
    /// 
    /// </summary>
    [Required(ErrorMessage = "Settings is required")]
    public required IDataConnectorSettingsMarker Settings { get; init; }
}