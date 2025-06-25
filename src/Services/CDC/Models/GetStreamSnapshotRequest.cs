namespace Tridenton.Horizon.SDK.CDC.Models;

public sealed record GetStreamSnapshotRequest
{
    
}

public sealed record GetStreamSnapshotResponse
{
    public StreamSnapshot Snapshot { get; init; }

    public GetStreamSnapshotResponse()
    {
        Snapshot = StreamSnapshot.Empty;
    }
}