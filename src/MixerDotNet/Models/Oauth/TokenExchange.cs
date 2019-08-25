using Newtonsoft.Json;

namespace MixerDotNet.Models.Oauth
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class TokenExchange : TokenBase
    {
        public TokenExchange(string clientId, string redirectUri, string code, string clientSecret = null)
            : base(clientId, "authorization_code", clientSecret)
        {
            RedirectUri = redirectUri;
            Code = code;
        }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "redirect_uri")]
        public string RedirectUri { get; set; }
    }
}
