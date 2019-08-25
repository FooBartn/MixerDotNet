using MixerDotNet.Enums;
using Newtonsoft.Json;

namespace MixerDotNet.Models.Channels
{
    public class ViewerMetricAnalytic : ChannelAnalytic
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("browser")]
        public ViewerBrowser? Browser { get; set; }

        [JsonProperty("platform")]
        public ViewerPlatform? Platform { get; set; }
    }
}
