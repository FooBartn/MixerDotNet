using MixerDotNet.Interfaces.Api;
using MixerDotNet.Models.Oauth;
using System.Threading.Tasks;

namespace MixerDotNet.Interfaces.Clients
{
    public interface IMixerRestClient
    {
        IBaseHttpClient HttpClient { get; }

        void Initialize(IMixerRestApi api, MixerCredentials credentials, TokenResult tokenResult);

        Task<TEntity> GetAsync<TEntity>(string endpoint, int version = 1);

        Task<TEntity> PatchAsync<TEntity>(string endpoint, string json, int version = 1);
    }
}
