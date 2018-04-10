using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Repositorio
    {

        private Pessoa[] arrayDePessoas;

        public Repositorio(Int32 quantity)
        {
            arrayDePessoas = new Pessoa[quantity];
        }

        public void adicionarPessoa(Pessoa pessoa)
        {
            for (Int32 i = 0; i < arrayDePessoas.Length; i ++)
            {
                if (arrayDePessoas[i] == null)
                {
                    arrayDePessoas[i] = pessoa;
                    break;
                }
            }
        }

        public Pessoa[] obterTodasPessoas()
        {
            return this.arrayDePessoas;
        }
    }
}
