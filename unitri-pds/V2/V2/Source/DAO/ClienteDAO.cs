using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class ClienteDAO
    {
        private SqlConnection conexao;
        private SqlTransaction tx;

        public ClienteDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public ClienteDAO(SqlConnection conexao, SqlTransaction tx) : this(conexao)
        {
            this.tx = tx;
        }

        internal void salvarCliente(Cliente cliente)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO cliente(nome, cpf, nascimento)");
            sql.Append("VALUES (@nome, @cpf, @nascimento)");
            sql.Append("SELECT @@identity from cliente");
            command.CommandText = sql.ToString();
            command.Parameters.AddWithValue("@nome", cliente.Nome);
            command.Parameters.AddWithValue("@cpf", cliente.Cpf);
            command.Parameters.AddWithValue("@nascimento", cliente.Nascimento);

            decimal id = (decimal)command.ExecuteScalar();
            cliente.Id = Convert.ToInt32(id);
        }

        internal void salvarClienteTelefone(Cliente cliente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.Transaction = this.tx;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO telefone_cliente(id_telefone, id_cliente) values(@idtelefone, @idcliente)";
            command.Parameters.AddWithValue("@idtelefone", cliente.Telefone.Id);
            command.Parameters.AddWithValue("@idcliente", cliente.Id);

            command.ExecuteNonQuery();
        }

        internal Cliente buscarCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}