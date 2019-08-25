using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixerDotNet.Interfaces.Channels
{
    interface IExpandedChannel : IChannel
    {
        string StreamKey { get; set; }

        uint? NumSubscribers { get; set; }

        uint? MaxConcurrentSubscribers { get; set; }

        uint? TotalUniqueSubscribers { get; set; }

        IResource Badge { get; set; }

        IResource Cover { get; set; }

        IChannelPreferences Preferences { get; set; }
    }
}
