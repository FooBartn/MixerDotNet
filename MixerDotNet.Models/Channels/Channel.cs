using MixerDotNet.Enums;
using MixerDotNet.Models.Base;
using MixerDotNet.Models.Users;
using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models.Channels
{
    public class Channel : TimeStamped
    {
        /// <summary>
        /// The unique ID of the channel.
        /// </summary>
        [JsonProperty("id")]
        public uint Id { get; set; }

        /// <summary>
        /// The ID of the user owning the channel.
        /// </summary>
        [JsonProperty("userId")]
        public uint UserId { get; set; }

        /// <summary>
        /// The name and url of the channel.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Indicates if the channel is streaming.
        /// </summary>
        [JsonProperty("online")]
        public bool Online { get; set; }

        /// <summary>
        /// True if featureLevel is > 0.
        /// </summary>
        [JsonProperty("featured")]
        public bool Featured { get; set; }

        /// <summary>
        /// The featured level for this channel. Its value controls the position and order of channels in the featured carousel.
        /// </summary>
        [JsonProperty("featureLevel")]
        public uint FeatureLevel { get; set; }

        /// <summary>
        /// Indicates if the channel is partnered.
        /// </summary>
        [JsonProperty("partnered")]
        public bool Partnered { get; set; }

        /// <summary>
        /// The id of the transcoding profile.
        /// </summary>
        [JsonProperty("transcodingProfileId")]
        public uint? TranscodingProfileId { get; set; }

        /// <summary>
        /// Indicates if the channel is suspended.
        /// </summary>
        [JsonProperty("suspended")]
        public bool Suspended { get; set; }

        /// <summary>
        /// The title of the channel.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The target audience of the channel.
        /// </summary>
        [JsonProperty("audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// Amount of unique viewers that ever viewed this channel.
        /// </summary>
        [JsonProperty("viewersTotal")]
        public uint ViewersTotal { get; set; }

        /// <summary>
        /// Amount of current viewers.
        /// </summary>
        [JsonProperty("viewersCurrent")]
        public uint ViewersCurrent { get; set; }

        /// <summary>
        /// Amount of followers.
        /// </summary>
        [JsonProperty("numFollowers")]
        public uint NumFollowers { get; set; }

        /// <summary>
        /// The description of the channel, can contain HTML.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the game type.
        /// </summary>
        [JsonProperty("typeId")]
        public uint? TypeId { get; set; }

        /// <summary>
        /// Indicates if that channel is interactive.
        /// </summary>
        [JsonProperty("interactive")]
        public bool Interactive { get; set; }

        /// <summary>
        /// The ID of the interactive game used.
        /// </summary>
        [JsonProperty("interactiveGameId")]
        public uint? InteractiveGameId { get; set; }

        /// <summary>
        /// The ftl stream id.
        /// </summary>
        [JsonProperty("ftl")]
        public uint Ftl { get; set; }

        /// <summary>
        /// Indicates if the channel has vod saved.
        /// </summary>
        [JsonProperty("hasVod")]
        public bool HasVod { get; set; }

        /// <summary>
        /// ISO 639 language id.
        /// </summary>
        [JsonProperty("languageId")]
        public string LanguageId { get; set; }

        /// <summary>
        /// The ID of the cover resource.
        /// </summary>
        [JsonProperty("coverId")]
        public uint? CoverId { get; set; }

        /// <summary>
        /// The resource ID of the thumbnail.
        /// </summary>
        [JsonProperty("thumbnailId")]
        public uint? ThumbnailId { get; set; }

        /// <summary>
        /// The resource ID of the subscriber badge.
        /// </summary>
        [JsonProperty("badgeId")]
        public uint? BadgeId { get; set; }

        /// <summary>
        /// The URL of the the banner image.
        /// </summary>
        [JsonProperty("bannerUrl")]
        public Uri BannerUrl { get; set; }

        /// <summary>
        /// The ID of the hostee channel.
        /// </summary>
        [JsonProperty("hosteeId")]
        public uint? HosteeId { get; set; }

        /// <summary>
        /// Indicates if the channel has transcodes enabled.
        /// </summary>
        [JsonProperty("hasTranscodes")]
        public bool HasTranscodes { get; set; }

        /// <summary>
        /// Indicates if the channel has vod recording enabled.
        /// </summary>
        [JsonProperty("vodsEnabled")]
        public bool VodsEnabled { get; set; }

        /// <summary>
        /// The costream that the channel is in, if any.
        /// </summary>
        [JsonProperty("costreamId")]
        public Guid? CostreamId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("thumbnail")]
        public Resource Thumbnail { get; set; }

        /// <inheritdoc/>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <inheritdoc/>
        [JsonProperty("type")]
        public GameType GameType { get; set; }
    }
}
