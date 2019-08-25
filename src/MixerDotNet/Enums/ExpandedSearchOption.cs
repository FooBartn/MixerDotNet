using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    public enum ExpandedSearchOption
    {
        [EnumMember(Value = "gt")]
        GreaterThan,

        [EnumMember(Value = "gte")]
        GreaterThanEqualTo,

        [EnumMember(Value = "lt")]
        LessThan,

        [EnumMember(Value = "lte")]
        LessThanEqualTo,

        [EnumMember(Value = "eq")]
        EqualTo,

        [EnumMember(Value = "ne")]
        NotEqualTo
    }
}
