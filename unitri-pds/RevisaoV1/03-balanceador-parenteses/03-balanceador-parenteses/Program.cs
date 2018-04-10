using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_balanceador_parenteses
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputCorreto = "(abc)(123(asd))";
            String inputIncorreto = "(abc)(123(123)";
            String inputIncorreto1 = "))(345678)()()";

            try
            {
                balancear(inputIncorreto1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Balanceamento falhou!");
            }


            Console.ReadKey();
        }

        static void balancear(String input)
        {
            Stack<Char> pilha = new Stack<char>();

            foreach (Char c in input)
            {
                if (c.Equals('('))
                {
                    pilha.Push(c);
                }

                if (c.Equals(')'))
                {
                    pilha.Pop();
                }
            }

            if (pilha.Count > 0)
            {
                Console.WriteLine("Balanceamento falhou, pilha não está vazia!");
            }
            else
            {
                Console.WriteLine("Deu certo!");
            }
        }
    }
}
