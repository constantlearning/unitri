using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class TelefoneDAO
    {
        private SqlConnection conexao;
        private SqlTransaction tx;

        public TelefoneDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public TelefoneDAO(SqlConnection conexao, SqlTransaction tx) : this(conexao)
        {
            this.tx = tx;
        }

        internal Telefone buscarTelefoneDoAtendente(Atendente atendente)
        {
            Telefone telefone = new Telefone();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM telefone ");
            sql.Append("INNER JOIN telefone_atendente ON telefone.Id = telefone_atendente.id_atendente ");
            sql.Append("WHERE id_atendente = @id");
            command.Parameters.AddWithValue("id", atendente.Id);

            command.CommandText = sql.ToString();
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            telefone.Id = (Int32)reader["Id"];
            telefone.Numero = (String)reader["numero"];

            return telefone;
        }

        internal Telefone buscarTelefoneDoCliente(Cliente cliente)
        {
            Telefone telefone = new Telefone();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM telefone ");
            sql.Append("INNER JOIN telefone_cliente ON telefone.Id = telefone_cliente.id_cliente ");
            sql.Append("WHERE id_cliente = @id");
            command.Parameters.AddWithValue("id", cliente.Id);

            command.CommandText = sql.ToString();
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            telefone.Id = (Int32)reader["Id"];
            telefone.Numero = (String)reader["numero"];

            return telefone;
        }

        internal void salvarTelefone(Telefone telefone)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO telefone(numero)");
            sql.Append("VALUES (@numero)");
            sql.Append("SELECT @@identity from telefone");
            command.CommandText = sql.ToString();
            command.Parameters.AddWithValue("@numero", telefone.Numero);

            decimal id = (decimal)command.ExecuteScalar();
            telefone.Id = Convert.ToInt32(id);
        }

        internal void atualizarTelefoneDoCliente(Cliente cliente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            if (tx != null)
            {
                command.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE telefone_cliente ");
            sql.Append("SET id_telefone = @idtelefone ");
            sql.Append("WHERE id_cliente = @idcliente");
            command.Parameters.AddWithValue("idtelefone", cliente.Telefone.Id);
            command.Parameters.AddWithValue("idcliente", cliente.Id);

            command.CommandText = sql.ToString();
            command.ExecuteNonQuery();
        }

        internal Telefone buscarTelefone(int id)
        {
            throw new NotImplementedException();
        }

        internal void atualizarTelefoneDoAtendente(Atendente atendente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            if (tx != null)
            {
                command.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE telefone_atendente ");
            sql.Append("SET id_telefone = @idtelefone ");
            sql.Append("WHERE id_atendente = @idatendente");
            command.Parameters.AddWithValue("idtelefone", atendente.Telefone.Id);
            command.Parameters.AddWithValue("idatendente", atendente.Id);

            command.CommandText = sql.ToString();
            command.ExecuteNonQuery();
        }
    }
}