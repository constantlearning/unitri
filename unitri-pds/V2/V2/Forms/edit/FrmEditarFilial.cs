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
    public partial class FrmEditarFilial : Form
    {
        public FrmEditarFilial()
        {
            InitializeComponent();
        }

        public Int32 idFilial;
        internal Filial filial;

        private void FrmEditarFilial_Load(object sender, EventArgs e)
        {
            this.filial = FilialService.BuscarFilial(this.idFilial);
            tbNome.Text = filial.Nome;
            tbEndereco.Text = filial.Endereco;
            mtbCNPJ.Text = filial.Cnpj;

            filial.Barbearia = BarbeariaService.BuscarBarbeariaDaFilial(filial);
            filial.Telefone = TelefoneService.BuscarTelefoneDaFilial(filial);

            mtbTelefone.Text = filial.Telefone.Numero;
            cbBarbearias.DataSource = BarbeariaService.BuscarTodasBarbearias();
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
                this.filial.Nome = tbNome.Text;
                this.filial.Endereco = tbEndereco.Text;
                this.filial.Cnpj = mtbCNPJ.Text
                    .Replace(".", "")
                    .Replace("/", "")
                    .Replace("-", "");

                this.filial.Barbearia = (Barbearia)cbBarbearias.SelectedValue;
                this.filial.Telefone.Numero = mtbTelefone.Text
                    .Replace("(", "")
                    .Replace(")", "")
                    .Replace("-", "");

                try
                {
                    FilialService.AtualizarFilial(filial);

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
