using pod_v1.sort.entidade;
using pod_v1.sort.entity;
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
                if ((CompararCandidatos.igual(candidatosOrdenados[count], new Candidato(chave), tipo)))
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

            int[] result = {0,0};
            int qtdComparacao = 0;

            while (esq <= dir)
            {
                qtdComparacao++;

                valorMeio = esq + ((dir - esq) / 2);
                if (CompararCandidatos.menor(candidatosOrdenados[valorMeio], new Candidato(chave), tipo))
                {
                    esq = valorMeio + 1;
                }
                else if (CompararCandidatos.maior(candidatosOrdenados[valorMeio], new Candidato(chave), tipo))
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

    }
}
