using MixerDotNet.Enums;
using MixerDotNet.Interfaces.General;
using MixerDotNet.Interfaces.Users;
using System;

namespace MixerDotNet.Interfaces.Channels
{
    /// <summary>
    /// A single channel within Mixer. Each channel is owned by a user, and a channel can be broadcasted to.
    /// </summary>
    public interface IChannel : ITimeStamped
    {
        /// <summary>
        /// The unique ID of the channel.
        /// </summary>
        uint Id { get; }

        /// <summary>
        /// The ID of the user owning the channel.
        /// </summary>
        uint UserId { get; }

        /// <summary>
        /// The name and url of the channel.
        /// </summary>
        string Token { get; }

        /// <summary>
        /// Indicates if the channel is streaming.
        /// </summary>
        bool Online { get; }

        /// <summary>
        /// True if featureLevel is > 0.
        /// </summary>
        bool Featured { get; }

        /// <summary>
        /// The featured level for this channel. Its value controls the position and order of channels in the featured carousel.
        /// </summary>
        uint FeatureLevel { get; }

        /// <summary>
        /// Indicates if the channel is partnered.
        /// </summary>
        bool Partnered { get; }

        /// <summary>
        /// The id of the transcoding profile.
        /// </summary>
        uint? TranscodingProfileId { get; }

        /// <summary>
        /// Indicates if the channel is suspended.
        /// </summary>
        bool Suspended { get; }

        /// <summary>
        /// The title of the channel.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The target audience of the channel.
        /// </summary>
        AudienceRating Audience { get; set; }

        /// <summary>
        /// Amount of unique viewers that ever viewed this channel.
        /// </summary>
        uint ViewersTotal { get; }

        /// <summary>
        /// Amount of current viewers.
        /// </summary>
        uint ViewersCurrent { get; }

        /// <summary>
        /// Amount of followers.
        /// </summary>
        uint NumFollowers { get; }

        /// <summary>
        /// The description of the channel, can contain HTML.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The ID of the game type.
        /// </summary>
        uint? TypeId { get; }

        /// <summary>
        /// Indicates if that channel is interactive.
        /// </summary>
        bool Interactive { get; }

        /// <summary>
        /// The ID of the interactive game used.
        /// </summary>
        uint? InteractiveGameId { get; }

        /// <summary>
        /// The ftl stream id.
        /// </summary>
        uint Ftl { get; }

        /// <summary>
        /// Indicates if the channel has vod saved.
        /// </summary>
        bool HasVod { get; }

        /// <summary>
        /// ISO 639 language id.
        /// </summary>
        ChannelLanguage? LanguageId { get; set; }

        /// <summary>
        /// The ID of the cover resource.
        /// </summary>
        uint? CoverId { get; }

        /// <summary>
        /// The resource ID of the thumbnail.
        /// </summary>
        uint? ThumbnailId { get; }

        /// <summary>
        /// The resource ID of the subscriber badge.
        /// </summary>
        uint? BadgeId { get; }

        /// <summary>
        /// The URL of the the banner image.
        /// </summary>
        Uri BannerUrl { get; }

        /// <summary>
        /// The ID of the hostee channel.
        /// </summary>
        uint? HosteeId { get; }

        /// <summary>
        /// Indicates if the channel has transcodes enabled.
        /// </summary>
        bool HasTranscodes { get; }

        /// <summary>
        /// Indicates if the channel has vod recording enabled.
        /// </summary>
        bool VodsEnabled { get; set; }

        /// <summary>
        /// The costream that the channel is in, if any.
        /// </summary>
        Guid? CostreamId { get; }

        /// <inheritdoc/>
        IResource Thumbnail { get; }

        /// <inheritdoc/>
        IUser User { get; }

        /// <inheritdoc/>
        IGameType GameType { get; }
    }
}
