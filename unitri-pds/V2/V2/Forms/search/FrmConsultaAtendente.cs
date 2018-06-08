using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
<<<<<<< HEAD

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
=======
>>>>>>> d70c839188ce89b46505b8e562dfb62a43c4fa66
    }
}
