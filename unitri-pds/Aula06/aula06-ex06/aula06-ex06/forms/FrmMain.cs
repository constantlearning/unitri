using aula06_ex06.forms;
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

namespace aula06_ex06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String nome = txtBuscar.Text;
            dgvCliente.DataSource = ConnectionFactory.obterClientesLike(nome);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();

            Cliente cliente = frmCliente.cliente;

            ConnectionFactory.adicionarCliente(cliente);

            atualizarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Int32 idCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

            FrmCliente frmCliente = new FrmCliente();
            frmCliente.id = idCliente;
            frmCliente.ShowDialog();

            Cliente cliente = frmCliente.cliente;

            ConnectionFactory.atualizarCliente(cliente);

            atualizarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Int32 idCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

            ConnectionFactory.deletarCliente(idCliente);

            atualizarGrid();
        }

        private void atualizarGrid()
        {
            dgvCliente.DataSource = ConnectionFactory.obterTodosOsClientes();
        }
    }
}
