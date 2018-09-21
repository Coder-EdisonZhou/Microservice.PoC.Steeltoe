using Microsoft.Extensions.Logging;
using Steeltoe.CircuitBreaker.Hystrix;
using Steeltoe.Common.Discovery;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microservice.PoC.PremiumService.Services
{
    public class ClientService : HystrixCommand<string>, IClientService
    {
        DiscoveryHttpClientHandler _handler;

        private const string API_GET_CLIENT_NAME_URL = "http://client-service/api/values";
        private ILogger<ClientService> _logger;

        public ClientService(IHystrixCommandOptions options, IDiscoveryClient client, ILoggerFactory logFactory = null):
            base(options)
        {
            _handler = new DiscoveryHttpClientHandler(client,  logFactory?.CreateLogger<DiscoveryHttpClientHandler>());
            IsFallbackUserDefined = true;
            _logger = logFactory?.CreateLogger<ClientService>();
        }

        private HttpClient GetClient()
        {
            var client = new HttpClient(_handler, false);

            return client;
        }

        public async Task<string> GetClientName(int clientId)
        {
            _logger?.LogInformation("GetClientName");
            var client = GetClient();

            return await client.GetStringAsync($"{API_GET_CLIENT_NAME_URL}/{clientId}");
        }

        public async Task<string> GetClientNameFallback(int clientId)
        {
            _logger?.LogInformation("GetClientName");
            var result = await ExecuteAsync();
            _logger?.LogInformation("GetClientName returns : " + result);

            return result;
        }

        protected override async Task<string> RunAsync()
        {
            _logger?.LogInformation("GetClientName");
            var client = GetClient();
            var result = await client.GetStringAsync(API_GET_CLIENT_NAME_URL);
            _logger?.LogInformation("RunAsync returns : " + result);

            return result;
        }

        protected override async Task<string> RunFallbackAsync()
        {
            _logger?.LogInformation("RunFallbackAsync");

            return await Task.FromResult("***There's one error, service is unavailable and please try again later!***");
        }
    }
}
