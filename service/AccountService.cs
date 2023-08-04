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
        private readonly ITransactionRepository transactionRepository;

        public AccountService(IAccountRepository accountRepository, IClientRepository clientRepository, ITransactionRepository transactionRepository) 
        {
            this.accountRepository = accountRepository;
            this.clientRepository = clientRepository;
            this.transactionRepository = transactionRepository;
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

        public void DeleteClientAccount(int numberAccount)
        {
            int idAccount = accountRepository.SearchAccount(numberAccount);

            transactionRepository.DeleteTransaction(idAccount);
            int idClient = accountRepository.DeleteAccount(idAccount);
            clientRepository.DeleteClient(idClient);
        }
    }
}
