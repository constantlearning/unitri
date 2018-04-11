using System;

namespace aula05_ex03.agenda
{
    class Endereco
    {

        private String logradouro;
        private Int32 numero;
        private String complemento;
        private String Cep;

        public Endereco(string logradouro, int numero, string complemento, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep1 = cep;
        }

        public string Logradouro { get => logradouro; set => logradouro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep1 { get => Cep; set => Cep = value; }

    }
}