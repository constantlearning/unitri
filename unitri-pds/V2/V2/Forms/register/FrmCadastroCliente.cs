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
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
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
                String cpf = mtbCPF.Text.Replace("-", "");
                DateTime nascimento = dtNascimento.Value;
                Telefone telefone = new Telefone();
                telefone.Numero = mtbTelefone.Text
                    .Replace("(", "")
                    .Replace(")", "")
                    .Replace("-", "");

                Cliente cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Cpf = cpf;
                cliente.Nascimento = nascimento;
                cliente.Telefone = telefone;

                try
                {
                    ClienteService.SalvarCliente(cliente);

                    MessageBox.Show("Salvo com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rbResidencial_CheckedChanged(object sender, EventArgs e)
        {
            mtbTelefone.Mask = "(00)0000-0000";
        }

        private void rbCelular_CheckedChanged(object sender, EventArgs e)
        {
            mtbTelefone.Mask = "(00)00000-0000";
        }
    }
}
