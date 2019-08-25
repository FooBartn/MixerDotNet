using MixerDotNet.Enums;
using MixerDotNet.Interfaces.Channels;
using Newtonsoft.Json;

namespace MixerDotNet.Models.Channels
{
    /// <summary>
    /// Channel preferences are a list of options and attributes which control behaviour for the channel. 
    /// Please see each property for more details.
    /// </summary>
    public class ChannelPreferences : IChannelPreferences
    {
        /// <summary>
        /// Allows other streamers to join you in a costream.
        /// ** Note: Should be a boolean according to API. It is not.
        /// </summary>
        [JsonProperty("costream:allow")]
        public CoStreamPreference CostreamAllow { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("mixer:featured:allow")]
        public bool? MixerFeaturedAllow { get; set; }

        /// <summary>
        /// Indicates if the channel allows other channels to host it.
        /// </summary>
        [JsonProperty("hosting:allow")]
        public bool HostingAllow { get; set; }

        /// <summary>
        /// Indicates if the channel allows HypeZone to host it.
        /// </summary>
        [JsonProperty("hypezone:allow")]
        public bool HypezoneAllow { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("hosting:allowlive")]
        public bool? HostingAllowlive { get; set; }

        /// <summary>
        /// When a user visits the channel while the channel is offline, 
        /// the most recent VOD will be automatically played if this preference is enabled.
        /// </summary>
        [JsonProperty("channel:offline:autoplayVod")]
        public bool? ChannelOfflineAutoplayVod { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("channel:bannedwords")]
        public string[] ChannelBannedwords { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("channel:catbot:level")]
        public uint ChannelCatbotLevel { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("channel:directPurchase:enabled")]
        public bool ChannelDirectPurchaseEnabled { get; set; }

        /// <summary>
        /// The message to be sent when a user completes a direct purchase on the channel. 
        /// The template parameter %USER% will be replaced with the name of the user who completed direct purchase. 
        /// The template parameter %CHANNEL% will be replaced with the name of the channel. 
        /// The template parameter %GAMETITLE% will be replaced with the name of the game purchased.
        /// </summary>
        [JsonProperty("channel:notify:directPurchaseMessage")]
        public string ChannelNotifyDirectPurchaseMessage { get; set; }

        /// <summary>
        ///  Not documented on the API
        /// </summary>
        [JsonProperty("channel:notify:donatemessage")]
        public string ChannelNotifyDonatemessage { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("channel:donations:enabled")]
        public bool ChannelDonationsEnabled { get; set; }

        /// <summary>
        /// The message to be sent when a user follows the channel. 
        /// The template parameter "%USER%" will be replaced with the follower's name.
        /// </summary>
        [JsonProperty("channel:notify:followmessage")]
        public string ChannelNotifyFollowmessage { get; set; }

        /// <summary>
        /// The message to be sent when a user hosts the channel. 
        /// The template parameter "%USER%" will be replaced with the hoster's name.
        /// </summary>
        [JsonProperty("channel:notify:hostedBy")]
        public string ChannelNotifyHostedBy { get; set; }

        /// <summary>
        /// The message to be sent when the channel hosts another. 
        /// The template parameter "%USER%" will be replaced with the hostee's name.
        /// </summary>
        [JsonProperty("channel:notify:hosting")]
        public string ChannelNotifyHosting { get; set; }

        /// <summary>
        /// Specifies whether links are allowed in the chat.
        /// </summary>
        [JsonProperty("channel:links:allowed")]
        public bool? ChannelLinksAllowed { get; set; }

        /// <summary>
        /// Specifies whether links are clickable in the chat.
        /// </summary>
        [JsonProperty("channel:links:clickable")]
        public bool? ChannelLinksClickable { get; set; }

        /// <summary>
        /// Indicates whether to mute when the streamer opens his own stream.
        /// </summary>
        [JsonProperty("channel:player:muteOwn")]
        public bool? ChannelPlayerMuteOwn { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("channel:notify:directPurchase")]
        public bool ChannelNotifyDirectPurchase { get; set; }

        [JsonProperty("channel:notify:donate")]
        public bool ChannelNotifyDonate { get; set; }

        /// <summary>
        /// Indicates whether a notification should be shown upon follow.
        /// </summary>
        [JsonProperty("channel:notify:follow")]
        public bool? ChannelNotifyFollow { get; set; }

        /// <summary>
        /// Indicates whether a notification should be shown upon subscription.
        /// </summary>
        [JsonProperty("channel:notify:subscribe")]
        public bool? ChannelNotifySubscribe { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("channel:notify:subscriptionGift")]
        public bool ChannelNotifySubscriptionGift { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("channel:notify:subscriptionGiftMessage")]
        public string ChannelNotifySubscriptionGiftMessage { get; set; }

        /// <summary>
        /// The text used when sharing the stream. 
        /// The template parameter %URL% will be replaced with the channel's URL. 
        /// The template parameter %USER% will be replaced with the channel's name.
        /// </summary>
        [JsonProperty("sharetext")]
        public string Sharetext { get; set; }

        /// <summary>
        /// Interval required between each chat message.
        /// </summary>
        [JsonProperty("channel:slowchat")]
        public int? ChannelSlowchat { get; set; }

        /// <summary>
        /// The text to be added to the subscription email.
        /// </summary>
        [JsonProperty("channel:partner:submail")]
        public string ChannelPartnerSubmail { get; set; }

        /// <summary>
        /// The message to be sent when a user subscribes to the channel. 
        /// The template parameter %USER% will be replaced with the subscriber's name.
        /// </summary>
        [JsonProperty("channel:notify:subscribemessage")]
        public string ChannelNotifySubscribemessage { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("channel:chat:hostswitch")]
        public bool ChannelChatHostswitch { get; set; }

        /// <summary>
        /// Indicates whether the tweet button should be shown.
        /// </summary>
        [JsonProperty("channel:tweet:enabled")]
        public bool? ChannelTweetEnabled { get; set; }

        /// <summary>
        /// The message to be used when a user tweets about the channel. 
        /// The template parameter %URL% will be replaced with the share url.
        /// </summary>
        [JsonProperty("channel:tweet:body")]
        public string ChannelTweetBody { get; set; }

        /// <summary>
        /// Not documented on the API
        /// </summary>
        [JsonProperty("channel:users:levelRestrict")]
        public uint ChannelUsersLevelRestrict { get; set; }
    }
}
