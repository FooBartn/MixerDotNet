using Newtonsoft.Json;
using System;

namespace MixerDotNet.Models.Oauth
{
    public class TokenResult
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        [JsonIgnore]
        public string CsrfToken { get; set; }

        [JsonIgnore]
        public DateTimeOffset IssueTime { get; set; } = DateTimeOffset.UtcNow;

        public bool TokenNeedsRefresh() => DateTimeOffset.UtcNow.AddMinutes(-5) > IssueTime.AddSeconds(ExpiresIn);
    }
}
