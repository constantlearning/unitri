using pod_v1.sort.entidade;
using pod_v1.sort.entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace pod_v1
{
    class InsertionSort
    {

        private List<Candidato> candidatosList;
        private TIPO tipo;
        private Stopwatch stopWatch;

        public Stopwatch StopWatch { get => stopWatch; set => stopWatch = value; }

        public InsertionSort(List<Candidato> candidatos, TIPO tipo)
        {
            stopWatch = new Stopwatch();
            this.candidatosList = candidatos;
            this.tipo = tipo;
        }

        public List<Candidato> sort()
        {
            stopWatch.Start();
            return new List<Candidato>(insertionSort(this.candidatosList.ToArray()));
        }

        public Candidato[] insertionSort(Candidato[] candidatos)
        {
            for (int i = 0; i < candidatos.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (CompararCandidatos.maior(candidatos[j - 1], candidatos[j], this.tipo))
                    {
                        Candidato temp = candidatos[j - 1];
                        candidatos[j - 1] = candidatos[j];
                        candidatos[j] = temp;
                    }
                    j--;
                }
            }

            stopWatch.Stop();
            return candidatos;
        }
    }
}