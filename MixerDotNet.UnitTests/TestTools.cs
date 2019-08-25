using Microsoft.Extensions.Logging;
using MixerDotNet.Clients;
using MixerDotNet.Interfaces.Api;
using MixerDotNet.Interfaces.Clients;
using MixerDotNet.RestApi;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MixerDotNet.UnitTests
{
    public static class TestTools
    {
        public static string GetJsonResource(string fileName)
            => File.ReadAllText($"Resources/{fileName}.json");

        public static IMixerRestApi GetApi<TEntity>(HttpMethod method, string endpoint, string content, 
            string json = null, int version = 1)
        {
            var mockBaseClient = new Mock<IBaseHttpClient>();
            mockBaseClient.Setup(x => x.GetHttpResponse<TEntity>(method, endpoint, json, version))
                .ReturnsAsync(new HttpResponseMessage { Content = new StringContent(content) });

            var restClient = new MixerRestClient(mockBaseClient.Object);
            return new MixerRestApi(restClient);
        }
    }
}
