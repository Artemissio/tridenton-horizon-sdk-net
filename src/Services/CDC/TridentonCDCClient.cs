using Tridenton.Core;
using Tridenton.Horizon.SDK.CDC.Models;
using Tridenton.Horizon.SDK.Core;

namespace Tridenton.Horizon.SDK.CDC;

public sealed class TridentonCDCClient : TridentonHorizonServiceClient
{
    public TridentonCDCClient(TridentonCredentials credentials)
        : base(credentials)
    {
    }

    public TridentonCDCClient(TridentonCredentials credentials, ClientConfig config)
        : base(credentials, config)
    {
    }

    public async Task<GetStreamSnapshotResponse> GetStreamSnapshotAsync(GetStreamSnapshotRequest request)
    {
        // TODO
        
        await Task.CompletedTask;

        return new GetStreamSnapshotResponse();
    }
}