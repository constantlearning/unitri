using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex03.src
{
    class Pedido
    {
        private Int32 id;
        private Cliente cliente;
        private Funcionario funcionario;
        private List<Item> items;
        private Double total;

        public int Id { get => id; set => id = value; }
        public double Total { get => total; set => total = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        internal List<Item> Items { get => items; set => items = value; }
    }
}
