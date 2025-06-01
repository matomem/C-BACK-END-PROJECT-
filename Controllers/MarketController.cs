using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CryptoExchange.Backend.Services;
using CryptoExchange.Backend.Luno;

namespace CryptoExchange.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarketController : ControllerBase
    {
        private readonly MarketDataService _marketDataService;

        public MarketController(MarketDataService marketDataService)
        {
            _marketDataService = marketDataService;
        }

        [HttpGet("tickers")]
        public async Task<ActionResult<List<Luno.Ticker>>> GetTickers()
        {
            var tickersResponse = await _marketDataService.GetMarketTickersAsync();
            return Ok(tickersResponse.Tickers);
        }
    }
} 