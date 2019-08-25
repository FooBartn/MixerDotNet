using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Models;
using MixerDotNet.Models.Base;
using MixerDotNet.Models.Channels;
using MixerDotNet.Models.Users;
using System;
using System.Collections.Generic;

namespace MixerDotNet.UnitTests
{
    public static class StaticResources
    {
        public static IViewerAnalytic ViewerAnalytic = new ViewerAnalytic
        {
            Anon = 4,
            Time = new DateTimeOffset(2018, 11, 04, 03, 56, 00, TimeSpan.Zero),
            Authed = 2,
            Channel = 2802009
        };

        public static IViewerMetricAnalytic ViewerMetric = new ViewerMetricAnalytic
        {
            Browser = "Edge",
            Channel = 2802009,
            Country = "FR",
            Platform = "Xbox",
            Time = new DateTimeOffset(2018, 11, 04, 16, 27, 35, 000, TimeSpan.Zero)
        };

        public static Channel Channel1 = new Channel
        {
            Featured = false,
            Id = 35609,
            UserId = 45419,
            Token = "C420",
            Online = true,
            FeatureLevel = 0,
            Partnered = false,
            Suspended = false,
            Name = "Playing MC",
            ViewersTotal = 0,
            ViewersCurrent = 0,
            NumFollowers = 0,
            Description = "<p>No microphone. Just playing MC. If that sounds boring to you, there are plenty of other streamers out there.</p>\n",
            Audience = Enums.AudienceRating.Family,
            TypeId = 127929,
            Interactive = false,
            Ftl = 35609,
            HasVod = false,
            LanguageId = Enums.ChannelLanguage.English,
            HasTranscodes = false,
            VodsEnabled = true,
            TimeStamps = new TimeStamps
            {
                CreatedAt = new DateTimeOffset(2015, 10, 21, 22, 33, 02, 000, TimeSpan.Zero),
                UpdatedAt = new DateTimeOffset(2019, 08, 16, 19, 52, 44, 000, TimeSpan.Zero)
            },
            User = new User
            {
                Level = 1,
                Id = 45419,
                Username = "C420",
                Verified = true,
                Experience = 0,
                Sparks = 0,
                Bio = "CCCC20",
                TimeStamps = new TimeStamps
                {
                    CreatedAt = new DateTimeOffset(2015, 10, 21, 22, 33, 01, 000, TimeSpan.Zero),
                    UpdatedAt = new DateTimeOffset(2019, 08, 16, 19, 48, 49, 000, TimeSpan.Zero)
                },
                Social = new SocialInfo
                {
                    Verified = new string[] { }
                },
            },
            GameType = new GameType
            {
                Id = 127929,
                Name = "Minecraft",
                Parent = "Games",
                Description = "Explore infinite worlds and build everything from the simplest of homes to the grandest of castles. Play in creative mode with unlimited resources or mine deep into the world in survival mode, crafting weapons, and armor to fend off dangerous mobs. Create, explore, and survive alone or with friends on mobile devices, Nintendo Switch, Xbox One and Windows 10.\n\nLearn more about Minecraft at https://minecraft.net/en-us/what-is-minecraft/.\n\nMinecraft: Bedrock Edition (\"Better Together Update\") is not available on Xbox 360, PlayStation 3, Wii U, New Nintendo 3DS, PlayStation Vita, MacOS, Linux, and PlayStation 4.",
                Source = "player:978",
                ViewersCurrent = 2670,
                CoverUrl = new Uri("https://gameart.mixer.com/art/127929/cover.jpg?locked"),
                BackgroundUrl = new Uri("https://uploads.mixer.com/cover/f5b59502e357b49dfc6e.jpg?rev=3"),
                Online = 1581,
                AvailableAt = new DateTimeOffset(2016, 06, 28, 04, 25, 45, 110, TimeSpan.Zero)
            }
        };

        public static Channel Channel2 = new Channel
        {
            Featured = true,
            Id = 35609,
            UserId = 45419,
            Token = "C420",
            Online = false,
            FeatureLevel = 1,
            Partnered = false,
            Suspended = false,
            Name = "Playing MC",
            ViewersTotal = 0,
            ViewersCurrent = 0,
            NumFollowers = 0,
            Description = "<p>No microphone. Just playing MC. If that sounds boring to you, there are plenty of other streamers out there.</p>\n",
            Audience = Enums.AudienceRating.Teen,
            TypeId = 127929,
            Interactive = false,
            Ftl = 35609,
            HasVod = false,
            LanguageId = Enums.ChannelLanguage.English,
            HasTranscodes = false,
            VodsEnabled = true,
            TimeStamps = new TimeStamps
            {
                CreatedAt = new DateTimeOffset(2015, 10, 21, 22, 33, 02, 000, TimeSpan.Zero),
                UpdatedAt = new DateTimeOffset(2019, 08, 16, 19, 52, 44, 000, TimeSpan.Zero)
            },
            Thumbnail = null,
            User = new User
            {
                Level = 1,
                Id = 45419,
                Username = "C420",
                Verified = true,
                Experience = 0,
                Sparks = 0,
                AvatarUrl = new Uri("https://uploads.mixer.com/avatar/zvv7avo7-3640317.jpg"),
                Bio = "CCCC20",
                TimeStamps = new TimeStamps
                {
                    CreatedAt = new DateTimeOffset(2015, 10, 21, 22, 33, 01, 000, TimeSpan.Zero),
                    UpdatedAt = new DateTimeOffset(2019, 08, 16, 19, 48, 49, 000, TimeSpan.Zero)
                },
                Social = new SocialInfo
                {
                    Verified = new string[] { }
                },
                Email = null
            },
            GameType = new GameType
            {
                Id = 127929,
                Name = "Minecraft",
                Parent = "Games",
                Description = "Explore infinite worlds and build everything from the simplest of homes to the grandest of castles. Play in creative mode with unlimited resources or mine deep into the world in survival mode, crafting weapons, and armor to fend off dangerous mobs. Create, explore, and survive alone or with friends on mobile devices, Nintendo Switch, Xbox One and Windows 10.\n\nLearn more about Minecraft at https://minecraft.net/en-us/what-is-minecraft/.\n\nMinecraft: Bedrock Edition (\"Better Together Update\") is not available on Xbox 360, PlayStation 3, Wii U, New Nintendo 3DS, PlayStation Vita, MacOS, Linux, and PlayStation 4.",
                Source = "player:978",
                ViewersCurrent = 2670,
                CoverUrl = new Uri("https://gameart.mixer.com/art/127929/cover.jpg?locked"),
                BackgroundUrl = new Uri("https://uploads.mixer.com/cover/f5b59502e357b49dfc6e.jpg?rev=3"),
                Online = 1581
            }
        };

        public static IExpandedChannel ExpandedChannel1 = new ExpandedChannel
        {
            Audience = Enums.AudienceRating.Adult,
            Badge = new Resource
            {
                Id = 3302316,
                Meta = new Dictionary<string, object>
                    {
                        { "size", new int[] { 16, 16 } }
                    },
                Relid = 248091,
                RemotePath = "badges/4kjs00s3-248091.png",
                Store = Enums.ResourceStore.S3,
                Type = "channel:badge",
                Url = new Uri("https://uploads.mixer.com/badges/4kjs00s3-248091.png"),
                TimeStamps = new TimeStamps
                {
                    CreatedAt = new DateTimeOffset(2018, 05, 04, 21, 02, 52, TimeSpan.Zero),
                    UpdatedAt = new DateTimeOffset(2018, 05, 04, 21, 02, 52, TimeSpan.Zero)
                }
            },
            BadgeId = 3302316,
            BannerUrl = new Uri("https://uploads.mixer.com/banner/6y6vd0dn-248091.jpg"),
            Description = "Test",
            Featured = false,
            FeatureLevel = 0,
            Ftl = 248091,
            GameType = new GameType
            {
                BackgroundUrl = new Uri("https://uploads.mixer.com/cover/2c7d22191fd44a80ed1b.jpg?rev=3"),
                CoverUrl = new Uri("https://gameart.mixer.com/art/543113/cover.jpg?locked"),
                Description = "Destiny 2 is an online first-person shooter developed by Bungie and published by Activision. One year after the events of Destiny: Rise of Iron, the Red Legion faction of the Cabal, a military-industrial empire of massive amphibians, have attacked The Last City with overwhelming forces, led by their commander, Ghaul. The Guardians have been stripped of their powers and forced to flee the Tower. The Guardians must acquire new powers to face Ghaul and the Red Legion, and venture to new worlds in the Destiny universe.",
                Id = 543113,
                Name = "Destiny 2",
                Online = 203,
                Parent = "Games",
                Source = "player:54684",
                ViewersCurrent = 620,
            },
            HasTranscodes = true,
            HasVod = false,
            Id = 248091,
            Interactive = true,
            InteractiveGameId = 224778,
            LanguageId = Enums.ChannelLanguage.English,
            Name = "Warlock Solstice Grind <> Bullets and Beer <>",
            NumFollowers = 14821,
            Online = false,
            Partnered = true,
            Preferences = new ChannelPreferences
            {
                ChannelBannedwords = new string[] { },
                ChannelCatbotLevel = 2,
                ChannelChatHostswitch = true,
                ChannelDirectPurchaseEnabled = true,
                ChannelDonationsEnabled = false,
                ChannelLinksAllowed = true,
                ChannelLinksClickable = true,
                ChannelNotifyDirectPurchase = true,
                ChannelNotifyDirectPurchaseMessage = "%USER% just bought %GAMETITLE%! Thanks for supporting %CHANNEL%! Have FUN!",
                ChannelNotifyDonate = false,
                ChannelNotifyDonatemessage = "",
                ChannelNotifyFollow = true,
                ChannelNotifyFollowmessage = "%USER% is now one of us!",
                ChannelNotifyHostedBy = "%USER% is sharing their community!",
                ChannelNotifyHosting = "We're now hosting %USER%!",
                ChannelNotifySubscribe = true,
                ChannelNotifySubscribemessage = "%USER% subscribed to the channel!",
                ChannelNotifySubscriptionGift = true,
                ChannelNotifySubscriptionGiftMessage = "%GIFTER% just gifted a subscription to %USER%!",
                ChannelOfflineAutoplayVod = true,
                ChannelPartnerSubmail = "Test",
                ChannelPlayerMuteOwn = true,
                ChannelSlowchat = 500,
                ChannelTweetBody = "I just went live on Mixer! %URL%",
                ChannelTweetEnabled = false,
                ChannelUsersLevelRestrict = 0,
                CostreamAllow = Enums.CoStreamPreference.All,
                HostingAllow = true,
                HostingAllowlive = false,
                HypezoneAllow = true,
                MixerFeaturedAllow = true,
                Sharetext = "I'm watching @Angry_Iceberg on @WatchMixer! Come join me here: %URL%"
            },
            Suspended = false,
            Thumbnail = new Resource
            {
                Id = 2588322,
                Meta = new Dictionary<string, object>
                    {
                        {"size", new int[] {405, 228} }
                    },
                Relid = 248091,
                RemotePath = "thumbnails/4mhk2p8b-248091.jpg",
                Store = Enums.ResourceStore.S3,
                Type = "channel:thumbnail",
                Url = new Uri("https://uploads.mixer.com/thumbnails/4mhk2p8b-248091.jpg"),
                TimeStamps = new TimeStamps
                {
                    CreatedAt = new DateTimeOffset(2018, 03, 21, 20, 55, 58, TimeSpan.Zero),
                    UpdatedAt = new DateTimeOffset(2018, 03, 21, 20, 55, 58, TimeSpan.Zero)
                }
            },
            ThumbnailId = 2588322,
            Token = "AngryIceberg",
            TranscodingProfileId = 1,
            TypeId = 543113,
            User = new User
            {
                AvatarUrl = new Uri("https://uploads.mixer.com/avatar/i7dhsoxw-353535.jpg"),
                Bio = "Welcome to the home of the Major Ragers. We are a group of friendly, positive, supportive and inclusive crazy people that want to get to know you. Don't be afraid to say hi and join in the fun. We're all friends here, and we hope you enjoy your stay.",
                Experience = 1708279,
                Id = 353535,
                Level = 118,
                Social = new SocialInfo
                {
                    Facebook = new Uri("https://www.facebook.com/theangryiceberg"),
                    Twitter = new Uri("https://twitter.com/angry_iceberg"),
                    Verified = new string[] { "twitter" },
                    Youtube = new Uri("https://www.youtube.com/user/angryicebergtv")
                },
                Sparks = 1391557,
                Username = "AngryIceberg",
                Verified = true,
                TimeStamps = new TimeStamps
                {
                    CreatedAt = new DateTimeOffset(2016, 09, 08, 20, 09, 45, TimeSpan.Zero),
                    UpdatedAt = new DateTimeOffset(2019, 08, 14, 07, 32, 39, 765, TimeSpan.Zero)
                }
            },
            UserId = 353535,
            ViewersCurrent = 0,
            ViewersTotal = 216251,
            VodsEnabled = true,
            TimeStamps = new TimeStamps
            {
                CreatedAt = new DateTimeOffset(2016, 09, 08, 13, 09, 45, TimeSpan.Zero),
                UpdatedAt = new DateTimeOffset(2019, 08, 17, 16, 02, 58, 547, TimeSpan.Zero)
            }
        };
    }
}
