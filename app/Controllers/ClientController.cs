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

        [HttpPost("clientregister")]
        public IActionResult ClientRegister([FromBody] ClientDTO client)
        {
            clientService.ClientRegister(client);
            return Ok();
        }

        [HttpGet("searchclient")]
        public IActionResult SearchClient([FromQuery] string CPF)
        {
            int id = clientService.SearchClient(CPF);
            return Ok(id);
        }

        [HttpPost("updateclient")]
        public IActionResult UpdateClient([FromBody] ClientDTO client)
        {
            clientService.UpdateClient(client);
            return Ok();
        }
    }
}
