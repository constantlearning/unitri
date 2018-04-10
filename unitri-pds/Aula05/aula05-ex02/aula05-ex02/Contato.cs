using System;

namespace aula05_ex02
{
    class Contato
    {

        private Int32 id;
        private String nome;
        private String endereco;
        private String telefone;

        public Contato(){}

        public Contato(int id, string nome, string endereco, string telefone)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}