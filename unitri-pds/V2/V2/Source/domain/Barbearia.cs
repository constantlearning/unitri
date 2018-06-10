using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.domain
{
    class Barbearia
    {
        private Int32 id;
        private String cnpj;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Cnpj { get => cnpj; set => validateCnpj(value); }
        public string Nome { get => nome; set => validateName(value); }

        public Barbearia()
        {
        }

        public Barbearia(string nome, string cnpj)
        {
            this.nome = nome;
            this.cnpj = cnpj;
        }

        private void validateName(string value)
        {
            validateNameLenght(value);
            nome = value;
        }

        private void validateNameLenght(string value)
        {
            if (value.Length > 50)
            {
                throw new Exception("O nome é muito longo, máximo de 50 caracteres.");
            }
        }

        private void validateCnpj(String value)
        {
            verifyCnpjLenght(value);
            verifyCnpjDigits(value);
            cnpj = value;
        }

        private void verifyCnpjLenght(String cpnj)
        {
            if (cpnj.Length != 14)
            {
                throw new Exception("O CNPJ precisa ter o tamanho de 14 digitos.");
            }
        }

        private void verifyCnpjDigits(String cnpj)
        {
            if (!cnpj.All(char.IsDigit))
            {
                throw new Exception("Valor inválido no CPNJ, inserir apenas números.");
            }
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
