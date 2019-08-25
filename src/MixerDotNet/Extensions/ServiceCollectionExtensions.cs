using Microsoft.Extensions.DependencyInjection;
using MixerDotNet.Clients;
using MixerDotNet.Interfaces.Api;
using MixerDotNet.Interfaces.Clients;
using MixerDotNet.RestApi;

namespace MixerDotNet.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static ServiceCollection AddMixerDotNet(this ServiceCollection serviceCollection)
        {
            serviceCollection
                .AddHttpClient()
                .AddScoped<IPolicyProvider, PolicyProvider>()
                .AddScoped<IBaseHttpClient, BaseHttpClient>()
                .AddScoped<IMixerRestApi, MixerRestApi>()
                .AddScoped<IMixerRestClient, MixerRestClient>();

            return serviceCollection;
        }
    }
}