using Microsoft.Extensions.Logging;
using Steeltoe.Common.Discovery;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microservice.PoC.PremiumService.Services
{
    public class ClientService : IClientService
    {
        DiscoveryHttpClientHandler _handler;

        private const string API_GET_CLIENT_NAME_URL = "http://client-service/api/values";
        private ILogger<ClientService> _logger;

        public ClientService(IDiscoveryClient client, ILoggerFactory logFactory = null)
        {
            _handler = new DiscoveryHttpClientHandler(client, logFactory?.CreateLogger<DiscoveryHttpClientHandler>());
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
    }
}
