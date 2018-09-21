using System.Threading.Tasks;

namespace Microservice.PoC.PremiumService.Services
{
    public interface IClientService
    {
        Task<string> GetClientName(int clientId);
        // Hystrix Fallback
        Task<string> GetClientNameFallback(int clientId);
    }
}
