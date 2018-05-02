using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex03.src.Repository
{
    class ClienteDAO
    {

        private SqlConnection conexao;
        private SqlTransaction tx;

        public ClienteDAO(SqlConnection con)
        {
            this.conexao = con;
        }

        public ClienteDAO(SqlConnection con, SqlTransaction tx)
        {
            this.conexao = con;
            this.tx = tx;
        }

        public List<Cliente> obterClientes()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;

            if (tx != null)
            {
                comando.Transaction = tx;
            }

            comando.CommandText = "SELECT * FROM Cliente";
            SqlDataReader reader = comando.ExecuteReader();

            List<Cliente> clientes = new List<Cliente>();

            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = (Int32)reader["id"];
                cliente.Nome = (String)reader["nome"];
                cliente.Telefone = (String)reader["telefone"];
                cliente.Cpf = (Int32)reader["cpf"];
                cliente.Endereco = (String)reader["endereco"];
                clientes.Add(cliente);
            }

            return clientes;
        }

    }
}
