using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using V2.Source.domain;
using V2.Source.util;

namespace V2.Source.service
{
    internal class AtendenteDAO
    {
        private SqlConnection conexao;

        public AtendenteDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public void salvarAtendente(Atendente atendente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into atendente (nome, cpf, nascimento) values (@nome, @cpf, @nascimento)";
            command.Parameters.AddWithValue("@nome", atendente.Nome);
            command.Parameters.AddWithValue("@cpf", atendente.Cpf);
            command.Parameters.AddWithValue("@nascimento", atendente.Nascimento);

            int n = command.ExecuteNonQuery();

            FabricaConexao.CloseConnection(this.conexao);
        }

        internal Atendente buscarAtendente(int id)
        {
            Atendente atendente = new Atendente();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM atendente WHERE id = @id";
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            atendente.Id = reader.GetInt32(0);
            atendente.Nome = reader.GetString(1);
            atendente.Cpf = reader.GetString(2);
            atendente.Nascimento = reader.GetDateTime(3);

            FabricaConexao.CloseConnection(this.conexao);

            return atendente;
        }

        public List<Atendente> buscarTodosAtendentes()
        {
            List<Atendente> atendentes = new List<Atendente>();

            SqlCommand command = new SqlCommand();
            command.Connection = conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM atendente";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Atendente atendente = new Atendente();
                atendente.Id = reader.GetInt32(0);
                atendente.Nome = reader.GetString(1);
                atendente.Cpf = reader.GetString(2);
                atendente.Nascimento = reader.GetDateTime(3);

                atendentes.Add(atendente);
            }

            FabricaConexao.CloseConnection(conexao);

            return atendentes;
        }

        public void deletarAtendente(int idAtendente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM atendente WHERE id = @id";
            command.Parameters.AddWithValue("id", idAtendente);

            int n = command.ExecuteNonQuery();

            FabricaConexao.CloseConnection(this.conexao);
        }

        public List<Atendente> buscarAtendentesLike(string filtro)
        {
            List<Atendente> atendentes = new List<Atendente>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM atendente WHERE nome like @filtro";
            command.Parameters.AddWithValue("filtro", "%" + filtro + "%");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Atendente atendente = new Atendente();
                atendente.Id = reader.GetInt32(0);
                atendente.Nome = reader.GetString(1);
                atendente.Cpf = reader.GetString(2);
                atendente.Nascimento = reader.GetDateTime(3);

                atendentes.Add(atendente);
            }

            FabricaConexao.CloseConnection(conexao);

            return atendentes;
        }
    }
}