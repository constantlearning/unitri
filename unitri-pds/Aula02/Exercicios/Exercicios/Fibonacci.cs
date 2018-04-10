using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Fibonacci
    {

        public static int fibonacciIterativo(int number)
        {
            int x = 0;
            int z = 1;
            for (int i = 0; i < number; i++)
            {
                int temp = x;
                x = z;
                z = temp + z;
            }
            return x;
        }

        public static int fibonacciRecursivo(int number)
        {
            if (number == 0) { return 0; }
            if (number == 1) { return 1; }

            return fibonacciRecursivo(number - 2) + fibonacciRecursivo(number - 1);
        }



    }
}
