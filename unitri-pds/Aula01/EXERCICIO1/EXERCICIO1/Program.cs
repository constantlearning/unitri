using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número que deseja o fatorial: ");
            Int32 number = Convert.ToInt32(Console.ReadLine());

            Fatorial fatorial = new Fatorial();
            Console.WriteLine("Iterativo: " + fatorial.Iterativo(number));
            Console.WriteLine("Recursivo: " + fatorial.Recursivo(number));

            Console.ReadKey();
        }
    }
}
