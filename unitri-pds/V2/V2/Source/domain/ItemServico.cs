using System;

namespace V2.Source.domain
{
    internal class ItemServico
    {
        private Int32 id;
        private Servico servico = new Servico();
        private Pedido pedido = new Pedido();
        private Double valor;
        private Int32 quantidade;

        public int Id { get => id; set => id = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Valor { get => valor; set => valor = value; }
        internal Servico Servico { get => servico; set => servico = value; }
        internal Pedido Pedido { get => pedido; set => pedido = value; }

        public void calcularValor()
        {
            Valor = servico.Valor * quantidade;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!obj.GetType().Equals(this.GetType())) return false;
            ItemServico item = (ItemServico)obj;
            if (item.servico.Id != this.servico.Id) return false;
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}