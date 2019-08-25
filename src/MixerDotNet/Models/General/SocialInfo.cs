using MixerDotNet.Interfaces.General;
using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models
{
    public class SocialInfo : ISocialInfo
    {
        [JsonProperty("twitter")]
        public Uri Twitter { get; set; }

        [JsonProperty("facebook")]
        public Uri Facebook { get; set; }

        [JsonProperty("youtube")]
        public Uri Youtube { get; set; }

        [JsonProperty("player")]
        public Uri Player { get; set; }

        [JsonProperty("discord")]
        public Uri Discord { get; set; }

        [JsonProperty("verified")]
        public string[] Verified { get; set; }
    }
}
