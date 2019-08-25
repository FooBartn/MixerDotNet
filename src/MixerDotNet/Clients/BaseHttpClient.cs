using Microsoft.Extensions.Logging;
using MixerDotNet.Enums;
using MixerDotNet.Exceptions;
using MixerDotNet.Extensions;
using MixerDotNet.Interfaces.Clients;
using MixerDotNet.Models.Oauth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static MixerDotNet.MixerDotNetConstants;

namespace MixerDotNet.Clients
{
    public class BaseHttpClient : IBaseHttpClient
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<BaseHttpClient> _logger;
        private readonly IPolicyProvider _policyProvider;
        private MixerCredentials _credentials;
        public TokenResult TokenResult { get; private set; }

        public BaseHttpClient(IHttpClientFactory clientFactory,
            IPolicyProvider policyProvider,
            ILogger<BaseHttpClient> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _policyProvider = policyProvider ?? throw new ArgumentNullException(nameof(policyProvider));
            _clientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
        }

        public void Initialize(MixerCredentials credentials) => Initialize(credentials, null);

        public void Initialize(MixerCredentials credentials, TokenResult tokenResult)
        {
            _credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));

            if (string.IsNullOrEmpty(_credentials.State))
                _credentials.State = GetUniqueToken();

            TokenResult = tokenResult ?? new TokenResult();
        }

        public async Task ExchangeCodeForToken(string code)
        {
            if (string.IsNullOrEmpty(TokenResult.CsrfToken))
                await SetCsrfToken();

            var exchange = new TokenExchange(_credentials.ClientId, _credentials.RedirectUri, code);
            var requestMsg = await GetHttpResponse<TokenResult>(HttpMethod.Post, "oauth/token", JsonConvert.SerializeObject(exchange));
            var tokenMsg = await requestMsg.Content.ReadAsStringAsync();
            TokenResult = JsonConvert.DeserializeObject<TokenResult>(tokenMsg);
        }

        public static async Task<string> GetPathWithQueryAsync(string path, List<KeyValuePair<string, string>> parameters)
        {
            if (parameters.Any())
            {
                using (var content = new FormUrlEncodedContent(parameters))
                {
                    var query = await content.ReadAsStringAsync();
                    return $"{path}?{query}";
                }
            }

            return path;
        }

        public async Task<HttpResponseMessage> GetHttpResponse<TEntity>(HttpMethod method, string endpoint,
            string json = null, int version = 1)
        {
            var fullUrl = $"{MixerBaseApiUrl}/v{version}/{endpoint}";
            await RefreshToken();

            var finalResult = await _policyProvider.RetryAfterPolicy
                .ExecuteAsync(async () =>
                {
                    using (var client = _clientFactory.CreateClient())
                    {
                        var request = BuildRequestMessage(method, fullUrl, json);
                        var result = await client.SendAsync(request);

                        if (result.Headers.TryGetValues("X-CSRF-Token", out IEnumerable<string> values))
                            TokenResult.CsrfToken = values.First();

                        return result;
                    }
                });


            if (!finalResult.IsSuccessStatusCode)
                await HandleResultAsync<TEntity>(finalResult);

            return finalResult;
        }

        private async Task HandleResultAsync<TEntity>(HttpResponseMessage result)
        {
            var message = await result.Content.ReadAsStringAsync();

            var exception = new MixerApiException(message);
            _logger.LogError(exception, nameof(TEntity));
            throw exception;
        }

        private HttpRequestMessage BuildRequestMessage(HttpMethod method, string endpoint,
            string json)
        {
            var request = new HttpRequestMessage(method, endpoint);

            if (json != null)
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            request.Headers.Add("Client-Id", _credentials.ClientId);

            if (!string.IsNullOrEmpty(TokenResult.AccessToken))
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", TokenResult.AccessToken);

            if (!string.IsNullOrEmpty(TokenResult.CsrfToken))
                request.Headers.Add("X-CSRF-TOKEN", TokenResult.CsrfToken);
                
            return request;
        }

        private async Task SetCsrfToken()
        {
            await GetHttpResponse<object>(HttpMethod.Get, "achievements");
        }

        private async Task RefreshToken()
        {
            if (TokenResult == null || string.IsNullOrEmpty(TokenResult.RefreshToken)
                || !TokenResult.TokenNeedsRefresh()) { return; }

            var refresh = new TokenRefresh(_credentials.ClientId, TokenResult.RefreshToken, _credentials.ClientSecret);
            var requestMsg = await GetHttpResponse<TokenResult>(HttpMethod.Post, "oauth/token", JsonConvert.SerializeObject(refresh));
            var tokenMsg = await requestMsg.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TokenResult>(tokenMsg);

            if (!string.IsNullOrEmpty(result.RefreshToken))
                TokenResult.RefreshToken = result.RefreshToken;

            TokenResult.ExpiresIn = result.ExpiresIn;
            TokenResult.IssueTime = DateTimeOffset.UtcNow;
            TokenResult.AccessToken = result.AccessToken;
        }

        public async Task<string> GetAuthorizeUrlAsync(IEnumerable<OauthScope> scopes)
        {
            var query = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("response_type", "code"),
                new KeyValuePair<string, string>("redirect_uri", _credentials.RedirectUri),
                new KeyValuePair<string, string>("scope", GetScopeValues(scopes)),
                new KeyValuePair<string, string>("client_id", _credentials.ClientId),
                new KeyValuePair<string, string>("state", _credentials.State)
            };

            return await GetPathWithQueryAsync(MixerBaseAuthUrl, query);
        }

        private static string GetScopeValues(IEnumerable<OauthScope> scopes)
        {
            var scopeValues = new List<string>();

            foreach (var scope in scopes)
            {
                scopeValues.Add(scope.GetEnumMemberValue());
            }

            return string.Join(" ", scopeValues);
        }

        private static string GetUniqueToken(string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890-_")
        {
            var random = new Random();
            var length = random.Next(10, 20);

            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[length];

                // If chars.Length isn't a power of 2 then there is a bias if we simply use the modulus operator. The first characters of chars will be more probable than the last ones.
                // buffer used if we encounter an unusable random byte. We will regenerate it in this buffer
                byte[] buffer = null;

                // Maximum random number that can be used without introducing a bias
                int maxRandom = byte.MaxValue - ((byte.MaxValue + 1) % chars.Length);

                crypto.GetBytes(data);

                char[] result = new char[length];

                for (int i = 0; i < length; i++)
                {
                    byte value = data[i];

                    while (value > maxRandom)
                    {
                        if (buffer == null)
                        {
                            buffer = new byte[1];
                        }

                        crypto.GetBytes(buffer);
                        value = buffer[0];
                    }

                    result[i] = chars[value % chars.Length];
                }

                return new string(result);
            }
        }
    }
}
