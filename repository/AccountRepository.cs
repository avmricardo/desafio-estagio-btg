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
    public class AccountRepository : IAccountRepository
    {
        private readonly IContexto contexto;
        private readonly IClientRepository clientRepository;

        public AccountRepository(ResolverContextoDelegate resolverContexto, IClientRepository clientRepository)
        {
            contexto = resolverContexto(ContextoBancoDeDados.Postgresql);
            this.clientRepository = clientRepository;
        }

        public void CreateAccount(int idClient)
        {
            var sqlCreateAccount = @"INSERT INTO public.account(id_client) VALUES(@IdCLient)";

            var parameter = new
            {
                IdClient = idClient,
            };

            contexto?.Conexao.Execute(sqlCreateAccount, parameter);
        }

        public void ChangeBalance(int value, int numberAccount)
        {
            var sqlChangeBalance = @"UPDATE public.account SET balance = @Value WHERE number = @NumberACcount";

            var parameters = new
            {
                Value = value,
                NumberAccount = numberAccount
            };

            contexto?.Conexao.Execute(sqlChangeBalance, parameters);
            
        }

        public int SearchAccount(int numberAccount)
        {
            var sqlSearchAccount = @"SELECT id_account FROM public.account WHERE number = @NumberAccount";

            var parameter = new
            {
                NumberAccount = numberAccount
            };

            int? idAccount = contexto?.Conexao.QuerySingleOrDefault<int>(sqlSearchAccount, parameter);
            return idAccount ?? 0;
        }

        public int ViewBalance(int numberAccount)
        {
            var sqlViewBalance = @"SELECT balance FROM public.account WHERE number = @NumberAccount";

            var parameter = new
            {
                NumberAccount = numberAccount
            };

            int? balance = contexto?.Conexao.QuerySingleOrDefault<int>(sqlViewBalance, parameter);
            return balance ?? 0;
        }

        public int DeleteAccount(int idAccount)
        {
            var sqlDeleteAccount = @"DELETE FROM public.account WHERE id_account = @IdAccount RETURNING id_client";

            var parameter = new
            {
                IdAccount = idAccount
            };

            int? idClient = contexto?.Conexao.QuerySingleOrDefault<int>(sqlDeleteAccount, parameter);
            return idClient ?? 0;
        }
    }
}
