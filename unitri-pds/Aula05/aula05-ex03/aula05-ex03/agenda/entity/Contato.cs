using System;
using System.Collections.Generic;

namespace aula05_ex03.agenda
{
    class Contato
    {

        private Int32 id;
        private String nome;
        private List<Telefone> telefones;
        private Endereco endereco;

        public Contato(int id, string nome, List<Telefone> telefones, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefones = telefones;
            Endereco = endereco;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal List<Telefone> Telefones { get => telefones; set => telefones = value; }
        internal Endereco Endereco { get => endereco; set => endereco = value; }

        public void adicionarTelefone(Telefone telefone)
        {
            this.telefones.Add(telefone);
        }

        public void deletarTelefone(Telefone telefone)
        {
            this.telefones.ForEach(tel =>
            {
                if (tel.Numero.Equals(telefone.Numero))
                {
                    this.telefones.Remove(tel);
                }
            });
        }
    }
}