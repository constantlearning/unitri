using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex03.src
{
    class Item
    {
        private Produto produto;
        private Int32 quantidade;

        public int Quantidade { get => quantidade; set => quantidade = value; }
        internal Produto Produto { get => produto; set => produto = value; }
    }
}
