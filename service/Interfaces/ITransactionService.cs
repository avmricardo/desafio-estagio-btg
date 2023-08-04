using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Interfaces
{
    public interface ITransactionService
    {
        public void Deposit(int numberAccount, int value);
    }
}
