using MixerDotNet.Interfaces.Users;
using Newtonsoft.Json;

namespace MixerDotNet.Models.Users
{
    public class Achievement : IAchievement
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sparks")]
        public ulong Sparks { get; set; }
    }
}
