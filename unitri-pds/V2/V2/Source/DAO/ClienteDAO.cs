using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using V2.Source.domain;
using V2.Source.util;

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

        internal void deletarCliente(int idCliente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM cliente WHERE id = @id";
            command.Parameters.AddWithValue("id", idCliente);

            int n = command.ExecuteNonQuery();
        }

        internal List<Cliente> BuscarTodosClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            SqlCommand command = new SqlCommand();
            command.Connection = conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM cliente";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = (Int32)reader["Id"];
                cliente.Cpf = (String)reader["cpf"];
                cliente.Nome = (String)reader["nome"];
                cliente.Nascimento = (DateTime)reader["nascimento"];

                clientes.Add(cliente);
            }

            FabricaConexao.CloseConnection(conexao);

            return clientes;
        }

        internal Cliente buscarClienteDoPedido(Pedido pedido)
        {
            Cliente cliente = new Cliente(); ;

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT* FROM cliente ");
            sql.Append("INNER JOIN pedido ON pedido.id_cliente = cliente.Id ");
            sql.Append("WHERE pedido.Id = @id");
            command.Parameters.AddWithValue("@id", pedido.Id);

            command.CommandText = sql.ToString();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                cliente.Id = (Int32)reader["Id"];
                cliente.Cpf = (String)reader["cpf"];
                cliente.Nome = (String)reader["nome"];
                cliente.Nascimento = (DateTime)reader["nascimento"];

                return cliente;
            }

            return null;
        }

        internal void atualizarCliente(Cliente cliente)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE cliente SET nome = @nome, cpf = @cpf, nascimento = @nascimento WHERE id = @id";
            command.Parameters.AddWithValue("@id", cliente.Id);
            command.Parameters.AddWithValue("@nome", cliente.Nome);
            command.Parameters.AddWithValue("@cpf", cliente.Cpf);
            command.Parameters.AddWithValue("@nascimento", cliente.Nascimento);
            int n = command.ExecuteNonQuery();
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

        internal List<Cliente> buscarClientesLike(string filtro)
        {
            List<Cliente> clientes = new List<Cliente>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM cliente WHERE nome like @filtro";
            command.Parameters.AddWithValue("filtro", "%" + filtro + "%");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = (Int32)reader["Id"];
                cliente.Cpf = (String)reader["cpf"];
                cliente.Nome = (String)reader["nome"];
                cliente.Nascimento = (DateTime)reader["nascimento"];

                clientes.Add(cliente);
            }

            return clientes;
        }

        internal Cliente buscarCliente(int id)
        {
            Cliente cliente = new Cliente();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM cliente WHERE id = @id";
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            cliente.Id = (Int32)reader["Id"];
            cliente.Cpf = (String)reader["cpf"];
            cliente.Nome = (String)reader["nome"];
            cliente.Nascimento = (DateTime)reader["nascimento"];

            return cliente;
        }
    }
}