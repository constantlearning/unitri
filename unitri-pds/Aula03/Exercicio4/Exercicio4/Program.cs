using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber n1 = new ComplexNumber(2.8, 4);
            ComplexNumber n2 = new ComplexNumber(4, 7.7);
            ComplexNumber n3 = n1.sum(n2);
            ComplexNumber n4 = n1.sum(n2).sub(n3);
            Console.WriteLine(n1 + n2);
            Console.WriteLine(n4);

            Console.ReadLine();
        }
    }
}
