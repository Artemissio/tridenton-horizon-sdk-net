namespace Tridenton.Horizon.SDK.CDC.Models;

public struct DataChangeEventTimestamps
{
    /// <summary>
    /// Timestamp in UTC format when the event initially happened in the data source
    /// </summary>
    public DateTime EventUtc { get; set; }
    
    /// <summary>
    /// Timestamp in UTC format when the event was read and handled by CDC
    /// </summary>
    public DateTime HandleUtc { get; set; }
    
    /// <summary>
    /// Timestamp in UTC format when the event was emitted by EventLink to the output channel
    /// </summary>
    public DateTime EmissionUtc { get; set; }
}