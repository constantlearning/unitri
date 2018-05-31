using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2.Forms.Cadastro
{
    public partial class FrmCadastroVeículo : Form
    {
        public FrmCadastroVeículo()
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
            DialogResult dialogResult = MessageBox.Show("Aviso!", "Deseja cancelar?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String placa = mtxtPlaca.Text;
                String marcaVeiculo = txtMarcaVeiculo.Text;
                DateTime dataModelo = this.dataModelo.Value;
                DateTime dataFabricacao = this.dataFabricacao.Value;

                try
                {
                    CadastroService.SalvarVeiculo(placa, marcaVeiculo, dataModelo, dataFabricacao);
                    MessageBox.Show("Salvo com sucesso!");
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
