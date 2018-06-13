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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void atualizarGrid()
        {
            pedidos = PedidoService.BuscarTodosPedidos();
        }
    }
}
