using MixerDotNet.Clients;
using MixerDotNet.Extensions;
using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Models.Channels;
using MixerDotNet.Models.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MixerDotNet.MixerDotNetConstants;

namespace MixerDotNet.RestApi
{
    public partial class MixerRestApi
    {
        public async Task<IExpandedChannel> GetChannelAsync(string tokenOrId)
            => await RestClient.GetAsync<ExpandedChannel>($"{Channels}/{tokenOrId}");

        public async Task<IExpandedChannel> GetChannelDetailsAsync(string tokenOrId)
            => await RestClient.GetAsync<ExpandedChannel>($"{Channels}/{tokenOrId}/details");

        public async Task<IReadOnlyCollection<IViewerAnalytic>> GetViewerAnalyticsAsync(string channelId, DateTimeOffset from, DateTimeOffset? to = null)
        {
            var query = GetAnalyticDateRange(from, to);
            var path = await BaseHttpClient.GetPathWithQueryAsync($"channels/{channelId}/analytics/tsdb/viewers", query);

            return await RestClient.GetAsync<IReadOnlyCollection<ViewerAnalytic>>(path);
        }

        public async Task<IReadOnlyCollection<IViewerMetricAnalytic>> GetViewerMetricsAsync(string channelId, DateTimeOffset from, DateTimeOffset? to = null)
        {
            var query = GetAnalyticDateRange(from, to);
            var path = await BaseHttpClient.GetPathWithQueryAsync($"channels/{channelId}/analytics/tsdb/viewersMetrics", query);
            return await RestClient.GetAsync<IReadOnlyCollection<ViewerMetricAnalytic>>(path);
        }

        public async Task<IExpandedChannel> UpdateChannelAsync(IExpandedChannel expandedChannel)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new ChannelUpdateConverter());
            var json = JsonConvert.SerializeObject(expandedChannel, settings);

            return await RestClient.PatchAsync<ExpandedChannel>($"{Channels}/{expandedChannel.Id}", json);
        }

        public List<KeyValuePair<string, string>> GetAnalyticDateRange(DateTimeOffset from, DateTimeOffset? to)
        {
            var query = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>(nameof(from), from.ToFormattedUtcString())
            };

            if (to is DateTimeOffset dateTimeOffset)
                query.Add(new KeyValuePair<string, string>(nameof(to), dateTimeOffset.ToFormattedUtcString()));

            return query;
        }
    }
}
