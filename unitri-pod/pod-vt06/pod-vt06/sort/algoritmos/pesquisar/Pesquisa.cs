using pod_v1.sort.entidade;
using pod_v1.sort.entity;
using pod_vt06.sort.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pod_vt06.sort.algoritmos.pesquisar
{
    class Pesquisa
    {


        public static int pesquisaSequencial(String chave, List<Candidato> candidatosOrdenados, TIPO tipo)
        {
            int count;
            for (count = 0; count < candidatosOrdenados.Count; count++)
            {
                Candidato candidato = new Candidato(chave, Convert.ToInt64(chave), Convert.ToDouble(chave));
                if ((CompararCandidatos.igual(candidatosOrdenados[count], candidato, tipo)))
                {
                    break;
                }
            }
            if (count >= candidatosOrdenados.Count)
            {
                count = 0;
            }

            return count;
        }

        public static int[] pesquisaBinaria(String chave, List<Candidato> candidatosOrdenados, TIPO tipo)
        {
            int esq = 0;
            int dir = candidatosOrdenados.Count - 1;
            int valorMeio;

            int[] result = { 0, 0 };
            int qtdComparacao = 0;

            while (esq <= dir)
            {
                qtdComparacao++;

                valorMeio = esq + ((dir - esq) / 2);

                Candidato candidato = new Candidato(chave, Convert.ToInt64(chave), Convert.ToDouble(chave));
                if (CompararCandidatos.menor(candidatosOrdenados[valorMeio], candidato, tipo))
                {
                    esq = valorMeio + 1;
                }
                else if (CompararCandidatos.maior(candidatosOrdenados[valorMeio], candidato, tipo))
                {
                    dir = valorMeio - 1;
                }
                else
                {
                    result[0] = valorMeio;
                    result[1] = qtdComparacao;
                    return result;
                }
            }

            result[0] = -1;
            result[1] = qtdComparacao;
            return result;
        }

        public static int[] pesquisaInterpolacao(string chave, List<Candidato> candidatos, TIPO tipo)
        {
            int[] result = { 0, 0 };
            int qtdComparacao = 0;

            int menor = 0;
            int meio = -1;
            int maior = candidatos.Count - 1;
            int indice = -1;

            Candidato candidato = new Candidato(chave, Convert.ToInt64(chave), Convert.ToDouble(chave));

            while (menor <= maior)
            {
                qtdComparacao++;
                meio = encontrarMeio(chave, candidatos, tipo, menor, maior);

                if (CompararCandidatos.igual(candidatos[meio], candidato, tipo))
                {
                    indice = meio;
                    break;
                }
                else
                {
                    if (CompararCandidatos.menor(candidatos[meio], candidato, tipo))
                    {
                        menor = meio + 1;
                    }
                    else
                    {
                        maior = meio - 1;
                    }
                }
            }

            result[0] = indice;
            result[1] = qtdComparacao;
            return result;
        }

        private static int encontrarMeio(string chave, List<Candidato> candidatos, TIPO tipo, int menor, int maior)
        {
            return (int)(menor + (((double)(maior - menor) /
                  (OperacaoCandidato.subtrair(candidatos[maior], candidatos[menor], tipo)) *
                  (OperacaoCandidato.subtrair(new Candidato(chave), candidatos[menor], tipo)))));
        }

        internal static int[] pesquisaHashing(string chave, List<Candidato> candidatosOrdenados, TIPO tipo)
        {
            int[] result = { 0, 0 };


            int size = candidatosOrdenados.Count;

            Dictionary<int, Candidato> candidatos = PopulateHashTable(candidatosOrdenados, size, tipo);

            long hash = OperacaoCandidato.valorChave(chave, tipo);

            Candidato resultado = (Candidato)candidatos[hash];

            return result;

        }

        private static Dictionary<int, Candidato> PopulateHashTable(List<Candidato> candidatosOrdenados, int size, TIPO tipo)
        {

            Dictionary<int, Candidato> candidatos = new Dictionary<int, Candidato>();

            foreach (Candidato candidato in candidatosOrdenados)
            {
                int posicao = OperacaoCandidato.restoDaDivisao(candidato, size, tipo);

                try
                {
                    candidatos.Add(posicao, candidato);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return candidatos;
        }
    }

}
