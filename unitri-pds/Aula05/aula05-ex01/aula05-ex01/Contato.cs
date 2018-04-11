using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula05_ex01
{
    class Contato
    {
        private Int32 id;
        private String nome;
        private String endereco;
        private String telefone;

        public Contato() { }

        public Contato(int id, string nome, string endereco, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
