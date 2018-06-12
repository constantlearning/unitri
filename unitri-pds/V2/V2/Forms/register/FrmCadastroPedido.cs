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
    public partial class FrmCadastroPedido : Form
    {
        public FrmCadastroPedido()
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

        private Pedido pedidoAtual;

        private void FrmCadastroPedido_Load(object sender, EventArgs e)
        {
            List<Barbearia> barbearias = BarbeariaService.BuscarTodasBarbearias();
            cbBarbearias.DataSource = barbearias;

            List<Cliente> clientes = ClienteService.BuscarTodosClientes();
            cbClientes.DataSource = clientes;

            produtoBindingSource.DataSource = ProdutoService.BuscarTodosProdutos();
            servicoBindingSource.DataSource = ServicoService.BuscarTodosServicos();

            this.pedidoAtual = new Pedido();
        }

        private void cbBarbearias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Barbearia barbearia = (Barbearia)cbBarbearias.SelectedValue;
            List<Filial> filiais = FilialService.BuscarFiliaisDaBarbearia(barbearia);
            cbFiliais.DataSource = filiais;
        }

        private void cbFiliais_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filial filial = (Filial)cbFiliais.SelectedValue;
            List<Atendente> atendentes = AtendenteService.BuscarAtendentesDaFilial(filial);
            cbAtendente.DataSource = atendentes;
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)produtoBindingSource.Current;

            ItemProduto novoProduto = new ItemProduto();
            novoProduto.Produto = produtoSelecionado;
            novoProduto.Pedido = pedidoAtual;
            novoProduto.Quantidade = 1;
            novoProduto.Valor = novoProduto.Quantidade * novoProduto.Produto.Valor;

            pedidoAtual.AddProduto(novoProduto);

            carrinhoProdutoBindingSource.DataSource = pedidoAtual.ItemProdutos;
            carrinhoProdutoBindingSource.ResetBindings(false);

            pedidoAtual.atualizaTotal();
            lblTotal.Text = pedidoAtual.Total.ToString();
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            carrinhoProdutoBindingSource.RemoveCurrent();
            pedidoAtual.atualizaTotal();
            lblTotal.Text = pedidoAtual.Total.ToString();
        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)servicoBindingSource.Current;

            ItemServico novoServico = new ItemServico();
            novoServico.Servico = servicoSelecionado;
            novoServico.Pedido = pedidoAtual;
            novoServico.Quantidade = 1;
            novoServico.Valor = novoServico.Quantidade * novoServico.Servico.Valor;

            pedidoAtual.AddServico(novoServico);

            carrinhoServicoBindingSource.DataSource = pedidoAtual.ItemServicos;
            carrinhoServicoBindingSource.ResetBindings(false);

            pedidoAtual.atualizaTotal();
            lblTotal.Text = pedidoAtual.Total.ToString();
        }

        private void btnRemoverServico_Click(object sender, EventArgs e)
        {
            carrinhoServicoBindingSource.RemoveCurrent();
            pedidoAtual.atualizaTotal();
            lblTotal.Text = pedidoAtual.Total.ToString();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja finalizar compra?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Barbearia barbearia = (Barbearia)cbBarbearias.SelectedValue;
                Filial filial = (Filial)cbFiliais.SelectedValue;
                Atendente atendente = (Atendente)cbAtendente.SelectedValue;
                Cliente cliente = (Cliente)cbClientes.SelectedValue;

                this.pedidoAtual.Barbearia = barbearia;
                this.pedidoAtual.Filial = filial;
                this.pedidoAtual.Atendente = atendente;
                this.pedidoAtual.Cliente = cliente;

                try
                {
                    PedidoService.SalvarPedido(this.pedidoAtual);

                    MessageBox.Show("Salvo com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmCadastroPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
