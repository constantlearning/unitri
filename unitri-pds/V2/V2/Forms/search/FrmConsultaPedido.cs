using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Source.domain;
using V2.Source.service;

namespace V2.Forms.search
{
    public partial class FrmConsultaPedido : Form
    {
        public FrmConsultaPedido()
        {
            InitializeComponent();
        }

        private List<Pedido> pedidos;

        private void FrmConsultaPedido_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Int32 idPedido = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            PedidoService.DeletarPedido(idPedido);
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
            pedidos = PedidoService.BuscarTodosPedidos();
            dgvCliente.DataSource = pedidos;
        }

        private void FrmConsultaPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
