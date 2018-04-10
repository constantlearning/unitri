using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula05_ex01
{
    class Repositorio
    {
        private List<Contato> contatos;

        public Repositorio()
        {
            this.Contatos = new List<Contato>();
            this.contatos.Add(new Contato(0, "Vito Corleone", "Rua 0", "0000-0000"));
            this.contatos.Add(new Contato(1, "Luca Brasi", "Rua 1", "1111-1111"));
            this.contatos.Add(new Contato(2, "Tom Hagen", "Rua 2", "2222-2222"));
            this.contatos.Add(new Contato(3, "Peter Clemenza", "Rua 3", "3333-3333"));
            this.contatos.Add(new Contato(4, "Johnny Fontane", "Rua 4", "4444-4444"));
            this.contatos.Add(new Contato(5, "Moe Greene", "Rua 5", "5555-5555"));
            this.contatos.Add(new Contato(6, "Kay Adams", "Rua 6", "6666-6666"));
            this.contatos.Add(new Contato(7, "Michael Corleone", "Rua 7", "7777-7777"));
            this.contatos.Add(new Contato(8, "Fredo Corleone", "Rua 8", "8888-8888"));
            this.contatos.Add(new Contato(9, "Sonny Corleone", "Rua 9", "9999-9999"));
        }

        internal List<Contato> Contatos { get => contatos; set => contatos = value; }

        public void updateContato(Contato contato)
        {
            this.contatos.ForEach(c =>
            {
                if (c.Id == contato.Id)
                {
                    c.Nome = contato.Nome;
                    c.Endereco = contato.Endereco;
                    c.Telefone = contato.Telefone;
                }
            });
        }
    }
}
