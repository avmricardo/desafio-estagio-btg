using dominio.Enums;

namespace repository.Contexto
{
    public class ResolverContexto
    {
        public delegate IContexto? ResolverContextoDelegate(ContextoBancoDeDados contexto);
    }
}
