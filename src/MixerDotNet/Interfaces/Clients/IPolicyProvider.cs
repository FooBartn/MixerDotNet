using Polly;
using System.Net.Http;

namespace MixerDotNet.Interfaces.Clients
{
    public interface IPolicyProvider
    {
        IAsyncPolicy<HttpResponseMessage> RetryAfterPolicy { get; }
    }
}
