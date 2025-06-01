using System.Threading.Tasks;
using CryptoExchange.Backend.Luno;

namespace CryptoExchange.Backend.Services
{
    public class AccountService
    {
        private readonly LunoApiClient _lunoApiClient;

        public AccountService(LunoApiClient lunoApiClient)
        {
            _lunoApiClient = lunoApiClient;
        }

        public async Task<ListBalancesResponse> GetAccountBalancesAsync()
        {
            return await _lunoApiClient.GetBalancesAsync();
        }
    }
} 