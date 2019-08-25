using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AudienceRating
    {
        [EnumMember(Value = "family")]
        Family,

        [EnumMember(Value = "teen")]
        Teen,

        [EnumMember(Value = "18+")]
        Adult
    }
}
