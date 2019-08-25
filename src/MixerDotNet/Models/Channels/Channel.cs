using MixerDotNet.Enums;
using MixerDotNet.Extensions;
using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Interfaces.General;
using MixerDotNet.Interfaces.Users;
using MixerDotNet.Models.Base;
using MixerDotNet.Models.Converters;
using MixerDotNet.Models.Users;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MixerDotNet.Models.Channels
{
    /// <inheritdoc/>
    public class Channel : MixerApiIncluded, IChannel
    {
        /// <inheritdoc/>
        [JsonProperty("id")]
        public uint Id { get; set; }

        /// <inheritdoc/>
        [JsonProperty("userId")]
        public uint UserId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <inheritdoc/>
        [JsonProperty("online")]
        public bool Online { get; set; }

        /// <inheritdoc/>
        [JsonProperty("featured")]
        public bool Featured { get; set; }

        /// <inheritdoc/>
        [JsonProperty("featureLevel")]
        public uint FeatureLevel { get; set; }

        /// <inheritdoc/>
        [JsonProperty("partnered")]
        public bool Partnered { get; set; }

        /// <inheritdoc/>
        [JsonProperty("transcodingProfileId")]
        public uint? TranscodingProfileId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("suspended")]
        public bool Suspended { get; set; }

        /// <inheritdoc/>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        [JsonProperty("audience")]
        public AudienceRating Audience { get; set; }

        /// <inheritdoc/>
        [JsonProperty("viewersTotal")]
        public uint ViewersTotal { get; set; }

        /// <inheritdoc/>
        [JsonProperty("viewersCurrent")]
        public uint ViewersCurrent { get; set; }

        /// <inheritdoc/>
        [JsonProperty("numFollowers")]
        public uint NumFollowers { get; set; }

        /// <inheritdoc/>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <inheritdoc/>
        [JsonProperty("typeId")]
        public uint? TypeId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("interactive")]
        public bool Interactive { get; set; }

        /// <inheritdoc/>
        [JsonProperty("interactiveGameId")]
        public uint? InteractiveGameId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("ftl")]
        public uint Ftl { get; set; }

        /// <inheritdoc/>
        [JsonProperty("hasVod")]
        public bool HasVod { get; set; }

        /// <inheritdoc/>
        [JsonProperty("languageId")]
        public ChannelLanguage? LanguageId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("coverId")]
        public uint? CoverId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("thumbnailId")]
        public uint? ThumbnailId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("badgeId")]
        public uint? BadgeId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("bannerUrl")]
        public Uri BannerUrl { get; set; }

        /// <inheritdoc/>
        [JsonProperty("hosteeId")]
        public uint? HosteeId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("hasTranscodes")]
        public bool HasTranscodes { get; set; }

        /// <inheritdoc/>
        [JsonProperty("vodsEnabled")]
        public bool VodsEnabled { get; set; }

        /// <inheritdoc/>
        [JsonProperty("costreamId")]
        public Guid? CostreamId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("thumbnail")]
        [JsonConverter(typeof(ConcreteConverter<Resource>))]
        public IResource Thumbnail { get; set; }

        /// <inheritdoc/>
        [JsonProperty("user")]
        [JsonConverter(typeof(ConcreteConverter<User>))]
        public IUser User { get; set; }

        /// <inheritdoc/>
        [JsonProperty("type")]
        [JsonConverter(typeof(ConcreteConverter<GameType>))]
        public IGameType GameType { get; set; }

        [JsonIgnore]
        public TimeStamps TimeStamps { get; set; }

        // **
        // JSON Custom Deserialization
        // **

        [JsonExtensionData]
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable 649 // Field 'field' is never assigned to, and will always have its default value 'value'
        private IDictionary<string, JToken> _additionalData;
#pragma warning restore 649
#pragma warning restore IDE0044 // Add readonly modifier

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context) => TimeStamps = _additionalData.GetTimeStamps();
    }
}
