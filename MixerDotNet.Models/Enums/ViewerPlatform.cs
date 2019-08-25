using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ViewerPlatform
    {
        [EnumMember(Value = "desktop")]
        Desktop,

        [EnumMember(Value = "tablet")]
        Tablet,

        [EnumMember(Value = "mobile")]
        Mobile
    }
}
