using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    public enum BoolSearchOption
    {
        [EnumMember(Value = "true")]
        All,

        [EnumMember(Value = "false")]
        None
    }
}
