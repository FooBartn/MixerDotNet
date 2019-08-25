using MixerDotNet.Interfaces.General;
using System.Threading.Tasks;

namespace MixerDotNet.Interfaces.Channels
{
    /// <summary>
    /// Augmented Channel with additional properties.
    /// </summary>
    public interface IExpandedChannel : IChannel
    {
        /// <summary>
        /// The users stream key.
        /// </summary>
        string StreamKey { get; }

        /// <summary>
        /// The current amount of subscribers the channel has.
        /// </summary>
        uint? NumSubscribers { get; }

        /// <summary>
        /// The maximum amount of concurrent subscribers.
        /// </summary>
        uint? MaxConcurrentSubscribers { get; }

        /// <summary>
        /// The total amount of unique subscribers the user has had.
        /// </summary>
        uint? TotalUniqueSubscribers { get; }

        /// <inheritdoc/>
        IResource Badge { get; }

        /// <inheritdoc/>
        IResource Cover { get; }

        /// <inheritdoc/>
        IChannelPreferences Preferences { get; }

        bool HasPrivateDetails { get; }

        Task<IExpandedChannel> UpdateChannelAsync();
    }
}
