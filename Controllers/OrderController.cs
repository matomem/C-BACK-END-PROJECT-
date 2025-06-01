using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CryptoExchange.Backend.Services;
using CryptoExchange.Backend.Luno;
using System.Collections.Generic;

namespace CryptoExchange.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("list")]
        public async Task<ActionResult<List<Luno.Order>>> GetOrders([FromQuery] string state = "PENDING", [FromQuery] string pair = null)
        {
            var orders = await _orderService.GetUserOrdersAsync(state, pair);
            if (orders == null) // Handle potential null response from service
            {
                 return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving orders.");
            }
            return Ok(orders);
        }
    }
} 