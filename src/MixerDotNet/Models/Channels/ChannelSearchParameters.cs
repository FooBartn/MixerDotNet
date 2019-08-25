using MixerDotNet.Enums;
using System.Collections.Generic;
using System.Linq;

namespace MixerDotNet.Models.Channels
{
    public class ChannelSearchParameters
    {
        private readonly List<string> _searchStrings = new List<string>();

        public static ChannelSearchParameters New() => new ChannelSearchParameters();

        public ChannelSearchParameters AddFeaturedFilter(BoolSearchOption value)
        {
            AddSearchFilter($"featured:eq:{value}");
            return this;
        }

        public ChannelSearchParameters AddOnlineFilter(BoolSearchOption value)
        {
            AddSearchFilter($"online:eq:{value}");
            return this;
        }

        public ChannelSearchParameters AddPartneredFilter(BoolSearchOption value)
        {
            AddSearchFilter($"partnered:eq:{value}");
            return this;
        }

        public ChannelSearchParameters AddSuspendedFilter(BoolSearchOption value)
        {
            AddSearchFilter($"suspended:eq:{value}");
            return this;
        }

        public ChannelSearchParameters AddInteractiveFilter(BoolSearchOption value)
        {
            AddSearchFilter($"interactive:eq:{value}");
            return this;
        }

        public ChannelSearchParameters AddHasVodFilter(BoolSearchOption value)
        {
            AddSearchFilter($"hasVod:eq:{value}");
            return this;
        }

        public ChannelSearchParameters AddVodEnabledFilter(BoolSearchOption value)
        {
            AddSearchFilter($"vodsEnabled:eq:{value}");
            return this;
        }

        public ChannelSearchParameters AddUsersFilter(IEnumerable<uint> userIds, ArraySearchOption searchOption)
        {
            var userIdsStr = string.Join(";", userIds);
            AddSearchFilter($"userId:{searchOption}:{userIdsStr}");
            return this;
        }

        public ChannelSearchParameters AddUserFilter(uint userId, bool include = true)
        {
            var condition = include ? "eq" : "ne";
            AddSearchFilter($"userId:{condition}:{userId}");
            return this;
        }

        public ChannelSearchParameters AddCurrentViewersFilter(uint value, ExpandedSearchOption searchOption)
        {
            AddSearchFilter($"viewersCurrent:{searchOption}:{value}");
            return this;
        }

        public ChannelSearchParameters AddCurrentViewersFilter(uint lowValue, uint highValue, BetweenSearchOption searchOption)
        {
            AddSearchFilter($"viewersCurrent:{searchOption}:{lowValue};{highValue}");
            return this;
        }

        public ChannelSearchParameters AddTotalViewersFilter(uint value, ExpandedSearchOption searchOption)
        {
            AddSearchFilter($"viewersTotal:{searchOption}:{value}");
            return this;
        }

        public ChannelSearchParameters AddTotalViewersFilter(uint lowValue, uint highValue, BetweenSearchOption searchOption)
        {
            AddSearchFilter($"viewersTotal:{searchOption}:{lowValue};{highValue}");
            return this;
        }

        public ChannelSearchParameters AddRatingFilter(AudienceRating rating, BaseSearchOption searchOption)
        {
            AddSearchFilter($"audience:{searchOption}:{rating}");
            return this;
        }

        public ChannelSearchParameters AddFollowersFilter(uint value, ExpandedSearchOption searchOption)
        {
            AddSearchFilter($"numFollowers:{searchOption}:{value}");
            return this;
        }

        public ChannelSearchParameters AddChannelsFilter(IEnumerable<uint> channelIds, ArraySearchOption searchOption)
        {
            var channelIdsStr = string.Join(";", channelIds);
            AddSearchFilter($"id:{searchOption}:{channelIdsStr}");
            return this;
        }

        private void AddSearchFilter(string filter)
        {
            var filterName = filter.Split(':').First();
            var oldFilter = _searchStrings.FirstOrDefault(x => x.StartsWith(filterName));
            if (oldFilter != null)
                _searchStrings.Remove(oldFilter);

            _searchStrings.Add(filter);
        }
    }
}
