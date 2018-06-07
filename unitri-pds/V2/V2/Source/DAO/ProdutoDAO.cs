using System;
using System.Data.SqlClient;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class ProdutoDAO
    {
        private SqlConnection conexao;

        public ProdutoDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        internal void salvarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        internal Produto buscarProduto(int id)
        {
            throw new NotImplementedException();
        }
    }
}