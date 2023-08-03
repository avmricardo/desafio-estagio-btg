using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Interfaces
{
    public interface IClientRepository
    {
        public void ClientRegister(ClientDTO client);
        public int SearchClient(string CPF);
        public void UpdateClient(ClientDTO client);
    }
}
