using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixerDotNet.Interfaces.Channels
{
    /// <summary>
    /// A broadcast represents a single broadcast from a Channel.
    /// </summary>
    interface IBroadcast
    {
        /// <summary>
        /// Unique ID for this broadcast.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// ID of the Channel this broadcast belongs to.
        /// </summary>
        uint ChannelId { get; }

        /// <summary>
        /// True if this broadcast is online and in progress.
        /// </summary>
        bool Online { get; }

        /// <summary>
        /// True if this broadcast is running in test stream mode.
        /// </summary>
        bool IsTestStream { get; }

        /// <summary>
        /// The date that this broadcast started at.
        /// </summary>
        DateTimeOffset StartedAt { get; }
    }
}
