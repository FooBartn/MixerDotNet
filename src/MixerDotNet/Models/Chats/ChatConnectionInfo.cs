using MixerDotNet.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MixerDotNet.Models.Chats
{
    public class ChatConnectionInfo
    {
        [JsonProperty("roles")]
        public IReadOnlyCollection<ChatRole> Roles { get; set; }

        [JsonProperty("authkey")]
        public string Authkey { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("endpoints")]
        public string[] Endpoints { get; set; }

        [JsonProperty("isLoadShed")]
        public bool IsLoadShed { get; set; }
    }
}
