using MixerDotNet.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using static MixerDotNet.Enums.OauthScope;

namespace MixerDotNet.RestApi
{
    public static class CompoundScopes
    {
        /// <summary>
        /// Bypass all filters and rules
        /// </summary>
        public static readonly IEnumerable<OauthScope> BypassRules = new OauthScope[]
        {
            BypassCatBot,
            BypassContentFilter,
            BypassNoLinks,
            BypassSlowChat
        };

        public static readonly IEnumerable<OauthScope> ManageSubscriptions = new OauthScope[]
        {
            CancelSubscriptions,
            CreateSubscriptions,
            RenewSubscriptions,
            ViewSubscriptions
        };

        public static readonly IEnumerable<OauthScope> ViewAccount = new OauthScope[]
        {
            ViewUserAnalytics,
            ViewSecurityLog,
            ViewPrivateDetails,
            ViewResources,
            ViewRedeemables,
            DelveSelf
        };

        public static readonly IEnumerable<OauthScope> ViewChannels = new OauthScope[]
        {
            ViewChannelAnalytics,
            ViewChannelDetails,
            ViewChannelStreamKey
        };

        public static readonly IEnumerable<OauthScope> ManageChannels = new List<OauthScope>(ViewChannels)
        {
            UpdateChannel,
            DeleteChannelClips,
            CreateChannelClips,
            FollowChannels
        };

        public static readonly IEnumerable<OauthScope> ManageAccount = new List<OauthScope>(ViewAccount)
        {
            ActAsUser,
            UpdateAccount,
            UpdatePassword,
            UseRedeemable,
            ManageSecurityLog,
            ManageOauth,
            ManageNotifications,
            ManageTeams,
            ManageVods,
            ManageInteractive,
            RunInteractive
        };

        public static readonly IEnumerable<OauthScope> ManageChat = new OauthScope[]
        {
            Chat,
            ConnectChat,
            ClearChat,
            ChangeChatTimeout,
            EditChatOptions,
            PurgeChat,
            RemoveChatMessage,
            StartChatGiveaway,
            StartChatPoll,
            VoteChatPoll,
            WhisperChat,
            ManageBans,
            ManageRoles
        };

        public static readonly IEnumerable<OauthScope> SuperUser = (OauthScope[])Enum.GetValues(typeof(OauthScope));
    }
}
