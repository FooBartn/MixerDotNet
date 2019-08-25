using System;
using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    public enum OauthScope
    {
        /// <summary>
        /// Let's you act as this user on other resources.
        /// </summary>
        [EnumMember(Value = "user:act_as")]
        ActAsUser,

        /// <summary>
        /// View your earned achievements.
        /// </summary>
        [EnumMember(Value = "achievement:view:self")]
        ViewAchievements,


        /// <summary>
        /// View your channel analytics.
        /// </summary>
        [EnumMember(Value = "channel:analytics:self")]
        ViewChannelAnalytics,

        /// <summary>
        /// Create new clips from videos on your channel.
        /// </summary>
        [EnumMember(Value = "channel:clip:create:self")]
        CreateChannelClips,

        /// <summary>
        /// Allows deleting existing clips on your channel.
        /// </summary>
        [EnumMember(Value = "channel:clip:delete:self")]
        DeleteChannelClips,

        /// <summary>
        /// Manage your costreaming requests.
        /// </summary>
        [EnumMember(Value = "channel:costream:self")]
        ManageCoStream,

        /// <summary>
        /// Delete your channel banner
        /// </summary>
        [EnumMember(Value = "channel:deleteBanner:self")]
        DeleteChannelBanner,

        /// <summary>
        /// View your channel details.
        /// </summary>
        [EnumMember(Value = "channel:details:self")]
        ViewChannelDetails,

        /// <summary>
        /// Follow and unfollow other channels.
        /// </summary>
        [EnumMember(Value = "channel:follow:self")]
        FollowChannels,

        /// <summary>
        /// View your channel's stream key.
        /// </summary>
        [EnumMember(Value = "channel:streamKey:self")]
        ViewChannelStreamKey,

        /// <summary>
        /// Watch your test streams.
        /// </summary>
        [EnumMember(Value = "channel:teststream:view:self")]
        WatchTestStreams,

        /// <summary>
        /// Update channel
        /// </summary>
        [EnumMember(Value = "channel:update:self")]
        UpdateChannel,

        /// <summary>
        /// Bypasses the catbot chat filter.
        /// </summary>
        [EnumMember(Value = "chat:bypass_catbot")]
        BypassCatBot,

        /// <summary>
        /// Bypass the chat content filter.
        /// </summary>
        [EnumMember(Value = "chat:bypass_filter")]
        BypassContentFilter,

        /// <summary>
        /// Bypass links being disallowed in chat.
        /// </summary>
        [EnumMember(Value = "chat:bypass_links")]
        BypassNoLinks,

        /// <summary>
        /// Bypass slowchat settings on channels.
        /// </summary>
        [EnumMember(Value = "chat:bypass_slowchat")]
        BypassSlowChat,

        /// <summary>
        /// Cancel a skill.
        /// </summary>
        [EnumMember(Value = "chat:cancel_skill")]
        CancelSkill,

        /// <summary>
        /// Manage bans in chats.
        /// </summary>
        [EnumMember(Value = "chat:change_ban")]
        ManageBans,

        /// <summary>
        /// Manage roles in chats.
        /// </summary>
        [EnumMember(Value = "chat:change_role")]
        ManageRoles,

        /// <summary>
        /// Interact with chats on your behalf.
        /// </summary>
        [EnumMember(Value = "chat:chat")]
        Chat,

        /// <summary>
        /// Clear messages in chats where authorized.
        /// </summary>
        [EnumMember(Value = "chat:clear_messages")]
        ClearChat,

        /// <summary>
        /// Connect to chat.
        /// </summary>
        [EnumMember(Value = "chat:connect")]
        ConnectChat,

        /// <summary>
        /// Edit chat options, including links settings and slowchat.
        /// </summary>
        [EnumMember(Value = "chat:edit_options")]
        EditChatOptions,

        /// <summary>
        /// Start a giveaway in chats where authorized.
        /// </summary>
        [EnumMember(Value = "chat:giveaway_start")]
        StartChatGiveaway,

        /// <summary>
        /// Start a poll in chats where authorized.
        /// </summary>
        [EnumMember(Value = "chat:poll_start")]
        StartChatPoll,

        /// <summary>
        /// Vote in chat polls.
        /// </summary>
        [EnumMember(Value = "chat:poll_vote")]
        VoteChatPoll,

        /// <summary>
        /// Clear all messages from a specific user in chat.
        /// </summary>
        [EnumMember(Value = "chat:purge")]
        PurgeChat,

        /// <summary>
        /// Remove own and other's messages in chat.
        /// </summary>
        [EnumMember(Value = "chat:remove_message")]
        RemoveChatMessage,

        /// <summary>
        /// Change timeout settings in chats.
        /// </summary>
        [EnumMember(Value = "chat:timeout")]
        ChangeChatTimeout,

        /// <summary>
        /// View deleted messages in chat.
        /// </summary>
        [EnumMember(Value = "chat:view_deleted")]
        ViewDeletedChat,

        /// <summary>
        /// Gives the ability to whisper in a channel
        /// </summary>
        [EnumMember(Value = "chat:whisper")]
        WhisperChat,

        /// <summary>
        /// View your Mixer homepage experience and recommendations.
        /// </summary>
        [EnumMember(Value = "delve:view:self")]
        DelveSelf,

        /// <summary>
        /// Create, update and delete the interactive games in your account.
        /// </summary>
        [EnumMember(Value = "interactive:manage:self")]
        ManageInteractive,

        /// <summary>
        /// Run as an interactive game in your channel.
        /// </summary>
        [EnumMember(Value = "interactive:robot:self")]
        RunInteractive,

        /// <summary>
        /// View the users invoices.
        /// </summary>
        [EnumMember(Value = "invoice:view:self")]
        ViewInvoices,

        /// <summary>
        /// View and manage your security log.
        /// </summary>
        [EnumMember(Value = "log:view:self")]
        ManageSecurityLog,

        /// <summary>
        /// View and manage your OAuth clients.
        /// </summary>
        [EnumMember(Value = "oauth:manage:self")]
        ManageOauth,

        /// <summary>
        /// Manage the users VODs.
        /// </summary>
        [EnumMember(Value = "recording:manage:self")]
        ManageVods,

        /// <summary>
        /// Create redeemables after performing a purchase.
        /// </summary>
        [EnumMember(Value = "redeemable:create:self")]
        CreateRedeemable,

        /// <summary>
        /// Use users redeemable.
        /// </summary>
        [EnumMember(Value = "redeemable:redeem:self")]
        UseRedeemable,

        /// <summary>
        /// View users redeemables.
        /// </summary>
        [EnumMember(Value = "redeemable:view:self")]
        ViewRedeemables,

        /// <summary>
        /// View emoticons and other graphical resources you have access to.
        /// </summary>
        [EnumMember(Value = "resource:find:self")]
        ViewResources,

        /// <summary>
        /// Cancel your subscriptions.
        /// </summary>
        [EnumMember(Value = "subscription:cancel:self")]
        CancelSubscriptions,

        /// <summary>
        /// Create new subscriptions.
        /// </summary>
        [EnumMember(Value = "subscription:create:self")]
        CreateSubscriptions,

        /// <summary>
        /// Renew your existing subscriptions.
        /// </summary>
        [EnumMember(Value = "subscription:renew:self")]
        RenewSubscriptions,

        /// <summary>
        /// View who you're subscribed to.
        /// </summary>
        [EnumMember(Value = "subscription:view:self")]
        ViewSubscriptions,

        /// <summary>
        /// Create, join, leave teams and set the users primary team.
        /// </summary>
        [EnumMember(Value = "team:manage:self")]
        ManageTeams,

        /// <summary>
        /// Cancel pending transactions.
        /// </summary>
        [EnumMember(Value = "transaction:cancel:self")]
        CancelTransactions,

        /// <summary>
        /// View your pending transactions.
        /// </summary>
        [EnumMember(Value = "transaction:view:self")]
        ViewTransactions,

        /// <summary>
        /// View your user analytics
        /// </summary>
        [EnumMember(Value = "user:analytics:self")]
        ViewUserAnalytics,

        /// <summary>
        /// View your email address and other private details.
        /// </summary>
        [EnumMember(Value = "user:details:self")]
        ViewPrivateDetails,

        /// <summary>
        /// View users discord invites.
        /// </summary>
        [EnumMember(Value = "user:getDiscordInvite:self")]
        ViewDiscordInvites,

        /// <summary>
        /// View your user security log.
        /// </summary>
        [EnumMember(Value = "user:log:self")]
        ViewSecurityLog,

        /// <summary>
        /// View and manage your notifications.
        /// </summary>
        [EnumMember(Value = "user:notification:self")]
        ManageNotifications,

        /// <summary>
        /// Mark a VOD as seen for the user.
        /// </summary>
        [EnumMember(Value = "user:seen:self")]
        MarkVodSeen,

        /// <summary>
        /// Update your account, including your email but not your password.
        /// </summary>
        [EnumMember(Value = "user:update:self")]
        UpdateAccount,

        /// <summary>
        /// Update your password.
        /// </summary>
        [EnumMember(Value = "user:updatePassword:self")]
        UpdatePassword
    }
}
