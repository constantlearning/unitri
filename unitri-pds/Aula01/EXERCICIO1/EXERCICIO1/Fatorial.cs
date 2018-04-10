using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO1
{
    class Fatorial
    {

        public Int32 Iterativo(Int32 number)
        {

            if (checkFat(number)) {
                return 1;
            }

            Int32 fatorial = 1;
            for (int i = 1; i <= number; i++) {
                fatorial = fatorial * i;
            }

            return fatorial;
        }

        public Int32 Recursivo(Int32 number)
        {
            if (checkFat(number)) {
                return 1;
            }

            return number * Recursivo(number - 1);
        }


        public bool checkFat(Int32 number)
        {
            if(number == 0 || number == 1) {
                return true;
            }

            return false;
        }

    }
}
