using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Repositorio
    {

        private List<Pessoa> listaDePessoas;

        public Repositorio()
        {
            this.listaDePessoas = new List<Pessoa>();
        }

        public void adicionarPessoa(Pessoa pessoa)
        {
            this.listaDePessoas.Add(pessoa);
        }

        public List<Pessoa> obterTodasPessoas()
        {
            return this.listaDePessoas;
        }
    }
}
