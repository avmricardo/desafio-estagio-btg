using dominio;
using Microsoft.AspNetCore.Mvc;
using service.Interfaces;
using System.Runtime.InteropServices;

namespace app.Controllers
{
    [ApiController]
    [Route("api/client")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService clientService;

        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpPost("createaccount")]
        public IActionResult CreateAccount([FromBody] ClientDTO client)
        {
            clientService.ClientRegister(client);
            return Ok();
        }

        [HttpPost("withdraw")]
        public IActionResult Withdraw()
        {
            return Ok();
        }

        [HttpPost("deposit")]
        public IActionResult Deposit()
        {
            return Ok();
        }

        [HttpGet("balance")]
        public IActionResult Balance()
        {
            return Ok();
        }
    }
}
