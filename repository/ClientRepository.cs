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
    }
}
