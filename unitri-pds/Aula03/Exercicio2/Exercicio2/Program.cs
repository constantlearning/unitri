using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Repositorio repositorio = new Repositorio();

            Boolean continuar = true;
            while (continuar)
            {
                System.Console.Clear();
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Endereço: ");
                String endereco = Console.ReadLine();
                Console.Write("Telefone: ");
                String telefone = Console.ReadLine();

                repositorio.adicionarPessoa(
                    new Pessoa(nome, endereco, telefone)
                );

                Console.WriteLine("Adicionar uma nova pessoa? (S/N)");
                String continuarAdicionando = Console.ReadLine();
                if (!string.Equals(continuarAdicionando, "s", StringComparison.OrdinalIgnoreCase))
                {
                    continuar = false;
                }
            }

            System.Console.Clear();

            Console.WriteLine("Listando pessoas: ");

            repositorio
                .obterTodasPessoas()
                .ForEach(pessoa => Console.WriteLine(pessoa));

            Console.ReadLine();
        }
    }
}
