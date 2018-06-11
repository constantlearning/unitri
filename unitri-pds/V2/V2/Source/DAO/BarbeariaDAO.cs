using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using V2.Source.domain;
using V2.Source.util;

namespace V2.Source.service
{
    internal class BarbeariaDAO
    {
        private SqlConnection conexao;
        private SqlTransaction tx;

        public BarbeariaDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public BarbeariaDAO(SqlConnection conexao, SqlTransaction tx) : this(conexao)
        {
            this.tx = tx;
        }

        internal void salvarBarbearia(Barbearia barbearia)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into barbearia (name, cnpj) values (@nome, @cnpj)";
            command.Parameters.AddWithValue("@nome", barbearia.Nome);
            command.Parameters.AddWithValue("@cnpj", barbearia.Cnpj);

            int n = command.ExecuteNonQuery();

            FabricaConexao.CloseConnection(this.conexao);
        }

        public Barbearia buscarBarbearia(int id)
        {
            Barbearia barbearia = new Barbearia();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM barbearia WHERE id = @id";
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            barbearia.Id = reader.GetInt32(0);
            barbearia.Nome = reader.GetString(1);
            barbearia.Cnpj = reader.GetString(2);

            FabricaConexao.CloseConnection(this.conexao);

            return barbearia;
        }

        internal Barbearia buscarBarbeariaDaFilial(Filial filial)
        {
            Barbearia barbearia = new Barbearia();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM barbearia ");
            sql.Append("INNER JOIN filial_barbearia ON barbearia.Id = filial_barbearia.id_barbearia ");
            sql.Append("WHERE id_filial = @id");
            command.Parameters.AddWithValue("id", filial.Id);

            command.CommandText = sql.ToString();
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            barbearia.Id = (Int32)reader["Id"];
            barbearia.Nome = (String)reader["name"];
            barbearia.Cnpj = (String)reader["cnpj"];

            return barbearia;
        }

        public List<Barbearia> buscarTodosBarbearias()
        {
            List<Barbearia> barbearias = new List<Barbearia>();

            SqlCommand command = new SqlCommand();
            command.Connection = conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM barbearia";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Barbearia barbearia = new Barbearia();
                barbearia.Id = reader.GetInt32(0);
                barbearia.Nome = reader.GetString(1);
                barbearia.Cnpj = reader.GetString(2);

                barbearias.Add(barbearia);
            }

            FabricaConexao.CloseConnection(conexao);

            return barbearias;
        }

        internal void atualizarBarbeariaDaFilial(Filial filial)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            if (tx != null)
            {
                command.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE filial_barbearia ");
            sql.Append("SET id_barbearia = @idbarbearia ");
            sql.Append("WHERE id_filial = @idfilial");
            command.Parameters.AddWithValue("idfilial", filial.Id);
            command.Parameters.AddWithValue("idbarbearia", filial.Barbearia.Id);

            command.CommandText = sql.ToString();
            command.ExecuteNonQuery();
        }

        internal void atualizarBarbearia(Barbearia barbearia)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE barbearia SET name = @nome, cnpj = @cnpj WHERE id = @id";
            command.Parameters.AddWithValue("@nome", barbearia.Nome);
            command.Parameters.AddWithValue("@cnpj", barbearia.Cnpj);
            command.Parameters.AddWithValue("@id", barbearia.Id);
            int n = command.ExecuteNonQuery();
        }

        internal List<Barbearia> buscarBarbeariasLike(string filtro)
        {
            List<Barbearia> barbearias = new List<Barbearia>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM barbearia WHERE name like @filtro";
            command.Parameters.AddWithValue("filtro", "%" + filtro + "%");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Barbearia barbearia = new Barbearia();
                barbearia.Id = reader.GetInt32(0);
                barbearia.Nome = reader.GetString(1);
                barbearia.Cnpj = reader.GetString(2);

                barbearias.Add(barbearia);
            }

            FabricaConexao.CloseConnection(conexao);

            return barbearias;
        }

        internal void deletarBarbearia(int idBarbearia)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM barbearia WHERE id = @id";
            command.Parameters.AddWithValue("id", idBarbearia);

            int n = command.ExecuteNonQuery();

        }

    }
}