using Tridenton.Core;
using Tridenton.Horizon.SDK.Core;

namespace Tridenton.Horizon.SDK.EventLink;

public sealed class TridentonEventLinkClient : TridentonHorizonServiceClient
{
    public TridentonEventLinkClient(TridentonCredentials credentials)
        : base(credentials)
    {
    }

    public TridentonEventLinkClient(TridentonCredentials credentials, ClientConfig config)
        : base(credentials, config)
    {
    }
}