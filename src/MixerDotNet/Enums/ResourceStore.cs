using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceStore
    {
        [EnumMember(Value = "s3")]
        S3,

        [EnumMember(Value = "uploads")]
        Uploads,

        [EnumMember(Value = "nil")]
        Nil
    }
}
