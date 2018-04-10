using aula06_ex03.repository;
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

namespace aula06_ex03
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
            String tel = txtTelefone.Text;

            SqlConnection connection = null;

            try
            {
                connection = ConnectionFactory.GetConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into cliente (nome, telefone) values (@nome, @telefone)";
                command.Parameters.AddWithValue("nome", nome);
                command.Parameters.AddWithValue("telefone", tel);

                int n = command.ExecuteNonQuery();
                MessageBox.Show("Usuário inserido na base!");
                clearFields();
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

        private void clearFields()
        {
            txtNome.Clear();
            txtTelefone.Clear();
        }
    }
}
