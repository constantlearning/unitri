using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using V2.Source.domain;
using V2.Source.util;

namespace V2.Source.service
{
    internal class ServicoDAO
    {
        private SqlConnection conexao;
        private SqlTransaction tx;

        public ServicoDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public ServicoDAO(SqlConnection conexao, SqlTransaction tx) : this(conexao)
        {
            this.tx = tx;
        }

        internal void salvarProduto(Servico servico)
        {

        }

        public void SalvarServico(Servico servico)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO servico(nome, descricao, valor)");
            sql.Append("VALUES (@nome, @descricao, @valor)");
            command.CommandText = sql.ToString();
            command.Parameters.AddWithValue("@nome", servico.Nome);
            command.Parameters.AddWithValue("@descricao", servico.Descricao);
            command.Parameters.AddWithValue("@valor", servico.Valor);

            command.ExecuteNonQuery();
        }

        internal Servico buscarProduto(int id)
        {
            throw new NotImplementedException();
        }
    }
}