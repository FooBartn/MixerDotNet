using Newtonsoft.Json;

namespace MixerDotNet.Models.Channels
{
    public class StreamSessionsAnalytic
    {
        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("duration")]
        public ulong? Duration { get; set; }

        [JsonProperty("type")]
        public ulong? Type { get; set; }

        [JsonProperty("partnered")]
        public bool Partnered { get; set; }
    }
}
