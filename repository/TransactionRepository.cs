using Dapper;
using dominio.Enums;
using repository.Contexto;
using repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static repository.Contexto.ResolverContexto;

namespace repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IContexto contexto;
        private readonly IAccountRepository accountRepository;

        public TransactionRepository(ResolverContextoDelegate resolverContexto, IAccountRepository accountRepository)
        {
            contexto = resolverContexto(ContextoBancoDeDados.Postgresql);
            this.accountRepository = accountRepository;
        }

        public void TransactionRegister(int numberAccount, int value, int typeTransaction)
        {
            var sqlDeposit = @"INSERT INTO public.transaction(value, id_account, date, type_transaction) VALUES(@Value, @Id_account, @Date, @Type_transaction)";

            var parameters = new
            {
                Date = DateTime.Today,
                Id_account = accountRepository.SearchAccount(numberAccount),
                Value = value,
                Type_transaction = typeTransaction
            };

            accountRepository.ChangeBalance(value, accountRepository.SearchAccount(numberAccount));

            contexto?.Conexao.Execute(sqlDeposit, parameters);
        }
    }
}
