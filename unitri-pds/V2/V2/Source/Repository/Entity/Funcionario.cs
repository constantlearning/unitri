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
        private DateTime nascimento;
        private string telefone;
        private String usuario;
        private String senha;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public Funcionario() { }

        public Funcionario(string nome, string sexo, DateTime nascimento, string telefone, string usuario, string senha)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.nascimento = nascimento;
            this.Telefone = telefone;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
