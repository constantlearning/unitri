using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGeneticoVT.Src.util
{
    class BasesNumericas
    {

        public static int BinarioParaDecimal(string novaPopulacao)
        {
            return Convert.ToInt32(novaPopulacao, 2);
        }

        public static void DecimalParaBinario(int[] pais, string[] binario)
        {
            for (int i = 0; i < pais.Length; i++)
            {
                if (pais[i] == 0 || pais[i] == 1)
                {
                    binario[i] = pais[i].ToString();
                }
                else
                {
                    while (pais[i] > 0)
                    {
                        binario[i] += pais[i] % 2; //Concatena o resto da divisão atribuindo ao vetor binário
                        pais[i] = pais[i] / 2; // Divide o valor do vetor e atribui a ele mesmo
                    }
                }

            }

            for (int i = 0; i < binario.Length; i++)
            {
                binario[i] = Inverter(binario[i]);
                binario[i] = binario[i].PadLeft(10, '0');
            }
        }

        private static string Inverter(string binario)
        {
            char[] caracter = binario.ToCharArray();
            Array.Reverse(caracter);
            return new string(caracter);
        }
    }
}
