using System.Collections.Generic;
using System.Threading.Tasks;
using CryptoExchange.Backend.Luno;

namespace CryptoExchange.Backend.Services
{
    public class OrderService
    {
        private readonly LunoApiClient _lunoApiClient;

        public OrderService(LunoApiClient lunoApiClient)
        {
            _lunoApiClient = lunoApiClient;
        }

        public async Task<List<Order>>> GetUserOrdersAsync(string state = "PENDING", string pair = null)
        {
            var ordersResponse = await _lunoApiClient.ListOrdersAsync(state, pair);
            return ordersResponse?.Orders; // Return the list of orders, handle potential null response
        }
    }
} 