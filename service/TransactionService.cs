using Microsoft.AspNetCore.Mvc;
using repository.Interfaces;
using service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly IAccountRepository accountRepository;

        public TransactionService(ITransactionRepository transactionRepository, IAccountRepository accountRepository)
        {
            this.transactionRepository = transactionRepository;
            this.accountRepository = accountRepository;
        }

        public void Deposit(int numberAccount, int value)
        {
            int newValue = accountRepository.ViewBalance(numberAccount) + value;
            transactionRepository.TransactionRegister(numberAccount, newValue, 2);
        }

        public void Withdraw(int numberAccount, int value)
        {
            if (accountRepository.ViewBalance(numberAccount) < value)
            {
                throw new Exception("Insufficient balance for withdrawal");
            }

            int newValue = accountRepository.ViewBalance(numberAccount) - value;
            transactionRepository.TransactionRegister(numberAccount, newValue, 1);
        }
    }
}
