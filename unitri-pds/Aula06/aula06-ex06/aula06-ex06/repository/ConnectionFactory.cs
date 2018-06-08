using aula06_ex06.repository.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06_ex06.repository
{
    class ConnectionFactory
    {
        private static String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\github\unitri\unitri-pds\Aula06\aula06-ex06\aula06-ex06\aula06ex06.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex) { }
        }

        public static List<Cliente> obterTodosOsClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            SqlConnection connection = null;
            try
            {
                connection = ConnectionFactory.GetConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM cliente";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32(0);
                    cliente.Nome = reader.GetString(1);
                    cliente.Telefone = reader.GetString(2);
                    clientes.Add(cliente);
                }
            }
            catch (Exception ex) { }
            finally
            {
                ConnectionFactory.CloseConnection(connection);
            }
            return clientes;
        }

        internal static object obterClientesLike(string filtro)
        {
            List<Cliente> clientes = new List<Cliente>();

            SqlConnection connection = null;
            try
            {
                connection = ConnectionFactory.GetConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM cliente WHERE nome like @filtro";
                command.Parameters.AddWithValue("filtro", "%" + filtro + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32(0);
                    cliente.Nome = reader.GetString(1);
                    cliente.Telefone = reader.GetString(2);
                    clientes.Add(cliente);
                }
            }
            catch (Exception ex) { }
            finally
            {
                ConnectionFactory.CloseConnection(connection);
            }
            return clientes;
        }

        public static Cliente obterClientePeloId(Int32 id)
        {
            SqlConnection connection = null;
            Cliente cliente = new Cliente();

            try
            {
                connection = ConnectionFactory.GetConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM cliente WHERE id = @id";
                command.Parameters.AddWithValue("id", id);
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                cliente.Id = reader.GetInt32(0);
                cliente.Nome = reader.GetString(1);
                cliente.Telefone = reader.GetString(2);
            }
            catch (Exception ex) { }
            finally
            {
                ConnectionFactory.CloseConnection(connection);
            }

            return cliente;
        }

        public static void deletarCliente(int idCliente)
        {
            SqlConnection connection = null;

            try
            {
                connection = ConnectionFactory.GetConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM cliente WHERE id = @id";
                command.Parameters.AddWithValue("id", idCliente);

                int n = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                ConnectionFactory.CloseConnection(connection);
            }
        }

        public static void adicionarCliente(Cliente cliente)
        {
            SqlConnection connection = null;

            try
            {
                connection = ConnectionFactory.GetConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into cliente (nome, telefone) values (@nome, @telefone)";
                command.Parameters.AddWithValue("nome", cliente.Nome);
                command.Parameters.AddWithValue("telefone", cliente.Telefone);

                int n = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                ConnectionFactory.CloseConnection(connection);
            }
        }

        public static void atualizarCliente(Cliente cliente)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConnectionFactory.GetConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "update cliente set nome = @nome, telefone = @telefone where id = @id";
                command.Parameters.AddWithValue("nome", cliente.Nome);
                command.Parameters.AddWithValue("telefone", cliente.Telefone);
                command.Parameters.AddWithValue("id", cliente.Id);

                int n = command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally
            {
                ConnectionFactory.CloseConnection(connection);
            }
        }
    }
}
