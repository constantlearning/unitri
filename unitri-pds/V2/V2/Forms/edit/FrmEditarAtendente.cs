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

        private void FrmCadastroAtendente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        internal Int32 idAtendente;
        private Atendente atendente;

        private void FrmEditarAtendente_Load(object sender, EventArgs e)
        {
            this.atendente = AtendenteService.BuscarAtendente(this.idAtendente);
            tbNome.Text = atendente.Nome;
            mtbCPF.Text = atendente.Cpf;
            dtNascimento.Value = atendente.Nascimento;

            atendente.Filial = FilialService.BuscarFilialDoAtendente(atendente);
            atendente.Telefone = TelefoneService.BuscarTelefoneDoAtendente(atendente);

            mtbTelefone.Text = atendente.Telefone.Numero;
            cbFilial.DataSource = FilialService.buscarTodasFiliais();
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
                this.atendente.Nome = tbNome.Text;
                this.atendente.Cpf = mtbCPF.Text.Replace("-", "");
                this.atendente.Nascimento = dtNascimento.Value;
                this.atendente.Telefone.Numero = mtbTelefone.Text
                    .Replace("(", "")
                    .Replace(")", "")
                    .Replace("-", "");
                this.atendente.Filial = (Filial)cbFilial.SelectedValue;

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
