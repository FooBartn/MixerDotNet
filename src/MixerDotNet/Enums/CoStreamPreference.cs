using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CoStreamPreference
    {
        [EnumMember(Value = "all")]
        All,

        [EnumMember(Value = "following")]
        Following,

        [EnumMember(Value = "none")]
        None
    }
}
