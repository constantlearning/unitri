using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex03.src
{
    class Cliente
    {

        private Int32 id;
        private Int32 cpf;
        private String nome;
        private String endereco;
        private String telefone;

        public int Id { get => id; set => id = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
