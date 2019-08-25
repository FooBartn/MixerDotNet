using Microsoft.Extensions.Logging;
using MixerDotNet.Interfaces.Clients;
using Polly;
using System;
using System.Net;
using System.Net.Http;

namespace MixerDotNet.Clients
{
    public class PolicyProvider : IPolicyProvider
    {
        private readonly ILogger<PolicyProvider> _logger;

        public PolicyProvider(ILogger<PolicyProvider> logger)
        {
            _logger = logger;
        }

        /// <inheritdoc/>
        public IAsyncPolicy<HttpResponseMessage> RetryAfterPolicy =>
        Policy.Handle<HttpRequestException>()
            .OrResult<HttpResponseMessage>(r => r.StatusCode == (HttpStatusCode)429)
            .WaitAndRetryAsync(
                retryCount: 2,
                sleepDurationProvider: (retryCount, response, context) =>
                {
                    // TODO: This won't be correct. Mixer users an x-retry header. 
                    var waitDuration = response?.Result?.Headers?.RetryAfter?.Delta.Value.TotalSeconds ?? 0;
                    return TimeSpan.FromSeconds(waitDuration + 1);
                },
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
                onRetryAsync: async (response, timespan, retryCount, context) =>

                {
                    _logger.LogInformation($"Retry: {retryCount}. Waiting for {timespan.TotalSeconds} seconds.");
                }
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
            );
    }
}
