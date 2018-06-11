using System;
using System.Collections.Generic;
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

        internal List<Produto> obterProdutosLike(string filtro)
        {
            List<Produto> produtos = new List<Produto>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM produto WHERE nome like @filtro";
            command.Parameters.AddWithValue("filtro", "%" + filtro + "%");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Produto produto = new Produto();
                produto.Id = (Int32)reader["Id"];
                produto.Nome = (String)reader["nome"];
                produto.Descricao = (String)reader["descricao"];
                produto.Valor = (Double)reader["valor"];

                produtos.Add(produto);
            }


            return produtos;
        }

        internal void atualizarProduto(Produto produto)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE produto SET nome = @nome, descricao = @descricao, valor = @valor WHERE id = @id";
            command.Parameters.AddWithValue("@id", produto.Id);
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@valor", produto.Valor);
            int n = command.ExecuteNonQuery();
        }

        internal Produto buscarProduto(int id)
        {
            Produto produto = new Produto();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM produto WHERE id = @id";
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            produto.Id = (Int32)reader["Id"];
            produto.Nome = (String)reader["nome"];
            produto.Descricao = (String)reader["descricao"];
            produto.Valor = (Double)reader["valor"];

            return produto;
        }

        internal List<Produto> buscarTodosProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            SqlCommand command = new SqlCommand();
            command.Connection = conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM produto";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Produto produto = new Produto();
                produto.Id = (Int32)reader["Id"];
                produto.Nome = (String)reader["nome"];
                produto.Descricao = (String)reader["descricao"];
                produto.Valor = (Double)reader["valor"];

                produtos.Add(produto);
            }

            return produtos;
        }

        internal void deletarProduto(int idProduto)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM produto WHERE id = @id";
            command.Parameters.AddWithValue("id", idProduto);

            int n = command.ExecuteNonQuery();
        }
    }
}