using Dapper;
using dominio;
using dominio.Enums;
using repository.Contexto;
using repository.Interfaces;
using System;
using static repository.Contexto.ResolverContexto;

namespace repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly IContexto contexto;

        public ClientRepository(ResolverContextoDelegate resolverContexto)
        {
            contexto = resolverContexto(ContextoBancoDeDados.Postgresql);
        }

        public void ClientRegister(ClientDTO client)
        {
            var sqlClientRegister = @"INSERT INTO public.client(cpf, name, telephone, address) VALUES(@CPF, @Name, @Telephone, @Address)";

            var clientData = new
            {
                CPF = client.CPF,
                Name = client.Name,
                Telephone = client.Telephone,
                Address = client.Address,
            };

            contexto?.Conexao.ExecuteScalar<int?>(sqlClientRegister, clientData);
        }

        public int SearchClient(string CPF)
        {
            var sqlSearchClient = @"SELECT id_client FROM public.client WHERE cpf = @CPF";

            var parameter = new
            {
                CPF = CPF,
            };

            int? id = contexto?.Conexao.QuerySingleOrDefault<int?>(sqlSearchClient, parameter);

            return id ?? 0;
        }
    }
}
