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
    public partial class FrmEditarCliente : Form
    {
        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        internal Int32 idCliente;
        private Cliente cliente;

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            this.cliente = ClienteService.BuscarCliente(idCliente);
            tbNome.Text = cliente.Nome;
            mtbCPF.Text = cliente.Cpf;
            dtNascimento.Value = cliente.Nascimento;

            cliente.Telefone = TelefoneService.BuscarTelefoneDoCliente(cliente);

            mtbTelefone.Text = cliente.Telefone.Numero;
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
                this.cliente.Nome = tbNome.Text;
                this.cliente.Cpf = mtbCPF.Text.Replace("-", "");
                this.cliente.Nascimento = dtNascimento.Value;
                this.cliente.Telefone.Numero = mtbTelefone.Text
                    .Replace("(", "")
                    .Replace(")", "")
                    .Replace("-", "");

                try
                {
                    ClienteService.AtualizarCliente(cliente);

                    MessageBox.Show("Atualizado com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmEditarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
