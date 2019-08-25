using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models.Channels
{
    public class GameType : GameTypeSimple
    {
        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("viewersCurrent")]
        public ulong ViewersCurrent { get; set; }

        [JsonProperty("online")]
        public ulong Online { get; set; }

        [JsonProperty("availableAt")]
        public DateTimeOffset? AvailableAt { get; set; }
    }
}
