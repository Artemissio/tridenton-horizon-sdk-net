using System.ComponentModel.DataAnnotations;
using Tridenton.Core.Utilities;

namespace Tridenton.Horizon.SDK.CDC.Models;

public sealed record EventsFilteringSettings
{
    [Required(ErrorMessage = "Pairs are required.")]
    public required FilteringPair[] Pairs { get; init; }
    
    public EventsFilteringSettings()
    {
        Pairs =
        [
            FilteringPair.All,
        ];
    }
}

public sealed record FilteringPair
{
    /// <summary>
    /// 
    /// </summary>
    public required string Collection { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required EventType[] EventTypes { get; init; }

    public static readonly FilteringPair All = new()
    {
        Collection = Constants.Wildcard,
        EventTypes = [],
    };
}