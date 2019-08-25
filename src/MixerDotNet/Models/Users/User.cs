using MixerDotNet.Extensions;
using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Interfaces.General;
using MixerDotNet.Interfaces.Users;
using MixerDotNet.Models.Base;
using MixerDotNet.Models.Channels;
using MixerDotNet.Models.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MixerDotNet.Models.Users
{
    public class User : IUser
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("level")]
        public uint Level { get; set; }

        [JsonProperty("social")]
        [JsonConverter(typeof(ConcreteConverter<SocialInfo>))]
        public ISocialInfo Social { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("experience")]
        public uint Experience { get; set; }

        [JsonProperty("sparks")]
        public uint Sparks { get; set; }

        [JsonProperty("avatarUrl")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("primaryTeam")]
        public uint? PrimaryTeam { get; set; }

        [JsonProperty("channel")]
        [JsonConverter(typeof(ConcreteConverter<Channel>))]
        public IChannel Channel { get; set; }

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
