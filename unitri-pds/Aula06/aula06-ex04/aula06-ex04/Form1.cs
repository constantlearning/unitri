using aula06_ex04.repository;
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

namespace aula06_ex04
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
                SqlDataReader dataReader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();

                while (dataReader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = dataReader.GetInt32(0);
                    cliente.Nome = dataReader.GetString(1);
                    cliente.Telefone = dataReader.GetString(2);
                    clientes.Add(cliente);
                }
                dtgClientes.DataSource = clientes;

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
