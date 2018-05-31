using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.Entity
{
    class Conveniada
    {
        private Int32 id;
        private String nome;
        private String telefone;

        public Conveniada(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
