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
