using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06_ex06.repository.entity
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
