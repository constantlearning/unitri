﻿using System;
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
        private SqlTransaction tx;

        public AtendenteDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public AtendenteDAO(SqlConnection conexao, SqlTransaction tx)
        {
            this.conexao = conexao;
            this.tx = tx;
        }

        public void salvarAtendente(Atendente atendente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.Transaction = this.tx;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into atendente (nome, cpf, nascimento) values (@nome, @cpf, @nascimento)";
            command.Parameters.AddWithValue("@nome", atendente.Nome);
            command.Parameters.AddWithValue("@cpf", atendente.Cpf);
            command.Parameters.AddWithValue("@nascimento", atendente.Nascimento);

            command.ExecuteNonQuery();
        }

        public void salvarAtendenteFilial(Atendente atendente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.Transaction = this.tx;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into atendente_filial(id_atendente, id_filial) values(@idatendente, @idfilial)";
            command.Parameters.AddWithValue("@idatendente", atendente.Id);
            command.Parameters.AddWithValue("@idfilial", atendente.Filial.Id);

            command.ExecuteNonQuery();
        }

        internal Atendente buscarAtendenteCPF(String cpf)
        {
            Atendente atendente = new Atendente();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = this.tx;
            }
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM atendente WHERE cpf = @cpf";
            command.Parameters.AddWithValue("cpf", cpf);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            atendente.Id = (Int32)reader["Id"];
            atendente.Cpf = (String)reader["cpf"];
            atendente.Nome = (String)reader["nome"];
            atendente.Nascimento = (DateTime)reader["nascimento"];

            FabricaConexao.CloseConnection(this.conexao);

            return atendente;
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

            atendente.Id = (Int32)reader["Id"];
            atendente.Cpf = (String)reader["cpf"];
            atendente.Nome = (String)reader["nome"];
            atendente.Nascimento = (DateTime)reader["nascimento"];

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
                atendente.Id = (Int32)reader["Id"];
                atendente.Cpf = (String)reader["cpf"];
                atendente.Nome = (String)reader["nome"];
                atendente.Nascimento = (DateTime)reader["nascimento"];

                atendentes.Add(atendente);
            }

            FabricaConexao.CloseConnection(conexao);

            return atendentes;
        }

        public void atualizarAtendente(Atendente atendente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE atendente SET nome = @nome, cpf = @cpf, nascimento = @nascimento WHERE id = @id";
            command.Parameters.AddWithValue("@id", atendente.Id);
            command.Parameters.AddWithValue("@nome", atendente.Nome);
            command.Parameters.AddWithValue("@cpf", atendente.Cpf);
            command.Parameters.AddWithValue("@nascimento", atendente.Nascimento);
            int n = command.ExecuteNonQuery();

            FabricaConexao.CloseConnection(this.conexao);
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
                atendente.Id = (Int32)reader["Id"];
                atendente.Cpf = (String)reader["cpf"];
                atendente.Nome = (String)reader["nome"];
                atendente.Nascimento = (DateTime)reader["nascimento"];

                atendentes.Add(atendente);
            }

            FabricaConexao.CloseConnection(conexao);

            return atendentes;
        }
    }
}