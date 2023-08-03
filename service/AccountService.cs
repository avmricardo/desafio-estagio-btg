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
    }
}
