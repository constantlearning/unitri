using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Forms.Cadastro;
using V2.Source.Entity;

namespace V2
{
    public partial class FrmMain : Form
    {
        internal Funcionario funcionario;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void conveniadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroConveniada frmCadastroConveniada = new FrmCadastroConveniada();
            frmCadastroConveniada.ShowDialog();
            this.Show();
        }

        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroMotorista frmCadastroMotorista = new FrmCadastroMotorista();
            frmCadastroMotorista.ShowDialog();
            this.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();
            frmCadastroFuncionario.ShowDialog();
            this.Show();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroVeículo frmCadastroVeículo = new FrmCadastroVeículo();
            frmCadastroVeículo.ShowDialog();
            this.Show();
        }

        private void habilitaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroHabilitacao frmCadastroHabilitacao = new FrmCadastroHabilitacao();
            frmCadastroHabilitacao.ShowDialog();
            this.Show();
        }

        private void chamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroChamado frmCadastroChamado = new FrmCadastroChamado();
            frmCadastroChamado.funcionario = funcionario;
            frmCadastroChamado.ShowDialog();
            this.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja sair?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbNomeFuncionario.Text = funcionario.Nome;
        }
    }
}
