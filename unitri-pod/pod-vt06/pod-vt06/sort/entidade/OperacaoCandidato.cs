using pod_v1.sort.entidade;
using pod_v1.sort.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pod_vt06.sort.entidade
{
    class OperacaoCandidato
    {

        public static long somar(Candidato atual, Candidato proximo, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    long actual = converterTextoParaNumero(atual.Nome);
                    long next = converterTextoParaNumero(proximo.Nome);
                    return actual + next;
                case TIPO.MATRICULA:
                    return atual.Matricula + proximo.Matricula;
                case TIPO.NOTA:
                    return Convert.ToInt64(atual.Nota + proximo.Nota);
            }

            return -1;
        }

        public static long subtrair(Candidato atual, Candidato proximo, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    long actual = converterTextoParaNumero(atual.Nome);
                    long next = converterTextoParaNumero(proximo.Nome);
                    return actual - next;
                case TIPO.MATRICULA:
                    return atual.Matricula - proximo.Matricula;
                case TIPO.NOTA:
                    return Convert.ToInt64(atual.Nota - proximo.Nota);
            }

            return -1;
        }

        public static long multiplicar(Candidato atual, Candidato proximo, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    long actual = converterTextoParaNumero(atual.Nome);
                    long next = converterTextoParaNumero(proximo.Nome);
                    return actual * next;
                case TIPO.MATRICULA:
                    return atual.Matricula * proximo.Matricula;
                case TIPO.NOTA:
                    return Convert.ToInt64(atual.Nota * proximo.Nota);
            }

            return -1;
        }

        public static long dividir(Candidato atual, Candidato proximo, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    long actual = converterTextoParaNumero(atual.Nome);
                    long next = converterTextoParaNumero(proximo.Nome);
                    return actual / next;
                case TIPO.MATRICULA:
                    return atual.Matricula / proximo.Matricula;
                case TIPO.NOTA:
                    return Convert.ToInt64(atual.Nota / proximo.Nota);
            }

            return -1;
        }

        private static long converterTextoParaNumero(String valor)
        {
            string resultado = "";

            byte[] asciiBytes = Encoding.ASCII.GetBytes(valor);

            foreach (byte b in asciiBytes)
            {
                resultado += b;
            }

            return Convert.ToInt64(resultado);
        }

        internal static int restoDaDivisao(Candidato candidato, int size, TIPO tipo)
        {
            switch (tipo)
            {
                case TIPO.NOME:
                    int resultado = 0;
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(candidato.Nome);
                    foreach (byte b in asciiBytes) { resultado += b; }
                    return resultado % size;
                case TIPO.MATRICULA:
                    return Convert.ToInt32(candidato.Matricula % size);
                case TIPO.NOTA:
                    return Convert.ToInt32(candidato.Nota % size);
            }

            return -1;
        }

        internal static long valorChave(string chave, TIPO tipo)
        {
            Candidato candidato = new Candidato(chave, Convert.ToInt64(chave), Convert.ToDouble(chave));

            switch (tipo)
            {
                case TIPO.NOME:
                    long resultado = 0;
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(chave);
                    foreach (byte b in asciiBytes) { resultado += b; }
                    return resultado;
                case TIPO.MATRICULA:
                    return Convert.ToInt64(chave);
                case TIPO.NOTA:
                    return Convert.ToInt64(chave);
            }

            return -1;
        }
    }
}
