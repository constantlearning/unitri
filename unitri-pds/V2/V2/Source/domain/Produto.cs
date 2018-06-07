using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.domain
{
    class Produto
    {

        private Int32 id;
        private String nome;
        private String descricao;
        private Double valor;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => validarValor(value); }

        public Produto()
        {
        }

        public Produto(string nome, string descricao, double valor)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
        }

        private void validarValor(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Valor não permitido.");
            }

            this.valor = valor;
        }
    }
}
