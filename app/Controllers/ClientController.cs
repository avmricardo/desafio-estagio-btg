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

        [HttpGet("searchclient")]
        public IActionResult SearchClient([FromQuery] string CPF)
        {
            ClientDTO client = clientService.SearchClient(CPF);
            return Ok(client);
        }

        [HttpPost("updateclient")]
        public IActionResult UpdateClient([FromBody] ClientDTO client)
        {
            clientService.UpdateClient(client);
            return Ok();
        }
    }
}
