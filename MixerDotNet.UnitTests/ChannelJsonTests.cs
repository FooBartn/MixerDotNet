using FluentAssertions;
using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Models.Channels;
using MixerDotNet.Models.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MixerDotNet.UnitTests
{
    public class ChannelJsonTests
    {
        [Fact]
        public void ShouldReturn_Valid_Channels()
        {
            var content = TestTools.GetJsonResource("Channels");
            var channels = JsonConvert.DeserializeObject<ReadOnlyCollection<Channel>>(content);

            channels.Count.Should().Be(2);
        }

        [Fact]
        public void ShouldSerialize_Subset_OfExpandedChannel()
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new ChannelUpdateConverter());
            var json = JsonConvert.SerializeObject(StaticResources.ExpandedChannel1, settings);
            json.Should().NotContain("streamKey");
            json.Should().NotContain("numSubscribers");
            json.Should().NotContain("description");
            json.Should().NotContain("numFollowers");
            json.Should().Contain("name");
            json.Should().Contain("languageId");
            json.Should().Contain("preferences");
        }

        [Fact]
        public async Task ShouldReturn_Valid_ExpandedChannel()
        {
            var content = TestTools.GetJsonResource("ExpandedChannel1");
            var api = TestTools.GetApi<IExpandedChannel>(HttpMethod.Get, "channels/MyChannelToken", content);
            var channel = await api.GetChannelAsync("MyChannelToken");

            channel.Should().BeEquivalentTo(StaticResources.ExpandedChannel1);
        }

        [Fact]
        public async Task ShouldReturn_Valid_ViewAnalytics()
        {
            var content = TestTools.GetJsonResource("ViewerAnalytics");
            var api = TestTools.GetApi<IReadOnlyCollection<IViewerAnalytic>>(HttpMethod.Get, "channels/2802009/analytics/tsdb/viewers?from=2016-06-28T04%3A25%3A45.110Z", content);
            var vAnalytics = await api.GetViewerAnalyticsAsync("2802009", new DateTimeOffset(2016, 06, 28, 04, 25, 45, 110, TimeSpan.Zero));

            vAnalytics.First().Should().BeEquivalentTo(StaticResources.ViewerAnalytic);
        }

        [Fact]
        public async Task ShouldReturn_Valid_ViewMetrics()
        {
            var content = TestTools.GetJsonResource("ViewerMetrics");
            var api = TestTools.GetApi<IReadOnlyCollection<IViewerMetricAnalytic>>(HttpMethod.Get, "channels/2802009/analytics/tsdb/viewersMetrics?from=2016-06-28T04%3A25%3A45.110Z", content);
            var vMetrics = await api.GetViewerMetricsAsync("2802009", new DateTimeOffset(2016, 06, 28, 04, 25, 45, 110, TimeSpan.Zero));

            vMetrics.First().Should().BeEquivalentTo(StaticResources.ViewerMetric);
        }
    }
}