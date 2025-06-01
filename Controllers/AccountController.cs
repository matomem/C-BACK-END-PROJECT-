using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CryptoExchange.Backend.Services;
using CryptoExchange.Backend.Luno;
using System.Collections.Generic;

namespace CryptoExchange.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly AccountService _accountService;

        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("balances")]
        public async Task<ActionResult<List<Luno.AccountBalance>>> GetBalances()
        {
            var balancesResponse = await _accountService.GetAccountBalancesAsync();
            return Ok(balancesResponse.Balance);
        }
    }
} 