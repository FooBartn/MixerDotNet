using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models.Base
{
    /// <summary>
    /// A type that contains information about creation, update and deletion dates.
    /// </summary>
    public class TimeStamped
    {
        /// <summary>
        /// The creation date of the channel.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The update date of the channel.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// The deletion date of the channel.
        /// </summary>
        [JsonProperty("deletedAt")]
        public DateTimeOffset? DeletedAt { get; set; }
    }
}
