﻿using Npgsql;
using System;
using System.Data;

namespace repository.Contexto
{
    public class ContextoPostgresql : IContexto, IDisposable
    {
        public IDbConnection Conexao { get; }
        public ContextoPostgresql(string connectionString) => Conexao = new NpgsqlConnection(connectionString);
        public void Dispose() => Conexao.Dispose();
    }
}
