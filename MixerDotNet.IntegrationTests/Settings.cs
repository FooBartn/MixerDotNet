using MixerDotNet.Models.Oauth;

namespace MixerDotNet.IntegrationTests
{
    public class Settings
    {
        public string ClientId { get; set; }

        public string RedirectUri { get; set; }

        public TokenResult TokenResult { get; set; }
    }
}
