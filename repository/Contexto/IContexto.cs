using System.Data;

namespace repository.Contexto
{
    public interface IContexto
    {
        IDbConnection Conexao { get; }
    }
}
