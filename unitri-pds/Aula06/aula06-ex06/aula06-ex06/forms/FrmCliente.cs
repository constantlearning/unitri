using aula06_ex06.repository;
using aula06_ex06.repository.entity;
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

namespace aula06_ex06.forms
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        internal Cliente cliente;
        internal Int32 id;

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                this.cliente = ConnectionFactory.obterClientePeloId(id);
            }
            else
            {
                cliente = new Cliente();
            }

            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;

            this.Close();
        }

    }
}
