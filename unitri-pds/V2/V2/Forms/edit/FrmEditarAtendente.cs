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

namespace V2.Forms.edit
{
    public partial class FrmEditarAtendente : Form
    {
        public FrmEditarAtendente()
        {
            InitializeComponent();
        }

        internal Int32 idAtendente;

        private void FrmCadastroAtendente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void FrmEditarAtendente_Load(object sender, EventArgs e)
        {
            Atendente atendente = AtendenteService.BuscarAtendente(this.idAtendente);
            tbNome.Text = atendente.Nome;
            mtbCPF.Text = atendente.Cpf;
            dtNascimento.Value = atendente.Nascimento;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
                Atendente atendente = new Atendente();
                atendente.Id = idAtendente;
                atendente.Nome = tbNome.Text;
                atendente.Cpf = mtbCPF.Text.Replace("-", "");
                atendente.Nascimento = dtNascimento.Value;

                try
                {
                    AtendenteService.AtualizarAtendente(atendente);

                    MessageBox.Show("Atualizado com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
