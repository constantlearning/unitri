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
using V2.Forms.register;
using V2.Source.service;

namespace V2.Forms.search
{
    public partial class FrmConsultaFilial : Form
    {
        public FrmConsultaFilial()
        {
            InitializeComponent();
        }

        private void FrmConsultaFilial_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String nome = txtBuscar.Text;
            dgvCliente.DataSource = FilialService.obterFiliaisLike(nome);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Int32 idFilial = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

            FrmEditarFilial frmEditarFilial = new FrmEditarFilial();
            frmEditarFilial.idFilial = idFilial;
            frmEditarFilial.MdiParent = this.ParentForm;
            frmEditarFilial.Show();
            frmEditarFilial.WindowState = FormWindowState.Maximized;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Int32 idFilial = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            FilialService.DeletarFilial(idFilial);
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

        private void atualizarGrid()
        {
            dgvCliente.DataSource = FilialService.buscarTodasFiliais();
        }

        private void FrmConsultaFilial_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
