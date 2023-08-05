using dominio;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
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
            transactionRepository.TransactionRegister(numberAccount, value, newValue, 2);
        }

        public void Withdraw(int numberAccount, int value)
        {
            if (accountRepository.ViewBalance(numberAccount) < value)
            {
                throw new Exception("Insufficient balance for withdrawal");
            }

            int newValue = accountRepository.ViewBalance(numberAccount) - value;
            transactionRepository.TransactionRegister(numberAccount, value, newValue, 1);
        }

        public List<TransactionDTO> ListTransaction(int numberAccount)
        {
            List<TransactionDTO> transactions_unordered = transactionRepository.ListTransaction(numberAccount);
            List<TransactionDTO> transactions = transactions_unordered.OrderBy(dict => dict.Date).ToList();

            return transactions;
        }
    }
}
