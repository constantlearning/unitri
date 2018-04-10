using aula06_ex01.repository;
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

namespace aula06_ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = null;

        private void btnConectar_Click(object sender, EventArgs e)
        {

            try
            {
                connection = ConnectionFactory.getConexao();
                lblStatusConexao.Text = "Conectado";
            }
            catch (Exception ex)
            {
                lblStatusConexao.Text = "Falha";
            }
            finally
            {
                ConnectionFactory.closeConnection(connection);
            }
        }
    }
}
