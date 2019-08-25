using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ViewerBrowser
    {
        [EnumMember(Value = "chr")]
        Chrome,

        [EnumMember(Value = "ff")]
        Firefox,

        [EnumMember(Value = "ie")]
        InternetExplorer,

        [EnumMember(Value = "ios")]
        Ios,

        [EnumMember(Value = "sf")]
        Safari,

        [EnumMember(Value = "an")]
        Android
    }
}
