using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            MessageBox.Show("Not implemented.");
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

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void serviçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void serviçoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void telefoneToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
