using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Pessoa
    {
        private String nome;
        private String endereco;
        private String telefone;

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public Pessoa(String nome, String endereco, String telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return String.Format("[Nome: {0}, Endereço: {1}, Telefone: {2}]", this.nome, this.endereco, this.telefone);
        }
    }
}
