using Newtonsoft.Json;

namespace MixerDotNet.Models.Oauth
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class TokenRefresh : TokenBase
    {
        public TokenRefresh(string clientId, string refreshToken, string clientSecret = null)
            : base(clientId, "refresh_token", clientSecret)
        {
            RefreshToken = refreshToken;
        }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }
    }
}
