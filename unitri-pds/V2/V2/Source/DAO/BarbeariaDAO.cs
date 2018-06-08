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
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
<<<<<<< HEAD
            command.CommandText = "insert into barbearia (name, cnpj) values (@nome, @cnpj)";
=======
            command.CommandText = "insert into barbearia (nome, cnpj) values (@nome, @cnpj)";
>>>>>>> d70c839188ce89b46505b8e562dfb62a43c4fa66
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
<<<<<<< HEAD
            List<Barbearia> barbearias = new List<Barbearia>();
=======
            List<Atendente> barbearias = new List<Atendente>();
>>>>>>> d70c839188ce89b46505b8e562dfb62a43c4fa66

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
<<<<<<< HEAD
            command.CommandText = "SELECT * FROM barbearia WHERE name like @filtro";
=======
            command.CommandText = "SELECT * FROM atendente WHERE nome like @filtro";
>>>>>>> d70c839188ce89b46505b8e562dfb62a43c4fa66
            command.Parameters.AddWithValue("filtro", "%" + filtro + "%");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
<<<<<<< HEAD
                Barbearia barbearia = new Barbearia();
                barbearia.Id = reader.GetInt32(0);
                barbearia.Nome = reader.GetString(1);
                barbearia.Cnpj = reader.GetString(2);

                barbearias.Add(barbearia);
=======
                Atendente atendente = new Atendente();
                atendente.Id = reader.GetInt32(0);
                atendente.Nome = reader.GetString(1);
                atendente.Cpf = reader.GetString(2);
                atendente.Nascimento = reader.GetDateTime(3);

                barbearias.Add(atendente);
>>>>>>> d70c839188ce89b46505b8e562dfb62a43c4fa66
            }

            FabricaConexao.CloseConnection(conexao);

<<<<<<< HEAD
            return barbearias;
=======
            //return barbearias;
            return null;
>>>>>>> d70c839188ce89b46505b8e562dfb62a43c4fa66
        }

        internal void deletarBarbearia(int idBarbearia)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
<<<<<<< HEAD
            command.CommandText = "DELETE FROM barbearia WHERE id = @id";
=======
            command.CommandText = "DELETE FROM atendente WHERE id = @id";
>>>>>>> d70c839188ce89b46505b8e562dfb62a43c4fa66
            command.Parameters.AddWithValue("id", idBarbearia);

            int n = command.ExecuteNonQuery();

            FabricaConexao.CloseConnection(this.conexao);
        }

    }
}