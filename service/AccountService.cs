using dominio;
using repository;
using repository.Interfaces;
using service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IClientRepository clientRepository;

        public AccountService(IAccountRepository accountRepository, IClientRepository clientRepository) 
        {
            this.accountRepository = accountRepository;
            this.clientRepository = clientRepository;
        }

        public void CreateClientAccount(ClientDTO client)
        {
            int idClient = clientRepository.ClientRegister(client);
            accountRepository.CreateAccount(idClient);
        }

        public int ViewBalance(int numberAccount)
        {
            int balance = accountRepository.ViewBalance(numberAccount);
            return balance;
        }
    }
}
