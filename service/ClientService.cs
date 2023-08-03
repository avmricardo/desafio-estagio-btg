using dominio;
using repository.Interfaces;
using service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public void ClientRegister(ClientDTO client)
        {
            clientRepository.ClientRegister(client);
        }
    }
}
