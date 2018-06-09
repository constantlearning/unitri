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

namespace V2.Forms.reports
{
    public partial class FrmConsultaAtendente : Form
    {
        public FrmConsultaAtendente()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String nome = txtBuscar.Text;
            dgvCliente.DataSource = AtendenteService.obterClientesLike(nome);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Int32 idAtendente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

            FrmEditarAtendente frmEditarAtendente = new FrmEditarAtendente();
            frmEditarAtendente.idAtendente = idAtendente;
            frmEditarAtendente.MdiParent = this.ParentForm;
            frmEditarAtendente.Show();
            frmEditarAtendente.WindowState = FormWindowState.Maximized;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Int32 idAtendente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            AtendenteService.DeletarCliente(idAtendente);
            atualizarGrid();
        }

        private void FrmConsultaAtendente_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            dgvCliente.DataSource = AtendenteService.BuscarTodosAtendentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmConsultaAtendente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
