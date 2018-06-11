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
    public partial class FrmEditarProduto : Form
    {
        public FrmEditarProduto()
        {
            InitializeComponent();
        }

        public Int32 idProduto;
        internal Produto produto;

        private void FrmEditarProduto_Load(object sender, EventArgs e)
        {
            this.produto = ProdutoService.BuscarProduto(this.idProduto);
            tbNome.Text = produto.Nome;
            tbDescricao.Text = produto.Nome;
            mtbValor.Text = Convert.ToString(produto.Valor);
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
            Double valor = Convert.ToDouble(mtbValor.Text
                .Replace("R$", "")
                .Replace(",", "."));

            produto.Nome = nome;
            produto.Descricao = descricao;
            produto.Valor = valor;

            try
            {
                ProdutoService.AtualizarProduto(produto);

                MessageBox.Show("Atualizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmEditarProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
