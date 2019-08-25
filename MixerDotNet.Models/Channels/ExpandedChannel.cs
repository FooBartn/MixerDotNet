using Newtonsoft.Json;

namespace MixerDotNet.Models.Channels
{
    public class ExpandedChannel : Channel
    {
        [JsonProperty("streamKey")]
        public string StreamKey { get; set; }

        [JsonProperty("numSubscribers")]
        public uint? NumSubscribers { get; set; }

        [JsonProperty("maxConcurrentSubscribers")]
        public uint? MaxConcurrentSubscribers { get; set; }

        [JsonProperty("totalUniqueSubscribers")]
        public uint? TotalUniqueSubscribers { get; set; }

        [JsonProperty("badge")]
        public Resource Badge { get; set; }

        [JsonProperty("cover")]
        public Resource Cover { get; set; }

        [JsonProperty("preferences")]
        public ChannelPreferences Preferences { get; set; }
    }
}
