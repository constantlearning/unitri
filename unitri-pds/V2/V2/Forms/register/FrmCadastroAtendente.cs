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

namespace V2.Forms.register
{
    public partial class FrmCadastroAtendente : Form
    {
        public FrmCadastroAtendente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja salvar?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                String nome = tbNome.Text;
                String cpf = mtbCPF.Text.Replace("-", "");
                DateTime nascimento = dtNascimento.Value;

                try
                {
                    AtendenteService.SalvarAtendente(nome, cpf, nascimento);

                    MessageBox.Show("Salvo com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void FrmCadastroAtendente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

    }
}
