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
            throw new NotImplementedException();
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