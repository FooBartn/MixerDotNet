using System;

namespace MixerDotNet.Extensions
{
    public static class DateTimeOffsetExtensions
    {
        public static string ToFormattedUtcString(this DateTimeOffset dateTime)
            => dateTime.UtcDateTime.ToString("yyyy-MM-ddTHH:mm:ss.fffK");
    }
}
