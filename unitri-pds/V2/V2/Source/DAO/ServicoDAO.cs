using System;
using System.Data.SqlClient;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class ServicoDAO
    {
        private SqlConnection conexao;

        public ServicoDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        internal void salvarProduto(Servico servico)
        {
            throw new NotImplementedException();
        }

        internal Servico buscarProduto(int id)
        {
            throw new NotImplementedException();
        }
    }
}