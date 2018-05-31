using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.Entity
{
    class Motorista
    {
        private Int32 id;
        private String nome;
        private String sexo;
        private DateTime nascimento;
        private String telefone;

        public Motorista()
        {
        }

        public Motorista(string nome, string sexo, DateTime nascimento, string telefone)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.nascimento = nascimento;
            this.telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
