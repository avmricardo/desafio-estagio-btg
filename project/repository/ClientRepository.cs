using Dapper;
using dominio;
using dominio.Enums;
using repository.Contexto;
using repository.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;
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

        public int ClientRegister(ClientDTO client)
        {
            var sqlClientRegister = @"INSERT INTO public.client(cpf, name, telephone, address) VALUES(@CPF, @Name, @Telephone, @Address) RETURNING id_client";

            var clientData = new
            {
                CPF = client.CPF,
                Name = client.Name,
                Telephone = client.Telephone,
                Address = client.Address,
            };

            int? idClient = contexto?.Conexao.ExecuteScalar<int?>(sqlClientRegister, clientData);
            return idClient ?? 0;
        }

        public void UpdateClient(ClientDTO client)
        {
            var sqlUpdateClient = @"UPDATE public.client SET name = @Name, telephone = @Telephone, address = @Address WHERE cpf = @CPF";

            var parameters = new
            {
                CPF = client.CPF,
                Name = client.Name,
                Telephone = client.Telephone,
                Address = client.Address,
            };

            contexto?.Conexao.Execute(sqlUpdateClient, parameters);
        }

        public ClientDTO SearchClient(string cpf)
        {
            var sqlSearchClient = @"SELECT cpf, name, telephone, address FROM public.client WHERE cpf = @CPF";

            var parameter = new
            {
                CPF = cpf
            };

            ClientDTO client = contexto?.Conexao.QuerySingleOrDefault<ClientDTO>(sqlSearchClient, parameter);
            return client;
        }

        public void DeleteClient(int idClient)
        {
            var sqlDeleteClient = @"DELETE FROM public.client WHERE id_client = @IdClient";

            var parameter = new
            {
                IdClient = idClient
            };

            contexto?.Conexao.ExecuteScalar(sqlDeleteClient, parameter);
        }

        public List<ClientDTO> ListCLient()
        {
            var sqlListCLient = @"SELECT cpf, name, telephone, address FROM public.client";

            List<ClientDTO> listCLient = contexto?.Conexao.Query<ClientDTO>(sqlListCLient).ToList();
            return listCLient;
        }
    }
}
