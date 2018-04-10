using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Fatorial
    {

        public static int fatorialIterativo(int number)
        {
            int fatorial = number;

            for (int i = number - 1; i > 1; i--)
            {
                fatorial *= i;
            }

            return fatorial;
        }

        public static long fatorialRecursivo(int number)
        {
            return recursiveFat(number);
        }


        private static long recursiveFat(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * recursiveFat(number - 1);
            }
        }
    }
}
