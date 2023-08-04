using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Interfaces
{
    public interface IAccountRepository
    {
        public void CreateAccount(int idClient);
        public void ChangeBalance(int value, int numberAccount);
        public int SearchAccount(int numberAccount);
        public int ViewBalance(int numberAccount);
        public int DeleteAccount(int idAccount);
    }
}
