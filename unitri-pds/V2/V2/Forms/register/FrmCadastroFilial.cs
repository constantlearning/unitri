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

namespace V2.Forms.register
{
    public partial class FrmCadastroFilial : Form
    {
        public FrmCadastroFilial()
        {
            InitializeComponent();
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

                String nome = tbNome.Text;
                String endereco = tbEndereco.Text;
                String cnpj = mtbCNPJ.Text
                    .Replace("-", "")
                    .Replace(".", "")
                    .Replace("/", "");
                Barbearia barbearia = (Barbearia)cbBarbearias.SelectedValue;


                Filial filial = new Filial();
                filial.Nome = nome;
                filial.Cnpj = cnpj;
                filial.Endereco = endereco;
                filial.Barbearia = barbearia;

                try
                {
                    FilialService.SalvarFilial(filial);

                    MessageBox.Show("Salvo com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmCadastroFilial_Load(object sender, EventArgs e)
        {

            List<Barbearia> barbearias = BarbeariaService.BuscarTodasBarbearias();
            cbBarbearias.DataSource = barbearias;
        }
    }
}
