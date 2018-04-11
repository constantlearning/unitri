using aula06_ex02.repository;
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

namespace aula06_ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String telefone = txtTelefone.Text;

            SqlConnection connection = null;
            try
            {
                connection = ConnectionFactory.GetConnection();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Cliente (Nome, Telefone) values ('" + nome + "', '" + telefone +"')";
                int n = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                txtNome.Text = "";
                txtTelefone.Text = "";
                ConnectionFactory.CloseConnection(connection);
            }

        }
    }
}
