using MixerDotNet.Enums;
using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Interfaces.Users;
using MixerDotNet.Models.Oauth;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MixerDotNet.Interfaces.Api
{
    public interface IMixerRestApi
    {
        void Initialize(MixerCredentials credentials, TokenResult tokenResult = null);

        Task<IExpandedChannel> GetChannelAsync(string tokenOrId);

        Task<IExpandedChannel> GetChannelDetailsAsync(string tokenOrId);

        Task<IReadOnlyCollection<IAchievement>> GetAchievementsAsync();

        Task<string> GetAuthorizeUrlAsync(IEnumerable<OauthScope> scopes);

        Task ExchangeCodeForTokenAsync(string code);

        Task<IExpandedChannel> UpdateChannelAsync(IExpandedChannel expandedChannel);

        Task<IReadOnlyCollection<IViewerAnalytic>> GetViewerAnalyticsAsync(string channelId, DateTimeOffset from, DateTimeOffset? to = null);

        Task<IReadOnlyCollection<IViewerMetricAnalytic>> GetViewerMetricsAsync(string channelId, DateTimeOffset from, DateTimeOffset? to = null);
    }
}
