using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models.Channels
{
    /// <summary>
    /// A broadcast represents a single broadcast from a Channel.
    /// </summary>
    public class Broadcast
    {
        /// <summary>
        /// Unique ID for this broadcast.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// ID of the Channel this broadcast belongs to.
        /// </summary>
        [JsonProperty("channelId")]
        public uint ChannelId { get; set; }

        /// <summary>
        /// True if this broadcast is online and in progress.
        /// </summary>
        [JsonProperty("online")]
        public bool Online { get; set; }

        /// <summary>
        /// True if this broadcast is running in test stream mode.
        /// </summary>
        [JsonProperty("isTestStream")]
        public bool IsTestStream { get; set; }

        /// <summary>
        /// The date that this broadcast started at.
        /// </summary>
        [JsonProperty("startedAt")]
        public DateTimeOffset StartedAt { get; set; }
    }
}
