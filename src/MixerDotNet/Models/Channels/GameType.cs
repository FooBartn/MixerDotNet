using MixerDotNet.Interfaces.Channels;
using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models.Channels
{
    public class GameType : GameTypeSimple, IGameType
    {
        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("viewersCurrent")]
        public uint ViewersCurrent { get; set; }

        [JsonProperty("online")]
        public uint Online { get; set; }

        [JsonProperty("availableAt")]
        public DateTimeOffset? AvailableAt { get; set; }
    }
}
