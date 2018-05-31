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
        private String nascimento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
    }
}
