using MixerDotNet.Interfaces.Channels;
using MixerDotNet.Models.Channels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace MixerDotNet.Models.Converters
{
    public class ChannelUpdateConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
            => (objectType.GetInterface(nameof(IExpandedChannel)) != null);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            => throw new NotImplementedException("Doesn't matter. CanRead == false");

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            var expandedChannel = value as ExpandedChannel;
            var channelObj = new JObject
            {
                { "name", new JValue(expandedChannel.Name) },
                { "audience", new JValue(expandedChannel.Audience) },
                { "languageId", new JValue(expandedChannel.LanguageId) },
                { "vodsEnabled", new JValue(expandedChannel.VodsEnabled) },
                { "preferences", JObject.FromObject(expandedChannel.Preferences) }
            };

            channelObj.WriteTo(writer);
        }

        public override bool CanRead => false;
    }
}
