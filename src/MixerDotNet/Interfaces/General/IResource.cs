using MixerDotNet.Enums;
using System;
using System.Collections.Generic;

namespace MixerDotNet.Interfaces.General
{
    /// <summary>
    /// Resources are general use items that are stored and linked to other entities within Mixer.
    /// They usually represent images or backgrounds for a channel or user.
    /// </summary>
    public interface IResource : ITimeStamped
    {
        /// <summary>
        /// The unique ID of the resource.
        /// </summary>
        uint Id { get; }

        /// <summary>
        /// Additional resource information.
        /// </summary>
        Dictionary<string, object> Meta { get; }

        /// <summary>
        /// Id linking to the parent object.
        /// </summary>
        uint? Relid { get; }

        /// <summary>
        /// Relative url to the resource.
        /// </summary>
        string RemotePath { get; }

        /// <summary>
        /// The storage type of the resource.
        /// </summary>
        ResourceStore Store { get; }

        /// <summary>
        /// The type of the resource.
        /// </summary>
        string Type { get; }

        /// <summary>
        /// The url of the resource.
        /// </summary>
        Uri Url { get; }
    }
}
