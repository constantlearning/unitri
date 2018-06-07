using System;
using System.Data.SqlClient;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class BarbeariaDAO
    {
        private SqlConnection conexao;

        public BarbeariaDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        internal void salvarBarbearia(Barbearia barbearia)
        {
            throw new NotImplementedException();
        }

        internal Barbearia buscarBarbearia(int id)
        {
            throw new NotImplementedException();
        }
    }
}