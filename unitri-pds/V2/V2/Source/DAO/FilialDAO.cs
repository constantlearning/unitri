using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using V2.Source.domain;
using V2.Source.util;

namespace V2.Source.service
{
    internal class FilialDAO
    {
        private SqlConnection conexao;
        private SqlTransaction tx;

        public FilialDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public FilialDAO(SqlConnection conexao, SqlTransaction tx) : this(conexao)
        {
            this.tx = tx;
        }

        internal void salvarFilial(Filial filial)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO filial(nome, endereco, cnpj)");
            sql.Append("VALUES (@nome, @endereco, @cnpj)");
            sql.Append("SELECT @@identity from filial");
            command.CommandText = sql.ToString();
            command.Parameters.AddWithValue("@nome", filial.Nome);
            command.Parameters.AddWithValue("@endereco", filial.Endereco);
            command.Parameters.AddWithValue("@cnpj", filial.Cnpj);

            decimal id = (decimal)command.ExecuteScalar();
            filial.Id = Convert.ToInt32(id);
        }

        internal void salvarFilialTelefone(Filial filial)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.Transaction = this.tx;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO telefone_filial(id_telefone, id_filial) values(@idtelefone, @idfilial)";
            command.Parameters.AddWithValue("@idtelefone", filial.Telefone.Id);
            command.Parameters.AddWithValue("@idfilial", filial.Id);

            command.ExecuteNonQuery();
        }

        internal void deletarFilial(int idFilial)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM filial WHERE id = @id";
            command.Parameters.AddWithValue("id", idFilial);

            int n = command.ExecuteNonQuery();
        }

        internal List<Filial> buscarFiliaisDaBarbearia(Barbearia barbearia)
        {
            List<Filial> filiais = new List<Filial>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM filial ");
            sql.Append("INNER JOIN filial_barbearia ON filial.Id = filial_barbearia.id_filial ");
            sql.Append("WHERE filial_barbearia.id_barbearia = @id");
            command.Parameters.AddWithValue("@id", barbearia.Id);

            command.CommandText = sql.ToString();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Filial filial = new Filial();
                filial.Id = (Int32)reader["Id"];
                filial.Nome = (String)reader["nome"];
                filial.Cnpj = (String)reader["cnpj"];
                filial.Endereco = (String)reader["endereco"];

                filiais.Add(filial);
            }

            FabricaConexao.CloseConnection(conexao);

            return filiais;
        }

        internal List<Filial> buscarFiliaisLike(string filtro)
        {
            List<Filial> filiais = new List<Filial>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM filial WHERE nome like @filtro";
            command.Parameters.AddWithValue("filtro", "%" + filtro + "%");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Filial filial = new Filial();
                filial.Id = (Int32) reader["Id"];
                filial.Nome = (String)reader["nome"];
                filial.Cnpj = (String) reader["cnpj"];
                filial.Endereco = (String)reader["endereco"];

                filiais.Add(filial);
            }

            FabricaConexao.CloseConnection(conexao);

            return filiais;
        }

        internal void atualizarFilial(Filial filial)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE filial SET nome = @nome, endereco = @endereco, cnpj = @cnpj WHERE id = @id";
            command.Parameters.AddWithValue("@id", filial.Id);
            command.Parameters.AddWithValue("@nome", filial.Nome);
            command.Parameters.AddWithValue("@endereco", filial.Endereco);
            command.Parameters.AddWithValue("@cnpj", filial.Cnpj);
            int n = command.ExecuteNonQuery();
        }

        internal Filial buscarFilialDoAtendente(Atendente atendente)
        {
            Filial filial = new Filial();


            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM filial ");
            sql.Append("INNER JOIN atendente_filial ON filial.Id = atendente_filial.id_filial ");
            sql.Append("WHERE id_atendente = @id");
            command.Parameters.AddWithValue("id", atendente.Id);

            command.CommandText = sql.ToString();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                filial.Id = (Int32)reader["Id"];
                filial.Nome = (String)reader["nome"];
                filial.Endereco = (String)reader["endereco"];
                filial.Cnpj = (String)reader["cnpj"];

                return filial;
            }

            return null;
        }

        internal void atualizarFilialDoAtendente(Atendente atendente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            if (tx != null)
            {
                command.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE atendente_filial ");
            sql.Append("SET id_filial = @idfilial ");
            sql.Append("WHERE id_atendente = @idatendente");
            command.Parameters.AddWithValue("idfilial", atendente.Filial.Id);
            command.Parameters.AddWithValue("idatendente", atendente.Id);

            command.CommandText = sql.ToString();
            command.ExecuteNonQuery();
        }

        internal void salvarFilialBarbearia(Filial filial)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.Transaction = this.tx;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO filial_barbearia(id_barbearia, id_filial) values(@idbarbearia, @idfilial)";
            command.Parameters.AddWithValue("@idbarbearia", filial.Barbearia.Id);
            command.Parameters.AddWithValue("@idfilial", filial.Id);

            command.ExecuteNonQuery();
        }

        internal Filial buscarFilial(int id)
        {
            Filial filial = new Filial();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM filial WHERE id = @id";
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            filial.Id = (Int32)reader["Id"];
            filial.Nome = (String)reader["nome"];
            filial.Cnpj = (String)reader["cnpj"];
            filial.Endereco = (String)reader["endereco"];

            return filial;
        }

        internal List<Filial> buscarTodasFiliais()
        {
            List<Filial> filiais = new List<Filial>();

            SqlCommand command = new SqlCommand();
            command.Connection = conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM filial";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Filial filial = new Filial();
                filial.Id = (Int32)reader["Id"];
                filial.Cnpj = (String)reader["cnpj"];
                filial.Nome = (String)reader["nome"];
                filial.Endereco = (String) reader["endereco"];

                filiais.Add(filial);
            }

            FabricaConexao.CloseConnection(conexao);

            return filiais;
        }
    }
}