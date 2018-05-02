using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex03.src
{
    class Produto
    {
        private Int32 id;
        private Int32 codigo;
        private String descricao;
        private Double precoVenda;
        private Double precoCusto;

        public int Id { get => id; set => id = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public double PrecoCusto { get => precoCusto; set => precoCusto = value; }
    }
}
