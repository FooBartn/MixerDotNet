using System;

namespace MixerDotNet.Interfaces.Channels
{
    /// <summary>
    /// A base analytics type for channel based analytical metrics.
    /// </summary>
    public interface IChannelAnalytic
    {
        /// <summary>
        /// The channel.
        /// </summary>
        uint Channel { get; }

        /// <summary>
        /// Timestamp for when this metric was recorded.
        /// </summary>
        DateTimeOffset Time { get; }
    }
}
