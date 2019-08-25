using MixerDotNet.Models.Base;
using Newtonsoft.Json;

namespace MixerDotNet.Models.Users
{
    public class AchievementEarning : TimeStamps
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("earned")]
        public bool Earned { get; set; }

        [JsonProperty("progress")]
        public long Progress { get; set; }

        [JsonProperty("achievement")]
        public string ChatAchievement { get; set; }

        [JsonProperty("user")]
        public long User { get; set; }

        [JsonProperty("Achievement")]
        public Achievement Achievement { get; set; }
    }
}
