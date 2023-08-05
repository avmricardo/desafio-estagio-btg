using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Interfaces
{
    public interface IAccountService
    {
        public int ViewBalance(int numberAccount);
        public void CreateClientAccount(ClientDTO client);
        public void DeleteClientAccount(int numberAccount);
    }
}
