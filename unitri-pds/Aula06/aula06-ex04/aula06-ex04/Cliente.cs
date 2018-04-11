using System;

namespace aula06_ex04
{
    class Cliente
    {

        private Int32 id;
        private String nome;
        private String telefone;

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}