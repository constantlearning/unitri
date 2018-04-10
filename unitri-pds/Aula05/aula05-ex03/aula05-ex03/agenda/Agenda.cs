using aula05_ex03.agenda.entity;
using System.Collections.Generic;

namespace aula05_ex03.agenda
{
    class Agenda
    {
        private List<Contato> contatos;

        public Agenda()
        {
            contatos = new List<Contato>();

            List<Telefone> tel0 = new List<Telefone>();
            tel0.Add(new Telefone(0, "0000-0000", TELEFONETIPO.RESIDENCIAL));
            this.contatos.Add(new Contato(0, "Vito Corleone", new List<Telefone>(tel0), new Endereco("Rua 0", 0, "Casa", "00000000")));

            List<Telefone> tel1 = new List<Telefone>();
            tel1.Add(new Telefone(0, "1111-0000", TELEFONETIPO.RESIDENCIAL));
            tel1.Add(new Telefone(1, "1111-1111", TELEFONETIPO.COMERCIAL));
            this.contatos.Add(new Contato(1, "Luca Brasi", new List<Telefone>(tel1), new Endereco("Rua 1", 1, "Casa", "11111111")));

            List<Telefone> tel2 = new List<Telefone>();
            tel2.Add(new Telefone(0,"2222-0000", TELEFONETIPO.RESIDENCIAL));
            tel2.Add(new Telefone(1,"2222-1111", TELEFONETIPO.COMERCIAL));
            tel2.Add(new Telefone(2,"2222-2222", TELEFONETIPO.RESIDENCIAL));
            this.contatos.Add(new Contato(2, "Tom Hagen", new List<Telefone>(), new Endereco("Rua 2", 2, "Casa", "22222222")));

            List<Telefone> tel3 = new List<Telefone>();
            tel3.Add(new Telefone(0, "3333-0000", TELEFONETIPO.RESIDENCIAL));
            tel3.Add(new Telefone(1, "3333-1111", TELEFONETIPO.COMERCIAL));
            tel3.Add(new Telefone(2, "3333-2222", TELEFONETIPO.COMERCIAL));
            tel3.Add(new Telefone(3, "3333-3333", TELEFONETIPO.RESIDENCIAL));
            this.contatos.Add(new Contato(3, "Peter Clemenza", new List<Telefone>(tel3), new Endereco("Rua 3", 3, "Casa", "33333333")));

            List<Telefone> tel4 = new List<Telefone>();
            tel3.Add(new Telefone(0, "4444-0000", TELEFONETIPO.RESIDENCIAL));
            tel3.Add(new Telefone(1, "4444-1111", TELEFONETIPO.RESIDENCIAL));
            tel3.Add(new Telefone(2, "4444-2222", TELEFONETIPO.COMERCIAL));
            tel3.Add(new Telefone(3, "4444-3333", TELEFONETIPO.RESIDENCIAL));
            tel3.Add(new Telefone(5, "4444-3333", TELEFONETIPO.RESIDENCIAL));
            tel3.Add(new Telefone(6, "4444-4444", TELEFONETIPO.COMERCIAL));
            this.contatos.Add(new Contato(4, "Johnny Fontane", new List<Telefone>(tel4), new Endereco("Rua 4", 4, "Casa", "44444444")));

            List<Telefone> tel5 = new List<Telefone>();
            tel5.Add(new Telefone(0, "5555-0000", TELEFONETIPO.RESIDENCIAL));
            tel5.Add(new Telefone(1, "5555-1111", TELEFONETIPO.COMERCIAL));
            tel5.Add(new Telefone(2, "5555-2222", TELEFONETIPO.RESIDENCIAL));
            tel5.Add(new Telefone(3, "5555-3333", TELEFONETIPO.COMERCIAL));
            tel5.Add(new Telefone(4, "5555-4444", TELEFONETIPO.RESIDENCIAL));
            tel5.Add(new Telefone(5, "5555-5555", TELEFONETIPO.RESIDENCIAL));
            this.contatos.Add(new Contato(5, "Moe Greene", new List<Telefone>(tel5), new Endereco("Rua 5", 5, "Apartamento", "55555555")));

            List<Telefone> tel6 = new List<Telefone>();
            tel6.Add(new Telefone(0, "6666-0000", TELEFONETIPO.RESIDENCIAL));
            tel6.Add(new Telefone(1, "6666-1111", TELEFONETIPO.RESIDENCIAL));
            tel6.Add(new Telefone(2, "6666-2222", TELEFONETIPO.COMERCIAL));
            tel6.Add(new Telefone(3, "6666-3333", TELEFONETIPO.RESIDENCIAL));
            tel6.Add(new Telefone(4, "6666-4444", TELEFONETIPO.RESIDENCIAL));
            tel6.Add(new Telefone(5, "6666-5555", TELEFONETIPO.COMERCIAL));
            tel6.Add(new Telefone(6, "6666-6666", TELEFONETIPO.RESIDENCIAL));
            this.contatos.Add(new Contato(6, "Kay Adams", new List<Telefone>(tel6), new Endereco("Rua 6", 6, "Apartamento", "66666666")));

            List<Telefone> tel7 = new List<Telefone>();
            tel7.Add(new Telefone(0, "7777-0000", TELEFONETIPO.RESIDENCIAL));
            tel7.Add(new Telefone(1, "7777-1111", TELEFONETIPO.RESIDENCIAL));
            tel7.Add(new Telefone(2, "7777-2222", TELEFONETIPO.COMERCIAL));
            tel7.Add(new Telefone(3, "7777-3333", TELEFONETIPO.RESIDENCIAL));
            tel7.Add(new Telefone(4, "7777-4444", TELEFONETIPO.RESIDENCIAL));
            tel7.Add(new Telefone(5, "7777-5555", TELEFONETIPO.COMERCIAL));
            tel7.Add(new Telefone(6, "7777-6666", TELEFONETIPO.RESIDENCIAL));
            tel7.Add(new Telefone(7, "7777-7777", TELEFONETIPO.RESIDENCIAL));
            this.contatos.Add(new Contato(7, "Michael Corleone", new List<Telefone>(tel7), new Endereco("Rua 7", 7, "Apartamento", "77777777")));

            List<Telefone> tel8 = new List<Telefone>();
            tel8.Add(new Telefone(0, "8888-0000", TELEFONETIPO.COMERCIAL));
            tel8.Add(new Telefone(1, "8888-1111", TELEFONETIPO.RESIDENCIAL));
            tel8.Add(new Telefone(2, "8888-2222", TELEFONETIPO.RESIDENCIAL));
            tel8.Add(new Telefone(3, "8888-3333", TELEFONETIPO.COMERCIAL));
            tel8.Add(new Telefone(4, "8888-4444", TELEFONETIPO.RESIDENCIAL));
            tel8.Add(new Telefone(5, "8888-5555", TELEFONETIPO.RESIDENCIAL));
            tel8.Add(new Telefone(6, "8888-6666", TELEFONETIPO.COMERCIAL));
            tel8.Add(new Telefone(7, "8888-7777", TELEFONETIPO.RESIDENCIAL));
            tel8.Add(new Telefone(8, "8888-8888", TELEFONETIPO.COMERCIAL));
            this.contatos.Add(new Contato(8, "Fredo Corleone", new List<Telefone>(tel8), new Endereco("Rua 8", 8, "Apartamento", "88888888")));

            List<Telefone> tel9 = new List<Telefone>();
            tel9.Add(new Telefone(0, "9999-0000", TELEFONETIPO.RESIDENCIAL));
            tel9.Add(new Telefone(1, "9999-1111", TELEFONETIPO.RESIDENCIAL));
            tel9.Add(new Telefone(2, "9999-2222", TELEFONETIPO.COMERCIAL));
            tel9.Add(new Telefone(3, "9999-3333", TELEFONETIPO.RESIDENCIAL));
            tel6.Add(new Telefone(4, "9999-4444", TELEFONETIPO.RESIDENCIAL));
            tel6.Add(new Telefone(5, "9999-5555", TELEFONETIPO.COMERCIAL));
            tel6.Add(new Telefone(6, "9999-6666", TELEFONETIPO.RESIDENCIAL));
            tel6.Add(new Telefone(7, "9999-7777", TELEFONETIPO.COMERCIAL));
            tel6.Add(new Telefone(8, "9999-8888", TELEFONETIPO.RESIDENCIAL));
            tel5.Add(new Telefone(9, "9999-9999", TELEFONETIPO.RESIDENCIAL));
            this.contatos.Add(new Contato(9, "Sonny Corleone", new List<Telefone>(tel9), new Endereco("Rua 9", 9, "Apartamento", "99999999")));
        }

        public List<Contato> Contatos { get => contatos; set => contatos = value; }


        public void atualizarContato(Contato contato)
        {
            this.contatos.ForEach(con=> {
                if (con.Id == contato.Id)
                {
                    con.Nome = contato.Nome;
                    con.Endereco = contato.Endereco;
                    con.Telefones = contato.Telefones;
                }
            });
        }

        public void removerContato(Contato contato)
        {
            this.contatos.ForEach(cont =>
            {
                if (contato.Id == contato.Id)
                {
                    this.contatos.Remove(cont);
                }
            });
        }

    }
}
