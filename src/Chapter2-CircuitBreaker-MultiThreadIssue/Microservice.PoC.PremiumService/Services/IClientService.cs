using System.Threading.Tasks;

namespace Microservice.PoC.PremiumService.Services
{
    public interface IClientService
    {
        Task<string> GetClientName(int clientId);
    }
}
