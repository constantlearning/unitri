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
    public partial class FrmEditarBarbearia : Form
    {
        public FrmEditarBarbearia()
        {
            InitializeComponent();
        }

        internal Int32 idBarbearia;
        private Barbearia barbearia;

        private void FrmEditarBarbearia_Load(object sender, EventArgs e)
        {
            this.barbearia = BarbeariaService.BuscarBarbearia(idBarbearia);
            tbNome.Text = barbearia.Nome;
            mtbCNPJ.Text = barbearia.Cnpj;
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

                this.barbearia.Nome = tbNome.Text;
                this.barbearia.Cnpj = mtbCNPJ.Text
                    .Replace(".", "")
                    .Replace("/", "")
                    .Replace("-", "");

                try
                {
                    BarbeariaService.AtualizarBarbearia(barbearia);

                    MessageBox.Show("Atualizado com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmEditarBarbearia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
