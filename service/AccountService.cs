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

        public AccountService(IAccountRepository accountRepository) 
        {
            this.accountRepository = accountRepository;
        }

        public void CreateAccount(string CPF)
        {
            accountRepository.CreateAccount(CPF);
        }

        public void ChangeBalance(int value, int numberAccount)
        {
            accountRepository.ChangeBalance(value, numberAccount);
        }

        public int SearchAccount(int numberAccount)
        {
            int idAccount = accountRepository.SearchAccount(numberAccount);
            return idAccount;
        }

        public int ViewBalance(int numberAccount)
        {
            int balance = accountRepository.ViewBalance(numberAccount);
            return balance;
        }
    }
}
