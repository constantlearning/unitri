using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a quantidade de clientes que deseja cadastrar: ");

            Int32 quantity = Convert.ToInt32(Console.ReadLine());

            Repositorio repositorio = new Repositorio(quantity);

            while(quantity > 0)
            {
                System.Console.Clear();

                Console.WriteLine("Nome: ");
                String nome = Console.ReadLine();
                Console.WriteLine("Endereço: ");
                String endereco = Console.ReadLine();
                Console.WriteLine("Telefone: ");
                String telefone = Console.ReadLine();

                repositorio.adicionarPessoa(
                    new Pessoa(nome, endereco, telefone)
                );

                quantity--;
            }


            Pessoa[] pessoas = repositorio.obterTodasPessoas();

            System.Console.Clear();
            Console.WriteLine("Obtendo lista de pessoas: \n");

            foreach(Pessoa p in pessoas)
            {
                Console.WriteLine(p);
            }


            Console.ReadLine();
        }
    }
}
