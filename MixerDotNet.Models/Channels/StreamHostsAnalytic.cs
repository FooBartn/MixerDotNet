﻿using Newtonsoft.Json;

namespace MixerDotNet.Models.Channels
{
    public class StreamHostsAnalytic : ChannelAnalytic
    {
        [JsonProperty("hoster")]
        public ulong? Hoster { get; set; }

        [JsonProperty("hostee")]
        public ulong? Hostee { get; set; }
    }
}
