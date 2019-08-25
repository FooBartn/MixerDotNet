using MixerDotNet.Models.Channels;
using Newtonsoft.Json;

namespace MixerDotNet.Models.Users
{
    public class UserWithChannel : User
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }
}
