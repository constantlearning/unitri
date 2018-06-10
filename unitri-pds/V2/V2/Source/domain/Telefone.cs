using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.domain
{
    class Telefone
    {
        private Int32 id;
        private String numero;

        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => verifyNumber(value); }

        public Telefone()
        {
        }

        public Telefone(string numero)
        {
            this.numero = numero;
        }

        private void verifyNumber(string value)
        {
            verifyPhoneNumbers(value);
            numero = value;
        }

        private void verifyPhoneNumbers(string value)
        {
            if (!value.All(char.IsDigit))
            {
                throw new Exception("Valor inválido no telefone, inserir apenas números.");
            }
        }
    }
}
