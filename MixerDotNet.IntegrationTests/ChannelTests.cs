using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MixerDotNet.Enums;
using MixerDotNet.Extensions;
using MixerDotNet.Interfaces.Api;
using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Interfaces.Users;
using MixerDotNet.Models.Channels;
using MixerDotNet.Models.Channels.Analytics;
using MixerDotNet.Models.Oauth;
using MixerDotNet.Models.Users;
using MixerDotNet.RestApi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace MixerDotNet.IntegrationTests
{
    public class ChannelTests
    {
        private readonly IMixerRestApi _mixerApi;

        public ChannelTests()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<Settings>()
                .Build();

            var services = new ServiceCollection();

            services.AddMixerDotNet();
            services.Configure<Settings>(ops => configuration.Bind(ops));
            var provider = services.BuildServiceProvider();

            _mixerApi = provider.GetRequiredService<IMixerRestApi>();
            var options = provider.GetRequiredService<IOptions<Settings>>();

            var credentials = new MixerCredentials(options.Value.ClientId, options.Value.RedirectUri);
            _mixerApi.Initialize(credentials, options.Value.TokenResult);
        }

        [Fact]
        public async Task ShouldReturn_ValidChannel()
        {
            var channelToken = "Pfeiffer";
            var channel = await _mixerApi.GetChannelAsync(channelToken);
            channel.Should().NotBeNull();
            channel.Should().BeOfType<ExpandedChannel>();
            channel.Should().BeAssignableTo<IExpandedChannel>();
            channel.Token.Should().Be(channelToken);
            channel.User.Username.Should().Be(channelToken);
            channel.HasPrivateDetails.Should().BeFalse();
        }

        [Fact]
        public async Task ShouldReturn_ValidPrivateChannel()
        {
            var channelToken = "DementedMistahJ";
            var channel = await _mixerApi.GetChannelDetailsAsync(channelToken);
            channel.Should().NotBeNull();
            channel.Should().BeOfType<ExpandedChannel>();
            channel.Should().BeAssignableTo<IExpandedChannel>();
            channel.Token.Should().Be(channelToken);
            channel.StreamKey.Should().NotBeNullOrEmpty();
            channel.User.Username.Should().Be(channelToken);
            channel.LanguageId.Should().Be(ChannelLanguage.English);
            channel.HasPrivateDetails.Should().BeTrue();
        }

        [Fact]
        public async Task ShouldUpdate_PrivateChannel()
        {
            var channelToken = "DementedMistahJ";
            var channel = await _mixerApi.GetChannelDetailsAsync(channelToken);
            channel.Name.Should().Be("Gamesees");
            channel.Name = "NoGamesees!";
            var updatedChannel = await channel.UpdateChannelAsync();
            updatedChannel.Name.Should().Be("NoGamesees!");
            updatedChannel.Name = "Gamesees";
            var backToOriginal = await updatedChannel.UpdateChannelAsync();
            backToOriginal.Name.Should().Be("Gamesees");
        }

        [Fact]
        public async Task ShouldReturn_ValidAchievements()
        {
            var achievements = await _mixerApi.GetAchievementsAsync();
            achievements.Should().NotBeNull();
            achievements.Should().BeOfType<ReadOnlyCollection<Achievement>>();
            achievements.Should().BeAssignableTo<IReadOnlyCollection<IAchievement>>();
            achievements.Count.Should().Be(11);
        }

        [Fact]
        public async Task ShouldReturn_ViewerAnalytics()
        {
            var analytics = await _mixerApi.GetViewerAnalyticsAsync("2802009", new DateTimeOffset(2016, 06, 28, 04, 25, 45, 110, TimeSpan.Zero));
            analytics.Should().NotBeNull();
            analytics.Should().BeOfType<ReadOnlyCollection<ViewerAnalytic>>();
            analytics.Should().BeAssignableTo<IReadOnlyCollection<IViewerAnalytic>>();
            analytics.Count.Should().BeGreaterThan(5);
        }

        [Fact]
        public async Task ShouldReturn_ViewerMetrics()
        {
            var metrics = await _mixerApi.GetViewerMetricsAsync("2802009", new DateTimeOffset(2016, 06, 28, 04, 25, 45, 110, TimeSpan.Zero));
            metrics.Should().NotBeNull();
            metrics.Should().BeOfType<ReadOnlyCollection<ViewerMetricAnalytic>>();
            metrics.Should().BeAssignableTo<IReadOnlyCollection<IViewerMetricAnalytic>>();
            metrics.Count.Should().BeGreaterThan(5);
        }
    }
}
