using Dapper;
using dominio;
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

        public void TransactionRegister(int numberAccount, int valueTransaction, int valueAccount, int typeTransaction)
        {
            var sqlDeposit = @"INSERT INTO public.transaction(value, id_account, date, type_transaction) VALUES(@Value, @Id_account, @Date, @Type_transaction)";

            var parameters = new
            {
                Date = DateTime.Now,
                Id_account = accountRepository.SearchAccount(numberAccount),
                Value = valueTransaction,
                Type_transaction = typeTransaction
            };

            accountRepository.ChangeBalance(valueAccount, accountRepository.SearchAccount(numberAccount));

            contexto?.Conexao.Execute(sqlDeposit, parameters);
        }

        public List<TransactionDTO> ListTransaction(int numberAccount)
        {
            var sqpListTransaction = @"SELECT value, date, type_transaction FROM public.transaction WHERE id_account = @IdAccount";

            var parameter = new
            {
                IdAccount = accountRepository.SearchAccount(numberAccount)
            };

            List<TransactionDTO>? transactions = contexto?.Conexao.Query<TransactionDTO>(sqpListTransaction, parameter).ToList();
            return transactions;
        }

        public void DeleteTransaction(int idAccount)
        {
            var sqlDeleteTRansaction = @"DELETE FROM public.transaction WHERE id_account = @IdAccount";

            var parameter = new
            {
                IdAccount = idAccount
            };

            contexto?.Conexao.ExecuteScalar(sqlDeleteTRansaction, parameter);
        }
    }
}
