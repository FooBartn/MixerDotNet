using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixerDotNet.Models.Oauth
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public abstract class TokenBase
    {
        protected TokenBase(string clientId, string grantType, string clientSecret = null)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            GrantType = grantType;
        }

        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        [JsonProperty(PropertyName = "grant_type")]
        public string GrantType { get; set; }

        [JsonProperty(PropertyName = "client_secret")]
        public string ClientSecret { get; set; }
    }
}
