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
    public partial class FrmEditarServico : Form
    {
        public FrmEditarServico()
        {
            InitializeComponent();
        }

        public Int32 idServico;
        internal Servico servico;

        private void FrmEditarServico_Load(object sender, EventArgs e)
        {
            this.servico = ServicoService.BuscarServico(this.idServico);
            tbNome.Text = servico.Nome;
            tbDescricao.Text = servico.Descricao;
            mtbValor.Text = Convert.ToString(servico.Valor);
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
            String nome = tbNome.Text;
            String descricao = tbDescricao.Text;

            servico.Nome = nome;
            servico.Descricao = descricao;

            try
            {
                Double valor = Convert.ToDouble(mtbValor.Text
                    .Replace("R$", "")
                    .Replace(",", "."));

                servico.Valor = valor;

                ServicoService.AtualizarServico(servico);

                MessageBox.Show("Atualizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmEditarServico_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
