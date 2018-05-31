using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.Entity
{
    class Funcionario
    {
        private Int32 id;
        private String nome;
        private String sexo;
        private String endereco;
        private DateTime nascimento;
        private string telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }

        public Funcionario() { }

        public Funcionario(string nome, string sexo, DateTime nascimento, string telefone)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.nascimento = nascimento;
            this.telefone = telefone;
        }
    }
}
