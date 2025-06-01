using System.Threading.Tasks;
using CryptoExchange.Backend.Luno;

namespace CryptoExchange.Backend.Services
{
    public class MarketDataService
    {
        private readonly LunoApiClient _lunoApiClient;

        public MarketDataService(LunoApiClient lunoApiClient)
        {
            _lunoApiClient = lunoApiClient;
        }

        public async Task<ListTickersResponse> GetMarketTickersAsync()
        {
            return await _lunoApiClient.GetTickersAsync();
        }
    }
} 