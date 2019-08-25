using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MixerDotNet.Models
{
    public class Resource
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("meta")]
        public Dictionary<string, object> Meta { get; set; }

        [JsonProperty("relid")]
        public ulong Relid { get; set; }

        [JsonProperty("remotePath")]
        public string RemotePath { get; set; }

        [JsonProperty("store")]
        public string Store { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
