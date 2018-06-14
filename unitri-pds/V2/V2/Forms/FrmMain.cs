using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Forms.graphics;
using V2.Forms.register;
using V2.Forms.reports;
using V2.Forms.search;

namespace V2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void atendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAtendente frmCadastroAtendente = new FrmCadastroAtendente();
            frmCadastroAtendente.MdiParent = this;
            frmCadastroAtendente.Show();
            frmCadastroAtendente.WindowState = FormWindowState.Maximized;

        }

        private void barbeariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroBarbearia frmCadastroBarbearia = new FrmCadastroBarbearia();
            frmCadastroBarbearia.MdiParent = this;
            frmCadastroBarbearia.Show();
            frmCadastroBarbearia.WindowState = FormWindowState.Maximized;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.MdiParent = this;
            frmCadastroCliente.Show();
            frmCadastroCliente.WindowState = FormWindowState.Maximized;
        }

        private void filialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroFilial frmCadastroFilial = new FrmCadastroFilial();
            frmCadastroFilial.MdiParent = this;
            frmCadastroFilial.Show();
            frmCadastroFilial.WindowState = FormWindowState.Maximized;
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPedido frmCadastroPedido = new FrmCadastroPedido();
            frmCadastroPedido.MdiParent = this;
            frmCadastroPedido.Show();
            frmCadastroPedido.WindowState = FormWindowState.Maximized;
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frmCadastroProduto = new FrmCadastroProduto();
            frmCadastroProduto.MdiParent = this;
            frmCadastroProduto.Show();
            frmCadastroProduto.WindowState = FormWindowState.Maximized;
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroServico frmCadastroServico = new FrmCadastroServico();
            frmCadastroServico.MdiParent = this;
            frmCadastroServico.Show();
            frmCadastroServico.WindowState = FormWindowState.Maximized;
        }

        private void atendenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendente frmConsultaAtendente = new FrmConsultaAtendente();
            frmConsultaAtendente.MdiParent = this;
            frmConsultaAtendente.Show();
            frmConsultaAtendente.WindowState = FormWindowState.Maximized;
        }

        private void barbeariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaBarbearia frmConsultaBarbearia = new FrmConsultaBarbearia();
            frmConsultaBarbearia.MdiParent = this;
            frmConsultaBarbearia.Show();
            frmConsultaBarbearia.WindowState = FormWindowState.Maximized;
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frmConsultaCliente = new FrmConsultaCliente();
            frmConsultaCliente.MdiParent = this;
            frmConsultaCliente.Show();
            frmConsultaCliente.WindowState = FormWindowState.Maximized;
        }

        private void filialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaFilial frmConsultaFilial = new FrmConsultaFilial();
            frmConsultaFilial.MdiParent = this;
            frmConsultaFilial.Show();
            frmConsultaFilial.WindowState = FormWindowState.Maximized;
        }

        private void serviçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaProduto frmConsultaProduto = new FrmConsultaProduto();
            frmConsultaProduto.MdiParent = this;
            frmConsultaProduto.Show();
            frmConsultaProduto.WindowState = FormWindowState.Maximized;
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaPedido frmConsultaPedido = new FrmConsultaPedido();
            frmConsultaPedido.MdiParent = this;
            frmConsultaPedido.Show();
            frmConsultaPedido.WindowState = FormWindowState.Maximized;
        }

        private void serviçoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultaServico frmConsultaServico = new FrmConsultaServico();
            frmConsultaServico.MdiParent = this;
            frmConsultaServico.Show();
            frmConsultaServico.WindowState = FormWindowState.Maximized;
        }

        private void vendaPorAtendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGraficoQuantidadeVendasPorAtendente frmVendasPorAtendente = new FrmGraficoQuantidadeVendasPorAtendente();
            frmVendasPorAtendente.MdiParent = this;
            frmVendasPorAtendente.Show();
            frmVendasPorAtendente.WindowState = FormWindowState.Maximized;
        }

        private void vendasPorFilialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGraficoFaturamentoDasFiliais frmGraficoFaturamentoDasFiliais = new FrmGraficoFaturamentoDasFiliais();
            frmGraficoFaturamentoDasFiliais.MdiParent = this;
            frmGraficoFaturamentoDasFiliais.Show();
            frmGraficoFaturamentoDasFiliais.WindowState = FormWindowState.Maximized;
        }

        private void faturamentoBarbeariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGraficoFaturamentoDasBarbearias frmGraficoFaturamentoDasBarbearias = new FrmGraficoFaturamentoDasBarbearias();
            frmGraficoFaturamentoDasBarbearias.MdiParent = this;
            frmGraficoFaturamentoDasBarbearias.Show();
            frmGraficoFaturamentoDasBarbearias.WindowState = FormWindowState.Maximized;
        }

        private void pedidosEmPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportPedidosEntrePeriodos frmReportPedidosEntrePeriodos = new FrmReportPedidosEntrePeriodos();
            frmReportPedidosEntrePeriodos.MdiParent = this;
            frmReportPedidosEntrePeriodos.Show();
            frmReportPedidosEntrePeriodos.WindowState = FormWindowState.Maximized;
        }

        private void pedidosPorFilialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportPedidosPorFilial frmReportPedidosPorFilial = new FrmReportPedidosPorFilial();
            frmReportPedidosPorFilial.MdiParent = this;
            frmReportPedidosPorFilial.Show();
            frmReportPedidosPorFilial.WindowState = FormWindowState.Maximized;
        }

        private void pedidosPorAtendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportPedidosPorAtendente frmReportPedidosPorAtendente = new FrmReportPedidosPorAtendente();
            frmReportPedidosPorAtendente.MdiParent = this;
            frmReportPedidosPorAtendente.Show();
            frmReportPedidosPorAtendente.WindowState = FormWindowState.Maximized;
        }
    }
}
