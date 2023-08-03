using Dapper;
using dominio;
using dominio.Enums;
using repository.Contexto;
using repository.Interfaces;
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
    }
}
