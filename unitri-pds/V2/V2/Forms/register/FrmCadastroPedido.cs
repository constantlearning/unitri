using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2.Forms.register
{
    public partial class FrmCadastroPedido : Form
    {
        public FrmCadastroPedido()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroPedido_Load(object sender, EventArgs e)
        {
            // Carregar clientes e setar no combobox.
            // Carregar barbearias e setar no combobox responsável.
        }

        private void cbBarbearias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Carregar filiais dessa barbearia
        }

        private void cbFiliais_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Carregar Atendentes dessa filial.
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverServico_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }


    }
}
