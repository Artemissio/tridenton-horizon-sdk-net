using Tridenton.Horizon.SDK.CDC.Models.DataConnectors;
using Tridenton.Horizon.SDK.CDC.Models.OutputChannels;

namespace Tridenton.Horizon.SDK.CDC.Models;

/// <summary>
/// 
/// </summary>
public sealed record CDCSettings
{
    /// <summary>
    /// 
    /// </summary>
    public ulong Limit { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required DataConnectorSettings DataConnectorSettings { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required OutputChannelSettings OutputChannelSettings { get; init; }

    /// <summary>
    /// 
    /// </summary>
    public required EventsFilteringSettings FilteringSettings { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public bool Limitless => Limit == 0;
}