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
    public partial class FrmConsultaServico : Form
    {
        public FrmConsultaServico()
        {
            InitializeComponent();
        }

        private void FrmConsultaServico_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String filtro = txtBuscar.Text;
            dgvCliente.DataSource = ServicoService.ObterServicosLike(filtro);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Int32 idServico = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            ServicoService.DeletarServico(idServico);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Int32 idServico = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

            FrmEditarServico frmEditarServico = new FrmEditarServico();
            frmEditarServico.idServico = idServico;
            frmEditarServico.MdiParent = this.ParentForm;
            frmEditarServico.Show();
            frmEditarServico.WindowState = FormWindowState.Maximized;
        }

        private void atualizarGrid()
        {
            dgvCliente.DataSource = ServicoService.BuscarTodosServicos();
        }

        private void FrmConsultaServico_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
