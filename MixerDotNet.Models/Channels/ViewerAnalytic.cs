using Newtonsoft.Json;

namespace MixerDotNet.Models.Channels
{
    public class ViewerAnalytic : ChannelAnalytic
    {
        [JsonProperty("anon")]
        public ulong Anon { get; set; }

        [JsonProperty("authed")]
        public ulong Authed { get; set; }
    }
}
