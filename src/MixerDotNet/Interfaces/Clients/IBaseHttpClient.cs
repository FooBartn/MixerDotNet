using MixerDotNet.Enums;
using MixerDotNet.Models.Oauth;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MixerDotNet.Interfaces.Clients
{
    public interface IBaseHttpClient
    {
        void Initialize(MixerCredentials credentials);

        void Initialize(MixerCredentials credentials, TokenResult tokenResult);

        Task<HttpResponseMessage> GetHttpResponse<TEntity>(HttpMethod method, string endpoint,
            string json = null, int version = 1);

        Task<string> GetAuthorizeUrlAsync(IEnumerable<OauthScope> scopes);

        Task ExchangeCodeForToken(string code);
    }
}
