using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    public enum BaseSearchOption
    {
        [EnumMember(Value = "eq")]
        EqualTo,

        [EnumMember(Value = "ne")]
        NotEqualTo
    }
}
