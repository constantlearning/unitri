using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_pre_calc
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(PosFixada.calcular("253*+;"));
            Console.WriteLine(PreFixada.calcular("+*352"));
            Console.ReadKey();
        }
    }
}
