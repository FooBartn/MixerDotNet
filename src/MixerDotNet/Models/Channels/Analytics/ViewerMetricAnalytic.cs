using MixerDotNet.Interfaces.Channels;
using Newtonsoft.Json;

namespace MixerDotNet.Models.Channels.Analytics
{
    public class ViewerMetricAnalytic : ChannelAnalytic, IViewerMetricAnalytic
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }
    }
}
