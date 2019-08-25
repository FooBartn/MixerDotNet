using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models.Channels
{
    public class GameTypeSimple
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coverUrl")]
        public Uri CoverUrl { get; set; }

        [JsonProperty("backgroundUrl")]
        public Uri BackgroundUrl { get; set; }
    }
}
