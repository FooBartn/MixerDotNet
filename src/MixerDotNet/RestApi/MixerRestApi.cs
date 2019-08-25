using MixerDotNet.Enums;
using MixerDotNet.Interfaces.Api;
using MixerDotNet.Interfaces.Clients;
using MixerDotNet.Interfaces.Users;
using MixerDotNet.Models.Oauth;
using MixerDotNet.Models.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MixerDotNet.RestApi
{
    public partial class MixerRestApi : IMixerRestApi
    {
        public IMixerRestClient RestClient { get; private set; }

        public MixerRestApi(IMixerRestClient teamsClient)
        {
            RestClient = teamsClient ?? throw new ArgumentNullException(nameof(teamsClient));
        }

        public void Initialize(MixerCredentials credentials, TokenResult tokenResult = null) 
            => RestClient.Initialize(this, credentials, tokenResult);

        public async Task<IReadOnlyCollection<IAchievement>> GetAchievementsAsync()
            => await RestClient.GetAsync<IReadOnlyCollection<Achievement>>("achievements");

        public async Task<string> GetAuthorizeUrlAsync(IEnumerable<OauthScope> scopes)
            => await RestClient.HttpClient.GetAuthorizeUrlAsync(scopes);

        public async Task ExchangeCodeForTokenAsync(string code)
            => await RestClient.HttpClient.ExchangeCodeForToken(code);
    }
}
