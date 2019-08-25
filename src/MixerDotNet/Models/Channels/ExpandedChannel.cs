using System.Runtime.Serialization;
using System.Threading.Tasks;
using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Interfaces.General;
using MixerDotNet.Models.Converters;
using MixerDotNet.Models.Users;
using Newtonsoft.Json;

namespace MixerDotNet.Models.Channels
{
    public class ExpandedChannel : Channel, IExpandedChannel
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
        [JsonConverter(typeof(ConcreteConverter<Resource>))]
        public IResource Badge { get; set; }

        [JsonProperty("cover")]
        [JsonConverter(typeof(ConcreteConverter<Resource>))]
        public IResource Cover { get; set; }

        [JsonProperty("preferences")]
        [JsonConverter(typeof(ConcreteConverter<ChannelPreferences>))]
        public IChannelPreferences Preferences { get; set; }

        [JsonIgnore]
        public bool HasPrivateDetails =>
            !string.IsNullOrEmpty(StreamKey)
            || NumSubscribers != null
            || MaxConcurrentSubscribers != null
            || TotalUniqueSubscribers != null;

        public async Task<IExpandedChannel> UpdateChannelAsync()
            => await RestApi.UpdateChannelAsync(this);
    }
}
