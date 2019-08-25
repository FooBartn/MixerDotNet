using System;

namespace MixerDotNet.Models.Oauth
{
    public class MixerCredentials
    {
        public MixerCredentials(string clientId, string redirectUri) : this(clientId, redirectUri, null, null) { }

        public MixerCredentials(string clientId, string redirectUri, string state) : this (clientId, redirectUri, state, null) { }

        public MixerCredentials(string clientId, string redirectUri, string state, string clientSecret)
        {
            ClientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
            RedirectUri = redirectUri ?? throw new ArgumentNullException(nameof(redirectUri));
            ClientSecret = clientSecret;
            State = state;
        }

        public string ClientId { get; private set; }
        internal string ClientSecret { get; private set; }
        internal string State { get; set; }
        public string RedirectUri { get; private set; }
    }
}
