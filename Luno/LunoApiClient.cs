using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;

namespace CryptoExchange.Backend.Luno
{
    public class LunoApiClient
    {
        private readonly LunoApiConfig _config;
        private readonly HttpClient _httpClient;

        public LunoApiClient(LunoApiConfig config, HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(_config.BaseUrl);
            var authToken = Encoding.ASCII.GetBytes($"{_config.ApiKey}:{_config.ApiSecret}");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));
        }

        // API call methods will go here

        public async Task<ListTickersResponse> GetTickersAsync()
        {
            var response = await _httpClient.GetAsync("/api/1/tickers");
            response.EnsureSuccessStatusCode(); // Throw if not a success code

            var responseBody = await response.Content.ReadAsStringAsync();
            var tickersResponse = JsonSerializer.Deserialize<ListTickersResponse>(responseBody);
            return tickersResponse;
        }

        public async Task<ListBalancesResponse> GetBalancesAsync()
        {
            var response = await _httpClient.GetAsync("/api/1/balance");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var balancesResponse = JsonSerializer.Deserialize<ListBalancesResponse>(responseBody);
            return balancesResponse;
        }

        public async Task<ListOrdersResponse> ListOrdersAsync(string state = "PENDING", string pair = null)
        {
            var requestUrl = "/api/exchange/2/listorders";
            var queryParams = new List<string>();

            if (!string.IsNullOrEmpty(state))
            {
                queryParams.Add($"state={state}");
            }

            if (!string.IsNullOrEmpty(pair))
            {
                queryParams.Add($"pair={pair}");
            }

            if (queryParams.Count > 0)
            {
                requestUrl += "?" + string.Join("&", queryParams);
            }

            var response = await _httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var ordersResponse = JsonSerializer.Deserialize<ListOrdersResponse>(responseBody);
            return ordersResponse;
        }
    }
} 