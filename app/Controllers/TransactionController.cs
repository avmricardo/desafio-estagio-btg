using dominio;
using Microsoft.AspNetCore.Mvc;
using service.Interfaces;
using System.Runtime.InteropServices;

namespace app.Controllers
{
    [ApiController]
    [Route("api/transaction")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        [HttpPost("withdraw")]
        public IActionResult Withdraw(int numberAccount, int value)
        {

            try
            {
                transactionService.Withdraw(numberAccount, value);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("deposit")]
        public IActionResult Deposit(int numberAccount, int value)
        {
            transactionService.Deposit(numberAccount, value);
            return Ok();
        }
    }
}
