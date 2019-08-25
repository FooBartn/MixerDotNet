using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Interfaces.General;
using System;

namespace MixerDotNet.Interfaces.Users
{
    public interface IUser : ITimeStamped
    {
        uint Id { get; set; }

        uint Level { get; set; }

        ISocialInfo Social { get; set; }

        string Username { get; set; }

        string Email { get; set; }

        bool Verified { get; set; }

        uint Experience { get; set; }

        uint Sparks { get; set; }

        Uri AvatarUrl { get; set; }

        string Bio { get; set; }

        uint? PrimaryTeam { get; set; }

        IChannel Channel { get; }
    }
}
