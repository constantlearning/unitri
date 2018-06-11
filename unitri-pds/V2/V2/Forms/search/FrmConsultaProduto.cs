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
    public partial class FrmConsultaProduto : Form
    {
        public FrmConsultaProduto()
        {
            InitializeComponent();
        }

        private void FrmConsultaProduto_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String filtro = txtBuscar.Text;
            dgvCliente.DataSource = ProdutoService.ObterProdutosLike(filtro);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Int32 idProduto = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            ProdutoService.DeletarProduto(idProduto);
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
            Int32 idProduto = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

            FrmEditarProduto frmEditarProduto = new FrmEditarProduto();
            frmEditarProduto.idProduto = idProduto;
            frmEditarProduto.MdiParent = this.ParentForm;
            frmEditarProduto.Show();
            frmEditarProduto.WindowState = FormWindowState.Maximized;
        }

        private void FrmConsultaProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void atualizarGrid()
        {
            dgvCliente.DataSource = ProdutoService.BuscarTodosProdutos();
        }
    }
}
