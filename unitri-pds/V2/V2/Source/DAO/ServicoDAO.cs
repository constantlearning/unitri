using System;
using System.Collections.Generic;
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

        internal List<Servico> obterServicosLike(string filtro)
        {
            List<Servico> servicos = new List<Servico>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM servico WHERE nome like @filtro";
            command.Parameters.AddWithValue("filtro", "%" + filtro + "%");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Servico servico = new Servico();
                servico.Id = (Int32)reader["Id"];
                servico.Nome = (String)reader["nome"];
                servico.Descricao = (String)reader["descricao"];
                servico.Valor = (Double)reader["valor"];

                servicos.Add(servico);
            }

            return servicos;
        }

        internal Servico buscarProduto(int id)
        {
            Servico servico = new Servico();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM servico WHERE id = @id";
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            servico.Id = (Int32)reader["Id"];
            servico.Nome = (String)reader["nome"];
            servico.Descricao = (String)reader["descricao"];
            servico.Valor = (Double)reader["valor"];

            return servico;
        }

        internal void deletarServico(int idServico)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM servico WHERE id = @id";
            command.Parameters.AddWithValue("id", idServico);

            int n = command.ExecuteNonQuery();
        }

        internal List<Servico> buscarTodosServicos()
        {
            List<Servico> servicos = new List<Servico>();

            SqlCommand command = new SqlCommand();
            command.Connection = conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM servico";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Servico servico = new Servico();
                servico.Id = (Int32)reader["Id"];
                servico.Nome = (String)reader["nome"];
                servico.Descricao = (String)reader["descricao"];
                servico.Valor = (Double)reader["valor"];

                servicos.Add(servico);
            }

            return servicos;
        }

        internal void atualizarProduto(Servico servico)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE servico SET nome = @nome, descricao = @descricao, valor = @valor WHERE id = @id";
            command.Parameters.AddWithValue("@id", servico.Id);
            command.Parameters.AddWithValue("@nome", servico.Nome);
            command.Parameters.AddWithValue("@descricao", servico.Descricao);
            command.Parameters.AddWithValue("@valor", servico.Valor);
            int n = command.ExecuteNonQuery();
        }
    }
}