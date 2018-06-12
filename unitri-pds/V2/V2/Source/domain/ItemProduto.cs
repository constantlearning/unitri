using System;

namespace V2.Source.domain
{
    public class ItemProduto
    {
        private Int32 id;
        private Produto produto = new Produto();
        private Pedido pedido = new Pedido();
        private Double valor;
        private Int32 quantidade;

        public int Id { get => id; set => id = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Valor { get => valor; set => valor = value; }
        internal Produto Produto { get => produto; set => produto = value; }
        internal Pedido Pedido { get => pedido; set => pedido = value; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!obj.GetType().Equals(this.GetType())) return false;
            ItemProduto item = (ItemProduto)obj;
            if (item.produto.Id != this.produto.Id) return false;
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}