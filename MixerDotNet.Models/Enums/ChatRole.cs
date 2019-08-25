using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MixerDotNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChatRole
    {
        User,

        Banned,

        Pro,

        VerifiedPartner,

        Partner,

        Subscriber,

        ChannelEditor,

        Mod,

        GlobalMod,

        Staff,

        Founder,

        Owner
    }
}