using MixerDotNet.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixerDotNet.Interfaces.Channels
{
    public interface IChannelSearch
    {
        IChannelSearch AddFeaturedChannelsFilter(BoolSearchOption value);

        IChannelSearch AddOnlineChannelsFilter(BoolSearchOption value);

        IChannelSearch AddPartneredChannelsFilter(BoolSearchOption value);
    }
}
