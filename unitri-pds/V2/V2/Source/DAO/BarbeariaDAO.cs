using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using V2.Source.domain;
using V2.Source.util;

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

            FabricaConexao.CloseConnection(this.conexao);
        }

    }
}