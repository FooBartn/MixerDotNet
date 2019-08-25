using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    public enum BetweenSearchOption
    {
        [EnumMember(Value = "between")]
        Between,

        [EnumMember(Value = "notBetween")]
        NotBetween
    }
}
