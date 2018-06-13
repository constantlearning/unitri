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

        internal Servico buscarServicoDoPedido(ItemServico itemServico)
        {
            Servico servico = new Servico(); ;

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT* FROM servico ");
            sql.Append("INNER JOIN pedido_itemservico ON servico.Id = pedido_itemservico.id_servico ");
            sql.Append("WHERE pedido_itemservico.Id = @id");
            command.Parameters.AddWithValue("@id", itemServico.Id);

            command.CommandText = sql.ToString();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                servico.Id = (Int32)reader["Id"];
                servico.Nome = (String)reader["nome"];
                servico.Descricao = (String)reader["descricao"];
                servico.Valor = (Double)reader["valor"];

                return servico;
            }

            return null;
        }

        internal List<ItemServico> buscarItemServicoDoPedido(Pedido pedido)
        {
            List<ItemServico> itemServico = new List<ItemServico>(); ;

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT* FROM pedido_itemservico ");
            sql.Append("INNER JOIN pedido ON pedido.Id = pedido_itemservico.id_pedido ");
            sql.Append("WHERE pedido_itemservico.id_pedido = @id");
            command.Parameters.AddWithValue("@id", pedido.Id);

            command.CommandText = sql.ToString();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ItemServico itemProduto = new ItemServico();
                itemProduto.Id = (Int32)reader["Id"];
                itemProduto.Quantidade = (Int32)reader["quantidade"];

                itemServico.Add(itemProduto);
            }

            return itemServico;
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