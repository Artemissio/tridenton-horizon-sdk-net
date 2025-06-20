using Tridenton.Core;

namespace Tridenton.Horizon.SDK.Core;

public abstract class TridentonHorizonServiceClient : TridentonServiceClient
{
    protected TridentonHorizonServiceClient(TridentonCredentials credentials) : base(credentials)
    {
    }

    protected TridentonHorizonServiceClient(TridentonCredentials credentials, ClientConfig config) : base(credentials, config)
    {
    }
}