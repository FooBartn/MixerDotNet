using MixerDotNet.Enums;
using MixerDotNet.Interfaces.General;
using MixerDotNet.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixerDotNet.Interfaces.Channels
{
    /// <summary>
    /// A single channel within Mixer. Each channel is owned by a user, and a channel can be broadcasted to.
    /// </summary>
    public interface IChannel
    {
        /// <summary>
        /// The unique ID of the channel.
        /// </summary>
        uint Id { get; set; }

        /// <summary>
        /// The ID of the user owning the channel.
        /// </summary>
        uint UserId { get; set; }

        /// <summary>
        /// The name and url of the channel.
        /// </summary>
        string Token { get; set; }

        /// <summary>
        /// Indicates if the channel is streaming.
        /// </summary>
        bool Online { get; set; }

        /// <summary>
        /// True if featureLevel is > 0.
        /// </summary>
        bool Featured { get; set; }

        /// <summary>
        /// The featured level for this channel. Its value controls the position and order of channels in the featured carousel.
        /// </summary>
        uint FeatureLevel { get; set; }

        /// <summary>
        /// Indicates if the channel is partnered.
        /// </summary>
        bool Partnered { get; set; }

        /// <summary>
        /// The id of the transcoding profile.
        /// </summary>
        uint? TranscodingProfileId { get; set; }

        /// <summary>
        /// Indicates if the channel is suspended.
        /// </summary>
        bool Suspended { get; set; }

        /// <summary>
        /// The title of the channel.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The target audience of the channel.
        /// </summary>
        Audience Audience { get; set; }

        /// <summary>
        /// Amount of unique viewers that ever viewed this channel.
        /// </summary>
        uint ViewersTotal { get; set; }

        /// <summary>
        /// Amount of current viewers.
        /// </summary>
        uint ViewersCurrent { get; set; }

        /// <summary>
        /// Amount of followers.
        /// </summary>
        uint NumFollowers { get; set; }

        /// <summary>
        /// The description of the channel, can contain HTML.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// The ID of the game type.
        /// </summary>
        uint? TypeId { get; set; }

        /// <summary>
        /// Indicates if that channel is interactive.
        /// </summary>
        bool Interactive { get; set; }

        /// <summary>
        /// The ID of the interactive game used.
        /// </summary>
        uint? InteractiveGameId { get; set; }

        /// <summary>
        /// The ftl stream id.
        /// </summary>
        uint Ftl { get; set; }

        /// <summary>
        /// Indicates if the channel has vod saved.
        /// </summary>
        bool HasVod { get; set; }

        /// <summary>
        /// ISO 639 language id.
        /// </summary>
        string LanguageId { get; set; }

        /// <summary>
        /// The ID of the cover resource.
        /// </summary>
        uint? CoverId { get; set; }

        /// <summary>
        /// The resource ID of the thumbnail.
        /// </summary>
        uint? ThumbnailId { get; set; }

        /// <summary>
        /// The resource ID of the subscriber badge.
        /// </summary>
        uint? BadgeId { get; set; }

        /// <summary>
        /// The URL of the the banner image.
        /// </summary>
        Uri BannerUrl { get; set; }

        /// <summary>
        /// The ID of the hostee channel.
        /// </summary>
        uint? HosteeId { get; set; }

        /// <summary>
        /// Indicates if the channel has transcodes enabled.
        /// </summary>
        bool HasTranscodes { get; set; }

        /// <summary>
        /// Indicates if the channel has vod recording enabled.
        /// </summary>
        bool VodsEnabled { get; set; }

        /// <summary>
        /// The costream that the channel is in, if any.
        /// </summary>
        Guid? CostreamId { get; set; }

        /// <inheritdoc/>
        IResource Thumbnail { get; set; }

        /// <inheritdoc/>
        IUser User { get; set; }

        /// <inheritdoc/>
        IGameType GameType { get; set; }
    }
}
