using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex01();
            //ex02();
            //ex03();
            //ex04();
            //ex05();
            //ex06();
            //ex07();
            //ex08();
            //ex09();
        }

        static void ex01()
        {
            Console.Write("Digite o primeiro número: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Soma: " + (firstNumber + secondNumber));
        }

        static void ex02()
        {
            Console.WriteLine("Digite o número que deseja o fatorial iterativo: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fatorial de " + number + ": " + Fatorial.fatorialIterativo(number));
        }

        static void ex03()
        {
            Console.WriteLine("Digite o número que deseja o fatorial recursivo: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fatorial de " + number + ": " + Fatorial.fatorialRecursivo(number));
        }

        private static void ex04()
        {
            Console.WriteLine("Digite o número que deseja o fibonacci iterativo: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Fibonacci.fibonacciIterativo(i));
            }
        }

        private static void ex05()
        {
            Console.WriteLine("Digite o número que deseja o fibonacci recursivo: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Fibonacci.fibonacciRecursivo(i));
            }
        }

        static void ex06()
        {
            Console.Write("Digite a string: ");
            String theString = Console.ReadLine();
            Console.Write("Digite o substring: ");
            String subsString = Console.ReadLine();

            Console.WriteLine("Substring está contida na string? " + theString.Contains(subsString));
        }

        private static void ex07()
        {
            Console.WriteLine("Digite um número para ser verificado: ");
            String phoneNumber = Console.ReadLine();

            Regex regex = new Regex(@"^(\d{4}-\d{4})");
            Match match = regex.Match(phoneNumber);

            if (match.Success)
            {
                Console.WriteLine("Padrão reconhecido!");
            }
            else
            {
                Console.WriteLine("Padrão não reconhecido!");
                Console.WriteLine("Padrão aceito dddd-dddd");
            }


        }

        private static void ex08()
        {
            Console.WriteLine("Digite o número que deseja o fibonacci iterativo: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Fibonacci.fibonacciIterativo(i));
            }
        }

        private static void ex09()
        {
            Console.WriteLine("Digite o número que deseja o fibonacci recursivo: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Fibonacci.fibonacciRecursivo(i));
            }
        }
    }
}
