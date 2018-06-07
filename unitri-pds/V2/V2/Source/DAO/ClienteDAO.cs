using System;
using System.Data.SqlClient;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class ClienteDAO
    {
        private SqlConnection conexao;

        public ClienteDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        internal void salvarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        internal Cliente buscarCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}