using MixerDotNet.Models.Base;
using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models.Users
{
    public class User : TimeStamped
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("level")]
        public ulong Level { get; set; }

        [JsonProperty("social")]
        public SocialInfo Social { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("experience")]
        public ulong Experience { get; set; }

        [JsonProperty("sparks")]
        public ulong Sparks { get; set; }

        [JsonProperty("avatarUrl")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("primaryTeam")]
        public uint? PrimaryTeam { get; set; }
    }
}
