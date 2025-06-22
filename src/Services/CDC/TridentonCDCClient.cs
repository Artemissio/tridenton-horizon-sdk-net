using Tridenton.Core;
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
}