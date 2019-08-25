using System;

namespace MixerDotNet.Interfaces.Channels
{
    /// <summary>
    /// A GameType can be set on a channel and represents the title they are broadcasting.
    /// </summary>
    public interface IGameType
    {
        /// <summary>
        /// The name of the parent type.
        /// </summary>
        string Parent { get; }

        /// <summary>
        /// The description of the type.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The source where the type has been imported from.
        /// </summary>
        string Source { get; }

        /// <summary>
        /// Total amount of users watching this type of stream.
        /// </summary>
        uint ViewersCurrent { get; }

        /// <summary>
        /// Amount of streams online with this type.
        /// </summary>
        uint Online { get; }

        DateTimeOffset? AvailableAt { get; }

        /// <summary>
        /// The unique ID of the game type.
        /// </summary>
        uint Id { get; }

        /// <summary>
        /// The name of the type.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The url to the type's cover.
        /// </summary>
        Uri CoverUrl { get; }

        /// <summary>
        /// The url to the type's background.
        /// </summary>
        Uri BackgroundUrl { get; }
    }
}
