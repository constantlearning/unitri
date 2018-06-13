using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.domain
{
    class Pedido
    {
        private Int32 id;
        private Barbearia barbearia;
        private Filial filial;
        private Atendente atendente;
        private Cliente cliente;
        private List<ItemProduto> itemProdutos;
        private List<ItemServico> itemServicos;
        private Double total;
        private DateTime dataPedido;

        public int Id { get => id; set => id = value; }
        public List<ItemProduto> ItemProdutos { get => itemProdutos; set => itemProdutos = value; }
        public double Total { get => total; set => total = value; }
        internal Barbearia Barbearia { get => barbearia; set => barbearia = value; }
        internal Filial Filial { get => filial; set => filial = value; }
        internal Atendente Atendente { get => atendente; set => atendente = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal List<ItemServico> ItemServicos { get => itemServicos; set => itemServicos = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }

        public Pedido()
        {
            itemProdutos = new List<ItemProduto>();
            itemServicos = new List<ItemServico>();
        }


        public void AddProduto(ItemProduto itemNovo)
        {
            int indice = ItemProdutos.IndexOf(itemNovo);
            if (indice >= 0)
            {
                ItemProduto itemAtual = this.ItemProdutos[indice];
                itemAtual.Quantidade++;
                itemAtual.Valor = itemAtual.Quantidade * itemAtual.Produto.Valor;
            }
            else
            {
                this.ItemProdutos.Add(itemNovo);
            }
        }

        public void AddServico(ItemServico itemNovo)
        {
            int indice = this.ItemServicos.IndexOf(itemNovo);
            if (indice >= 0)
            {
                ItemServico itemAtual = this.ItemServicos[indice];
                itemAtual.Quantidade++;
                itemAtual.Valor = itemAtual.Quantidade * itemAtual.Servico.Valor;
            }
            else
            {
                this.ItemServicos.Add(itemNovo);
            }
        }

        public void atualizaTotal()
        {
            Double total = 0;
            foreach (ItemProduto item in this.ItemProdutos)
            {
                total = total + item.Valor;
            }

            foreach (ItemServico item in this.ItemServicos)
            {
                total = total + item.Valor;
            }
            this.Total = total;
        }
    }
}
