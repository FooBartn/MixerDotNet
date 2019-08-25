using FluentAssertions;
using MixerDotNet.Models;
using MixerDotNet.Models.Base;
using MixerDotNet.Models.Channels;
using MixerDotNet.Models.Users;
using Newtonsoft.Json;
using System;
using Xunit;

namespace MixerDotNet.UnitTests
{
    public class UserJsonTests
    {
        [Fact]
        public void ShouldReturn_Valid_User_WithChannel()
        {
            var content = TestTools.GetJsonResource("UserWithChannel");
            var user = JsonConvert.DeserializeObject<User>(content);

            var expectedUser = new User
            {
                Level = 63,
                Social = new SocialInfo
                {
                    Twitter = new Uri("https://www.twitter.com/dementedmistahj"),
                    Verified = new string[] { },
                },
                Id = 3640317,
                Username = "DementedMistahJ",
                Verified = true,
                Experience = 14566,
                Sparks = 293754,
                TimeStamps = new TimeStamps
                {
                    CreatedAt = new DateTimeOffset(2017, 04, 04, 05, 49, 12, 000, TimeSpan.Zero),
                    UpdatedAt = new DateTimeOffset(2019, 05, 17, 12, 35, 43, 000, TimeSpan.Zero)
                },
                Bio = "Streaming home to a bearded Dad of 5 boys. I don't have mad skillz, but I do love to play and discuss video games. I also request puns and wordplay be used in excess. ",
                Channel = new Channel
                {
                    Audience = Enums.AudienceRating.Teen,
                    Description = "Test",
                    Featured = false,
                    Id = 2802009,
                    UserId = 3640317,
                    Token = "DementedMistahJ",
                    Online = false,
                    FeatureLevel = 0,
                    Partnered = false,
                    Suspended = false,
                    Name = "Morning Games",
                    ViewersTotal = 95,
                    ViewersCurrent = 0,
                    NumFollowers = 12,
                    TypeId = 566510,
                    Interactive = false,
                    Ftl = 2802009,
                    HasVod = false,
                    LanguageId = Enums.ChannelLanguage.English,
                    ThumbnailId = 9345239,
                    HasTranscodes = true,
                    VodsEnabled = true,
                    TimeStamps = new TimeStamps
                    {
                        CreatedAt = new DateTimeOffset(2017, 04, 04, 05, 49, 12, TimeSpan.Zero),
                        UpdatedAt = new DateTimeOffset(2019, 05, 02, 20, 40, 30, 000, TimeSpan.Zero)
                    }
                },
                AvatarUrl = new Uri("https://uploads.mixer.com/avatar/zvv7avo7-3640317.jpg"),

            };

            user.Should().BeEquivalentTo(expectedUser);
        }
    }
}