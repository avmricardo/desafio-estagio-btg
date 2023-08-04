using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Interfaces
{
    public interface ITransactionRepository
    {
        public void TransactionRegister(int numberAccount, int valueTransaction, int valueAccount, int typeTransaction);
        public List<TransactionDTO> ListTransaction(int numberAccount);
    }
}
