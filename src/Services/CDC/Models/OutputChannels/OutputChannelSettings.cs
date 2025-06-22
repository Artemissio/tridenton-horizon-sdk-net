using System.ComponentModel.DataAnnotations;

namespace Tridenton.Horizon.SDK.CDC.Models.OutputChannels;

/// <summary>
/// Marker interface for output channel settings
/// </summary>
public interface IOutputChannelSettingsMarker {}

/// <summary>
/// 
/// </summary>
public sealed record OutputChannelSettings
{
    /// <summary>
    /// 
    /// </summary>
    [Required(ErrorMessage = "Channel is required")]
    public required OutputChannel Channel { get; init; }

    /// <summary>
    /// 
    /// </summary>
    [Required(ErrorMessage = "Settings is required")]
    public required IOutputChannelSettingsMarker Settings { get; init; }
}