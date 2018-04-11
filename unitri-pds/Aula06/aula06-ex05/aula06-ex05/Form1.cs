using aula06_ex05.repository;
using aula06_ex05.repository.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula06_ex05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConnectionFactory.GetConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from cliente";
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32(0);
                    cliente.Nome = reader.GetString(1);
                    cliente.Telefone = reader.GetString(2);
                    clientes.Add(cliente);
                }

                dataGridView1.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                ConnectionFactory.CloseConnection(connection);
            }
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            String nome = txtProcurar.Text;

            SqlConnection connection = null;
            try
            {
                connection = ConnectionFactory.GetConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                // SELECT * FROM cliente WHERE nome LIKE '%L%';
                command.CommandText = "SELECT * FROM cliente WHERE nome = @nome";
                command.Parameters.AddWithValue("nome", nome);
                SqlDataReader reader = command.ExecuteReader();

                List<Cliente> clientes = new List<Cliente>();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32(0);
                    cliente.Nome = reader.GetString(1);
                    cliente.Telefone = reader.GetString(2);
                    clientes.Add(cliente);
                }

                dataGridView1.DataSource = clientes;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                ConnectionFactory.CloseConnection(connection);
            }
        }
    }
}
