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
        public int ClientRegister(ClientDTO client);
        public void UpdateClient(ClientDTO client);
        public ClientDTO SearchClient(string cpf);
        public void DeleteClient(int idClient);
    }
}
