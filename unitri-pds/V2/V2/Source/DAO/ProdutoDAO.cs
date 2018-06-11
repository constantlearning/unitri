using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class ProdutoDAO
    {
        private SqlConnection conexao;
        private SqlTransaction tx;
        private object servico;

        public ProdutoDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public ProdutoDAO(SqlConnection conexao, SqlTransaction tx) : this(conexao)
        {
            this.tx = tx;
        }

        internal void salvarProduto(Produto produto)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO produto(nome, descricao, valor)");
            sql.Append("VALUES (@nome, @descricao, @valor)");
            command.CommandText = sql.ToString();
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@valor", produto.Valor);

            command.ExecuteNonQuery();
        }

        internal Produto buscarProduto(int id)
        {
            throw new NotImplementedException();
        }
    }
}