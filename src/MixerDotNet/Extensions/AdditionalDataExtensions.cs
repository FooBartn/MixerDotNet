using MixerDotNet.Models.Base;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace MixerDotNet.Extensions
{
    public static class AdditionalDataExtensions
    {
        public static TimeStamps GetTimeStamps(this IDictionary<string, JToken> jsonExtensionData)
        {
            var createdAt = (DateTimeOffset)jsonExtensionData["createdAt"];
            var updatedAt = (DateTimeOffset)jsonExtensionData["updatedAt"];
            DateTimeOffset? deletedAt = null;

            if (jsonExtensionData.ContainsKey("deletedAt"))
                deletedAt = (DateTimeOffset?)jsonExtensionData["deletedAt"];

            return new TimeStamps
            {
                CreatedAt = createdAt,
                UpdatedAt = updatedAt,
                DeletedAt = deletedAt
            };
        }
    }
}
