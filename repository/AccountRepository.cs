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
    public class AccountRepository : IAccountRepository
    {
        private readonly IContexto contexto;
        private readonly IClientRepository clientRepository;

        public AccountRepository(ResolverContextoDelegate resolverContexto, IClientRepository clientRepository)
        {
            contexto = resolverContexto(ContextoBancoDeDados.Postgresql);
            this.clientRepository = clientRepository;
        }

        public void CreateAccount(string CPF)
        {
            var sqlCreateAccount = @"INSERT INTO public.account(id_client) VALUES(@IdCLient)";

            int IdClient = clientRepository.SearchClient(CPF);

            var parameter = new
            {
                IdClient = IdClient,
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
    }
}
