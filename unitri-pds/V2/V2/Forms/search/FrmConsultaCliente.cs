using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Forms.edit;
using V2.Source.service;

namespace V2.Forms.search
{
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String nome = txtBuscar.Text;
            dgvCliente.DataSource = ClienteService.obterClientesLike(nome);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Int32 idCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

            FrmEditarCliente frmEditarCliente = new FrmEditarCliente();
            frmEditarCliente.idCliente = idCliente;
            frmEditarCliente.MdiParent = this.ParentForm;
            frmEditarCliente.Show();
            frmEditarCliente.WindowState = FormWindowState.Maximized;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Int32 idCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            ClienteService.DeletarCliente(idCliente);
            atualizarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            dgvCliente.DataSource = ClienteService.BuscarTodosClientes();
        }

        private void FrmConsultaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
