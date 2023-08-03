using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Interfaces
{
    public interface IClientService
    {
        public void ClientRegister(ClientDTO client);
        public int SearchClient(string CPF);
        public void CreateAccount(string CPF);
    }
}
