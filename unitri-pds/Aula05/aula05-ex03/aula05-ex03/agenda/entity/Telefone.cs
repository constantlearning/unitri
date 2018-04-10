using aula05_ex03.agenda.entity;
using System;

namespace aula05_ex03.agenda
{
    class Telefone
    {
        private Int32 id;
        private String  numero;
        private TELEFONETIPO tipoTelefone;

        public Telefone()
        {
        }

        public Telefone(Int32 id, string numero, TELEFONETIPO tipoTelefone)
        {
            Id = id;
            Numero = numero;
            TipoTelefone = tipoTelefone;
        }

        public string Numero { get => numero; set => numero = value; }
        public TELEFONETIPO TipoTelefone { get => tipoTelefone; set => tipoTelefone = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return numero;
        }
    }
}