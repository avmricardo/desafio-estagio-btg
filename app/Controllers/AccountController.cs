using dominio;
using Microsoft.AspNetCore.Mvc;
using service.Interfaces;
using System.Runtime.InteropServices;

namespace app.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("createclientaccount")]
        public IActionResult CreateClientAccount([FromBody]ClientDTO client)
        {
            accountService.CreateClientAccount(client);
            return Ok();
        }

        [HttpGet("viewbalance")]
        public IActionResult ViewBalance([FromQuery]int number)
        {
            int balance = accountService.ViewBalance(number);
            return Ok(balance);
        }

    }
}
