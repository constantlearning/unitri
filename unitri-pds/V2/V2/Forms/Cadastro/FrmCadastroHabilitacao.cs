using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Source.Entity;
using V2.Source.Service;

namespace V2.Forms.Cadastro
{
    public partial class FrmCadastroHabilitacao : Form
    {
        public FrmCadastroHabilitacao()
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

                Motorista motorista = (Motorista) cbMotoristas.SelectedItem;
                String categoria = txtCategoriaCnh.Text;
                DateTime emissao = dataEmissao.Value;
                DateTime validade = dataValidade.Value;

                try
                {
                    CadastroService.SalvarHabilitacao(motorista, categoria, emissao, validade);
                    MessageBox.Show("Salvo com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmCadastroHabilitacao_Load(object sender, EventArgs e)
        {
            cbMotoristas.DataSource = ConsultaService.BuscarMotoristas();
        }
    }
}
