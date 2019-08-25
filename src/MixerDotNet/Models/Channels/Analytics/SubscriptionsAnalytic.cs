using Newtonsoft.Json;

namespace MixerDotNet.Models.Channels.Analytics
{
    public class SubscriptionsAnalytic : ChannelAnalytic
    {
        [JsonProperty(PropertyName = "total")]
        public uint Total { get; set; }

        [JsonProperty(PropertyName = "delta")]
        public int Delta { get; set; }

        [JsonProperty(PropertyName = "user")]
        public uint? UserId { get; set; }
    }
}
