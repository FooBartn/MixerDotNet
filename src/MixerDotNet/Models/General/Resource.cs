using MixerDotNet.Enums;
using MixerDotNet.Extensions;
using MixerDotNet.Interfaces.General;
using MixerDotNet.Models.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MixerDotNet.Models
{
    public class Resource : IResource
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("meta")]
        public Dictionary<string, object> Meta { get; set; }

        [JsonProperty("relid")]
        public uint? Relid { get; set; }

        [JsonProperty("remotePath")]
        public string RemotePath { get; set; }

        [JsonProperty("store")]
        public ResourceStore Store { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonIgnore]
        public TimeStamps TimeStamps { get; set; }

        // **
        // JSON Custom Deserialization
        // **

        [JsonExtensionData]
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable 649 // Field 'field' is never assigned to, and will always have its default value 'value'
        private IDictionary<string, JToken> _additionalData;
#pragma warning restore 649
#pragma warning restore IDE0044 // Add readonly modifier

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context) => TimeStamps = _additionalData.GetTimeStamps();
    }
}
