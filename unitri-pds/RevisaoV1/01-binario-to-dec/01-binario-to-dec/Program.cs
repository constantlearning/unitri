using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_binario_to_dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor binário: ");
            String valor = Console.ReadLine();

            Int32 simples = convertToDecimalSimples(valor);
            Int32 normal = converToDecimalNormal(valor);

            Console.WriteLine(simples);
            Console.WriteLine(normal);

            Console.ReadKey();
        }

        static Int32 convertToDecimalSimples(String valor)
        {
            char[] rev = valor.ToCharArray();
            Array.Reverse(rev);
            String reversed = new String(rev);

            Int32 valorDecimal = 0;
            Int32 baseNumero = 2;

            for (int i = 0; i < reversed.Length; i ++)
            {
                valorDecimal += Convert.ToInt32(reversed[i] + "") * Convert.ToInt32(Math.Pow(baseNumero, i));
            }

            return valorDecimal;
        }

        static Int32 converToDecimalNormal(String valor)
        {
            Int32 valorDecimal = 0;
            Int32 expoente = 0;
            Int32 baseNumero = 2;

            for (int i = valor.Length; i > 0; i --)
            {
                valorDecimal += Convert.ToInt32(valor[i-1] + "") * Convert.ToInt32(Math.Pow(baseNumero, expoente));
                expoente++;
            }

            return valorDecimal;
        }
    }
}
