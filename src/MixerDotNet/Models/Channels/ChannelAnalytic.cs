using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models.Channels
{
    /// <summary>
    /// A base analytics type for channel based analytical metrics.
    /// </summary>
    public class ChannelAnalytic
    {
        /// <summary>
        /// The channel.
        /// </summary>
        [JsonProperty("channel")]
        public uint Channel { get; set; }

        /// <summary>
        /// Timestamp for when this metric was recorded.
        /// </summary>
        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }
    }
}
