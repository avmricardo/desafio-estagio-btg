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

        [HttpPost("createaccount")]
        public IActionResult CreateAccount([FromBody] string CPF)
        {
            accountService.CreateAccount(CPF);
            return Ok();
        }

        [HttpPost("changebalance")]
        public IActionResult ChangeBalance([FromBody] int value, int numberAccount)
        {
            accountService.ChangeBalance(value, numberAccount);
            return Ok();
        }
    }
}
