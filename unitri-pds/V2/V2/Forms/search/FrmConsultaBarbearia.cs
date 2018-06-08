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

namespace V2.Forms.search
{
    public partial class FrmConsultaBarbearia : Form
    {
        public FrmConsultaBarbearia()
        {
            InitializeComponent();
        }

        private void FrmConsultaBarbearia_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Int32 idBarbearia = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            BarbeariaService.DeletarBarbearia(idBarbearia);
            atualizarGrid();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String nome = txtBuscar.Text;
            dgvCliente.DataSource = BarbeariaService.obterBarbeariasLike(nome);
        }

        private void atualizarGrid()
        {
            dgvCliente.DataSource = BarbeariaService.BuscarTodasBarbearias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmConsultaBarbearia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
