using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace MixerDotNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChannelLanguage
    {
        [EnumMember(Value = "en")]
        English,

        [EnumMember(Value = "ar")]
        Arabic,

        [EnumMember(Value = "zh-hk")]
        Cantonese,

        [EnumMember(Value = "da")]
        Danish,

        [EnumMember(Value = "nl")]
        Dutch,

        [EnumMember(Value = "fi")]
        Finnish,

        [EnumMember(Value = "fr")]
        French,

        [EnumMember(Value = "de")]
        German,

        [EnumMember(Value = "he")]
        Hebrew,

        [EnumMember(Value = "it")]
        Italian,

        [EnumMember(Value = "ja")]
        Japanese,

        [EnumMember(Value = "ko")]
        Korean,

        [EnumMember(Value = "zh")]
        Mandarin,

        [EnumMember(Value = "nb")]
        Norwegian,

        [EnumMember(Value = "pl")]
        Polish,

        [EnumMember(Value = "pt")]
        Portuguese,

        [EnumMember(Value = "ro")]
        Russian,

        [EnumMember(Value = "es")]
        Spanish,

        [EnumMember(Value = "sv")]
        Swedish,

        [EnumMember(Value = "tr")]
        Turkish,

        [EnumMember(Value = "other")]
        Other
    }
}
