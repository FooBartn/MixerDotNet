using MixerDotNet.Interfaces.Api;
using MixerDotNet.Interfaces.Clients;
using MixerDotNet.Models.Base;
using MixerDotNet.Models.Oauth;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace MixerDotNet.Clients
{
    public class MixerRestClient : IMixerRestClient
    {
        private readonly JsonSerializer _jsonSerializer;
        private IMixerRestApi _api;

        public IBaseHttpClient HttpClient { get; }

        public MixerRestClient(IBaseHttpClient baseHttpClient)
        {
            HttpClient = baseHttpClient ?? throw new ArgumentNullException(nameof(baseHttpClient));

            _jsonSerializer = new JsonSerializer
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                }
            };
        }

        public void Initialize(IMixerRestApi api, MixerCredentials credentials, TokenResult tokenResult)
        {
            HttpClient.Initialize(credentials, tokenResult);
            InitializeApi(api);
        }

        private void InitializeApi(IMixerRestApi api) => _api = api ?? throw new ArgumentNullException(nameof(api));

        public async Task<TEntity> GetAsync<TEntity>(string endpoint, int version = 1)
        {
            using (var result = await HttpClient.GetHttpResponse<TEntity>(HttpMethod.Get, endpoint, version: version))
                return await DeserializeObjectAsync<TEntity>(result);
        }

        public async Task<TEntity> PatchAsync<TEntity>(string endpoint, string json, int version = 1)
        {
            var method = new HttpMethod("PATCH");
            using (var result = await HttpClient.GetHttpResponse<TEntity>(method, endpoint, json, version: version))
                return await DeserializeObjectAsync<TEntity>(result);
        }

        private async Task<TEntity> DeserializeObjectAsync<TEntity>(HttpResponseMessage result)
        {
            using (var streamReader = new StreamReader(await result.Content.ReadAsStreamAsync()))
            {
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    var obj = _jsonSerializer.Deserialize<TEntity>(jsonTextReader);

                    if (obj is MixerApiIncluded mxApiObj)
                        IncludeApi(mxApiObj);

                    return obj;
                }
            }
        }

        private void IncludeApi<TEntity>(TEntity entity)
            where TEntity : MixerApiIncluded
                => entity.RestApi = _api;
    }
}
